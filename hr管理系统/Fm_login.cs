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
    public partial class Fm_login : Form
    {
        public Fm_login()
        {
            InitializeComponent();
        }

        private bool is_login = false;

        //检查输入合法性
        private bool Check_Valid() 
        {
            if(txt_uid.Text==string.Empty)
            {
                MessageBox.Show("用户名不可为空!", "用户名输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_uid.Focus();
                return false;
            }
            else if (txt_pwd.Text == string.Empty)
            {
                MessageBox.Show("密码不可为空!", "密码输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pwd.Focus();
                return false;
            }
            else if(txt_pwd.Text.Length<6||txt_pwd.Text.Length>10)
            {
                MessageBox.Show("密码不可小于6位或者大于10位!", "密码输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pwd.Clear();
                txt_pwd.Focus();
                return false;
            }
            return true;
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            //检查输入合法性
            if (Check_Valid() == false)
                return;

            //连接数据库
            Mydbcon.My_con_open();
            string sqlcomd = "SELECT login_pwd FROM tb_login WHERE login_id=@id";
            SqlCommand cmd = Mydbcon.Create_command(sqlcomd);
            SqlParameter _uid = new SqlParameter("@id", SqlDbType.Char, 10);
            cmd.Parameters.Add(_uid);
            _uid.Value = txt_uid.Text;
            SqlDataReader upwd = cmd.ExecuteReader();
            string pwd;
            while (upwd.Read())
            {
                pwd = upwd["login_pwd"].ToString();
                if (pwd == txt_pwd.Text)
                {
                    Program.user = txt_uid.Text;
                    Program.pwd = txt_pwd.Text;
                    is_login = true;
                }
            }
            if (is_login)
            {
                this.Close();
                return;
            }
            MessageBox.Show("密码错误!", "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Mydbcon.My_con_close();
            txt_pwd.Clear();
            txt_pwd.Focus();
        }

        private void txt_uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_pwd.Focus();
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_login_Click(sender,e);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_register";
            Form_manege.Open_Form();
        }

        private void fm_load_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (is_login == true)
            {
                this.Hide();
                Form_manege.Choice = "Fm_main";
                Form_manege.Open_Form();
            }
        }
    }
}
