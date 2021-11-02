using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private DataTable dt;
        public BookRoomForm()
        {
            InitializeComponent();
        }

        private void bookRoom_BT_Click(object sender, EventArgs e)
        {
                int room_id;
                decimal price;
                if (roomID_TB.Text != "")
                {
                    room_id = int.Parse(this.roomID_TB.Text.Trim());
                    price = Decimal.Parse(room_DGV.CurrentRow.Cells[4].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Missing Fields OR You Need To Choose Room To Booking. Cannot Booking, Please Try Again", "Book Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            try
            {
                if (this.booking.createBooking(Globals.GlobalUserId, room_id, this.booking_DTP.Value, this.return_DTP.Value, price))
                {

                    this.room.updateStatus(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value), true, false);
                    this.reloadDGV();
                    this.roomID_TB.Text = "";
                    MessageBox.Show("Booking Successful", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fail to book", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Book Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
/*            }    
            else
            {
                MessageBox.Show("Choose room which you want to book", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            this.booking_DTP.Format = DateTimePickerFormat.Custom;
            this.booking_DTP.CustomFormat = "dd/MM/yyyy";
            this.return_DTP.Format = DateTimePickerFormat.Custom;
            this.return_DTP.CustomFormat = "dd/MM/yyyy";

            dt = GuestForm.dt;
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
            if(!Convert.IsDBNull(dt.Rows[0][3]))
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                this.photoT2_PB.Image = Image.FromStream(picture);
            }
            else
            {
                this.photoT2_PB.Image = null;
            }
            this.reloadDGV();
        }
        private void reloadDGV()
        {
/*            this.roomType_CBO.DataSource = this.room.getRoomType();
            this.roomType_CBO.DisplayMember = "type_name";
            this.roomType_CBO.ValueMember = "room_type_id";*/

            this.room_DGV.DataSource = this.room.getAllRoomsForBooking();
            this.room_DGV.ReadOnly = true;
            this.room_DGV.AllowUserToAddRows = false;
            this.room_DGV.Columns[0].HeaderText = "Room ID";
            this.room_DGV.Columns[1].HeaderText = "Name";
            this.room_DGV.Columns[2].HeaderText = "Capacity";
            this.room_DGV.Columns[3].HeaderText = "Bed";
            this.room_DGV.Columns[4].HeaderText = "Price";
            this.room_DGV.Columns[5].HeaderText = "Status";
        }

/*        private void roomType_CBO_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.roomType_CBO.SelectedItem;

            string type_name = drv.Row[0].ToString().Trim();
            this.room_DGV.DataSource = this.room.getAllRoomsByType(type_name);
        }*/

        private void room_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.room_DGV.CurrentRow.Cells[5].Value.ToString().Trim() == "Full")
            {
                MessageBox.Show("This Room Was Booked By Some One Else. Please Choose Another Room That Empty", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.roomID_TB.Text = "";
                return;
            }
            else
            {
                this.roomID_TB.Text = this.room_DGV.CurrentRow.Cells[0].Value.ToString().Trim();
                this.roomType_TB.Text = this.room_DGV.CurrentRow.Cells[1].Value.ToString().Trim();
            }
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.search_TB_TextChanged(null, null);
        }

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            string colName = filter_CBO.SelectedItem.ToString();
            if (colName == "Room ID")
                colName = "room_id";
            else if (colName == "Name")
                colName = "type_name";
            else if (colName == "Capacity")
                colName = "room_capacity";
            else if (colName == "Bed")
                colName = "room_bed";
            else if (colName == "Price")
                colName = "room_price";
            else if (colName == "Status")
                colName = "room_status";
            this.searchData(colName, this.search_TB.Text.Trim());
        }

        private void searchData(string colName, string valueToFind)
        {
            this.room_DGV.DataSource = this.room.searchData(colName, valueToFind);
        }

/*        private void room_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(room_DGV.CurrentRow.Cells[5].Value.ToString() == "Full")
            {
                int room_id = int.Parse(this.room_DGV.CurrentRow.Cells[0].Value.ToString().Trim());
                CustomerInfoForm frm = new CustomerInfoForm(room_id);
                frm.Show();
            }
        }*/
    }
}
