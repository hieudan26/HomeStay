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
    class Schedule : My_DB
    {
        public DataTable getScheduleByUserId(DateTime tnow, int emp_id)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "select * from [dbo].[Function_getScheduleByUserId](@tnow, @emp_id)";
                command.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
                command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
                command.Connection = this.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                command.Parameters.Clear();
                this.closeConnection();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get schedule by user id\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }
    }
}
