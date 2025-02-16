﻿using System;
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
    class Customer
    {
        public DataTable getInfoCustomerByRoomID(int room_id)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM dbo.Function_getInfoCustomerByRoomID(@room_id)";
            com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            My_DB.closeConnection();
            return dt;
        }

        //Kiểm tra tên username đã tồn tại
        public bool customerName_Existed(String username)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.Function_checkUsernameExisted(@username)", My_DB.getConnection);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                My_DB.openConnection();
                int userExisted = (int)cmd.ExecuteScalar();
                My_DB.closeConnection();
                if (userExisted == 0)
                {
                    result = false;
                }
                result = true;
            }
            catch (Exception)
            {
                My_DB.closeConnection();
                MessageBox.Show("Error can't check username", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        //Lấy thông tin customer bằng id
        public DataTable getInfoCustomers(int customer_id)
        {
            try
            {
                SqlCommand com = new SqlCommand("SELECT * FROM dbo.Function_getCustomerbyID(@customer_id)", My_DB.getConnection);
                com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
                com.Connection = My_DB.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                return dt;
            }
            catch
            {
                My_DB.closeConnection();
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
                SqlCommand com = new SqlCommand("SELECT dbo.Function_countCustomers()", My_DB.getConnection);
                My_DB.openConnection();
                int num = (int)com.ExecuteScalar();
                My_DB.closeConnection();
                //Console.WriteLine(num);
                result = num;
            }
            catch
            {
                My_DB.closeConnection();
                MessageBox.Show("Error can't count quantity of customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool createCustomer(string fname, string lname, MemoryStream pic, string phn, string uname, string pwd)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_addNewCustomer";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            if (pic != null)
                com.Parameters.Add("@photo", SqlDbType.Image).Value = pic.ToArray();
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
            com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phn;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = uname;
            com.Parameters.Add("@passwd", SqlDbType.NVarChar).Value = pwd;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == -1)
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
        public bool editCustomer(int cid, string fname, string lname, MemoryStream pic, string phn, string uname, string pwd)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_editCustomer";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            com.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            if (pic != null)
                com.Parameters.Add("@photo", SqlDbType.Image).Value = pic.ToArray();
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
            com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phn;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = uname;
            com.Parameters.Add("@passwd", SqlDbType.NVarChar).Value = pwd;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == -1)
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
