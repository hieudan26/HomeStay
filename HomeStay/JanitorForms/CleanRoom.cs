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

namespace HomeStay.JanitorForms
{
    public partial class CleanRoom : Form
    {
        Room room = new Room();
        public CleanRoom()
        {
            InitializeComponent();
        }

        private void CleanRoom_Load(object sender, EventArgs e)
        {

            roomDirty_DGV.DataSource = room.getDirtyRoomInfoWithJanitorID(Globals.GlobalUserId);
            roomDirty_DGV.ReadOnly = true;
            roomDirty_DGV.AllowUserToAddRows = false;
            roomDirty_DGV.Columns[0].HeaderText = "Room ID";
            roomDirty_DGV.Columns[1].HeaderText = "Room Type";
            roomDirty_DGV.Columns[2].HeaderText = "Room Capacity";
            roomDirty_DGV.Columns[3].HeaderText = "Room Bed";
        }

        private void cleanRoom_BT_Click(object sender, EventArgs e)
        {
            try
            {
                String action = "del";
                int room_id = Convert.ToInt32(roomDirty_DGV.CurrentRow.Cells[0].Value.ToString());

                room.setJanitorCleanRoom(action, Globals.GlobalUserId, room_id);
                room.updateStatus(room_id, false, false);
                roomDirty_DGV.DataSource = room.getDirtyRoomInfoWithJanitorID(Globals.GlobalUserId);
                MessageBox.Show("Accept Room To Clean Successful", "Clean Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
