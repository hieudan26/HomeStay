
namespace HomeStay.CustomerForms
{
    partial class CheckInCheckOutForm
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
            this.checkOut_BT = new Guna.UI2.WinForms.Guna2Button();
            this.checkIn_BT = new Guna.UI2.WinForms.Guna2Button();
            this.checkInOut_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.checkInOut_DGV)).BeginInit();
            this.SuspendLayout();
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
            this.checkOut_BT.Location = new System.Drawing.Point(532, 208);
            this.checkOut_BT.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut_BT.Name = "checkOut_BT";
            this.checkOut_BT.ShadowDecoration.Parent = this.checkOut_BT;
            this.checkOut_BT.Size = new System.Drawing.Size(206, 64);
            this.checkOut_BT.TabIndex = 114;
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
            this.checkIn_BT.Location = new System.Drawing.Point(95, 208);
            this.checkIn_BT.Margin = new System.Windows.Forms.Padding(2);
            this.checkIn_BT.Name = "checkIn_BT";
            this.checkIn_BT.ShadowDecoration.Parent = this.checkIn_BT;
            this.checkIn_BT.Size = new System.Drawing.Size(205, 64);
            this.checkIn_BT.TabIndex = 113;
            this.checkIn_BT.Text = "Check In";
            this.checkIn_BT.Click += new System.EventHandler(this.checkIn_BT_Click);
            // 
            // checkInOut_DGV
            // 
            this.checkInOut_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkInOut_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.checkInOut_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.checkInOut_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOut_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.checkInOut_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkInOut_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.checkInOut_DGV.EnableHeadersVisualStyles = false;
            this.checkInOut_DGV.Location = new System.Drawing.Point(8, 7);
            this.checkInOut_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.checkInOut_DGV.Name = "checkInOut_DGV";
            this.checkInOut_DGV.RowHeadersVisible = false;
            this.checkInOut_DGV.RowHeadersWidth = 82;
            this.checkInOut_DGV.RowTemplate.DividerHeight = 1;
            this.checkInOut_DGV.RowTemplate.Height = 33;
            this.checkInOut_DGV.RowTemplate.ReadOnly = true;
            this.checkInOut_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkInOut_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkInOut_DGV.Size = new System.Drawing.Size(819, 197);
            this.checkInOut_DGV.TabIndex = 112;
            // 
            // CheckInCheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 278);
            this.Controls.Add(this.checkOut_BT);
            this.Controls.Add(this.checkIn_BT);
            this.Controls.Add(this.checkInOut_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckInCheckOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckInCheckOutForm";
            this.Load += new System.EventHandler(this.CheckInCheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkInOut_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button checkOut_BT;
        private Guna.UI2.WinForms.Guna2Button checkIn_BT;
        private System.Windows.Forms.DataGridView checkInOut_DGV;
    }
}