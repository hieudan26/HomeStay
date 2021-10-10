using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.CustomerForms
{
    public partial class HistoryBookingForm : Form
    {
        private Booking booking = new Booking(); 
        public HistoryBookingForm()
        {
            InitializeComponent();
        }

        private void HistoryBookingForm_Load(object sender, EventArgs e)
        {
            //Warning: set cứng///////
            Globals.SetGlobalUserId(9179);
            //////////////////////////
            ///
            this.history_DGV.DataSource = this.booking.getAllHistoryBooking_byID(Globals.GlobalUserId);
            this.history_DGV.ReadOnly = true;
            this.history_DGV.AllowUserToAddRows = false;

            this.history_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[0].HeaderText = "Booking ID";
            this.history_DGV.Columns[1].HeaderText = "Room ID";
            this.history_DGV.Columns[2].HeaderText = "Date In Book";
            this.history_DGV.Columns[3].HeaderText = "Date Out Book";
            this.history_DGV.Columns[4].HeaderText = "Check In";
            this.history_DGV.Columns[5].HeaderText = "Check Out";
            this.history_DGV.Columns[6].HeaderText = "Room Price";
            this.history_DGV.Columns[7].HeaderText = "Overdue Fee";
            this.history_DGV.Columns[8].HeaderText = "Payment Total";
        }
    }
}
