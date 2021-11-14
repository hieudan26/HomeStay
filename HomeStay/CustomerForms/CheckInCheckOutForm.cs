using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.CustomerForms
{
    public partial class CheckInCheckOutForm : Form
    {
        private Room room = new Room();
        private Booking booking = new Booking();

        public CheckInCheckOutForm()
        {
            InitializeComponent();
        }

        private void CheckInCheckOutForm_Load(object sender, EventArgs e)
        {
            this.checkInOut_DGV.DataSource = this.booking.getBooking(Globals.GlobalUserId);
            this.checkInOut_DGV.ReadOnly = true;
            this.checkInOut_DGV.AllowUserToAddRows = false;

            this.checkInOut_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.checkInOut_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.checkInOut_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.checkInOut_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.checkInOut_DGV.Columns[0].HeaderText = "Booking ID";
            this.checkInOut_DGV.Columns[1].HeaderText = "Room ID";
            this.checkInOut_DGV.Columns[2].HeaderText = "Date In Book";
            this.checkInOut_DGV.Columns[3].HeaderText = "Date Out Book";
            this.checkInOut_DGV.Columns[4].HeaderText = "Check In";
            this.checkInOut_DGV.Columns[5].HeaderText = "Check Out";
        }

        private void checkIn_BT_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString().Trim();
            int booking_id = int.Parse(this.checkInOut_DGV.Rows[0].Cells[0].Value.ToString().Trim());
            try
            {
                this.booking.insertCheckInData(booking_id, DateTime.Parse(now));
                MessageBox.Show("Checked In!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.checkInOut_DGV.DataSource = this.booking.getBooking(Globals.GlobalUserId);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message, "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void checkOut_BT_Click(object sender, EventArgs e)
        {
            try
            {
                int booking_id = int.Parse(this.checkInOut_DGV.Rows[0].Cells[0].Value.ToString().Trim());
                DateTime now = DateTime.Now;
                this.booking.insertCheckOutData(booking_id, now);
                this.room.updateStatus(Convert.ToInt32(this.checkInOut_DGV.CurrentRow.Cells[1].Value.ToString().Trim()), false, true);
                if (DateTime.Compare(now, DateTime.Parse(checkInOut_DGV.Rows[0].Cells[3].Value.ToString())) > 0)
                {
                    MessageBox.Show("You're late. You'll pay overdue fee.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TimeSpan timeSpan = now - DateTime.Parse(this.checkInOut_DGV.Rows[0].Cells[3].Value.ToString().Trim());
                    int room_id = int.Parse(this.checkInOut_DGV.CurrentRow.Cells[1].Value.ToString().Trim());
                    int room_type_id = this.room.getRoomtype_byRoomID(room_id);
                    decimal room_price = this.room.getPriceofRoom_byTypeId(room_type_id);
                    decimal overdue_fee = (decimal.Parse(Math.Round(timeSpan.TotalHours).ToString()) * room_price / 10 * 2) / 100;
                    this.booking.updateOverdue_fee(booking_id, overdue_fee);
                }
                else
                {
                    MessageBox.Show("Checked Out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.checkInOut_DGV.DataSource = this.booking.getBooking(Globals.GlobalUserId);
                ReviewForm frm = new ReviewForm(booking_id, Globals.GlobalUserId);
                frm.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message, "Error Check In Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

        }
    }
}
