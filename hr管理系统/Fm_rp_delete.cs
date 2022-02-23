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
    public partial class Fm_rp_delete : Form
    {
        public Fm_rp_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT ID FROM tb_reward_and_punishment WHERE ID=@id";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            cmd.Parameters.Add(_id);
            _id.Value = Convert.ToInt32(txt_id.Text);
            if(cmd.ExecuteScalar()!=null)
            {
                if(MessageBox.Show("是否删除此id的相关记录", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    cmd = Mydbcon.Create_command("DELETE FROM tb_reward_and_punishment WHERE ID=" + txt_id.Text);
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("未查询到此员工的奖惩记录", "删除", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_delete_Click(sender, e);
        }
    }
}
