
namespace HomeStay.JanitorForms
{
    partial class CleanRoom
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
            this.cleanRoom_BT = new Guna.UI2.WinForms.Guna2Button();
            this.roomDirty_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.roomDirty_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cleanRoom_BT
            // 
            this.cleanRoom_BT.BorderRadius = 3;
            this.cleanRoom_BT.CheckedState.Parent = this.cleanRoom_BT;
            this.cleanRoom_BT.CustomImages.Parent = this.cleanRoom_BT;
            this.cleanRoom_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.cleanRoom_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanRoom_BT.ForeColor = System.Drawing.Color.White;
            this.cleanRoom_BT.HoverState.Parent = this.cleanRoom_BT;
            this.cleanRoom_BT.Location = new System.Drawing.Point(12, 276);
            this.cleanRoom_BT.Name = "cleanRoom_BT";
            this.cleanRoom_BT.ShadowDecoration.Parent = this.cleanRoom_BT;
            this.cleanRoom_BT.Size = new System.Drawing.Size(1228, 100);
            this.cleanRoom_BT.TabIndex = 116;
            this.cleanRoom_BT.Text = "Clean";
            this.cleanRoom_BT.Click += new System.EventHandler(this.cleanRoom_BT_Click);
            // 
            // roomDirty_DGV
            // 
            this.roomDirty_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDirty_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.roomDirty_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomDirty_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDirty_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomDirty_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDirty_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomDirty_DGV.EnableHeadersVisualStyles = false;
            this.roomDirty_DGV.Location = new System.Drawing.Point(12, 12);
            this.roomDirty_DGV.Name = "roomDirty_DGV";
            this.roomDirty_DGV.RowHeadersVisible = false;
            this.roomDirty_DGV.RowHeadersWidth = 82;
            this.roomDirty_DGV.RowTemplate.DividerHeight = 1;
            this.roomDirty_DGV.RowTemplate.Height = 33;
            this.roomDirty_DGV.RowTemplate.ReadOnly = true;
            this.roomDirty_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDirty_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDirty_DGV.Size = new System.Drawing.Size(1228, 248);
            this.roomDirty_DGV.TabIndex = 115;
            // 
            // CleanRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 388);
            this.Controls.Add(this.cleanRoom_BT);
            this.Controls.Add(this.roomDirty_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CleanRoom";
            this.Text = "CleanRoom";
            this.Load += new System.EventHandler(this.CleanRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDirty_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button cleanRoom_BT;
        private System.Windows.Forms.DataGridView roomDirty_DGV;
    }
}