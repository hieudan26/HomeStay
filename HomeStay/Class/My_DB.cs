using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay
{
    public class My_DB
    {
        // Change data source base on your computer
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB_HomeStay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection getConnection
        {
            get
            {
                return this.con;
            }
        }

        public void openConnection()
        {
            if(this.con.State == ConnectionState.Closed || this.con.State == ConnectionState.Broken)
            {
                this.con.Open();
            }
        }

        public void closeConnection()
        {
            if(this.con.State == ConnectionState.Open)
            {
                this.con.Close();
            }
        }
    }
}
