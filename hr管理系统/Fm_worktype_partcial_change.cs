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
    public partial class Fm_worktype_partcial_change : Form
    {
        public Fm_worktype_partcial_change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "UPDATE tb_worktype SET w_name=@worktype_new WHERE w_name=@worktype_now";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _worktype_now = new SqlParameter("@worktype_now", SqlDbType.VarChar,30);
            SqlParameter _worktype_new = new SqlParameter("@worktype_new", SqlDbType.VarChar,30);
            cmd.Parameters.Add(_worktype_now);
            cmd.Parameters.Add(_worktype_new);
            _worktype_now.Value = cb_worktype_now.Text;
            _worktype_new.Value = txt_worktype_new.Text;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Mydbcon.My_con_close();
        }
    }
}
