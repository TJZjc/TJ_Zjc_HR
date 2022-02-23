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
    public partial class Fm_salary : Form
    {
        public Fm_salary()
        {
            InitializeComponent();
        }

        private void update_info()
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_salary";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "salary");
            dgv_result.DataSource = ds.Tables["salary"];
            Mydbcon.My_con_close();
        }

        private void btn_search_by_name_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_salary WHERE name=@name";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _name = new SqlParameter("@name", SqlDbType.VarChar, 30);
            cmd.Parameters.Add(_name);
            _name.Value = txt_name.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "salary");
            if (ds.Tables["salary"].Rows.Count > 0)
                dgv_result.DataSource = ds.Tables["salary"];
            else
            {
                MessageBox.Show("未查询到此员工的工资记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
                txt_name.Clear();
            }
            Mydbcon.My_con_close();
        }

        private void btn_search_by_id_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_salary WHERE id=@id";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            cmd.Parameters.Add(_id);
            _id.Value = int.Parse(txt_id.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "salary");
            if (ds.Tables["salary"].Rows.Count > 0)
                dgv_result.DataSource = ds.Tables["salary"];
            else
            {
                MessageBox.Show("未查询到此员工的工资记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                txt_id.Clear();
            }
            Mydbcon.My_con_close();
        }

        private void btn_search_partial_Click(object sender, EventArgs e)
        {
            if (cb_salary.Text != string.Empty)
            {
                Mydbcon.My_con_open();
                string sqlcmd = "SELECT * FROM view_salary WHERE salary=@salary";
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlParameter _salary = new SqlParameter("@salary", SqlDbType.Money);
                cmd.Parameters.Add(_salary);
                _salary.Value = decimal.Parse(cb_salary.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "salary");
                if (ds.Tables["salary"].Rows.Count > 0)
                    dgv_result.DataSource = ds.Tables["salary"];
                else
                {
                    MessageBox.Show("未查询到此工资的相关信息", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Mydbcon.My_con_close();
            }
        }

        private void btn_search_total_Click(object sender, EventArgs e)
        {
            update_info();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_salary_change_partcial";
            Form_manege.Open_Form();
            update_info();
        }

        private void btn_change_person_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_salary_change";
            Form_manege.Open_Form();
            update_info();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_search_by_name_Click(sender, e);
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_search_by_id_Click(sender, e);
        }

        private void Fm_salary_Load(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT salary FROM tb_salary GROUP BY salary";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataReader reader = cmd.ExecuteReader();
            string item;
            while(reader.Read())
            {
                item = reader.GetValue(0).ToString();
                cb_salary.Items.Add(item);
            }
            Mydbcon.My_con_close();
        }
    }
}
