using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay.Class
{
    class Employee
    {
        public DataTable getEmployees(SqlCommand com)
        {
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public Boolean insertEmployee(string fname, string lname, string email, string title, string gender, DateTime bdate, string phone, MemoryStream picture, string username, string password, string repassword)
        {
            SqlCommand com = new SqlCommand("dbo.prod_insert_Employee_Account", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = lname;
            com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            com.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            com.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            if(picture != null)
                com.Parameters.Add("@photo", SqlDbType.Image).Value = picture.ToArray();
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
            com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            com.Parameters.Add("@repassword", SqlDbType.NVarChar).Value = repassword;

            My_DB.openConnection();
            int num = com.ExecuteNonQuery();
            Console.WriteLine(num);
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
        public bool updateEmployee(int id, string fname, string lname, string email, string title, string gender, DateTime bdate, string phone, MemoryStream picture)
        {
            SqlCommand com = new SqlCommand("prod_editEmployees", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = lname;
            com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            com.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            com.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            if (picture != null)
                com.Parameters.Add("@photo", SqlDbType.Image).Value = picture.ToArray();
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
            com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;

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
        public bool delEmployee(int emp_id, int acc_id)
        {
            try
            {
                SqlCommand com = new SqlCommand("dbo.prod_delete_Employee_Account", My_DB.getConnection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
                com.Parameters.Add("@acc_id", SqlDbType.Int).Value = acc_id;
                Console.WriteLine(com.CommandText);
                My_DB.openConnection();
                if (com.ExecuteNonQuery() > 0)
                {
                    com.Parameters.Clear();
                    My_DB.closeConnection();
                    return true;
                }
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                My_DB.closeConnection();
            }

            return false;
        }
        public int countEmployeesByTitle(string title)
        {
            SqlCommand com = new SqlCommand("dbo.func_countEmployeesHasTitle", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            com.Parameters.Add("@@count", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            My_DB.openConnection();
            com.ExecuteNonQuery();

            int count = Convert.ToInt32(com.Parameters["@@count"].Value);
            My_DB.closeConnection();
            com.Parameters.Clear();
            return count;
        }
        //tam thoi
        public int numOfEmployees()
        {
            SqlCommand com = new SqlCommand("dbo.func_countEmployees", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@@count", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            My_DB.openConnection();
            com.ExecuteNonQuery();

            int count = Convert.ToInt32(com.Parameters["@@count"].Value);
            My_DB.closeConnection();
            com.Parameters.Clear();
            return count;
        }
    }
}
