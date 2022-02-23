using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr管理系统
{
    public partial class Fm_hr_manegment : Form
    {
        public Fm_hr_manegment()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Program.hr_management_choice = "insert";
            Form_manege.Choice = "Fm_details";
            Form_manege.Open_Form();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Program.hr_management_choice = "change";
            Form_manege.Choice = "Fm_find";
            Form_manege.Open_Form();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Program.hr_management_choice = "delete";
            Form_manege.Choice = "Fm_find";
            Form_manege.Open_Form();
        }
    }
}
