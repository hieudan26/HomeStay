using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.CustomerForms
{
    public partial class BookRoomForm : Form
    {
        private Customer customer = new Customer();
        private Room room = new Room();
        private Booking booking = new Booking();
        private int room_type_id;

        public BookRoomForm()
        {
            InitializeComponent();
        }

        private void bookRoom_BT_Click(object sender, EventArgs e)
        {
            int room_id = int.Parse(roomID_TB.Text.Trim());

            //get price by type room
            decimal price = 0;
            try
            {
                MessageBox.Show("" + this.room_type_id);
                price = this.room.getPriceofRoom_byTypeId(this.room_type_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Warning: set cứng///////
            Globals.SetGlobalUserId(9179);
            //////////////////////////

            if (this.booking.createBooking(Globals.GlobalUserId, room_id, this.booking_DTP.Value, this.return_DTP.Value, price))
            {

                this.room.updateStatus(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value), true);
                this.reloadDGV();
                this.roomID_TB.Text = "";
                MessageBox.Show("Successful", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail To Book", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            this.booking_DTP.Format = DateTimePickerFormat.Custom;
            this.booking_DTP.CustomFormat = "dd/MM/yyyy";
            this.return_DTP.Format = DateTimePickerFormat.Custom;
            this.return_DTP.CustomFormat = "dd/MM/yyyy";

            //Warning: set cứng///////
            Globals.SetGlobalUserId(9179);
            //////////////////////////

            DataTable dt = this.customer.getInfoCustomers(Globals.GlobalUserId);
            try
            {
                this.customerID_TB.Text = dt.Rows[0][0].ToString().Trim();
                this.fnameT2_TB.Text = dt.Rows[0][1].ToString().Trim();
                this.lnameT2_TB.Text = dt.Rows[0][2].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //catch error photo null
            try
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                this.photoT2_PB.Image = Image.FromStream(picture);
            }
            catch (Exception)
            {
                MessageBox.Show("Please update your photo and comeback later", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.reloadDGV();
        }

        private void reloadDGV()
        {
            this.room_DGV.DataSource = this.room.getAllRooms();
            this.room_DGV.ReadOnly = true;
            this.room_DGV.AllowUserToAddRows = false;
            this.room_DGV.Columns[0].HeaderText = "Room ID";
            this.room_DGV.Columns[1].HeaderText = "Name";
            this.room_DGV.Columns[2].HeaderText = "Capacity";
            this.room_DGV.Columns[3].HeaderText = "Bed";
            this.room_DGV.Columns[4].HeaderText = "Price";
            this.room_DGV.Columns[5].HeaderText = "Status";

            this.roomType_CBO.DataSource = this.room.getRoomType();
            this.roomType_CBO.DisplayMember = "type_name";
            this.roomType_CBO.ValueMember = "room_type_id";
        }

        private void roomType_CBO_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.roomType_CBO.SelectedItem;

            this.room_type_id = Convert.ToInt32(drv.Row[1].ToString().Trim());
            this.room_DGV.DataSource = this.room.getAllRoomsByType(room_type_id);
        }

        private void room_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (room_DGV.CurrentRow.Cells[5].Value.ToString().Trim() == "Full")
            {
                MessageBox.Show("This Room Was Booked By Some One Else. Please Choose Another Room That Empty", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.roomID_TB.Text = "";
                return;
            }
            else
                this.roomID_TB.Text = this.room_DGV.CurrentRow.Cells[0].Value.ToString().Trim();
        }
    }
}
