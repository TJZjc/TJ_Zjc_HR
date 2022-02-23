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
    public partial class Fm_branch : Form
    {
        public Fm_branch()
        {
            InitializeComponent();
        }

        public static bool if_find = false;
        
        public static string id;

        private void update_info()
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_branch order by name";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "branch_infor");
            dgv_infor.DataSource = ds.Tables["branch_infor"];
            Mydbcon.My_con_close();
        }
        private void Fm_branch_Load(object sender, EventArgs e)
        {
            update_info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fm_resume_find.open_way = "branch_search";
            Form_manege.Choice = "Fm_resume_find";
            Form_manege.Open_Form();

            if (if_find)
            {
                Mydbcon.My_con_open();
                string sqlcmd = "SELECT * FROM view_branch WHERE id=" + id;
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "branch_infor");
                dgv_infor.DataSource = ds.Tables["branch_infor"];
                Mydbcon.My_con_close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Fm_resume_find.open_way = "branch_search";
            Form_manege.Choice = "Fm_resume_find";
            Form_manege.Open_Form();

            if (if_find)
            {
                Mydbcon.My_con_open();
                string sqlcmd = "DELETE FROM tb_branch WHERE id=" + id;
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mydbcon.My_con_close();
            }

            update_info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_branch_delete";
            Form_manege.Open_Form();
            update_info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_branch_change";
            Form_manege.Open_Form();
            update_info();
        }

        private void cb_branch_MouseLeave(object sender, EventArgs e)
        {
            if (cb_branch.Text != string.Empty)
            {
                string sqlcmd = "SELECT * FROM view_branch WHERE branch='" + cb_branch.Text + "' GROUP BY branch";
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                Mydbcon.My_con_open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "branch_infor");
                dgv_infor.DataSource = ds.Tables["branch_infor"];
                Mydbcon.My_con_close();
            }
        }
    }
}
