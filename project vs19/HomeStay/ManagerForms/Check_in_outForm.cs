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

namespace HomeStay.ManagerForms
{
    public partial class Check_in_outForm : Form
    {
        private Schedule schedule = new Schedule();
        public Check_in_outForm()
        {
            InitializeComponent();
        }

        private void Check_in_outForm_Load(object sender, EventArgs e)
        {
            /*this.ParentForm.Width = 1050;
            this.ParentForm.Height = 560;
            DateTime tmp = this.dateTimePicker1.Value;

            this.shifts_DGV.DataSource = this.schedule.getScheduleByUserId(tmp, Globals.GlobalUserId);
            this.shifts_DGV.RowTemplate.Height = 50;
            this.shifts_DGV.ReadOnly = true;
            this.shifts_DGV.AllowUserToAddRows = false;


            DataTable tableSh = sch.getDateStartEnd(tmp);
            label1.Text = "Your Shift From " + Convert.ToDateTime(tableSh.Rows[0]["date_start"].ToString()).ToString("MM/dd/yyyy") + " To " + Convert.ToDateTime(tableSh.Rows[0]["date_end"].ToString()).ToString("MM/dd/yyyy");

            setting_DGV.DataSource = ck.getShiftTimeByUserId(DateTime.Now, Globals.GlobalUserId);
            setting_DGV.ReadOnly = true;
            setting_DGV.AllowUserToAddRows = false;
            setting_DGV.Columns[0].HeaderText = "Shift Name";
            setting_DGV.Columns[1].HeaderText = "Time Start";
            setting_DGV.Columns[2].HeaderText = "Time End";
            setting_DGV.Columns[1].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[3].HeaderText = "No.Manager";
            setting_DGV.Columns[4].HeaderText = "No.Receptionist";
            setting_DGV.Columns[5].HeaderText = "No.Janitor";

            checkInOut_DGV.RowTemplate.Height = 50;
            checkInOut_DGV.ReadOnly = true;
            checkInOut_DGV.AllowUserToAddRows = false;

            checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
            checkInOut_DGV.Columns[0].HeaderText = "Date";
            checkInOut_DGV.Columns[1].HeaderText = "Shift";
            checkInOut_DGV.Columns[2].HeaderText = "Time Start";
            checkInOut_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            checkInOut_DGV.Columns[3].DefaultCellStyle.Format = "hh\\:mm";
            checkInOut_DGV.Columns[3].HeaderText = "Time End";
            checkInOut_DGV.Columns[4].HeaderText = "Time In";
            checkInOut_DGV.Columns[5].HeaderText = "Time Out";*/
        }
    }
}
