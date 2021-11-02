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
    public partial class ManageRoomTypesForm : Form
    {
        public ManageRoomTypesForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ManageRoomTypesForm_Load(object sender, EventArgs e)
        {
            reloadManageRoomTypesForm();
        }
        void reloadManageRoomTypesForm()
        {
            roomType_DGV.DataSource = room.getAllRoomTypes();
            roomType_DGV.AllowUserToAddRows = false;
            roomType_DGV.ReadOnly = true;
            roomType_DGV.Columns[0].HeaderText = "Type ID";
            roomType_DGV.Columns[1].HeaderText = "Name";
            roomType_DGV.Columns[2].HeaderText = "Capacity";
            roomType_DGV.Columns[3].HeaderText = "Bed";
            roomType_DGV.Columns[4].HeaderText = "Price";
            if (roomType_DGV.Rows.Count > 0)
                roomType_DGV_CellMouseClick(null, null);
        }



        private void showRoom_BT_Click(object sender, EventArgs e)
        {
            ManageRoomsForm frm = new ManageRoomsForm();
            frm.TopLevel = false;

            panelMngRoom.Controls.Clear();
            panelMngRoom.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void roomType_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            roomType_TB.Text = roomType_DGV.CurrentRow.Cells[1].Value.ToString();
            capacity_CBO.Text = roomType_DGV.CurrentRow.Cells[2].Value.ToString();
            bed_CBO.Text = roomType_DGV.CurrentRow.Cells[3].Value.ToString();
            price_TB.Text = roomType_DGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void add_BT_Click(object sender, EventArgs e)
        {
            string roomType = roomType_TB.Text;
            int capacity = Convert.ToInt32(capacity_CBO.Text);
            int bed = Convert.ToInt32(bed_CBO.Text);
            int price = Convert.ToInt32(price_TB.Text);
            try
            {
                //MessageBox.Show(room.checkExistRoomType(roomType).ToString(), "Add Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    room.addRoomType(roomType, capacity, bed, price);
                    MessageBox.Show($"Room Type: {roomType} Has Been Added", "Add Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message, "Add Room Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                roomType_DGV.DataSource = room.getAllRoomTypes();
            }
        }

        private void del_BT_Click(object sender, EventArgs e)
        {
            string roomType = roomType_TB.Text;
            try
            {
                if (room.delRoomType(roomType))
                {
                    MessageBox.Show($"Room Type: {roomType} Has Been Deleted", "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Room Type: {roomType} Cannot Be Deleted", "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                roomType_DGV.DataSource = room.getAllRoomTypes();
            }
        }
    }
}
