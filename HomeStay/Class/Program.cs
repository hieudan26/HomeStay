using HomeStay.CustomerForms;
using HomeStay.JanitorForms;
using HomeStay.ManagerForms;
using HomeStay.ReceptionistForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            if (IsServerConnected())
            {
                Console.WriteLine("Connected!");
            }
            else
            {
                Console.WriteLine("Not Yet Connected!");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        private static bool IsServerConnected()
        {
            try
            {
                My_DB.openConnection();
                return true;
            }
            catch (SqlException)
            {
                    return false;
             }
        }
    }
}
