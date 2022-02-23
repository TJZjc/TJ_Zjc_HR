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
    public partial class Fm_addresslist : Form
    {
        public Fm_addresslist()
        {
            InitializeComponent();
        }

        private void btn_search_id_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            if (ckb_email.Checked)
            {
                item += " e_mail,";
            }
            if (ckb_phone.Checked)
            {
                item += " phone_number,";
            }
            if (ckb_qq.Checked)
            {
                item += " QQ_number,";
            }
            if (item == string.Empty)
            {
                MessageBox.Show("请选择要查询的内容", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StringBuilder _itme = new StringBuilder(item);
            _itme[item.Length - 1] = ' ';
            item = _itme.ToString();
            string sqlcmd = "SELECT id,w_name," + item + " FROM tb_addrlist WHERE ID=@id";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            cmd.Parameters.Add(_id);
            _id.Value = int.Parse(txt_id.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT id,w_name,qq_number FROM tb_addrlist";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT id,w_name,phone_number FROM tb_addrlist";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT id,w_name,e_mail FROM tb_addrlist";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM tb_addrlist";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_add_addresslist";
            Form_manege.Open_Form();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_serach_name_Click(sender, e);
        }

        private void btn_serach_name_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            if (ckb_email.Checked)
            {
                item += " e_mail,";
            }
            if (ckb_phone.Checked)
            {
                item += " phone_number,";
            }
            if (ckb_qq.Checked)
            {
                item += " QQ_number,";
            }
            if (item == string.Empty)
            {
                MessageBox.Show("请选择要查询的内容", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StringBuilder _itme = new StringBuilder(item);
            _itme[item.Length - 1] = ' ';
            item = _itme.ToString();
            string sqlcmd = "SELECT id,w_name," + item + " FROM tb_addrlist WHERE w_name=@name";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _name = new SqlParameter("@name", SqlDbType.VarChar, 30);
            cmd.Parameters.Add(_name);
            _name.Value = txt_name.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "addresslist");
            dgv_result.DataSource = ds.Tables["addresslist"];
            Mydbcon.My_con_close();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_search_id_Click(sender, e);
        }
    }
}
