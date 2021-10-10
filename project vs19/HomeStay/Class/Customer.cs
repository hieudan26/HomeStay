using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.Class
{
    class Customer : My_DB
    {//tao trong day ko save =)
        public DataTable getInfoCustomerByRoomID(int room_id)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getInfoCustomerByRoomID(@room_id)";
                com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch(Exception e)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't get information about customer by room_id\n" + e.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        //Kiểm tra tên username đã tồn tại
        public bool customerName_Existed(String username)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.Function_checkUsernameExisted(@username)", this.getConnection);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                this.openConnection();
                int userExisted = (int)cmd.ExecuteScalar();
                this.closeConnection();
                if (userExisted == 0)
                {
                    result = false;
                }
                result = true;
            }
            catch (Exception)
            {
                this.closeConnection();
                MessageBox.Show("Error can't check username", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        //Lấy thông tin customer bằng id
        public DataTable getInfoCustomers(int customer_id)
        {
            try
            {
                SqlCommand com = new SqlCommand("SELECT * FROM dbo.Function_getCustomerbyID(@customer_id)", this.getConnection);
                com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                return dt;
            }
            catch
            {
                this.closeConnection();
                MessageBox.Show("Error can't get information about customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public int getNumOfCustomer()
        {
            int result = -1;
            try
            {
                //Call function have any statement
                SqlCommand com = new SqlCommand("SELECT dbo.Function_countCustomers()", this.getConnection);
                this.openConnection();
                int num = (int)com.ExecuteScalar();
                this.closeConnection();
                //Console.WriteLine(num);
                result = num;
            }
            catch
            {
                this.closeConnection();
                MessageBox.Show("Error can't count quantity of customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool createCustomer(string fname, string lname, MemoryStream pic, string phn, string uname, string pwd)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                //Call stored procedures to insert new customer into Customers table
                com.CommandText = "dbo.Procedure_addNewCustomer";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
                com.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
                com.Parameters.Add("@photo", SqlDbType.Image).Value = pic.ToArray();
                com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phn;
                com.Parameters.Add("@username", SqlDbType.NVarChar).Value = uname;
                com.Parameters.Add("@passwd", SqlDbType.NVarChar).Value = pwd;
                this.openConnection();
                if (com.ExecuteNonQuery() == -1)
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    return true;
                }
                else
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't create new customer\n" + ex.Message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
