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
using System.IO;

namespace hr管理系统
{
    public partial class Fm_details : Form
    {
        public string Open_way = Program.hr_management_choice;

        private string detail = "无";

        private bool if_OK = true;
        public Fm_details()
        {
            InitializeComponent();
        }

        public static int id;
        private void btn_insert_Click(object sender, EventArgs e)
        {
            byte[] photo_byte = null;
            MemoryStream ms = new MemoryStream();
            pct_photo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            photo_byte = ms.GetBuffer();

            string sqlcmd = "INSERT INTO tb_basic_information " + Environment.NewLine +
                          "VALUES (@ID,@name,@nation,@age,@edu_degree,@sex,@political_status,@ID_card,@begin_time,@work_length,@w_type,@salary,@branch,@phone,@school,@graduate_time,@address,@photo,@bank,@pact_b,@pact_e,@pact_y,@qq_number,@email); "
                          + Environment.NewLine +
                          "DISABLE TRIGGER UPDATE_resume ON tb_work_resume;"
                          + Environment.NewLine +
                          "UPDATE tb_work_resume "
                          + Environment.NewLine +
                          "SET details='" + detail + "' WHERE ID=@ID;"
                           + Environment.NewLine +
                           "ENABLE TRIGGER UPDATE_resume ON tb_work_resume;";

            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);

            SqlParameter _ID = new SqlParameter("@ID",SqlDbType.Int);
            SqlParameter _name = new SqlParameter("@name",SqlDbType.VarChar,20);
            SqlParameter _nation = new SqlParameter("@nation",SqlDbType.VarChar,20);
            SqlParameter _age = new SqlParameter("@age",SqlDbType.Int);
            SqlParameter _edu_degree = new SqlParameter("@edu_degree",SqlDbType.VarChar,20);
            SqlParameter _sex = new SqlParameter("@sex",SqlDbType.VarChar,4);
            SqlParameter _political_status = new SqlParameter("@political_status",SqlDbType.VarChar,10);
            SqlParameter _ID_card = new SqlParameter("@ID_card",SqlDbType.VarChar,20);
            SqlParameter _begin_time = new SqlParameter("@begin_time",SqlDbType.Date);
            SqlParameter _work_length = new SqlParameter("@work_length",SqlDbType.Int);
            SqlParameter _w_type = new SqlParameter("@w_type",SqlDbType.VarChar,30);
            SqlParameter _salary = new SqlParameter("@salary",SqlDbType.Money);
            SqlParameter _branch = new SqlParameter("@branch",SqlDbType.VarChar,30);
            SqlParameter _phone = new SqlParameter("@phone",SqlDbType.VarChar,11);
            SqlParameter _school = new SqlParameter("@school",SqlDbType.VarChar,30);
            SqlParameter _graduate_time = new SqlParameter("@graduate_time",SqlDbType.Date);
            SqlParameter _address = new SqlParameter("@address",SqlDbType.VarChar,30);
            SqlParameter _photo = new SqlParameter("@photo", SqlDbType.VarBinary, 1000000);
            SqlParameter _bank = new SqlParameter("@bank",SqlDbType.VarChar,30);
            SqlParameter _pact_b = new SqlParameter("@pact_b",SqlDbType.Date);
            SqlParameter _pact_e = new SqlParameter("@pact_e", SqlDbType.Date);
            SqlParameter _pact_y = new SqlParameter("@pact_y", SqlDbType.Float);
            SqlParameter _qq_number = new SqlParameter("@qq_number", SqlDbType.VarChar, 30);
            SqlParameter _email = new SqlParameter("@email", SqlDbType.VarChar, 50);

            cmd.Parameters.Add(_ID);
            cmd.Parameters.Add(_name);
            cmd.Parameters.Add(_nation);
            cmd.Parameters.Add(_age);
            cmd.Parameters.Add(_edu_degree);
            cmd.Parameters.Add(_sex);
            cmd.Parameters.Add(_political_status);
            cmd.Parameters.Add(_ID_card);
            cmd.Parameters.Add(_begin_time);
            cmd.Parameters.Add(_work_length);
            cmd.Parameters.Add(_w_type);
            cmd.Parameters.Add(_salary);
            cmd.Parameters.Add(_branch);
            cmd.Parameters.Add(_phone);
            cmd.Parameters.Add(_school);
            cmd.Parameters.Add(_graduate_time);
            cmd.Parameters.Add(_address);
            cmd.Parameters.Add(_photo);
            cmd.Parameters.Add(_bank);
            cmd.Parameters.Add(_pact_b);
            cmd.Parameters.Add(_pact_e);
            cmd.Parameters.Add(_pact_y);
            cmd.Parameters.Add(_qq_number);
            cmd.Parameters.Add(_email);

            _ID.Value = int.Parse(txt_id.Text);
            _name.Value = txt_name.Text;
            _nation.Value = cb_nation.Text;
            _age.Value = int.Parse(txt_age.Text);
            _edu_degree.Value = cb_degree.Text;
            _sex.Value = cb_sex.Text;
            _political_status.Value = cb_pstatus.Text;
            _ID_card.Value = txt_idcard.Text;
            _begin_time.Value = DateTime.Parse(dtp_work_begin_time.Text);
            _work_length.Value = int.Parse(txt_work_length.Text);
            _w_type.Value = cb_work_type.Text;
            _salary.Value = Convert.ToDecimal(txt_salary.Text);
            _branch.Value = cb_branch.Text;
            _phone.Value = txt_phone.Text;
            _school.Value = txt_school.Text;
            _graduate_time.Value = DateTime.Parse(dtp_graduate.Text);
            _address.Value = txt_address.Text;
            _photo.Value = photo_byte;
            _bank.Value = txt_bank.Text;
            _pact_b.Value = DateTime.Parse(dtp_pact_begin_time.Text);
            _pact_e.Value = DateTime.Parse(dtp_pact_end_time.Text);
            _pact_y.Value = float.Parse(txt_pact_length.Text);
            _qq_number.Value = txt_qq.Text;
            _email.Value = txt_email.Text;

            try
            {
                cmd.ExecuteNonQuery();
                if (Open_way == "insert")
                    MessageBox.Show("插入一条成功!", "插入", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "插入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if_OK = false;
            }
            finally
            {
                Mydbcon.My_con_close();
                this.Close();
            }
        }

        private void Fm_details_Load(object sender, EventArgs e)
        {
            if(Program.hr_management_choice=="insert")
            {
                btn_delete.Enabled = false;
                btn_delete.Visible = false;
                btn_change.Enabled = false;
                btn_change.Visible = false;
                string sqlcmd = "SELECT TOP 1 id FROM tb_ID";
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_id.Text = reader["id"].ToString();
                }
                reader.Close();
                Mydbcon.My_con_close();
            }
            else if(Program.hr_management_choice=="change")
            {
                btn_delete.Enabled = false;
                btn_delete.Visible = false;
                btn_insert.Enabled = false;
                btn_insert.Visible = false;

                string sqlcmd = "SELECT * FROM tb_basic_information WHERE id=" + id.ToString();
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_id.Text = reader["ID"].ToString();
                    txt_name.Text = reader["stuffname"].ToString();
                    cb_nation.Text = reader["folk"].ToString();
                    txt_age.Text = reader["age"].ToString();
                    cb_degree.Text = reader["edu_degree"].ToString();
                    cb_sex.Text = reader["sex"].ToString();
                    cb_pstatus.Text = reader["p_status"].ToString();
                    txt_idcard.Text = reader["IDcard"].ToString();
                    dtp_work_begin_time.Value = DateTime.Parse(reader["begin_time"].ToString());
                    txt_work_length.Text = reader["work_length"].ToString();
                    cb_work_type.Text = reader["w_type"].ToString();
                    txt_salary.Text = reader["salary"].ToString();
                    cb_branch.Text = reader["branch"].ToString();
                    txt_phone.Text = reader["phone"].ToString();
                    txt_school.Text = reader["school"].ToString();
                    dtp_graduate.Value = DateTime.Parse(reader["graduate_time"].ToString());
                    txt_address.Text = reader["address"].ToString();
                    txt_bank.Text = reader["bank"].ToString();
                    dtp_pact_begin_time.Value = DateTime.Parse(reader["pact_b"].ToString());
                    dtp_pact_end_time.Value = DateTime.Parse(reader["pact_e"].ToString());
                    txt_pact_length.Text = reader["pact_y"].ToString();
                    txt_qq.Text = reader["qq_number"].ToString();
                    txt_email.Text = reader["email"].ToString();

                    byte[] image = (byte[])reader["photo"];
                    MemoryStream ms = new MemoryStream(image);
                    pct_photo.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                reader.Close();
                Mydbcon.My_con_close();
            }
            else
            {
                btn_insert.Enabled = false;
                btn_insert.Visible = false;
                btn_change.Enabled = false;
                btn_change.Visible = false;

                txt_age.ReadOnly = true;
                txt_address.ReadOnly = true;
                txt_bank.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_idcard.ReadOnly = true;
                txt_name.ReadOnly = true;
                txt_pact_length.ReadOnly = true;
                txt_phone.ReadOnly = true;
                txt_qq.ReadOnly = true;
                txt_salary.ReadOnly = true;
                txt_school.ReadOnly = true;
                txt_work_length.ReadOnly = true;

                cb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cb_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cb_nation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cb_pstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cb_work_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                dtp_graduate.Enabled = false;
                dtp_pact_begin_time.Enabled = false;
                dtp_pact_end_time.Enabled = false;
                dtp_work_begin_time.Enabled = false;

                string sqlcmd = "SELECT * FROM tb_basic_information WHERE id=" + id.ToString();
                Mydbcon.My_con_open();
                SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_id.Text = reader["ID"].ToString();
                    txt_name.Text = reader["stuffname"].ToString();
                    cb_nation.Text = reader["folk"].ToString();
                    txt_age.Text = reader["age"].ToString();
                    cb_degree.Text = reader["edu_degree"].ToString();
                    cb_sex.Text = reader["sex"].ToString();
                    cb_pstatus.Text = reader["p_status"].ToString();
                    txt_idcard.Text = reader["IDcard"].ToString();
                    dtp_work_begin_time.Value = DateTime.Parse(reader["begin_time"].ToString());
                    txt_work_length.Text = reader["work_length"].ToString();
                    cb_work_type.Text = reader["w_type"].ToString();
                    txt_salary.Text = reader["salary"].ToString();
                    cb_branch.Text = reader["branch"].ToString();
                    txt_phone.Text = reader["phone"].ToString();
                    txt_school.Text = reader["school"].ToString();
                    dtp_graduate.Value = DateTime.Parse(reader["graduate_time"].ToString());
                    txt_address.Text = reader["address"].ToString();
                    txt_bank.Text = reader["bank"].ToString();
                    dtp_pact_begin_time.Value = DateTime.Parse(reader["pact_b"].ToString());
                    dtp_pact_end_time.Value = DateTime.Parse(reader["pact_e"].ToString());
                    txt_pact_length.Text = reader["pact_y"].ToString();
                    txt_qq.Text = reader["qq_number"].ToString();
                    txt_email.Text = reader["email"].ToString();

                    byte[] image = (byte[])reader["photo"];
                    MemoryStream ms = new MemoryStream(image);
                    pct_photo.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                reader.Close();
                Mydbcon.My_con_close();
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
            btn_insert_Click(sender, e);
            if (if_OK)
                MessageBox.Show("修改成功!", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            if (Open_way == "delete")
            {
                result = MessageBox.Show("是否删除本人信息", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (Open_way == "change")
                result = DialogResult.OK;
            if (result == DialogResult.OK)
            {
                string sqlcmd = "DELETE FROM tb_basic_information"
                    + Environment.NewLine +
                    "WHERE ID=" + txt_id.Text;
                try
                {
                    Mydbcon.My_con_open();
                    SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
                    cmd.ExecuteNonQuery();
                    if (Open_way == "delete")
                        MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if_OK = false;
                }
                finally
                {
                    Mydbcon.My_con_close();
                    this.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_photo.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png";
            open_photo.FileName = "";
            if (open_photo.ShowDialog() == DialogResult.OK)
                pct_photo.Image = Image.FromFile(open_photo.FileName);
        }

        private void btn_resume_exp_Click(object sender, EventArgs e)
        {
            Fm_exp.ID = txt_id.Text;
            Fm_exp new_fm = new Fm_exp();
            new_fm.ShowDialog();
            new_fm.Dispose();
            detail = Fm_exp.exp;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_age.Focus();
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_sex.Focus();
        }

        private void cb_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_nation.Focus();
        }

        private void cb_nation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_pstatus.Focus();
        }

        private void cb_pstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_address.Focus();
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_idcard.Focus();
        }

        private void txt_idcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_phone.Focus();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_qq.Focus();
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_degree.Focus();
        }

        private void txt_qq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_email.Focus();
        }

        private void cb_degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_school.Focus();
        }

        private void txt_school_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                dtp_graduate.Focus();
        }

        private void dtp_graduate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                dtp_pact_begin_time.Focus();
        }

        private void dtp_pact_begin_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                dtp_pact_end_time.Focus();
        }

        private void dtp_pact_end_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_pact_length.Focus();
        }

        private void txt_pact_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                dtp_work_begin_time.Focus();
        }

        private void dtp_work_begin_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_work_length.Focus();
        }

        private void txt_work_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_branch.Focus();
        }

        private void cb_branch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                cb_work_type.Focus();
        }

        private void cb_work_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_salary.Focus();
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                txt_bank.Focus();
        }
    }
}
