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
    public partial class ManagerScheduleForm : Form
    {
        Setting setting = new Setting();
        Schedule schedule = new Schedule();
        DateTime date = DateTime.Today;
        Boolean isThisWeek = true;
        public ManagerScheduleForm()
        {
            InitializeComponent();
        }

        private void ManagerScheduleForm_Load(object sender, EventArgs e)
        {
            reloadShiftsForm();
        }
        void reloadShiftsForm()
        {
            this.ParentForm.Width = 1000;
            this.ParentForm.Height = 485;

            setting_DGV.ReadOnly = true;
            setting_DGV.AllowUserToAddRows = false;
            setting_DGV.Columns.Add("Shift Name", "Shift Name");
            setting_DGV.Columns.Add("Time Start", "Time Start");
            setting_DGV.Columns.Add("Time End", "Time End");
            setting_DGV.Columns[1].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns.Add("No.Manager", "No.Manager");
            setting_DGV.Columns.Add("No.Receptionist", "No.Receptionist");
            setting_DGV.Columns.Add("No.Janitor", "No.Janitor");
            if (setting_DGV.Rows.Count > 0)
            {
                setting_DGV_CellMouseClick(null, null);
            }

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                this.ParentForm.Width = 1160;
                this.ParentForm.Height = 585;
/*                this.Width = 925;
                this.Height = 525;*/
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
            else
            {
                this.ParentForm.Width = 1000;
                this.ParentForm.Height = 485;
                /*                this.Width = 770;
                                this.Height = 435;*/
            }
        }

        private void setting_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shiftName_TB.Text = setting_DGV.CurrentRow.Cells[0].Value.ToString();
            timeStart_TB.Text = setting_DGV.CurrentRow.Cells[1].FormattedValue.ToString();
            timeEnd_TB.Text = setting_DGV.CurrentRow.Cells[2].FormattedValue.ToString();
            manage_CBO.Text = setting_DGV.CurrentRow.Cells[3].Value.ToString();
            recept_CBO.Text = setting_DGV.CurrentRow.Cells[4].Value.ToString();
            janitor_CBO.Text = setting_DGV.CurrentRow.Cells[5].Value.ToString();
        }

        private void add_BT_Click(object sender, EventArgs e)
        {

            string[] row = { shiftName_TB.Text, timeStart_TB.Text, timeEnd_TB.Text, manage_CBO.Text, recept_CBO.Text, janitor_CBO.Text };
            if(validationEmpty(row))
            {
                row[1] = TimeSpan.Parse(timeStart_TB.Text).ToString("hh\\:mm");
                row[2] = TimeSpan.Parse(timeEnd_TB.Text).ToString("hh\\:mm");
                setting_DGV.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Please Enter Something To Empty TextBox", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void del_BT_Click(object sender, EventArgs e)
        {
            setting_DGV.Rows.RemoveAt(setting_DGV.CurrentRow.Index);
        }

        private void edit_BT_Click(object sender, EventArgs e)
        {
            if(setting_DGV.RowCount > 0)
            {
                DataGridViewRow row = setting_DGV.CurrentRow;
                row.Cells[0].Value = shiftName_TB.Text;
                row.Cells[1].Value = timeStart_TB.Text;
                row.Cells[2].Value = timeEnd_TB.Text;
                row.Cells[3].Value = manage_CBO.Text;
                row.Cells[4].Value = recept_CBO.Text;
                row.Cells[5].Value = janitor_CBO.Text;
            }
            else
            {
                MessageBox.Show("Add To Table Before Edit", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool validationEmpty(string[] row)
        {
            if (row[0].Trim() == string.Empty ||
                row[1].Trim() == string.Empty ||
                row[2].Trim() == string.Empty ||
                row[3].Trim() == string.Empty ||
                row[4].Trim() == string.Empty ||
                row[5].Trim() == string.Empty)
                return false;
            return true;
        }
        private void applySetting_BT_Click(object sender, EventArgs e)
        {
            int set_num = setting.numOfSetting() + 1;
            foreach (DataGridViewRow row in setting_DGV.Rows)
            {
                if (!row.IsNewRow)
                {
                    string name = row.Cells[0].Value.ToString();
                    TimeSpan time_start = TimeSpan.Parse(row.Cells[1].Value.ToString());
                    TimeSpan time_end = TimeSpan.Parse(row.Cells[2].Value.ToString());
                    int no_manager = Convert.ToInt32(row.Cells[3].Value.ToString());
                    int no_recept = Convert.ToInt32(row.Cells[4].Value.ToString());
                    int no_janitor = Convert.ToInt32(row.Cells[5].Value.ToString());
                    try
                    {
                        setting.addShift(set_num, name, time_start, time_end, no_manager, no_recept, no_janitor);
                    }
                    catch(SqlException ex)
                    {
                        if(ex.Errors[0].Class == 16)
                        {
                           MessageBox.Show(ex.Message, "Error Add Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           return;
                        }
                    }
                }
            }
            MessageBox.Show("Added Setting", "Add Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateSchedule_BT_Click(object sender, EventArgs e)
        {
            GenerateScheduleForm form = new GenerateScheduleForm();
            form.Show();
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
                if(isThisWeek == true)
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
