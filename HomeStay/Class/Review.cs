using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HomeStay.Class
{
    class Review: My_DB
    {
        public bool createNewReview(int booking_id, int customer_id, String comment, int rating)
        {
            bool result = false;
            SqlCommand com = new SqlCommand();
            com.CommandText = "dbo.Procedure_addNewReview";
            com.Connection = this.getConnection;
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@booking_id", SqlDbType.Int).Value = booking_id;
            com.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
            com.Parameters.Add("@comment", SqlDbType.NText).Value = comment;
            com.Parameters.Add("@rating", SqlDbType.Int).Value = rating;
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
            return result;
        }
    }
}
