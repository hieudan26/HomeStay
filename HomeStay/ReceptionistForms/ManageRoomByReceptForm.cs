using HomeStay.Class;
using HomeStay.CustomerForms;
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

namespace HomeStay.ReceptionistForms
{
    public partial class ManageRoomByReceptForm : Form
    {
        public ManageRoomByReceptForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Employee emp = new Employee();

        private void ManageRoomByReceptForm_Load(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1120;
            this.ParentForm.Height = 460;
            reloadManageRoomsForm();

        }
        void reloadManageRoomsForm()
        {
            getJanitorWorking();

            roomDirty_DGV.DataSource = room.getDirtyRoom();
            roomDirty_DGV.ReadOnly = true;
            roomDirty_DGV.AllowUserToAddRows = false;
            roomDirty_DGV.Columns[0].HeaderText = "Room ID";
            roomDirty_DGV.Columns[1].HeaderText = "Room Type";

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
            //room_DGV.Columns[6].HeaderText = "Clean/Dirty";

        }
        private void getJanitorWorking()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy/MM/dd");
            string time = now.ToString("HH:mm:ss");
            string dname = now.ToString("dddd"); 

            SqlCommand com = new SqlCommand("SELECT * FROM func_getJanitorWorking()");
            janitor_CBO.DataSource = emp.getEmployees(com);
            janitor_CBO.DisplayMember = "firstname";
            janitor_CBO.ValueMember = "emp_id";

        }

        private void room_DGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(room_DGV.CurrentRow.Cells[5].Value.ToString() == "Empty")
            {
                MessageBox.Show("This Room Dont' Have Guest.", "Check Info Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Globals.SetGlobalRoomId(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value));
                CustomerInfoForm frm = new CustomerInfoForm(Globals.GlobalRoomId);
                frm.Show();
            }
        }

        private void clean_BT_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)janitor_CBO.SelectedItem;
            int emp_id = Convert.ToInt32(drv.Row[0].ToString());
            int room_id = Convert.ToInt32(roomDirty_DGV.CurrentRow.Cells[0].Value.ToString());
            String action = "set";
            try
            {
                room.setJanitorCleanRoom(action, emp_id, room_id);
                roomDirty_DGV.DataSource = room.getDirtyRoom();
                getJanitorWorking();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
