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
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient;

namespace HomeStay.ManagerForms
{
    public partial class ManageReportForm : Form
    {
        Booking booking = new Booking();
        CheckInOut ck = new CheckInOut();
        public ManageReportForm()
        {
            InitializeComponent();
        }

        private void ManageReportForm_Load(object sender, EventArgs e)
        {
            dateStart_DTP.Format = DateTimePickerFormat.Custom;
            dateStart_DTP.CustomFormat = "dd/MM/yyyy";
            dateEnd_DTP.Format = DateTimePickerFormat.Custom;
            dateEnd_DTP.CustomFormat = "dd/MM/yyyy";
            dateStartPage2_DTP.Format = DateTimePickerFormat.Custom;
            dateStartPage2_DTP.CustomFormat = "dd/MM/yyyy";
            dateEndPage2_DTP.Format = DateTimePickerFormat.Custom;
            dateEndPage2_DTP.CustomFormat = "dd/MM/yyyy";

            booking_DGV.ReadOnly = true;
            booking_DGV.AllowUserToAddRows = false;

            DateTime dstart = DateTime.Parse(DateTime.Parse(dateStart_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            DateTime dend = DateTime.Parse(DateTime.Parse(dateEnd_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            try
            {
                DataTable dt = booking.getBookingHistory(dstart, dend);
                booking_DGV.DataSource = dt;

                this.booking_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                this.booking_DGV.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
                this.booking_DGV.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
                this.booking_DGV.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
                this.booking_DGV.Columns[0].HeaderText = "Booking ID";
                this.booking_DGV.Columns[1].HeaderText = "First Name";
                this.booking_DGV.Columns[2].HeaderText = "Last Name";
                this.booking_DGV.Columns[3].HeaderText = "Room ID";
                this.booking_DGV.Columns[4].HeaderText = "Room Type";
                this.booking_DGV.Columns[5].HeaderText = "Date In Book";
                this.booking_DGV.Columns[6].HeaderText = "Date Out Book";
                this.booking_DGV.Columns[7].HeaderText = "Check In";
                this.booking_DGV.Columns[8].HeaderText = "Check Out";
                this.booking_DGV.Columns[9].HeaderText = "Amount";
                int sum_pay = 0;
                for (int i = 0; i < this.booking_DGV.Rows.Count - 1; i++)
                {
                    sum_pay += int.Parse(this.booking_DGV.Rows[i].Cells[9].Value.ToString());
                }
            }
            catch(SqlException ex)
            {
                if(ex.Errors[0].Class == 16)
                    MessageBox.Show(ex.Errors[0].Message, "Invalid DateTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showBooking_BT_Click(object sender, EventArgs e)
        {
            ManageReportForm_Load(null, null);
        }

        private void showOverdue_BT_Click(object sender, EventArgs e)
        {
            DateTime dstart = DateTime.Parse(DateTime.Parse(dateStart_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            DateTime dend = DateTime.Parse(DateTime.Parse(dateEnd_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            try
            {
                DataTable dt = booking.getBookingHistoryOverdue(dstart, dend);
                booking_DGV.DataSource = dt;

                this.booking_DGV.Columns[9].HeaderText = "Overdue Fee";
                int sum_pay = 0;
                for (int i = 0; i < this.booking_DGV.Rows.Count - 1; i++)
                {
                    sum_pay += int.Parse(this.booking_DGV.Rows[i].Cells[9].Value.ToString());
                }

            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                    MessageBox.Show(ex.Errors[0].Message, "Invalid DateTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_BT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document (*.docx)|*.docx";
            sfd.FileName = $"Report_From_{dateStart_DTP.Value.ToString("dd / MM / yyyy").Replace('/', '_')}_To_{dateEnd_DTP.Value.ToString("dd / MM / yyyy").Replace('/', '_')}.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(booking_DGV, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                Console.WriteLine(RowCount);
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";

                

                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        if (c == 5 || c == 6 || c == 7 || c == 8)
                        {
                            oTemp = oTemp + DateTime.Parse(DGV.Rows[r].Cells[c].Value.ToString()).ToString("dd/MM/yyyy") + "\t";
                        }
                        else 
                        {
                            if (r == RowCount - 1 && c == ColumnCount - 1)
                                oTemp = oTemp + DataArray[r, c];
                            else
                                oTemp = oTemp + DataArray[r, c] + "\t";
                        }

                           
                    }

                }
                oRange.Text = oTemp;

                object Separator = WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBoders = true;
                object AutoFit = true;
                object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBoders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 1");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.Text = $"Report_From_{dateStart_DTP.Value.ToString("dd / MM / yyyy").Replace('/', '_')}_To_{dateEnd_DTP.Value.ToString("dd / MM / yyyy").Replace('/', '_')}";
                    ;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }
                oDoc.SaveAs(filename);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ck.getDataCheckInCheckOut(dateStartPage2_DTP.Value, dateEndPage2_DTP.Value);
                checkInOutHis_DGV.DataSource = dt;
                checkInOutHis_DGV.AllowUserToAddRows = false;
                checkInOutHis_DGV.ReadOnly = true;

                checkInOutHis_DGV.Columns[0].HeaderText = "Employee ID";
                checkInOutHis_DGV.Columns[1].HeaderText = "First Name";
                checkInOutHis_DGV.Columns[2].HeaderText = "Last Name";
                checkInOutHis_DGV.Columns[3].HeaderText = "Date";
                checkInOutHis_DGV.Columns[4].HeaderText = "Shift";
                checkInOutHis_DGV.Columns[5].HeaderText = "Time Start";
                checkInOutHis_DGV.Columns[5].DefaultCellStyle.Format = "hh\\:mm";
                checkInOutHis_DGV.Columns[6].DefaultCellStyle.Format = "hh\\:mm";
                checkInOutHis_DGV.Columns[6].HeaderText = "Time End";
                checkInOutHis_DGV.Columns[7].HeaderText = "Time In";
                checkInOutHis_DGV.Columns[8].HeaderText = "Time Out";
                checkInOutHis_DGV.Columns[9].HeaderText = "Time Worked";
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Class == 16)
                    MessageBox.Show(ex.Errors[0].Message, "Invalid DateTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void showCheckInOutHis_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }
    }
}
