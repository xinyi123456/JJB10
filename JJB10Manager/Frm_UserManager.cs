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
    public partial class Frm_UserManager : Form
    {
        public Frm_UserManager()
        {
            InitializeComponent();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var _id = dgv.Rows[e.RowIndex].Cells["ID"].Value;
                if (_id == null)
                {
                    //新增
                    Frm_AddUser fa = new Frm_AddUser();
                    fa.ShowDialog();
                }
                else
                {
                    //修改、删除
                    Frm_EditUser fe = new Frm_EditUser(_id.ToString());
                    fe.ShowDialog();
                }
            }
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgv.Rows.Clear();
            List<Users> allUser = DataControl.GetAllUsers().OrderBy(a=>a.MAC).ToList();
            for (int i = 0; i < allUser.Count; i++)
            {
                dgv.Rows.Add(i + 1,
                    allUser[i].UserName,
                    allUser[i].MAC,
                    allUser[i].Timer,
                    allUser[i].ID);
            }
        }

        private void Frm_UserManager_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
    }
}
