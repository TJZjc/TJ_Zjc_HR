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
    public partial class Fm_resume_find : Form
    {
        public Fm_resume_find()
        {
            InitializeComponent();
        }

        public static string open_way;
        private void btn_id_Click(object sender, EventArgs e)
        {
            if (open_way != "branch_search")
            {
                string sqlcmd = "SELECT ID FROM tb_work_resume WHERE ID=@id";
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                cmd.Parameters.Add(_id);
                _id.Value = Convert.ToInt32(txt_id.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    Mydbcon.My_con_close();
                    Program.search_id = txt_id.Text;
                    Fm_resume new_fm = new Fm_resume();
                    new_fm.ShowDialog();
                    new_fm.Dispose();
                    Program.search_id = string.Empty;
                    txt_id.Clear();
                }
                else
                {
                    MessageBox.Show("未查询到此员工，请确认ID是否正确", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sqlcmd = "SELECT ID FROM view_branch WHERE ID=@id";
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                cmd.Parameters.Add(_id);
                _id.Value = Convert.ToInt32(txt_id.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Fm_branch.if_find = true;
                    reader.Close();
                    Mydbcon.My_con_close();
                    Fm_branch.id = txt_id.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("未查询到此员工，请确认ID是否正确", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_id.Clear();
                }
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_id_Click(sender, e);
        }
    }
}
