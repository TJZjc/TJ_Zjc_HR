using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr管理系统
{
    static class Program
    {
        public static string user;
        public static string pwd;
        public static string search_id;
        public static string hr_management_choice;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fm_login());
        }
    }
}
