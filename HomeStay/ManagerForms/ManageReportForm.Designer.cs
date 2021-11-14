
namespace HomeStay.ManagerForms
{
    partial class ManageReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateEnd_DTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.showOverdue_BT = new Guna.UI2.WinForms.Guna2Button();
            this.showBooking_BT = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart_DTP = new System.Windows.Forms.DateTimePicker();
            this.export_BT = new Guna.UI2.WinForms.Guna2Button();
            this.booking_DGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exportPage2_BT = new Guna.UI2.WinForms.Guna2Button();
            this.checkInOutHis_DGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateEndPage2_DTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.showCheckInOutHis = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateStartPage2_DTP = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.exportPage3_BT = new Guna.UI2.WinForms.Guna2Button();
            this.Review_DGV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInOutHis_DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Review_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 974);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.export_BT);
            this.tabPage1.Controls.Add(this.booking_DGV);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(8, 50);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1376, 916);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Booking";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateEnd_DTP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.showOverdue_BT);
            this.panel2.Controls.Add(this.showBooking_BT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateStart_DTP);
            this.panel2.Location = new System.Drawing.Point(28, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 110);
            this.panel2.TabIndex = 129;
            // 
            // dateEnd_DTP
            // 
            this.dateEnd_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd_DTP.Location = new System.Drawing.Point(448, 35);
            this.dateEnd_DTP.Name = "dateEnd_DTP";
            this.dateEnd_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateEnd_DTP.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 36);
            this.label2.TabIndex = 116;
            this.label2.Text = "To:";
            // 
            // showOverdue_BT
            // 
            this.showOverdue_BT.BorderRadius = 3;
            this.showOverdue_BT.CheckedState.Parent = this.showOverdue_BT;
            this.showOverdue_BT.CustomImages.Parent = this.showOverdue_BT;
            this.showOverdue_BT.FillColor = System.Drawing.Color.Chocolate;
            this.showOverdue_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOverdue_BT.ForeColor = System.Drawing.Color.White;
            this.showOverdue_BT.HoverState.Parent = this.showOverdue_BT;
            this.showOverdue_BT.Location = new System.Drawing.Point(1015, 15);
            this.showOverdue_BT.Name = "showOverdue_BT";
            this.showOverdue_BT.ShadowDecoration.Parent = this.showOverdue_BT;
            this.showOverdue_BT.Size = new System.Drawing.Size(287, 80);
            this.showOverdue_BT.TabIndex = 115;
            this.showOverdue_BT.Text = "Show Overdue";
            this.showOverdue_BT.Click += new System.EventHandler(this.showOverdue_BT_Click);
            // 
            // showBooking_BT
            // 
            this.showBooking_BT.BorderRadius = 3;
            this.showBooking_BT.CheckedState.Parent = this.showBooking_BT;
            this.showBooking_BT.CustomImages.Parent = this.showBooking_BT;
            this.showBooking_BT.FillColor = System.Drawing.Color.IndianRed;
            this.showBooking_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBooking_BT.ForeColor = System.Drawing.Color.White;
            this.showBooking_BT.HoverState.Parent = this.showBooking_BT;
            this.showBooking_BT.Location = new System.Drawing.Point(708, 15);
            this.showBooking_BT.Name = "showBooking_BT";
            this.showBooking_BT.ShadowDecoration.Parent = this.showBooking_BT;
            this.showBooking_BT.Size = new System.Drawing.Size(287, 80);
            this.showBooking_BT.TabIndex = 113;
            this.showBooking_BT.Text = "Show Booking";
            this.showBooking_BT.Click += new System.EventHandler(this.showBooking_BT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 36);
            this.label3.TabIndex = 112;
            this.label3.Text = "From:";
            // 
            // dateStart_DTP
            // 
            this.dateStart_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart_DTP.Location = new System.Drawing.Point(112, 35);
            this.dateStart_DTP.Name = "dateStart_DTP";
            this.dateStart_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateStart_DTP.TabIndex = 111;
            // 
            // export_BT
            // 
            this.export_BT.BorderRadius = 3;
            this.export_BT.CheckedState.Parent = this.export_BT;
            this.export_BT.CustomImages.Parent = this.export_BT;
            this.export_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.export_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_BT.ForeColor = System.Drawing.Color.White;
            this.export_BT.HoverState.Parent = this.export_BT;
            this.export_BT.Location = new System.Drawing.Point(28, 808);
            this.export_BT.Name = "export_BT";
            this.export_BT.ShadowDecoration.Parent = this.export_BT;
            this.export_BT.Size = new System.Drawing.Size(1320, 90);
            this.export_BT.TabIndex = 128;
            this.export_BT.Text = "Export To FIle";
            this.export_BT.Click += new System.EventHandler(this.export_BT_Click);
            // 
            // booking_DGV
            // 
            this.booking_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.booking_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.booking_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.booking_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booking_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booking_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booking_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booking_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.booking_DGV.EnableHeadersVisualStyles = false;
            this.booking_DGV.Location = new System.Drawing.Point(28, 151);
            this.booking_DGV.Name = "booking_DGV";
            this.booking_DGV.RowHeadersVisible = false;
            this.booking_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.booking_DGV.RowTemplate.DividerHeight = 1;
            this.booking_DGV.RowTemplate.Height = 33;
            this.booking_DGV.RowTemplate.ReadOnly = true;
            this.booking_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.booking_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booking_DGV.Size = new System.Drawing.Size(1320, 642);
            this.booking_DGV.TabIndex = 127;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exportPage2_BT);
            this.tabPage2.Controls.Add(this.checkInOutHis_DGV);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(8, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1376, 916);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Time Attendence";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exportPage2_BT
            // 
            this.exportPage2_BT.BorderRadius = 3;
            this.exportPage2_BT.CheckedState.Parent = this.exportPage2_BT;
            this.exportPage2_BT.CustomImages.Parent = this.exportPage2_BT;
            this.exportPage2_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.exportPage2_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportPage2_BT.ForeColor = System.Drawing.Color.White;
            this.exportPage2_BT.HoverState.Parent = this.exportPage2_BT;
            this.exportPage2_BT.Location = new System.Drawing.Point(30, 804);
            this.exportPage2_BT.Name = "exportPage2_BT";
            this.exportPage2_BT.ShadowDecoration.Parent = this.exportPage2_BT;
            this.exportPage2_BT.Size = new System.Drawing.Size(1320, 90);
            this.exportPage2_BT.TabIndex = 132;
            this.exportPage2_BT.Text = "Export To FIle";
            // 
            // checkInOutHis_DGV
            // 
            this.checkInOutHis_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.checkInOutHis_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.checkInOutHis_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.checkInOutHis_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.checkInOutHis_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOutHis_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.checkInOutHis_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkInOutHis_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkInOutHis_DGV.EnableHeadersVisualStyles = false;
            this.checkInOutHis_DGV.Location = new System.Drawing.Point(30, 147);
            this.checkInOutHis_DGV.Name = "checkInOutHis_DGV";
            this.checkInOutHis_DGV.RowHeadersVisible = false;
            this.checkInOutHis_DGV.RowHeadersWidth = 82;
            this.checkInOutHis_DGV.RowTemplate.DividerHeight = 1;
            this.checkInOutHis_DGV.RowTemplate.Height = 33;
            this.checkInOutHis_DGV.RowTemplate.ReadOnly = true;
            this.checkInOutHis_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOutHis_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkInOutHis_DGV.Size = new System.Drawing.Size(1320, 642);
            this.checkInOutHis_DGV.TabIndex = 131;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateEndPage2_DTP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.showCheckInOutHis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateStartPage2_DTP);
            this.panel1.Location = new System.Drawing.Point(30, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 110);
            this.panel1.TabIndex = 130;
            // 
            // dateEndPage2_DTP
            // 
            this.dateEndPage2_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndPage2_DTP.Location = new System.Drawing.Point(448, 35);
            this.dateEndPage2_DTP.Name = "dateEndPage2_DTP";
            this.dateEndPage2_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateEndPage2_DTP.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 36);
            this.label1.TabIndex = 116;
            this.label1.Text = "To:";
            // 
            // showCheckInOutHis
            // 
            this.showCheckInOutHis.BorderRadius = 3;
            this.showCheckInOutHis.CheckedState.Parent = this.showCheckInOutHis;
            this.showCheckInOutHis.CustomImages.Parent = this.showCheckInOutHis;
            this.showCheckInOutHis.FillColor = System.Drawing.Color.IndianRed;
            this.showCheckInOutHis.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCheckInOutHis.ForeColor = System.Drawing.Color.White;
            this.showCheckInOutHis.HoverState.Parent = this.showCheckInOutHis;
            this.showCheckInOutHis.Location = new System.Drawing.Point(708, 15);
            this.showCheckInOutHis.Name = "showCheckInOutHis";
            this.showCheckInOutHis.ShadowDecoration.Parent = this.showCheckInOutHis;
            this.showCheckInOutHis.Size = new System.Drawing.Size(287, 80);
            this.showCheckInOutHis.TabIndex = 113;
            this.showCheckInOutHis.Text = "Show";
            this.showCheckInOutHis.Click += new System.EventHandler(this.showCheckInOutHis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 36);
            this.label4.TabIndex = 112;
            this.label4.Text = "From:";
            // 
            // dateStartPage2_DTP
            // 
            this.dateStartPage2_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartPage2_DTP.Location = new System.Drawing.Point(112, 35);
            this.dateStartPage2_DTP.Name = "dateStartPage2_DTP";
            this.dateStartPage2_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateStartPage2_DTP.TabIndex = 111;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.exportPage3_BT);
            this.tabPage3.Controls.Add(this.Review_DGV);
            this.tabPage3.Location = new System.Drawing.Point(8, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1376, 916);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Review";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // exportPage3_BT
            // 
            this.exportPage3_BT.BorderRadius = 3;
            this.exportPage3_BT.CheckedState.Parent = this.exportPage3_BT;
            this.exportPage3_BT.CustomImages.Parent = this.exportPage3_BT;
            this.exportPage3_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.exportPage3_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportPage3_BT.ForeColor = System.Drawing.Color.White;
            this.exportPage3_BT.HoverState.Parent = this.exportPage3_BT;
            this.exportPage3_BT.Location = new System.Drawing.Point(28, 805);
            this.exportPage3_BT.Name = "exportPage3_BT";
            this.exportPage3_BT.ShadowDecoration.Parent = this.exportPage3_BT;
            this.exportPage3_BT.Size = new System.Drawing.Size(1320, 90);
            this.exportPage3_BT.TabIndex = 135;
            this.exportPage3_BT.Text = "Export To FIle";
            // 
            // Review_DGV
            // 
            this.Review_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Review_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Review_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.Review_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Review_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Review_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Review_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Review_DGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.Review_DGV.EnableHeadersVisualStyles = false;
            this.Review_DGV.Location = new System.Drawing.Point(28, 30);
            this.Review_DGV.Name = "Review_DGV";
            this.Review_DGV.RowHeadersVisible = false;
            this.Review_DGV.RowHeadersWidth = 82;
            this.Review_DGV.RowTemplate.DividerHeight = 1;
            this.Review_DGV.RowTemplate.Height = 40;
            this.Review_DGV.RowTemplate.ReadOnly = true;
            this.Review_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Review_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Review_DGV.Size = new System.Drawing.Size(1320, 760);
            this.Review_DGV.TabIndex = 134;
            this.Review_DGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Review_DGV_CellMouseDoubleClick);
            // 
            // ManageReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 974);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReportForm";
            this.Text = "ManageReportForm";
            this.Load += new System.EventHandler(this.ManageReportForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkInOutHis_DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Review_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateEnd_DTP;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button showOverdue_BT;
        private Guna.UI2.WinForms.Guna2Button showBooking_BT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateStart_DTP;
        private Guna.UI2.WinForms.Guna2Button export_BT;
        public System.Windows.Forms.DataGridView booking_DGV;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button exportPage2_BT;
        public System.Windows.Forms.DataGridView checkInOutHis_DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateEndPage2_DTP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button showCheckInOutHis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateStartPage2_DTP;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button exportPage3_BT;
        public System.Windows.Forms.DataGridView Review_DGV;
    }
}