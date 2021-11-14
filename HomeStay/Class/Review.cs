using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HomeStay.Class
{
    class Review
    {
        public bool createNewReview(int booking_id, int customer_id, String comment, int rating)
        {
            bool result = false;
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Procedure_addNewReview";
            com.Connection = My_DB.getConnection;
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
            com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
            com.Parameters.Add("@comment", SqlDbType.NText).Value = comment;
            com.Parameters.Add("@rating", SqlDbType.Int).Value = rating;
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
        public DataTable getData()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Select * from view_reviews";
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        
        public DataTable getInfoBookingByID(int bid)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Select * from Function_getInfoBookingByID(@bid)";
            com.Parameters.Add("@bid", SqlDbType.Int).Value = bid;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
    }
}
