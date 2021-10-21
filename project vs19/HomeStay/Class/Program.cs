using HomeStay.CustomerForms;
using HomeStay.ManagerForms;
using HomeStay.ReceptionistForm;
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
            My_DB mydb = new My_DB();
            
            /*if(IsServerConnected(mydb))
            {
                Console.WriteLine("Connected!");
            }
            else
            {
                Console.WriteLine("Not Yet Connected!");*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageEmployeesForm());
        }
        
        /*private static bool IsServerConnected(My_DB mydb)
        {
            try
            {
                mydb.openConnection();
                return true;
            }
            catch (SqlException)
            {
                    return false;
             }
        }*/
    }
}
