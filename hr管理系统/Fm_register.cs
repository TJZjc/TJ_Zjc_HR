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
    public partial class Fm_register : Form
    {
        public Fm_register()
        {
            InitializeComponent();
        }

        public bool Check_valid()
        {
            if(txt_name.Text.Length>10)
            {
                MessageBox.Show("用户名长度不可以大于10个字符", "注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Clear();
                txt_name.Focus();
                return false;
            }
            else if(txt_name.Text==string.Empty)
            {
                MessageBox.Show("用户名长度不可以为空", "注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
                return false;
            }
            else if(txt_pwd.Text.Length<6||txt_pwd.Text.Length>10)
            {
                MessageBox.Show("密码长度不可以小于六位或者大于10位", "注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pwd.Clear();
                txt_pwd.Focus();
                return false;
            }
            else if(txt_pwd.Text!=txt_pwd_again.Text)
            {
                MessageBox.Show("密码与再次输入的密码不同!", "注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pwd_again.Clear();
                txt_pwd_again.Focus();
                return false;
            }
            return true;
        }

        public bool Check_existed()
        {
            string sqlcmd = "SELECT login_id FROM tb_login WHERE login_id=@uid";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);

            SqlParameter _uid = new SqlParameter("@uid", SqlDbType.Char, 10);
            cmd.Parameters.Add(_uid);
            _uid.Value = txt_name.Text;
            try
            {
                Mydbcon.My_con_open();
                SqlDataReader upwd = cmd.ExecuteReader();
                if (!upwd.HasRows)
                    return false;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Mydbcon.My_con_close();
            }
            return true;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_pwd.Focus();
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_pwd_again.Focus();
        }

        private void txt_pwd_again_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_register_Click(sender, new EventArgs());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //检测输入信息是否合法
            if (!Check_valid())
                return;

            //检测用户名是否存在
            bool if_existed = Check_existed();
            if (if_existed)
            {
                MessageBox.Show("用户名已经存在!", "注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //执行插入
            string sqlcmd = @"INSERT INTO tb_login" 
                            + Environment.NewLine+
                            @"VALUES(@uid,@pwd)";

            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);

            SqlParameter _uid = new SqlParameter("@uid", SqlDbType.Char, 10);
            SqlParameter _pwd = new SqlParameter("@pwd", SqlDbType.VarChar, 10);
            cmd.Parameters.Add(_uid);
            cmd.Parameters.Add(_pwd);
            _uid.Value = txt_name.Text;
            _pwd.Value = txt_pwd.Text;
            try
            {
                Mydbcon.My_con_open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("注册成功!", "注册", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Mydbcon.My_con_close();
                this.Close();
            }
        }
    }
}
