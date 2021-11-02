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
    public partial class GenerateScheduleForm : Form
    {
        public GenerateScheduleForm()
        {
            InitializeComponent();
        }
        Setting setting = new Setting();
        Employee emp = new Employee();
        Schedule schedule = new Schedule();
        private void GenerateScheduleForm_Load(object sender, EventArgs e)
        {
            this.Width = 870;
            this.Height = 440;
            setting_DGV.ReadOnly = true;
            setting_DGV.AllowUserToAddRows = false;


            settingID_CBO.DataSource = setting.getAllSettingId();
            settingID_CBO.DisplayMember = "set_id";
            settingID_CBO.ValueMember = "set_id";
            datestart_DTP.Format = DateTimePickerFormat.Custom;
            datestart_DTP.CustomFormat = "dd/MM/yyyy";
            dateend_DTP.Format = DateTimePickerFormat.Custom;
            dateend_DTP.CustomFormat = "dd/MM/yyyy";
            int set_id = Convert.ToInt32(settingID_CBO.SelectedValue);
            setting_DGV.DataSource = setting.getInfoSetById(set_id, -1);
            setting_DGV.Columns[0].HeaderText = "Shift Name";
            setting_DGV.Columns[1].HeaderText = "Time Start";
            setting_DGV.Columns[2].HeaderText = "Time End";
            setting_DGV.Columns[1].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[3].HeaderText = "No.Manager";
            setting_DGV.Columns[4].HeaderText = "No.Receptionist";
            setting_DGV.Columns[5].HeaderText = "No.Janitor";
            automaticShiftReload(set_id);
        }

        private void settingID_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)settingID_CBO.SelectedItem;
            int set_id = Convert.ToInt32(dr.Row[0].ToString());
            setting_DGV.DataSource = setting.getInfoSetById(set_id, -1);
            automaticShiftReload(set_id);
        }
        void automaticShiftReload(int set_id)
        {
            // ***This code below for Manage Shifts TabPage***
            DataTable shift_result = new DataTable();
            int num_set_use_generate = schedule.getNumScheduleGenBySet(set_id);
            int idx_start_mng = -1 + num_set_use_generate;
            int idx_start_recept = -1 + num_set_use_generate;
            int idx_start_janitor = -1 + num_set_use_generate;
            // Số ca làm
            int no_shift = setting.getShiftNumWithSetNum(set_id);
            // Lấy ra slnv là Manager, Receptionist, Janitor

            int no_manager = emp.countEmployeesByTitle("Manager");

            int no_recept = emp.countEmployeesByTitle("Receptionist");

            int no_janitor = emp.countEmployeesByTitle("Janitor");

            for (int shift_id = 1; shift_id <= no_shift; shift_id++)
            {
                idx_start_mng = (idx_start_mng + 1) % (no_manager);
                idx_start_recept = (idx_start_recept + 1) % (no_recept);
                idx_start_janitor = (idx_start_janitor + 1) % (no_janitor);
                shift_result.Merge(scheduleByShift(set_id, shift_id, no_manager, no_recept, no_janitor, idx_start_mng, idx_start_recept, idx_start_janitor));
            }

            automaticShift_DGV.DataSource = shift_result;


            automaticShift_DGV.ReadOnly = true;
            automaticShift_DGV.AllowUserToAddRows = false;
        }
        private DataTable scheduleByShift(int set_id, int shift_id, int no_manager, int no_recept, int no_janitor, int idx_start_mng, int idx_start_recept, int idx_start_janitor)
        {
            DataTable dt = setting.getInfoSetById(set_id, shift_id);
            string shift_name = Convert.ToString(dt.Rows[0]["shift_name"]);
            int no_manager_need = Convert.ToInt32(dt.Rows[0]["no_manager"]);

            int no_recept_need = Convert.ToInt32(dt.Rows[0]["no_receptionist"]);
            int no_janitor_need = Convert.ToInt32(dt.Rows[0]["no_janitor"]);
            dt = new DataTable();
            // Xếp lịch cho manager, receptionist, janitor
            dt.Merge(setting.automaticShift("Manager", no_manager_need, no_manager, shift_name, idx_start_mng));
            dt.Merge(setting.automaticShift("Receptionist", no_recept_need, no_recept, shift_name, idx_start_recept));
            dt.Merge(setting.automaticShift("Janitor", no_janitor_need, no_janitor, shift_name, idx_start_janitor));
            return dt;
        }

        private void addSchedule_BT_Click(object sender, EventArgs e)
        {
            DateTime dstart = new DateTime(datestart_DTP.Value.Year, datestart_DTP.Value.Month, datestart_DTP.Value.Day, 0, 0, 0);
            DateTime dend = new DateTime(dateend_DTP.Value.Year, dateend_DTP.Value.Month, dateend_DTP.Value.Day, 23, 59, 59);
            /*if (dstart >= dend)
            {
                MessageBox.Show("Cannot Generate Schedule With Date Start Higher Than Date End! PLease Try Again.", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dstart.DayOfWeek.ToString() != "Monday")
            {
                MessageBox.Show("Date Start Must Be Monday", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dend.DayOfWeek.ToString() != "Sunday")
            {
                MessageBox.Show("Date End Must Be Monday", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!schedule.isExist(dstart, dend))
                {
                    int schedule_id = schedule.numOfSchedule() + 1;
                    int shift_id = 1;

                    for (int i = 0; i < automaticShift_DGV.Rows.Count; i++)
                    {
                        if ((i + 1) % emp.numOfEmployees() == 0)
                            shift_id += 1;
                        int emp_id = Convert.ToInt32(automaticShift_DGV.Rows[i].Cells["Employee ID"].Value);
                        string Monday = automaticShift_DGV.Rows[i].Cells["Monday"].Value.ToString();
                        string Tuesday = automaticShift_DGV.Rows[i].Cells["Tuesday"].Value.ToString();
                        string Wednesday = automaticShift_DGV.Rows[i].Cells["Wednesday"].Value.ToString();
                        string Thursday = automaticShift_DGV.Rows[i].Cells["Thursday"].Value.ToString();
                        string Friday = automaticShift_DGV.Rows[i].Cells["Friday"].Value.ToString();
                        string Saturday = automaticShift_DGV.Rows[i].Cells["Saturday"].Value.ToString();
                        string Sunday = automaticShift_DGV.Rows[i].Cells["Sunday"].Value.ToString();
                        DataRowView dr = (DataRowView)settingID_CBO.SelectedItem;
                        int set_id = Convert.ToInt32(dr.Row[0].ToString());
                        schedule.addSchedule(schedule_id, set_id, emp_id, dstart, dend,
                                            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday);
                    }
                    MessageBox.Show("Generate Schedule Has Been Succeed.", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Schedule Conflicted With Exist Schedule! Please Try Again.", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            int schedule_id = schedule.numOfSchedule() + 1;
            int shift_id = 1;
            try
            {
                for (int i = 0; i < automaticShift_DGV.Rows.Count; i++)
                {
                    if ((i + 1) % emp.numOfEmployees() == 0)
                        shift_id += 1;
                    int emp_id = Convert.ToInt32(automaticShift_DGV.Rows[i].Cells["Employee ID"].Value);
                    string Monday = automaticShift_DGV.Rows[i].Cells["Monday"].Value.ToString();
                    string Tuesday = automaticShift_DGV.Rows[i].Cells["Tuesday"].Value.ToString();
                    string Wednesday = automaticShift_DGV.Rows[i].Cells["Wednesday"].Value.ToString();
                    string Thursday = automaticShift_DGV.Rows[i].Cells["Thursday"].Value.ToString();
                    string Friday = automaticShift_DGV.Rows[i].Cells["Friday"].Value.ToString();
                    string Saturday = automaticShift_DGV.Rows[i].Cells["Saturday"].Value.ToString();
                    string Sunday = automaticShift_DGV.Rows[i].Cells["Sunday"].Value.ToString();
                    DataRowView dr = (DataRowView)settingID_CBO.SelectedItem;
                    int set_id = Convert.ToInt32(dr.Row[0].ToString());
                    schedule.addSchedule(schedule_id, set_id, emp_id, dstart, dend,
                                        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday);
                }
                MessageBox.Show("Generate Schedule Has Been Succeed.", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                {
                    MessageBox.Show(ex.Message, "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
