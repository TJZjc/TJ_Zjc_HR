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
    public partial class Fm_find : Form
    {
        public Fm_find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT ID FROM tb_basic_information WHERE ID=@id";
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
                Fm_details.id = int.Parse(txt_id.Text);
                this.Close();
                this.Hide();
                Fm_details new_fm = new Fm_details();
                new_fm.ShowDialog();
                new_fm.Dispose();
            }
            else
            {
                MessageBox.Show("未查询到此员工，请确认ID是否正确", "查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button1_Click(sender, e);
        }
    }
}
