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
    public partial class Fm_main : Form
    {
        public Fm_main()
        {
            InitializeComponent();
        }

        private void Fm_main_Load(object sender, EventArgs e)
        {
            timer_change_time.Start();
        }

        private void timer_change_time_Tick(object sender, EventArgs e)
        {
            status_lab_time.Text = DateTime.Now.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                timer_change_time.Stop();
                Application.Exit();
            }
        }

        private void btn_re_login_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要重新登录吗", "重新登录", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                timer_change_time.Stop();
                Application.Restart();
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            btn_re_login_Click(sender, e);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            btn_exit_Click(sender, e);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_set_user";
            Form_manege.Open_Form();
        }

        private void 人事简历资料_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_resume_find";
            Form_manege.Open_Form();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_hr_manegment";
            Form_manege.Open_Form();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_resume_find";
            Form_manege.Open_Form();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8_Click(sender, e);
        }

        private void e_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_branch";
            Form_manege.Open_Form();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_randp";
            Form_manege.Open_Form();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_salary";
            Form_manege.Open_Form();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_worktype";
            Form_manege.Open_Form();
        }

        private void 通讯录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_manege.Choice = "Fm_addresslist";
            Form_manege.Open_Form();
        }

        private void btn_addresslist_Click(object sender, EventArgs e)
        {
            通讯录ToolStripMenuItem_Click(sender, e);
        }
    }
}
