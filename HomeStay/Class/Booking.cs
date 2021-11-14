using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay.Class
{
    class Booking
    {
        SqlCommand com = new SqlCommand();
        // FOR MANAGER FORM
        public DataTable getBookingHistory(DateTime dstart, DateTime dend)
        {
            com.Parameters.Clear();
            com.CommandText = "proc_getBookingHistory";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@dstart", SqlDbType.DateTime).Value = dstart;
            com.Parameters.Add("@dend", SqlDbType.DateTime).Value = dend;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getBookingHistoryOverdue(DateTime dstart, DateTime dend)
        {
            com.Parameters.Clear();
            com.CommandText = "proc_getBookingHistoryOverdue";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@dstart", SqlDbType.DateTime).Value = dstart;
            com.Parameters.Add("@dend", SqlDbType.DateTime).Value = dend;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getBookingOverdue()
        {
            com.Parameters.Clear();
            com.CommandText = "proc_getBookingOverdue";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //
        public bool createBooking(int customer_id, int room_id, DateTime booking_date, DateTime return_date, decimal amount, double overdue_fee = 0)
        {
            bool result = false;
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_createBooking";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
            com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
            com.Parameters.Add("@booking_date", SqlDbType.DateTime).Value = booking_date;
            com.Parameters.Add("@return_date", SqlDbType.DateTime).Value = return_date;

            com.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;

            com.Parameters.Add("@overdue_fee", SqlDbType.Decimal).Value = overdue_fee;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == -1)
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                result = true;
            }
            else
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                result = false;
            }
            return result;
        }
        public DataTable getBooking(int customer_id)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM dbo.Function_getBooking(@customer_id)";
            com.Connection = My_DB.getConnection;
            com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            My_DB.closeConnection();
            return dt;
        }
        public bool insertCheckInData(int booking_id, DateTime checkin)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_updateCheckInData";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
            com.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == 1)
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
        public bool updateOverdue_fee(int booking_id, decimal overdue_fee)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_updateOverdue_fee";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
            com.Parameters.Add("@overdue_fee", SqlDbType.Decimal).Value = overdue_fee;
            My_DB.openConnection();

            if (com.ExecuteNonQuery() == 1)
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
        public bool updateOverDueBooking()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.proc_updateOverDueBooking";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now;
            My_DB.openConnection();

            if (com.ExecuteNonQuery() == 1)
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
        public bool insertCheckOutData(int booking_id, DateTime checkout)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Proc_updateCheckOutData";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
            com.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == 1)
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
        public DataTable getAllHistoryBooking_byID(int customer_id)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM dbo.Function_getAllHistoryBooking_byID(@customer_id)";
            com.Connection = My_DB.getConnection;
            com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            My_DB.closeConnection();
            return dt;
        }

    }
}
