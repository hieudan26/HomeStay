
namespace HomeStay.ManagerForms
{
    partial class Check_in_outForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkInOut_DGV = new System.Windows.Forms.DataGridView();
            this.setting_DGV = new System.Windows.Forms.DataGridView();
            this.checkOut_BT = new Guna.UI2.WinForms.Guna2Button();
            this.checkIn_BT = new Guna.UI2.WinForms.Guna2Button();
            this.shifts_DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.checkInOut_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifts_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInOut_DGV
            // 
            this.checkInOut_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkInOut_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.checkInOut_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.checkInOut_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOut_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.checkInOut_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkInOut_DGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.checkInOut_DGV.EnableHeadersVisualStyles = false;
            this.checkInOut_DGV.Location = new System.Drawing.Point(19, 380);
            this.checkInOut_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.checkInOut_DGV.Name = "checkInOut_DGV";
            this.checkInOut_DGV.RowHeadersVisible = false;
            this.checkInOut_DGV.RowHeadersWidth = 82;
            this.checkInOut_DGV.RowTemplate.DividerHeight = 1;
            this.checkInOut_DGV.RowTemplate.Height = 33;
            this.checkInOut_DGV.RowTemplate.ReadOnly = true;
            this.checkInOut_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOut_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkInOut_DGV.Size = new System.Drawing.Size(1082, 197);
            this.checkInOut_DGV.TabIndex = 115;
            // 
            // setting_DGV
            // 
            this.setting_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.setting_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.setting_DGV.BackgroundColor = System.Drawing.Color.White;
            this.setting_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.setting_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.setting_DGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.setting_DGV.EnableHeadersVisualStyles = false;
            this.setting_DGV.Location = new System.Drawing.Point(19, 79);
            this.setting_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.setting_DGV.Name = "setting_DGV";
            this.setting_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.setting_DGV.RowHeadersVisible = false;
            this.setting_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.setting_DGV.RowTemplate.DividerHeight = 1;
            this.setting_DGV.RowTemplate.Height = 33;
            this.setting_DGV.RowTemplate.ReadOnly = true;
            this.setting_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.setting_DGV.Size = new System.Drawing.Size(415, 297);
            this.setting_DGV.TabIndex = 114;
            // 
            // checkOut_BT
            // 
            this.checkOut_BT.BorderRadius = 20;
            this.checkOut_BT.CheckedState.Parent = this.checkOut_BT;
            this.checkOut_BT.CustomImages.Parent = this.checkOut_BT;
            this.checkOut_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.checkOut_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_BT.ForeColor = System.Drawing.Color.White;
            this.checkOut_BT.HoverState.Parent = this.checkOut_BT;
            this.checkOut_BT.Location = new System.Drawing.Point(607, 583);
            this.checkOut_BT.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut_BT.Name = "checkOut_BT";
            this.checkOut_BT.ShadowDecoration.Parent = this.checkOut_BT;
            this.checkOut_BT.Size = new System.Drawing.Size(206, 64);
            this.checkOut_BT.TabIndex = 113;
            this.checkOut_BT.Text = "Check Out";
            this.checkOut_BT.Click += new System.EventHandler(this.checkOut_BT_Click);
            // 
            // checkIn_BT
            // 
            this.checkIn_BT.BorderRadius = 20;
            this.checkIn_BT.CheckedState.Parent = this.checkIn_BT;
            this.checkIn_BT.CustomImages.Parent = this.checkIn_BT;
            this.checkIn_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.checkIn_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_BT.ForeColor = System.Drawing.Color.White;
            this.checkIn_BT.HoverState.Parent = this.checkIn_BT;
            this.checkIn_BT.Location = new System.Drawing.Point(230, 583);
            this.checkIn_BT.Margin = new System.Windows.Forms.Padding(2);
            this.checkIn_BT.Name = "checkIn_BT";
            this.checkIn_BT.ShadowDecoration.Parent = this.checkIn_BT;
            this.checkIn_BT.Size = new System.Drawing.Size(205, 64);
            this.checkIn_BT.TabIndex = 112;
            this.checkIn_BT.Text = "Check In";
            this.checkIn_BT.Click += new System.EventHandler(this.checkIn_BT_Click);
            // 
            // shifts_DGV
            // 
            this.shifts_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.shifts_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shifts_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shifts_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.shifts_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shifts_DGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.shifts_DGV.EnableHeadersVisualStyles = false;
            this.shifts_DGV.Location = new System.Drawing.Point(438, 79);
            this.shifts_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.shifts_DGV.Name = "shifts_DGV";
            this.shifts_DGV.RowHeadersVisible = false;
            this.shifts_DGV.RowHeadersWidth = 82;
            this.shifts_DGV.RowTemplate.DividerHeight = 1;
            this.shifts_DGV.RowTemplate.Height = 33;
            this.shifts_DGV.RowTemplate.ReadOnly = true;
            this.shifts_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shifts_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shifts_DGV.Size = new System.Drawing.Size(663, 297);
            this.shifts_DGV.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Your Shift...To...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "dddd MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 32);
            this.dateTimePicker1.TabIndex = 109;
            // 
            // Check_in_outForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1121, 680);
            this.Controls.Add(this.checkInOut_DGV);
            this.Controls.Add(this.setting_DGV);
            this.Controls.Add(this.checkOut_BT);
            this.Controls.Add(this.checkIn_BT);
            this.Controls.Add(this.shifts_DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_in_outForm";
            this.Text = "Check_in_outForm";
            this.Load += new System.EventHandler(this.Check_in_outForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkInOut_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifts_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView checkInOut_DGV;
        private System.Windows.Forms.DataGridView setting_DGV;
        private Guna.UI2.WinForms.Guna2Button checkOut_BT;
        private Guna.UI2.WinForms.Guna2Button checkIn_BT;
        private System.Windows.Forms.DataGridView shifts_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}