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
    public partial class Fm_salary_change : Form
    {
        public Fm_salary_change()
        {
            InitializeComponent();
        }

        private bool if_exist = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if(if_exist)
            {
                Mydbcon.My_con_open();
                string sqlcmd = "UPDATE tb_salary SET salary=" + txt_salary_new.Text + " WHERE id = " + txt_id.Text;
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请输入存在的ID", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_salary WHERE id=" + txt_id.Text;
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "salary");
            if (ds.Tables["salary"].Rows.Count > 0)
            {
                if_exist = true;
                txt_branch.Text = ds.Tables["salary"].Rows[0]["branch"].ToString();
                txt_name.Text = ds.Tables["salary"].Rows[0]["name"].ToString();
                txt_work_type.Text = ds.Tables["salary"].Rows[0]["worktype"].ToString();
                txt_salary.Text = ds.Tables["salary"].Rows[0]["salary"].ToString();
            }
            else
            {
                MessageBox.Show("未查询到此id", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Clear();
                txt_id.Focus();
            }
            Mydbcon.My_con_close();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_salary_new.Focus();
        }
    }
}
