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
    public partial class Fm_branch_change : Form
    {
        public Fm_branch_change()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd_change = "UPDATE tb_branch SET b_name='"+ cb_branch_change .Text+ "' WHERE id=" + txt_id.Text;
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd_change);
            cmd = Mydbcon.Create_command(sqlcmd_change);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Mydbcon.My_con_close();
                this.Close();
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_branch_change.Focus();
        }

        private void cb_branch_change_KeyPress(object sender, KeyPressEventArgs e)
        {
            btn_change_Click(sender, e);
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty)
            {
                string sqlcmd = "SELECT name,branch FROM view_branch WHERE ID=@id";
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                cmd.Parameters.Add(_id);
                _id.Value = Convert.ToInt32(txt_id.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_branch_now.Text = reader["branch"].ToString();
                    txt_name.Text = reader["name"].ToString();
                }
                else
                {
                    MessageBox.Show("未查询到此员工，请检查ID是否正确", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Clear();
                    return;
                }
            }
        }
    }
}
