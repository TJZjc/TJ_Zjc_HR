using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace hr管理系统
{
    public partial class Fm_resume : Form
    {
        public Fm_resume()
        {
            InitializeComponent();
        }

        private void Fm_resume_Load(object sender, EventArgs e)
        {
            //查询结果显示
            string sqlcmd = @"SELECT " +
                   "ID,w_name,begin_date,end_date,worktype,branch,photo,details,degree,graduation,age,phone,address " + Environment.NewLine +
                   " FROM tb_work_resume " + Environment.NewLine +
                   " WHERE ID=@wid ";
            Mydbcon.My_con_open();
            SqlCommand cmd = Mydbcon.Create_command(sqlcmd);
            SqlParameter _wid = new SqlParameter("@wid", SqlDbType.Int);
            cmd.Parameters.Add(_wid);
            _wid.Value = Convert.ToInt32(Program.search_id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "resume");
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables["resume"];

            txt_id.Text = ds.Tables["resume"].Rows[0]["ID"].ToString();
            txt_name.Text = ds.Tables["resume"].Rows[0]["w_name"].ToString();
            txt_age.Text = ds.Tables["resume"].Rows[0]["age"].ToString();
            txt_begin_time.Text = DateTime.Parse(ds.Tables["resume"].Rows[0]["begin_date"].ToString()).ToString();
            txt_end_time.Text = ds.Tables["resume"].Rows[0]["end_date"].ToString();
            txt_branch.Text = ds.Tables["resume"].Rows[0]["branch"].ToString();
            txt_worktype.Text = ds.Tables["resume"].Rows[0]["worktype"].ToString();
            txt_degree.Text = ds.Tables["resume"].Rows[0]["degree"].ToString();
            txt_graduation.Text = ds.Tables["resume"].Rows[0]["graduation"].ToString();
            txt_phone.Text = ds.Tables["resume"].Rows[0]["phone"].ToString();
            txt_address.Text = ds.Tables["resume"].Rows[0]["address"].ToString();
         
            rtxt_detail.DataBindings.Add("text", bs, "details");
            byte[] photo = (byte[])ds.Tables["resume"].Rows[0]["photo"];
            MemoryStream ms = new MemoryStream(photo);
            pct_photo.Image = Image.FromStream(ms);

            ms.Dispose();
            adapter.Dispose();
            ds.Dispose();
            bs.Dispose();
            cmd.Dispose();
            Mydbcon.My_con_close();
        }

        private void btn_more_details_Click(object sender, EventArgs e)
        {
            Program.hr_management_choice = "change";
            Fm_details.id = int.Parse(txt_id.Text);
            Form_manege.Choice = "Fm_details";
            Form_manege.Open_Form();
        }
    }
}
