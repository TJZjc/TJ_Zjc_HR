using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace hr管理系统
{
    class Mydbcon
    {
        private static string server = ".";

        public static string Server
        {
            set { Mydbcon.server = value; }
            get { return Mydbcon.server; }
        }

        private static string database = "db_HR";

        public static string Database
        {
            set { Mydbcon.database = value; }
            get { return Mydbcon.database; }
        }

        private static string integrated_security = "SSPI";

        public static string Integrated_security
        {
            set { Mydbcon.integrated_security = value; }
            get{ return Mydbcon.integrated_security;}
        }

        private static SqlConnection my_conn;
        public static void My_con_open()
        {
            try
            {
                string open_db = "Server=" + server + ";Integrated Security=" + integrated_security + ";Database=" + database;
                my_conn = new SqlConnection(open_db);
                my_conn.Open();
            }
            catch(SqlException ex)
            {
                DialogResult d_result =MessageBox.Show(ex.Message+Environment.NewLine+"按确认关闭程序并检查数据库!", "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mydbcon.My_con_close();
                if(d_result==DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        public static void My_con_close()
        {
            my_conn.Close();
            my_conn.Dispose();
        }

        public static SqlCommand Create_command(string str)
        {
            SqlCommand cmd = new SqlCommand(str,my_conn);
            return cmd;
        }
    }
}
