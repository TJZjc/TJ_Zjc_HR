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
    public partial class Fm_worktype : Form
    {
        public Fm_worktype()
        {
            InitializeComponent();
        }

        private void update_info()
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_worktype";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "worktype");
            dgv_result.DataSource = ds.Tables["worktype"];
            Mydbcon.My_con_close();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_worktype WHERE id=@id";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            cmd.Parameters.Add(_id);
            _id.Value = int.Parse(txt_id.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "worktype");
            if (ds.Tables["worktype"].Rows.Count > 0)
                dgv_result.DataSource = ds.Tables["worktype"];
            else
            {
                MessageBox.Show("未查询到此员工的记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                txt_id.Clear();
            }
            Mydbcon.My_con_close();
        }

        private void btn_search_worktype_Click(object sender, EventArgs e)
        {
            Mydbcon.My_con_open();
            string sqlcmd = "SELECT * FROM view_worktype WHERE worktype=@worktype";
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _worktype = new SqlParameter("@worktype", SqlDbType.VarChar,30);
            cmd.Parameters.Add(_worktype);
            _worktype.Value = cb_worktype.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "worktype");
            if (ds.Tables["worktype"].Rows.Count > 0)
                dgv_result.DataSource = ds.Tables["worktype"];
            else
            {
                MessageBox.Show("未查询到此职务的记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                txt_id.Clear();
            }
            Mydbcon.My_con_close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update_info();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_worktype_partcial_change";
            Form_manege.Open_Form();
            update_info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_worktype_change";
            Form_manege.Open_Form();
            update_info();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_name_Click(sender, e);
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM view_worktype WHERE name=@name";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _name = new SqlParameter("@name", SqlDbType.VarChar, 30);
            cmd.Parameters.Add(_name);
            _name.Value = txt_name.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "worktype");
            if (ds.Tables["worktype"].Rows.Count > 0)
                dgv_result.DataSource = ds.Tables["worktype"];
            else
            {
                MessageBox.Show("未查询到此员工的记录", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
                txt_name.Clear();
            }
            Mydbcon.My_con_close();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_id_Click(sender, e);
        }
    }
}
