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
    public partial class Fm_salary_change_partcial : Form
    {
        public Fm_salary_change_partcial()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "UPDATE tb_salary SET salary=@salary_new WHERE salary=@salary_now";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _salary_now = new SqlParameter("@salary_now", SqlDbType.Money);
            SqlParameter _salary_new = new SqlParameter("@salary_new", SqlDbType.Money);
            cmd.Parameters.Add(_salary_now);
            cmd.Parameters.Add(_salary_new);
            _salary_now.Value = decimal.Parse(cb_salary_now.Text);
            _salary_new.Value = decimal.Parse(txt_salary_new.Text);
            if(cmd.ExecuteNonQuery()>0)
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
