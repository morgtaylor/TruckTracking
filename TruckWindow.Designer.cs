namespace TruckTracking
{
    partial class TruckWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.towsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trucksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.towsToolStripMenuItem,
            this.trucksToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.driversToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // towsToolStripMenuItem
            // 
            this.towsToolStripMenuItem.Name = "towsToolStripMenuItem";
            this.towsToolStripMenuItem.Size = new System.Drawing.Size(76, 31);
            this.towsToolStripMenuItem.Text = "Tows";
            // 
            // trucksToolStripMenuItem
            // 
            this.trucksToolStripMenuItem.Name = "trucksToolStripMenuItem";
            this.trucksToolStripMenuItem.Size = new System.Drawing.Size(96, 31);
            this.trucksToolStripMenuItem.Text = "Trucks";
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.calendarToolStripMenuItem.Text = "Calendar";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(101, 31);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // CompanyName
            // 
            this.CompanyName.BackColor = System.Drawing.Color.LightGray;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyName.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(901, 12);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(181, 40);
            this.CompanyName.TabIndex = 4;
            this.CompanyName.Text = "Stan\'s Towing";
            // 
            // TruckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1094, 672);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TruckWindow";
            this.Text = "Tow Truck Tracking - Trucks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem towsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trucksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.TextBox CompanyName;
    }
}