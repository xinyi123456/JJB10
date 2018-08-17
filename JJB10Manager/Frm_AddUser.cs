using JJB10Manager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JJB10Manager
{
    public partial class Frm_AddUser : Form
    {
        public Frm_AddUser()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.UserCode = Win32.GenerateRandomCode(10);
            user.MAC = txt_Mac.Text.Trim();
            user.UserName = txt_userName.Text.Trim();
            user.Timer = DateTime.Now;

            string msg = "";

            bool result = DataControl.AddOrUpdateUsers(user, 0, ref msg);
            if (result)
            {
                MessageBox.Show("操作成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败，" + msg);
            }
        }
    }
}
