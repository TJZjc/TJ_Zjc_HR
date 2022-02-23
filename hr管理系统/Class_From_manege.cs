using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr管理系统
{
    static class Form_manege
    {
        private static string choice;

        public static string Choice
        {
            set { choice = value; }
        }

        public static void Open_Form()
        {
            switch (choice)
            {
                case "Fm_add_addresslist":
                    { 
                        Fm_add_addresslist new_fm = new Fm_add_addresslist();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_add_rp":
                    { 
                        Fm_add_rp new_fm = new Fm_add_rp();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_addresslist":
                    { 
                        Fm_addresslist new_fm = new Fm_addresslist();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_branch":
                    { 
                        Fm_branch new_fm = new Fm_branch();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_branch_change":
                    { 
                        Fm_branch_change new_fm = new Fm_branch_change();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_branch_delete":
                    { 
                        Fm_branch_delete new_fm = new Fm_branch_delete();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_details":
                    { 
                        Fm_details new_fm = new Fm_details();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_exp":
                    { 
                        Fm_exp new_fm = new Fm_exp();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_find":
                    { 
                        Fm_find new_fm = new Fm_find();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_hr_manegment":
                    { 
                        Fm_hr_manegment new_fm = new Fm_hr_manegment();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_login":
                    { 
                        Fm_login new_fm = new Fm_login();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_main":
                    { 
                        Fm_main new_fm = new Fm_main();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_randp":
                    { 
                        Fm_randp new_fm = new Fm_randp();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_register":
                    { 
                        Fm_register new_fm = new Fm_register();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_resume":
                    { 
                        Fm_resume new_fm = new Fm_resume();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_resume_find":
                    { 
                        Fm_resume_find new_fm = new Fm_resume_find();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_rp_delete":
                    { 
                        Fm_rp_delete new_fm = new Fm_rp_delete();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_salary":
                    { 
                        Fm_salary new_fm = new Fm_salary();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_salary_change":
                    {
                        Fm_salary_change new_fm = new Fm_salary_change();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_salary_change_partcial":
                    { 
                        Fm_salary_change_partcial new_fm = new Fm_salary_change_partcial();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_set_user":
                    { 
                        Fm_set_user new_fm = new Fm_set_user();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_worktype":
                    { 
                        Fm_worktype new_fm = new Fm_worktype();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_worktype_change":
                    { 
                        Fm_worktype_change new_fm = new Fm_worktype_change();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
                case "Fm_worktype_partcial_change":
                    { 
                        Fm_worktype_partcial_change new_fm = new Fm_worktype_partcial_change();
                        new_fm.ShowDialog();
                        new_fm.Dispose();
                    }
                    break;
            }
        }
    }
}
