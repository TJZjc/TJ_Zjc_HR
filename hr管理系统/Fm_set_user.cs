using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hr管理系统
{
    public partial class Fm_set_user : Form
    {
        public Fm_set_user()
        {
            InitializeComponent();
        }

        private void Fm_set_user_Load(object sender, EventArgs e)
        {
            txt_uid.Text = Program.user;
            txt_pwd.Text = Program.pwd;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_newpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_new_pwd_again.Focus();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(txt_newpwd.Text==txt_new_pwd_again.Text)
            {
                Mydbcon.My_con_open();
                string sqlcmd = "UPDATE tb_login SET login_pwd=" + txt_newpwd.Text + " WHERE login_id = " + txt_uid.Text;
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Program.pwd = txt_newpwd.Text;
                    txt_pwd.Text = txt_newpwd.Text;
                    MessageBox.Show("修改成功!即将重新登录!", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("修改失败", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("新密码两次输入不相符!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_new_pwd_again.Focus();
            }
        }
    }
}
