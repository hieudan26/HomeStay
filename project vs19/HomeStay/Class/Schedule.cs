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

        public DataTable getDateStartEnd(DateTime tnow)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "Select * from [dbo].[Function_getDateStartEnd](@tnow)";
                command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
                command.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                command.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get date start end\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }

        public DataTable getShiftTimeByUserId(DateTime tnow, int emp_id)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "Select * from [dbo].[Function_getShiftTimeByUserId](@tnow, @emp_id)";
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
                MessageBox.Show("Error can't get shift time by user id\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }
    }
}
