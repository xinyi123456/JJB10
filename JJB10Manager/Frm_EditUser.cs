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
    public partial class Frm_EditUser : Form
    {
        string id = "";
        public Frm_EditUser(string _Id)
        {
            InitializeComponent();
            id = _Id;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ID = Convert.ToInt32(id);
            user.MAC = txt_Mac.Text.Trim();
            user.UserName = txt_userName.Text.Trim();
            user.Timer = DateTime.Now;

            string msg = "";

            bool result = DataControl.AddOrUpdateUsers(user, 1, ref msg);
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            bool result = DataControl.DeleteUsersById(id);
            if (result)
            {
                MessageBox.Show("操作成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败" );
            }
        }

        private void Frm_EditUser_Load(object sender, EventArgs e)
        {
            Users user = DataControl.GetUserById(id);
            txt_userName.Text = user.UserName;
            txt_Mac.Text = user.MAC;
        }
    }
}
