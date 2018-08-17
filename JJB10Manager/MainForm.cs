using JJB10Manager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJB10Manager
{
    public partial class MainForm : Form
    {
        private static Socket serverSocket;
        private static byte[] result = new byte[1024];
        private static List<Users> allUsers = new List<Users>();

        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = Program.AppName;
            lab_appName.Text = Program.AppName;
            AccessHelper.connStr = Program.connStr;

            ChangeGb(1);

            allUsers = DataControl.GetAllUsers();

            StartSocketServer();
        }

        #region ----Socket相关----

        private void StartSocketServer()
        {
            try
            {
                //服务器IP地址
                IPAddress ip = IPAddress.Parse(Program.Ip);
                int myProt = int.Parse(Program.Port);//xuzp
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ip, myProt)); //绑定IP地址：端口
                serverSocket.Listen(10); //设定最多10个排队连接请求
                AddRunLog("启动监听{0}成功," + serverSocket.LocalEndPoint.ToString());
                //Console.WriteLine("启动监听{0}成功", serverSocket.LocalEndPoint.ToString());
                //通过Clientsoket发送数据
                Thread myThread = new Thread(ListenClientConnect);
                myThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动监听异常，原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 关闭Socket 连接 xuzp
        /// </summary>
        private void stopSocketServer()
        {
            serverSocket.Close(5);
            serverSocket.Dispose();

        }
        /// <summary>
        /// 监听客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
 
                IPEndPoint clientipe = (IPEndPoint)clientSocket.RemoteEndPoint;
                string ip = clientipe.Address.ToString();
                string mac = getRemoteMac(ip);
                Users User = DataControl.GetUserByMac(mac);
                dgv.Rows.Add(User.UserName, ip, mac, "");

                AddRunLog("新连接建立：" + ip + " : " + mac);

                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);

            }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="clientSocket"></param>
        private void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;
            myClientSocket.ReceiveTimeout = 120000;
            IPEndPoint clientipe = (IPEndPoint)myClientSocket.RemoteEndPoint;
            string ip = clientipe.Address.ToString();
            string mac = getRemoteMac(ip);
            Data data;
            byte[] sendBuffer = new byte[1];
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据
                    int receiveNumber = myClientSocket.Receive(result);
                    string reciveData = Encoding.Default.GetString(result, 0, receiveNumber);

                    AddRunLog(string.Format("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), reciveData));

                    data = DataControl.GetDataFromReciveStr(reciveData);
                    if (data != null)
                    {
                        data.IP = ip;
                        DataControl.InsertIntoData(data);
                    }

                    sendBuffer = new byte[receiveNumber];
                    for (int i = 0; i < receiveNumber; i++)
                    {
                        sendBuffer[i] = result[i];
                    }
                    myClientSocket.Send(sendBuffer);

                    if (!myClientSocket.Connected || receiveNumber == 0)
                    {
                        AddRunLog(ip + "  " + mac + "  " + "断开连接");
                        myClientSocket.Shutdown(SocketShutdown.Both);
                        myClientSocket.Close();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    AddRunLog(ip + "  " + mac + "  " + ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells["IP"].Value.ToString() == ip)
                {
                    dgv.Rows.RemoveAt(i);
                    break;
                }
            }
        }

        public string getRemoteMac(string remoteIP)
        {
            var addr = IPAddress.Parse(remoteIP);
            int ip4 = BitConverter.ToInt32((addr.GetAddressBytes()), 0);

            try
            {
                long macinfo = 0;
                int len = 6;
                int res = SendARP(ip4, 0, ref macinfo, ref len);
                return Convert.ToString(macinfo, 16);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error:{0}", err.Message);
            }
            return 0.ToString();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            StartSocketServer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = { 0x41, 0x44, 0x45, 0x54, 0x45, 0x33, 0x32, 0x39, 0x30, 0x30, 0x30, 0x33,
                                      0xD6, 0xD0, 0xD1, 0xEB, 0xB1, 0xE4, 0xB5, 0xE7, 0xCB, 0xF9,0xD2,0xBB,
                                      0xB6, 0xFE, 0xC8, 0xFD, 0xCB, 0xC4, 0xCE, 0xE5, 0x32,0x30, 0x31, 0x38,
                                      0x2D, 0x30, 0x31, 0x2D, 0x30, 0x32, 0x20, 0x31, 0x31,0x3A, 0x31, 0x32,
                                      0x3A, 0x31, 0x33, 0x2B, 0x30, 0x31, 0x30, 0x2e,0x32, 0x33, 0x31, 0x33,
                                      0x3A, 0x31, 0x36, 0x3A, 0x31, 0x39 };



                string s = System.Text.Encoding.Default.GetString(buffer);


                string teststr = "爱我中华";



                byte[] buffer1 = System.Text.Encoding.Default.GetBytes(teststr);

                byte[] buffer2 = new byte[20];
                for (int i = 0; i < buffer2.Length; i++)
                {
                    buffer2[i] = 0;
                }
                buffer1.CopyTo(buffer2, 0);

                s = System.Text.Encoding.Default.GetString(buffer2);
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_UserManager um = new Frm_UserManager();
            um.ShowDialog();
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            Frm_UserManager fum = new Frm_UserManager();
            fum.ShowDialog();
        }
        private void ChangeGb(int index)
        {
            gb_main.Dock = DockStyle.Fill;
            gb_Conn.Dock = DockStyle.Fill;
            gb_Query.Dock = DockStyle.Fill;
            gb_manager.Dock = DockStyle.Fill;
            if (index == 1)
            {
                //首页
                gb_main.Visible = true;
                gb_Conn.Visible = false;
                gb_Query.Visible = false;
                gb_manager.Visible = false;
            }
            else if (index == 2)
            {
                //连接状态
                gb_main.Visible = false;
                gb_Conn.Visible = true;
                gb_Query.Visible = false;
                gb_manager.Visible = false;
            }
            else if (index == 3)
            {
                //查询报表
                gb_main.Visible = false;
                gb_Conn.Visible = false;
                gb_Query.Visible = true;
                gb_manager.Visible = false;
            }
            else if (index == 4)
            {
                //配置管理
                gb_main.Visible = false;
                gb_Conn.Visible = false;
                gb_Query.Visible = false;
                gb_manager.Visible = true;
            }

            lab_1.Visible = gb_main.Visible;
            lab_2.Visible = gb_Conn.Visible;
            lab_3.Visible = gb_Query.Visible;
            lab_4.Visible = gb_manager.Visible;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            ChangeGb(1);
        }

        private void btn_connState_Click(object sender, EventArgs e)
        {
            ChangeGb(2);
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            ChangeGb(3);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            ChangeGb(4);
        }

        private void AddRunLog(string msg)
        {
            if (lb_runLog.Items.Count > 200)
            {
                lb_runLog.Items.RemoveAt(0);
            }
            lb_runLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "  " + msg);
        }


        private void ReLoadDgv(DateTime timer)
        {
            List<Data> Datas = DataControl.GetDataByDate(timer).OrderBy(a => a.MAC).ThenBy(a => a.Timer).ToList();
            dgv_qurey.Rows.Clear();
            for (int i = 0; i < Datas.Count; i++)
            {
                dgv_qurey.Rows.Add(i + 1,
                    Datas[i].MAC,
                    Datas[i].Place,
                    Datas[i].RealValue,
                    Datas[i].Timer,
                    Datas[i].UpTime
                    );
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            ReLoadDgv(dtp_timer.Value);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                stopSocketServer();
            }
            catch (Exception ex)
            {

            }
            Environment.Exit(0);
        }
    }
}
