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
    public partial class Fm_add_rp : Form
    {
        public Fm_add_rp()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty)
            {
                string sqlcmd = "SELECT id FROM tb_basic_information WHERE id=" + txt_id.Text;
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                try
                {
                    if (cmd.ExecuteScalar()!=null)
                    {
                        string sqlcmd_add = "INSERT INTO tb_reward_and_punishment (ID,rp_type,rp_time,rp_money,approver) VALUES(@id,@rp_type,@rp_time,@money,@approver)";
                        cmd = Mydbcon.Create_command(sqlcmd_add);
                        SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                        SqlParameter _rp_type = new SqlParameter("@rp_type", SqlDbType.VarChar, 40);
                        SqlParameter _rp_time = new SqlParameter("@rp_time", SqlDbType.Date);
                        SqlParameter _money = new SqlParameter("@money", SqlDbType.Money);
                        SqlParameter _approver = new SqlParameter("@approver", SqlDbType.VarChar, 20);
                        cmd.Parameters.Add(_id);
                        cmd.Parameters.Add(_rp_type);
                        cmd.Parameters.Add(_rp_time);
                        cmd.Parameters.Add(_money);
                        cmd.Parameters.Add(_approver);
                        _id.Value = int.Parse(txt_id.Text);
                        _rp_type.Value = rtxt_rp_type.Text;
                        _rp_time.Value = DateTime.Parse(dtp_time.Text);
                        _money.Value = decimal.Parse(txt_money.Text);
                        _approver.Value = txt_approver.Text;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("插入成功", "插入", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("插入失败", "插入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("未查询到此员工，请确认ID是否正确", "添加", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Mydbcon.My_con_close();
                }
            }
            else
            {
                MessageBox.Show("请输入员工ID", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                rtxt_rp_type.Focus();
        }

        private void rtxt_rp_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                dtp_time.Focus();
        }

        private void dtp_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_money.Focus();
        }

        private void txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_approver.Focus();
        }

        private void txt_approver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_add_Click(sender,e);
        }
    }
}
