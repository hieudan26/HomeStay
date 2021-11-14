using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay
{
    static class My_DB
    {
        // Change data source base on your computer
        public static String urlConnection = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=HomeStay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection con = new SqlConnection(urlConnection);
        static public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        static public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        static public void closeConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        static public String makeURL(String username, String password) {
            string firstPart = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=HomeStay;Integrated Security=True;";
            string lastPart = "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string middlePart = $"User ID={username};Password={password};";

            return firstPart + middlePart + lastPart;
        }
        static public Boolean grantPermission(String username, String password, String role)
        {
            SqlCommand com = new SqlCommand("proc_grantPermission", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            com.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

            My_DB.openConnection();
            int num = com.ExecuteNonQuery();
            if (num > 0)
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                return true;
            }
            else
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                return false;
            }
        }
    }
}
