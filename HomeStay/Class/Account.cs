using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay.Class
{
    class Account
    {
        public DataTable getAccounts(SqlCommand com)
        {
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Login(string username, string password, string title)
        {
            SqlCommand com = new SqlCommand("SELECT dbo.func_Login(@username, @password, @title)");
            com.Connection = My_DB.getConnection;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            My_DB.openConnection();
            int user_id = (int)com.ExecuteScalar();
            My_DB.closeConnection();
            com.Parameters.Clear();
            return user_id;
        }
        public DataTable getNameAndPhoto(int id, string title)
        {
            SqlCommand com = new SqlCommand("dbo.proc_getNameAndPhoto");
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = My_DB.getConnection;
            Console.WriteLine(id);
            Console.WriteLine(title);
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            My_DB.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            My_DB.closeConnection();
            com.Parameters.Clear();
            return dt;
        }
        public bool updateAccount(int id, string user, string pass)
        {
            SqlCommand com = new SqlCommand("prod_editEmployeeAccounts", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@acc_id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = user;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = pass;
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
