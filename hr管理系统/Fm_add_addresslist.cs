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
    public partial class Fm_add_addresslist : Form
    {
        public Fm_add_addresslist()
        {
            InitializeComponent();
        }

        private bool if_exist = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty)
            {
                string sqlcmd = "SELECT * FROM tb_addrlist WHERE id=" + txt_id.Text;
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "addlist");
                if (ds.Tables["addlist"].Rows.Count > 0)
                {
                    if_exist = true;
                    txt_qq.Text = ds.Tables["addlist"].Rows[0]["QQ_number"].ToString();
                    txt_name.Text = ds.Tables["addlist"].Rows[0]["w_name"].ToString();
                    txt_phone.Text = ds.Tables["addlist"].Rows[0]["phone_number"].ToString();
                    txt_email.Text = ds.Tables["addlist"].Rows[0]["e_mail"].ToString();
                }
                else
                {
                    MessageBox.Show("未查询到此id", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Clear();
                    txt_id.Focus();
                }
                Mydbcon.My_con_close();
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_qq.Focus();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_email.Focus();
        }

        private void txt_qq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_phone.Focus();
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_change_Click(sender, e);
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (if_exist)
            {
                string sqlcmd = "delete FROM tb_addrlist WHERE id=" + txt_id.Text;
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    string sqlcmd2 = "INSERT INTO tb_addrlist VALUES(@id,@name,@qq,@phone,@email)";
                    cmd = Mydbcon.Create_command(sqlcmd2);
                    SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                    SqlParameter _name = new SqlParameter("@name", SqlDbType.VarChar, 30);
                    SqlParameter _qq = new SqlParameter("@qq", SqlDbType.VarChar, 30);
                    SqlParameter _phone = new SqlParameter("@phone", SqlDbType.VarChar, 11);
                    SqlParameter _email = new SqlParameter("@email", SqlDbType.VarChar, 30);
                    cmd.Parameters.Add(_id);
                    cmd.Parameters.Add(_name);
                    cmd.Parameters.Add(_qq);
                    cmd.Parameters.Add(_phone);
                    cmd.Parameters.Add(_email);
                    _id.Value = int.Parse(txt_id.Text);
                    _name.Value = txt_name.Text;
                    _qq.Value = txt_qq.Text;
                    _phone.Value = txt_phone.Text;
                    _email.Value = txt_email.Text;
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("修改失败", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请输入存在的ID", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
