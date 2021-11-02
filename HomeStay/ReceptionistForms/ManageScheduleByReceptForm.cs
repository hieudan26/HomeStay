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

namespace HomeStay.ReceptionistForms
{
    public partial class ManageScheduleByReceptForm : Form
    {
        Schedule schedule = new Schedule();
        DateTime date = DateTime.Today;
        Boolean isThisWeek = true;
        public ManageScheduleByReceptForm()
        {
            InitializeComponent();
        }

        private void ManageScheduleByReceptForm_Load(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1140;
            this.ParentForm.Height = 545;

            schedule_DGV.DataSource = schedule.getTimeSchedule(date);
            schedule_DGV.Columns[0].HeaderText = "Date Start";
            schedule_DGV.Columns[1].HeaderText = "Date End";
            schedule_DGV.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            schedule_DGV.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            schedule_DGV.ReadOnly = true;
            schedule_DGV.AllowUserToAddRows = false;



            if (schedule_DGV.Rows.Count > 0)
            {
                todaySchedules_DGV.ReadOnly = true;
                todaySchedules_DGV.AllowUserToAddRows = false;
                string dayName = Convert.ToString(date.DayOfWeek);
                todaySchedules_DGV.DataSource = schedule.getScheduleInfoToday(date, dayName);
                todaySchedules_DGV.Columns[0].HeaderText = "Employee ID";
                todaySchedules_DGV.Columns[1].HeaderText = "First Name";
                todaySchedules_DGV.Columns[2].HeaderText = "Last Name";
                todaySchedules_DGV.Columns[3].HeaderText = "Title";
                todaySchedules_DGV.Columns[4].HeaderText = dayName;

                schedules_DGV.ReadOnly = true;
                schedules_DGV.AllowUserToAddRows = false;
                schedules_DGV.DataSource = schedule.getScheduleInfoByDate(date);
                schedules_DGV.Columns[0].HeaderText = "Employee ID";
                schedules_DGV.Columns[1].HeaderText = "First Name";
                schedules_DGV.Columns[2].HeaderText = "Last Name";
                schedules_DGV.Columns[3].HeaderText = "Title";
                schedules_DGV.Columns[4].HeaderText = "Monday";
                schedules_DGV.Columns[5].HeaderText = "Tuesday";
                schedules_DGV.Columns[6].HeaderText = "Wednesday";
                schedules_DGV.Columns[7].HeaderText = "Thursday";
                schedules_DGV.Columns[8].HeaderText = "Friday";
                schedules_DGV.Columns[9].HeaderText = "Saturday";
                schedules_DGV.Columns[10].HeaderText = "Sunday";
            }
            filter_CBO.SelectedIndex = 0;
        }

        private void thisWeek_BT_Click(object sender, EventArgs e)
        {
            isThisWeek = true;
            date = DateTime.Today;
            schedules_DGV.DataSource = schedule.getScheduleInfoByDate(date);
            schedule_DGV.DataSource = schedule.getTimeSchedule(date);
            search_TB_TextChanged(null, null);
        }

        private void lastWeek_BT_Click(object sender, EventArgs e)
        {
            isThisWeek = false;
            DateTime last7Days = date.AddDays(-7);
            schedules_DGV.DataSource = schedule.getScheduleInfoByDate(last7Days);
            schedule_DGV.DataSource = schedule.getTimeSchedule(last7Days);
            search_TB_TextChanged(null, null);
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TB_TextChanged(null, null);
        }

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colName;
                colName = filter_CBO.SelectedItem.ToString();

                if (colName == "Employee ID")
                    colName = "emp_id";
                else if (colName == "First Name" || colName == " ")
                    colName = "firstname";
                else if (colName == "Last Name")
                    colName = "lastname";
                else if (colName == "Title")
                    colName = "title";
                if (isThisWeek == true)
                {
                    schedules_DGV.DataSource = schedule.searchData(date, colName, search_TB.Text);
                }
                else
                {
                    DateTime last7Days = date.AddDays(-7);
                    schedules_DGV.DataSource = schedule.searchData(last7Days, colName, search_TB.Text);
                }
            }
            catch
            {
                MessageBox.Show("Choose Filter First", "Find Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
