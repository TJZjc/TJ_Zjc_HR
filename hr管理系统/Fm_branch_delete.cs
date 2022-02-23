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
    public partial class Fm_branch_delete : Form
    {
        public Fm_branch_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确认是否删除此部门","删除",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string sqlcmd = "DELETE FROM tb_branch WHERE b_name=@branch_name";
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlParameter _branch_name = new SqlParameter("@branch_name",SqlDbType.VarChar,30);
                cmd.Parameters.Add(_branch_name);
                _branch_name.Value = cb_branch.Text;
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("删除失败,请确认是否存在该部门", "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mydbcon.My_con_close();
            }
        }

        private void cb_branch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_delete_Click(sender, e);
        }
    }
}
