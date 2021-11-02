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

namespace HomeStay.ManagerForms
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            reloadManageRoomsForm();
        }
        void reloadManageRoomsForm()
        {
            room_DGV.DataSource = room.getAllRooms();
            room_DGV.ReadOnly = true;
            room_DGV.AllowUserToAddRows = false;
            room_DGV.Columns[0].HeaderText = "Room ID";
            room_DGV.Columns[1].HeaderText = "Name";
            room_DGV.Columns[2].HeaderText = "Capacity";
            room_DGV.Columns[3].HeaderText = "Bed";
            room_DGV.Columns[4].HeaderText = "Price";
            room_DGV.Columns[5].HeaderText = "Room Status";
            room_DGV.Columns[6].HeaderText = "Clean Status";

            roomType_CBO.DataSource = room.getRoomType();
            roomType_CBO.DisplayMember = "type_name";
            roomType_CBO.ValueMember = "room_type_id";
        }

        private void roomType_CBO_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)roomType_CBO.SelectedItem;

            int room_type_id = Convert.ToInt32(drv.Row[1]);
            DataTable dt = room.getInfoRoomByType(room_type_id);
            capacity_TB.Text = dt.Rows[0]["room_capacity"].ToString();
            bed_TB.Text = dt.Rows[0]["room_bed"].ToString();
            price_TB.Text = dt.Rows[0]["room_price"].ToString();
        }

        private void room_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            roomType_CBO.Text = room_DGV.CurrentRow.Cells[1].Value.ToString();
        }

        private void add_BT_Click(object sender, EventArgs e)
        {
            int room_type_id = Convert.ToInt32(roomType_CBO.SelectedValue);
            room.insertRoom(room_type_id);
            room_DGV.DataSource = room.getAllRooms();
        }

        private void delete_BT_Click(object sender, EventArgs e)
        {
            int room_id = Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value);
            string status_name = Convert.ToString(room_DGV.CurrentRow.Cells[5].Value);
            try
            {
                    room.delRoom(room_id, status_name);
                    MessageBox.Show("Remove Room Successful", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message, "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                reloadManageRoomsForm();
            }
        }

        private void showRoomType_BT_Click(object sender, EventArgs e)
        {
            ManageRoomTypesForm frm = new ManageRoomTypesForm();
            frm.TopLevel = false;

            panelMngRoom.Controls.Clear();
            panelMngRoom.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
