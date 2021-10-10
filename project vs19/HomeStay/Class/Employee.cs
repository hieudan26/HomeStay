using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.Class
{
    class Employee : My_DB
    {
        public DataTable getEmployee_byID(int emp_id)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM [dbo].[Function_getEmployee_byID(@emp_id)";
                com.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't get data of employee\n" + e.Message, "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable searchData(string colName, string valueToFind)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM [dbo].[Function_searchData_Janitor]('Janitor', @colName, @valueToFind)";
                com.Parameters.Add("@colName", SqlDbType.NVarChar).Value = colName;
                com.Parameters.Add("@valueToFind", SqlDbType.NVarChar).Value = valueToFind;
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't search data of janitor\n" + e.Message, "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable getEmployees()
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM [dbo].[Function_getAllEmployee_Janitor](@title)";
                com.Parameters.Add("@title", SqlDbType.NVarChar).Value = "Janitor";
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't get employees\n" + e.Message, "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
