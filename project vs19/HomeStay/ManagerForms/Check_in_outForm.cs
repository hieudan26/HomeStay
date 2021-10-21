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
    public partial class Check_in_outForm : Form
    {
        private Schedule schedule = new Schedule();
        private Check_in_out cio = new Check_in_out();

        public Check_in_outForm()
        {
            InitializeComponent();
        }

        private void Check_in_outForm_Load(object sender, EventArgs e)
        {
            try
            {
                ///////////
                ///
                ///
                Globals.SetGlobalUserId(1390);

                /*this.ParentForm.Width = 1050;
                this.ParentForm.Height = 560;*/
                DateTime tmp = this.dateTimePicker1.Value;

                this.shifts_DGV.DataSource = this.schedule.getScheduleByUserId(tmp, Globals.GlobalUserId);
                this.shifts_DGV.RowTemplate.Height = 50;
                this.shifts_DGV.ReadOnly = true;
                this.shifts_DGV.AllowUserToAddRows = false;


                DataTable tableSh = this.schedule.getDateStartEnd(tmp);
                this.label1.Text = "Your Shift From " + Convert.ToDateTime(tableSh.Rows[0]["date_start"].ToString()).ToString("MM/dd/yyyy")
                    + " To " + Convert.ToDateTime(tableSh.Rows[0]["date_end"].ToString()).ToString("MM/dd/yyyy");

                this.setting_DGV.DataSource = this.schedule.getShiftTimeByUserId(DateTime.Now, Globals.GlobalUserId);
                this.setting_DGV.ReadOnly = true;
                this.setting_DGV.AllowUserToAddRows = false;
                this.setting_DGV.Columns[0].HeaderText = "Shift Name";
                this.setting_DGV.Columns[1].HeaderText = "Time Start";
                this.setting_DGV.Columns[2].HeaderText = "Time End";
                this.setting_DGV.Columns[1].DefaultCellStyle.Format = "hh\\:mm";
                this.setting_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
                this.setting_DGV.Columns[3].HeaderText = "No.Manager";
                this.setting_DGV.Columns[4].HeaderText = "No.Receptionist";
                this.setting_DGV.Columns[5].HeaderText = "No.Janitor";

                this.checkInOut_DGV.RowTemplate.Height = 50;
                this.checkInOut_DGV.ReadOnly = true;
                this.checkInOut_DGV.AllowUserToAddRows = false;

                this.checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                this.checkInOut_DGV.Columns[0].HeaderText = "Date";
                this.checkInOut_DGV.Columns[1].HeaderText = "Shift";
                this.checkInOut_DGV.Columns[2].HeaderText = "Time Start";
                this.checkInOut_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
                this.checkInOut_DGV.Columns[3].DefaultCellStyle.Format = "hh\\:mm";
                this.checkInOut_DGV.Columns[3].HeaderText = "Time End";
                this.checkInOut_DGV.Columns[4].HeaderText = "Time In";
                this.checkInOut_DGV.Columns[5].HeaderText = "Time Out";
                this.checkInOut_DGV.Columns[6].HeaderText = "Time Worked";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check_in_outForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Tuple<int, TimeSpan> getShiftName(TimeSpan time_late, TimeSpan time)
        {
            int idx = -1;
            TimeSpan minus = new TimeSpan();
            foreach (DataGridViewRow row in this.setting_DGV.Rows)
            {
                TimeSpan time_start = (TimeSpan)(row.Cells["time_start"].Value);
                TimeSpan time_end = (TimeSpan)(row.Cells["time_end"].Value);
                int temp = TimeSpan.Compare(time.Subtract(time_start), time_late);
                if (time <= time_start || TimeSpan.Compare(time.Subtract(time_start), time_late) == -1)
                {
                    idx = row.Index;
                    minus = time_start.Subtract(time);
                    return Tuple.Create(idx, minus);
                }
            }
            return Tuple.Create(idx, minus);
        }

        private void checkIn_BT_Click(object sender, EventArgs e)
        {
            var time_late_max = new TimeSpan(4, 0, 0);
            var dateAndTime = DateTime.Now;
            var date_name = dateAndTime.ToString("dddd");
            var time_now = TimeSpan.Parse((dateAndTime.ToString("HH:mm:ss")));
            var shiftNameIdx = getShiftName(time_late_max, time_now);
            if (shiftNameIdx.Item1 != -1)
            {
                int temp = TimeSpan.Compare(shiftNameIdx.Item2, new TimeSpan(0, 0, 0));
                MessageBox.Show("" + shiftNameIdx.Item1);
                var shiftName = setting_DGV.Rows[shiftNameIdx.Item1].Cells["shift_name"].Value.ToString();
                TimeSpan time_start = TimeSpan.Parse(setting_DGV.Rows[shiftNameIdx.Item1].Cells["time_start"].Value.ToString());
                TimeSpan time_end = TimeSpan.Parse(setting_DGV.Rows[shiftNameIdx.Item1].Cells["time_end"].Value.ToString());
                if (this.cio.isCheckedin(Globals.GlobalUserId, dateAndTime.Date, shiftName))
                {
                    MessageBox.Show("You Checked In Already", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        if (this.cio.insertCheckInData(Globals.GlobalUserId, dateAndTime.Date, shiftName, time_start, time_end, time_now))
                        {
                            MessageBox.Show("Check In Successful.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Check In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("You don't have shift today. Please comback later", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkOut_BT_Click(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var time_now = TimeSpan.Parse((dateAndTime.ToString("HH:mm:ss")));
            DataTable dt = this.cio.getDataCheckInCheckOutWith(Globals.GlobalUserId, dateAndTime.Date);
            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["time_out"] == DBNull.Value)
                    {
                        if (TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_start"].ToString())) <= 0)
                        {
                            try
                            {
                                var temp = new TimeSpan(0, 0, 0);
                                TimeSpan twork = new TimeSpan(time_now.Hours - TimeSpan.Parse(row["time_start"].ToString()).Hours, 0, 0);
                                if (TimeSpan.Compare(twork, temp) >= 0)
                                {
                                    this.cio.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork);
                                }
                                else
                                {
                                    //ko bắt đc trigger @@
                                    MessageBox.Show("You cannot check out before the time your shift start.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }    
                            }
                            catch (SqlException ex)
                            { 
                                MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            //MessageBox.Show("You cannot check out before the time your shift start.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                            return;
                        }
                        if (TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_end"].ToString())) < 0)
                        {
                            if (MessageBox.Show("Too Soon To Check Out. Are You Still Want To Check Out?.", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                try
                                {
                                    TimeSpan twork = new TimeSpan(time_now.Hours - TimeSpan.Parse(row["time_start"].ToString()).Hours, 0, 0);
                                    if (this.cio.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork))
                                    {
                                        checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                                        return;
                                    }
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                TimeSpan twork = TimeSpan.Parse(row["time_end"].ToString()).Subtract(TimeSpan.Parse(row["time_start"].ToString()));
                                if (this.cio.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork))
                                {
                                    checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                                    MessageBox.Show("Check Out Successful.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }    
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        if (dt.Rows.IndexOf(row) == dt.Rows.Count - 1)
                            MessageBox.Show("You Were Checked Out Before.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
            }
            else
            {
                TimeSpan t = new TimeSpan(12, 0, 0);
                dateAndTime = dateAndTime.AddDays(-1);

                dt = this.cio.getDataCheckInCheckOutWith(Globals.GlobalUserId, dateAndTime.Date);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (TimeSpan.Parse(row["time_start"].ToString()) >= t && TimeSpan.Parse(row["time_end"].ToString()) <= t)
                        {
                            if (row["time_out"] == DBNull.Value)
                            {
                                if (TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_end"].ToString())) < 0)
                                {
                                    if (MessageBox.Show("Too Soon To Check Out. Are You Still Want To Check Out?.", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            TimeSpan twork = new TimeSpan(time_now.Hours + (24 - TimeSpan.Parse(row["time_start"].ToString()).Hours), 0, 0);
                                            if (this.cio.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork))
                                            {
                                                checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                                            }    
                                            return;
                                        }
                                        catch (SqlException ex)
                                        {
                                            MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        TimeSpan twork = new TimeSpan(TimeSpan.Parse(row["time_end"].ToString()).Hours + (24 - TimeSpan.Parse(row["time_start"].ToString()).Hours), 0, 0);
                                        if (this.cio.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork))
                                        {
                                            checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                                            MessageBox.Show("Check Out Successful.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                if (dt.Rows.IndexOf(row) == dt.Rows.Count - 1)
                                    MessageBox.Show("You Were Checked Out Before.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        checkInOut_DGV.DataSource = this.cio.getDataCheckInCheckOut(Globals.GlobalUserId);
                    }
                }
                else
                {
                    MessageBox.Show("You have to checkin first.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }
    }
}
