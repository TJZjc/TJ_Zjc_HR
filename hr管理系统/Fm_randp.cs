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
    public partial class Fm_randp : Form
    {
        public Fm_randp()
        {
            InitializeComponent();
        }

        private void update_info()
        {
            string sqlcmd = "SELECT * FROM tb_reward_and_punishment";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "rp");
            dgv_total.DataSource = ds.Tables["rp"];
            Mydbcon.My_con_close();
        }

        private void Fm_randp_Load(object sender, EventArgs e)
        {
            update_info();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("请输入员工ID", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
            }
            else
            {
                string sqlcmd = "SELECT * FROM tb_reward_and_punishment WHERE id=" + txt_id.Text;
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "personal");
                if (ds.Tables["personal"].Rows.Count>0)
                {
                    dgv_result.DataSource = ds.Tables["personal"];
                }
                else
                {
                    MessageBox.Show("未查询到此员工，请确认ID是否正确", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Mydbcon.My_con_close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_add_rp";
            Form_manege.Open_Form();
            update_info();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_rp_delete";
            Form_manege.Open_Form();
            update_info();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_id_Click(sender, e);
        }
    }
}
