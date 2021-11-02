
namespace HomeStay.ReceptionistForms
{
    partial class ManagerJanitorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employee_DGV = new System.Windows.Forms.DataGridView();
            this.filter_LB = new System.Windows.Forms.Label();
            this.search_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.search_LB = new System.Windows.Forms.Label();
            this.filter_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.empID_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.emp_id_LB = new System.Windows.Forms.Label();
            this.photoT2_LB = new System.Windows.Forms.Label();
            this.photoT2_PB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phoneT2_LB = new System.Windows.Forms.Label();
            this.phoneT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.bdateT2_DTP = new System.Windows.Forms.DateTimePicker();
            this.genderT2_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.titleT2_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bdateT2_LB = new System.Windows.Forms.Label();
            this.genderT2_LB = new System.Windows.Forms.Label();
            this.titleT2_LB = new System.Windows.Forms.Label();
            this.emailT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailT2_LB = new System.Windows.Forms.Label();
            this.lnameT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameT2_LB = new System.Windows.Forms.Label();
            this.fnameT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.fnameT2_LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoT2_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_DGV
            // 
            this.employee_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employee_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.employee_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employee_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.employee_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_DGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.employee_DGV.EnableHeadersVisualStyles = false;
            this.employee_DGV.Location = new System.Drawing.Point(10, 119);
            this.employee_DGV.Name = "employee_DGV";
            this.employee_DGV.RowHeadersVisible = false;
            this.employee_DGV.RowHeadersWidth = 82;
            this.employee_DGV.RowTemplate.DividerHeight = 1;
            this.employee_DGV.RowTemplate.Height = 33;
            this.employee_DGV.RowTemplate.ReadOnly = true;
            this.employee_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_DGV.Size = new System.Drawing.Size(990, 698);
            this.employee_DGV.TabIndex = 44;
            this.employee_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_DGV_CellClick);
            // 
            // filter_LB
            // 
            this.filter_LB.AutoSize = true;
            this.filter_LB.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_LB.Location = new System.Drawing.Point(4, 30);
            this.filter_LB.Name = "filter_LB";
            this.filter_LB.Size = new System.Drawing.Size(127, 36);
            this.filter_LB.TabIndex = 46;
            this.filter_LB.Text = "Filter By:";
            // 
            // search_TB
            // 
            this.search_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_TB.DefaultText = "";
            this.search_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_TB.DisabledState.Parent = this.search_TB;
            this.search_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_TB.FocusedState.Parent = this.search_TB;
            this.search_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_TB.HoverState.Parent = this.search_TB;
            this.search_TB.Location = new System.Drawing.Point(320, 72);
            this.search_TB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.search_TB.Name = "search_TB";
            this.search_TB.PasswordChar = '\0';
            this.search_TB.PlaceholderText = "";
            this.search_TB.SelectedText = "";
            this.search_TB.ShadowDecoration.Parent = this.search_TB;
            this.search_TB.Size = new System.Drawing.Size(398, 36);
            this.search_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.search_TB.TabIndex = 49;
            this.search_TB.TextChanged += new System.EventHandler(this.search_TB_TextChanged);
            // 
            // search_LB
            // 
            this.search_LB.AutoSize = true;
            this.search_LB.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_LB.Location = new System.Drawing.Point(314, 30);
            this.search_LB.Name = "search_LB";
            this.search_LB.Size = new System.Drawing.Size(121, 36);
            this.search_LB.TabIndex = 48;
            this.search_LB.Text = "Search:";
            // 
            // filter_CBO
            // 
            this.filter_CBO.BackColor = System.Drawing.Color.Transparent;
            this.filter_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filter_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.filter_CBO.FocusedState.Parent = this.filter_CBO;
            this.filter_CBO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filter_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filter_CBO.FormattingEnabled = true;
            this.filter_CBO.HoverState.Parent = this.filter_CBO;
            this.filter_CBO.ItemHeight = 13;
            this.filter_CBO.Items.AddRange(new object[] {
            "EmployeeID",
            "FirstName",
            "LastName",
            "Email",
            "Title",
            "Phone"});
            this.filter_CBO.ItemsAppearance.Parent = this.filter_CBO;
            this.filter_CBO.Location = new System.Drawing.Point(10, 72);
            this.filter_CBO.Margin = new System.Windows.Forms.Padding(0);
            this.filter_CBO.Name = "filter_CBO";
            this.filter_CBO.ShadowDecoration.Parent = this.filter_CBO;
            this.filter_CBO.Size = new System.Drawing.Size(266, 19);
            this.filter_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.filter_CBO.TabIndex = 47;
            this.filter_CBO.SelectedIndexChanged += new System.EventHandler(this.filter_CBO_SelectedIndexChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.empID_TB);
            this.guna2GroupBox2.Controls.Add(this.emp_id_LB);
            this.guna2GroupBox2.Controls.Add(this.photoT2_LB);
            this.guna2GroupBox2.Controls.Add(this.photoT2_PB);
            this.guna2GroupBox2.Controls.Add(this.phoneT2_LB);
            this.guna2GroupBox2.Controls.Add(this.phoneT2_TB);
            this.guna2GroupBox2.Controls.Add(this.bdateT2_DTP);
            this.guna2GroupBox2.Controls.Add(this.genderT2_CBO);
            this.guna2GroupBox2.Controls.Add(this.titleT2_CBO);
            this.guna2GroupBox2.Controls.Add(this.bdateT2_LB);
            this.guna2GroupBox2.Controls.Add(this.genderT2_LB);
            this.guna2GroupBox2.Controls.Add(this.titleT2_LB);
            this.guna2GroupBox2.Controls.Add(this.emailT2_TB);
            this.guna2GroupBox2.Controls.Add(this.emailT2_LB);
            this.guna2GroupBox2.Controls.Add(this.lnameT2_TB);
            this.guna2GroupBox2.Controls.Add(this.lnameT2_LB);
            this.guna2GroupBox2.Controls.Add(this.fnameT2_TB);
            this.guna2GroupBox2.Controls.Add(this.fnameT2_LB);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(1017, 119);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(640, 698);
            this.guna2GroupBox2.TabIndex = 50;
            this.guna2GroupBox2.Text = "Employee Infomation";
            // 
            // empID_TB
            // 
            this.empID_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empID_TB.DefaultText = "";
            this.empID_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empID_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empID_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empID_TB.DisabledState.Parent = this.empID_TB;
            this.empID_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empID_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empID_TB.FocusedState.Parent = this.empID_TB;
            this.empID_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_TB.ForeColor = System.Drawing.Color.Silver;
            this.empID_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empID_TB.HoverState.Parent = this.empID_TB;
            this.empID_TB.Location = new System.Drawing.Point(20, 131);
            this.empID_TB.Margin = new System.Windows.Forms.Padding(10, 13, 10, 13);
            this.empID_TB.Name = "empID_TB";
            this.empID_TB.PasswordChar = '\0';
            this.empID_TB.PlaceholderText = "";
            this.empID_TB.SelectedText = "";
            this.empID_TB.ShadowDecoration.Parent = this.empID_TB;
            this.empID_TB.Size = new System.Drawing.Size(266, 44);
            this.empID_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empID_TB.TabIndex = 26;
            // 
            // emp_id_LB
            // 
            this.emp_id_LB.AutoSize = true;
            this.emp_id_LB.Location = new System.Drawing.Point(16, 94);
            this.emp_id_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_id_LB.Name = "emp_id_LB";
            this.emp_id_LB.Size = new System.Drawing.Size(45, 36);
            this.emp_id_LB.TabIndex = 25;
            this.emp_id_LB.Text = "ID";
            // 
            // photoT2_LB
            // 
            this.photoT2_LB.AutoSize = true;
            this.photoT2_LB.Location = new System.Drawing.Point(346, 263);
            this.photoT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.photoT2_LB.Name = "photoT2_LB";
            this.photoT2_LB.Size = new System.Drawing.Size(98, 36);
            this.photoT2_LB.TabIndex = 23;
            this.photoT2_LB.Text = "Photo";
            // 
            // photoT2_PB
            // 
            this.photoT2_PB.Location = new System.Drawing.Point(354, 310);
            this.photoT2_PB.Margin = new System.Windows.Forms.Padding(4);
            this.photoT2_PB.Name = "photoT2_PB";
            this.photoT2_PB.ShadowDecoration.Parent = this.photoT2_PB;
            this.photoT2_PB.Size = new System.Drawing.Size(266, 246);
            this.photoT2_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoT2_PB.TabIndex = 22;
            this.photoT2_PB.TabStop = false;
            // 
            // phoneT2_LB
            // 
            this.phoneT2_LB.AutoSize = true;
            this.phoneT2_LB.Location = new System.Drawing.Point(346, 181);
            this.phoneT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneT2_LB.Name = "phoneT2_LB";
            this.phoneT2_LB.Size = new System.Drawing.Size(106, 36);
            this.phoneT2_LB.TabIndex = 21;
            this.phoneT2_LB.Text = "Phone";
            // 
            // phoneT2_TB
            // 
            this.phoneT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneT2_TB.DefaultText = "";
            this.phoneT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneT2_TB.DisabledState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneT2_TB.FocusedState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneT2_TB.HoverState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Location = new System.Drawing.Point(354, 213);
            this.phoneT2_TB.Margin = new System.Windows.Forms.Padding(36, 50, 36, 50);
            this.phoneT2_TB.Name = "phoneT2_TB";
            this.phoneT2_TB.PasswordChar = '\0';
            this.phoneT2_TB.PlaceholderText = "";
            this.phoneT2_TB.SelectedText = "";
            this.phoneT2_TB.ShadowDecoration.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Size = new System.Drawing.Size(266, 44);
            this.phoneT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phoneT2_TB.TabIndex = 20;
            // 
            // bdateT2_DTP
            // 
            this.bdateT2_DTP.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdateT2_DTP.Location = new System.Drawing.Point(350, 128);
            this.bdateT2_DTP.Margin = new System.Windows.Forms.Padding(4);
            this.bdateT2_DTP.Name = "bdateT2_DTP";
            this.bdateT2_DTP.Size = new System.Drawing.Size(266, 41);
            this.bdateT2_DTP.TabIndex = 17;
            // 
            // genderT2_CBO
            // 
            this.genderT2_CBO.BackColor = System.Drawing.Color.Transparent;
            this.genderT2_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderT2_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderT2_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.genderT2_CBO.FocusedState.Parent = this.genderT2_CBO;
            this.genderT2_CBO.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderT2_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderT2_CBO.FormattingEnabled = true;
            this.genderT2_CBO.HoverState.Parent = this.genderT2_CBO;
            this.genderT2_CBO.ItemHeight = 30;
            this.genderT2_CBO.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderT2_CBO.ItemsAppearance.Parent = this.genderT2_CBO;
            this.genderT2_CBO.Location = new System.Drawing.Point(20, 608);
            this.genderT2_CBO.Margin = new System.Windows.Forms.Padding(4);
            this.genderT2_CBO.Name = "genderT2_CBO";
            this.genderT2_CBO.ShadowDecoration.Parent = this.genderT2_CBO;
            this.genderT2_CBO.Size = new System.Drawing.Size(266, 36);
            this.genderT2_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.genderT2_CBO.TabIndex = 16;
            // 
            // titleT2_CBO
            // 
            this.titleT2_CBO.BackColor = System.Drawing.Color.Transparent;
            this.titleT2_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.titleT2_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleT2_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.titleT2_CBO.FocusedState.Parent = this.titleT2_CBO;
            this.titleT2_CBO.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleT2_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.titleT2_CBO.FormattingEnabled = true;
            this.titleT2_CBO.HoverState.Parent = this.titleT2_CBO;
            this.titleT2_CBO.ItemHeight = 30;
            this.titleT2_CBO.Items.AddRange(new object[] {
            "Manager",
            "Receptionist",
            "Janitor"});
            this.titleT2_CBO.ItemsAppearance.Parent = this.titleT2_CBO;
            this.titleT2_CBO.Location = new System.Drawing.Point(20, 483);
            this.titleT2_CBO.Margin = new System.Windows.Forms.Padding(4);
            this.titleT2_CBO.Name = "titleT2_CBO";
            this.titleT2_CBO.ShadowDecoration.Parent = this.titleT2_CBO;
            this.titleT2_CBO.Size = new System.Drawing.Size(266, 36);
            this.titleT2_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.titleT2_CBO.TabIndex = 15;
            // 
            // bdateT2_LB
            // 
            this.bdateT2_LB.AutoSize = true;
            this.bdateT2_LB.Location = new System.Drawing.Point(346, 90);
            this.bdateT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bdateT2_LB.Name = "bdateT2_LB";
            this.bdateT2_LB.Size = new System.Drawing.Size(155, 36);
            this.bdateT2_LB.TabIndex = 10;
            this.bdateT2_LB.Text = "Birth Date";
            // 
            // genderT2_LB
            // 
            this.genderT2_LB.AutoSize = true;
            this.genderT2_LB.Location = new System.Drawing.Point(16, 569);
            this.genderT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderT2_LB.Name = "genderT2_LB";
            this.genderT2_LB.Size = new System.Drawing.Size(125, 36);
            this.genderT2_LB.TabIndex = 8;
            this.genderT2_LB.Text = "Gender";
            // 
            // titleT2_LB
            // 
            this.titleT2_LB.AutoSize = true;
            this.titleT2_LB.Location = new System.Drawing.Point(16, 442);
            this.titleT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleT2_LB.Name = "titleT2_LB";
            this.titleT2_LB.Size = new System.Drawing.Size(70, 36);
            this.titleT2_LB.TabIndex = 6;
            this.titleT2_LB.Text = "Title";
            // 
            // emailT2_TB
            // 
            this.emailT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailT2_TB.DefaultText = "";
            this.emailT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailT2_TB.DisabledState.Parent = this.emailT2_TB;
            this.emailT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailT2_TB.FocusedState.Parent = this.emailT2_TB;
            this.emailT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailT2_TB.HoverState.Parent = this.emailT2_TB;
            this.emailT2_TB.Location = new System.Drawing.Point(20, 385);
            this.emailT2_TB.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.emailT2_TB.Name = "emailT2_TB";
            this.emailT2_TB.PasswordChar = '\0';
            this.emailT2_TB.PlaceholderText = "";
            this.emailT2_TB.SelectedText = "";
            this.emailT2_TB.ShadowDecoration.Parent = this.emailT2_TB;
            this.emailT2_TB.Size = new System.Drawing.Size(266, 44);
            this.emailT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emailT2_TB.TabIndex = 5;
            // 
            // emailT2_LB
            // 
            this.emailT2_LB.AutoSize = true;
            this.emailT2_LB.Location = new System.Drawing.Point(16, 354);
            this.emailT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailT2_LB.Name = "emailT2_LB";
            this.emailT2_LB.Size = new System.Drawing.Size(92, 36);
            this.emailT2_LB.TabIndex = 4;
            this.emailT2_LB.Text = "Email";
            // 
            // lnameT2_TB
            // 
            this.lnameT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameT2_TB.DefaultText = "";
            this.lnameT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameT2_TB.DisabledState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameT2_TB.FocusedState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameT2_TB.HoverState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Location = new System.Drawing.Point(20, 302);
            this.lnameT2_TB.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.lnameT2_TB.Name = "lnameT2_TB";
            this.lnameT2_TB.PasswordChar = '\0';
            this.lnameT2_TB.PlaceholderText = "";
            this.lnameT2_TB.SelectedText = "";
            this.lnameT2_TB.ShadowDecoration.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Size = new System.Drawing.Size(266, 44);
            this.lnameT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.lnameT2_TB.TabIndex = 3;
            // 
            // lnameT2_LB
            // 
            this.lnameT2_LB.AutoSize = true;
            this.lnameT2_LB.Location = new System.Drawing.Point(16, 269);
            this.lnameT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameT2_LB.Name = "lnameT2_LB";
            this.lnameT2_LB.Size = new System.Drawing.Size(165, 36);
            this.lnameT2_LB.TabIndex = 2;
            this.lnameT2_LB.Text = "Last Name";
            // 
            // fnameT2_TB
            // 
            this.fnameT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameT2_TB.DefaultText = "";
            this.fnameT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameT2_TB.DisabledState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameT2_TB.FocusedState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameT2_TB.HoverState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Location = new System.Drawing.Point(20, 223);
            this.fnameT2_TB.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fnameT2_TB.Name = "fnameT2_TB";
            this.fnameT2_TB.PasswordChar = '\0';
            this.fnameT2_TB.PlaceholderText = "";
            this.fnameT2_TB.SelectedText = "";
            this.fnameT2_TB.ShadowDecoration.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Size = new System.Drawing.Size(266, 44);
            this.fnameT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.fnameT2_TB.TabIndex = 1;
            // 
            // fnameT2_LB
            // 
            this.fnameT2_LB.AutoSize = true;
            this.fnameT2_LB.Location = new System.Drawing.Point(16, 187);
            this.fnameT2_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameT2_LB.Name = "fnameT2_LB";
            this.fnameT2_LB.Size = new System.Drawing.Size(162, 36);
            this.fnameT2_LB.TabIndex = 0;
            this.fnameT2_LB.Text = "First Name";
            // 
            // ManagerJanitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 839);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.employee_DGV);
            this.Controls.Add(this.filter_LB);
            this.Controls.Add(this.search_TB);
            this.Controls.Add(this.search_LB);
            this.Controls.Add(this.filter_CBO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerJanitorForm";
            this.Text = "ManagerJanitorForm";
            this.Load += new System.EventHandler(this.ManagerJanitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoT2_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_DGV;
        private System.Windows.Forms.Label filter_LB;
        private Guna.UI2.WinForms.Guna2TextBox search_TB;
        private System.Windows.Forms.Label search_LB;
        private Guna.UI2.WinForms.Guna2ComboBox filter_CBO;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox empID_TB;
        private System.Windows.Forms.Label emp_id_LB;
        private System.Windows.Forms.Label photoT2_LB;
        private Guna.UI2.WinForms.Guna2PictureBox photoT2_PB;
        private System.Windows.Forms.Label phoneT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox phoneT2_TB;
        private System.Windows.Forms.DateTimePicker bdateT2_DTP;
        private Guna.UI2.WinForms.Guna2ComboBox genderT2_CBO;
        private Guna.UI2.WinForms.Guna2ComboBox titleT2_CBO;
        private System.Windows.Forms.Label bdateT2_LB;
        private System.Windows.Forms.Label genderT2_LB;
        private System.Windows.Forms.Label titleT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox emailT2_TB;
        private System.Windows.Forms.Label emailT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox lnameT2_TB;
        private System.Windows.Forms.Label lnameT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox fnameT2_TB;
        private System.Windows.Forms.Label fnameT2_LB;
    }
}