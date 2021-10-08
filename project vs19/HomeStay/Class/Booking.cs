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
    class Booking : My_DB
    {
        public bool updateAmount(int booking_id, decimal overdue_fee)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateAmount";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
                com.Parameters.Add("@overdue_fee", SqlDbType.Decimal).Value = overdue_fee;
                this.openConnection();

                if (com.ExecuteNonQuery() == 1)
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
            catch (Exception e)
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't update amount with booking id: " + booking_id +
                    "\n" + e.Message, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool updateOverdue_fee(int booking_id, decimal overdue_fee)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateOverdue_fee";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
                com.Parameters.Add("@overdue_fee", SqlDbType.Decimal).Value = overdue_fee;
                this.openConnection();

                if (com.ExecuteNonQuery() == 1)
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
            catch (Exception e)
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't update overdue_fee with booking id: " + booking_id + 
                    "\n" + e.Message, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //get all history data of customer
        public DataTable getAllHistoryBooking_byID(int customer_id)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getAllHistoryBooking_byID(@customer_id)";
                com.Connection = this.getConnection;
                com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error can't get history data\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return null;
        }

        public bool insertCheckOutData(int booking_id, DateTime checkout)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateCheckOutData";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
                com.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
                this.openConnection();
                if (com.ExecuteNonQuery() == 1)
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
            catch (Exception e)
            {
                MessageBox.Show("Error insert checkout data\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return false;
        }

        public bool insertCheckInData(int booking_id, DateTime checkin)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateCheckInData";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
                com.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
                this.openConnection();
                if (com.ExecuteNonQuery() == 1)
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
            catch (Exception e)
            {
                MessageBox.Show("Error insert checkin data\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return false;
        }
            
        public DataTable getBooking(int customer_id)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getBooking(@customer_id)";
                com.Connection = this.getConnection;
                com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get booking\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return null;
        }

        public bool createBooking(int customer_id, int room_id, DateTime booking_date, DateTime return_date, decimal amount, double overdue_fee = 0)
        {
            bool result = false;
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_createBooking";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
                com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
                com.Parameters.Add("@booking_date", SqlDbType.DateTime).Value = booking_date;
                com.Parameters.Add("@return_date", SqlDbType.DateTime).Value = return_date;
                com.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                com.Parameters.Add("@overdue_fee", SqlDbType.Decimal).Value = overdue_fee;
                this.openConnection();
                if (com.ExecuteNonQuery() == -1)
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    result = true;
                }
                else
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    result = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error DAO create new booking\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return result;
        }

        public int getNumOfBooking()
        {
            int num = -1;
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "Select dbo.Function_countBooking()";
                com.Connection = this.getConnection;
                this.openConnection();
                num = (int)com.ExecuteScalar();
                this.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error DAO get all booking of customer\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return num;
        }
    }
}
