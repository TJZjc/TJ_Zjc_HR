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
    public partial class Fm_exp : Form
    {
        public static string exp;
        public static string ID;
        public Fm_exp()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_exp.Text!=string.Empty)
            {
                exp = txt_exp.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入简历说明后重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_exp.Focus();
            }
        }

        private void Fm_exp_Load(object sender, EventArgs e)
        {
            if (Program.hr_management_choice == "change")
            {
                string sqlcmd = "SELECT details FROM tb_work_resume WHERE ID=" + ID;
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_exp.Text = reader["details"].ToString();
                }
                reader.Close();
                Mydbcon.My_con_close();
            }
        }
    }
}
