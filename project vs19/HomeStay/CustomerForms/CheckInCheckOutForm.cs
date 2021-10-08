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
            //Warning: set cứng///////
            Globals.SetGlobalUserId(9179);
            //////////////////////////
            ///
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
            try
            {
                string now = DateTime.Now.ToString("MM/dd/yyyy").Trim();
                int booking_id = int.Parse(this.checkInOut_DGV.Rows[0].Cells[0].Value.ToString().Trim());
                try
                {
                    this.booking.insertCheckInData(booking_id, DateTime.Parse(now));
                    MessageBox.Show("Checked In!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.checkInOut_DGV.DataSource = this.booking.getBooking(Globals.GlobalUserId);
                }
                catch
                {
                    MessageBox.Show("Cannot Check In!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void checkOut_BT_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkInOut_DGV.Rows[0].Cells[4].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("You Need To Check In First!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int booking_id = int.Parse(this.checkInOut_DGV.Rows[0].Cells[0].Value.ToString().Trim());
                    DateTime now = DateTime.Now;
                    if (now.ToString("MM/dd/yyyy").CompareTo(DateTime.Parse(this.checkInOut_DGV.Rows[0].Cells[3].Value.ToString().Trim()).ToString("MM/dd/yyyy")) <= 0)
                    {
                        //update trạng thái check out
                        this.booking.insertCheckOutData(booking_id, DateTime.Parse(now.ToString("MM/dd/yyyy")));
                        //Can phai kiem tra lai dong tostring trim
                        this.room.updateStatus(Convert.ToInt32(this.checkInOut_DGV.CurrentRow.Cells[1].Value.ToString().Trim()), false);
                        //room.updateRoomStatus(Convert.ToInt32(checkInOut_DGV.CurrentRow.Cells[1].Value), true);
                        MessageBox.Show("Checked Out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You late! Check out now bitch", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //update trạng thái check out
                        this.booking.insertCheckOutData(booking_id, DateTime.Parse(now.ToString("MM/dd/yyyy")));
                        //update phí ngoài giờ
                        TimeSpan timeSpan = now - DateTime.Parse(this.checkInOut_DGV.Rows[0].Cells[3].Value.ToString().Trim());
                        int room_id = int.Parse(this.checkInOut_DGV.CurrentRow.Cells[1].Value.ToString().Trim());
                        int room_type_id = this.room.getRoomtype_byRoomID(room_id);
                        decimal room_price = this.room.getPriceofRoom_byTypeId(room_type_id);
                        decimal overdue_fee = (decimal.Parse(Math.Round(timeSpan.TotalHours).ToString()) * 2 * room_price) / 100;
                        this.booking.updateOverdue_fee(booking_id, overdue_fee);
                        //
                        this.room.updateStatus(Convert.ToInt32(this.checkInOut_DGV.CurrentRow.Cells[1].Value.ToString().Trim()), false);
                        //double temp = timeSpan.TotalHours;
                        //MessageBox.Show(" " + Math.Round(temp));
                        //update thành tiền
                        this.booking.updateAmount(booking_id, overdue_fee);

                    }
                    this.checkInOut_DGV.DataSource = this.booking.getBooking(Globals.GlobalUserId);
                }
            }
            catch { }
        }
    }
}
