namespace TruckTracking
{
    partial class TowsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowsWindow));
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.towsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trucksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Status = new System.Windows.Forms.CheckedListBox();
            this.TicketNum = new System.Windows.Forms.TextBox();
            this.DriverName = new System.Windows.Forms.TextBox();
            this.PuTime = new System.Windows.Forms.TextBox();
            this.PuLoc = new System.Windows.Forms.TextBox();
            this.DoLoc = new System.Windows.Forms.TextBox();
            this.estCost = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.todayTickets = new System.Windows.Forms.ListBox();
            this.DoTime = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custName = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.BackColor = System.Drawing.Color.LightGray;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyName.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(912, 12);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(181, 40);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "Stan\'s Towing";
            this.CompanyName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.menuStrip1.Location = new System.Drawing.Point(9, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 35);
            this.menuStrip1.TabIndex = 2;
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Status.CheckOnClick = true;
            this.Status.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Waiting for Pick Up",
            "Picked Up",
            "In Route",
            "Picked Up",
            "Dropped off",
            "Paid",
            "Completed"});
            this.Status.Location = new System.Drawing.Point(13, 275);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(171, 144);
            this.Status.TabIndex = 6;
            // 
            // TicketNum
            // 
            this.TicketNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketNum.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketNum.Location = new System.Drawing.Point(13, 16);
            this.TicketNum.Name = "TicketNum";
            this.TicketNum.Size = new System.Drawing.Size(252, 31);
            this.TicketNum.TabIndex = 7;
            this.TicketNum.Text = "Ticket Number: ";
            // 
            // DriverName
            // 
            this.DriverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverName.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverName.Location = new System.Drawing.Point(13, 53);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(252, 31);
            this.DriverName.TabIndex = 8;
            this.DriverName.Text = "Driver: ";
            this.DriverName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PuTime
            // 
            this.PuTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuTime.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuTime.Location = new System.Drawing.Point(13, 90);
            this.PuTime.Name = "PuTime";
            this.PuTime.Size = new System.Drawing.Size(252, 31);
            this.PuTime.TabIndex = 9;
            this.PuTime.Text = "Pick Up Time: ";
            // 
            // PuLoc
            // 
            this.PuLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuLoc.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuLoc.Location = new System.Drawing.Point(13, 164);
            this.PuLoc.Name = "PuLoc";
            this.PuLoc.Size = new System.Drawing.Size(310, 31);
            this.PuLoc.TabIndex = 10;
            this.PuLoc.Text = "Pick Up Location: ";
            // 
            // DoLoc
            // 
            this.DoLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoLoc.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoLoc.Location = new System.Drawing.Point(13, 201);
            this.DoLoc.Name = "DoLoc";
            this.DoLoc.Size = new System.Drawing.Size(310, 31);
            this.DoLoc.TabIndex = 11;
            this.DoLoc.Text = "Drop Off Location: ";
            // 
            // estCost
            // 
            this.estCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estCost.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estCost.Location = new System.Drawing.Point(431, 16);
            this.estCost.Name = "estCost";
            this.estCost.Size = new System.Drawing.Size(310, 31);
            this.estCost.TabIndex = 12;
            this.estCost.Text = "Est. Cost:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(9, 76);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.todayTickets);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.Status);
            this.splitContainer1.Panel2.Controls.Add(this.StatusBox);
            this.splitContainer1.Panel2.Controls.Add(this.DoTime);
            this.splitContainer1.Panel2.Controls.Add(this.estCost);
            this.splitContainer1.Panel2.Controls.Add(this.TicketNum);
            this.splitContainer1.Panel2.Controls.Add(this.DoLoc);
            this.splitContainer1.Panel2.Controls.Add(this.DriverName);
            this.splitContainer1.Panel2.Controls.Add(this.PuLoc);
            this.splitContainer1.Panel2.Controls.Add(this.PuTime);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 567);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 13;
            // 
            // todayTickets
            // 
            this.todayTickets.FormattingEnabled = true;
            this.todayTickets.Location = new System.Drawing.Point(3, 1);
            this.todayTickets.Name = "todayTickets";
            this.todayTickets.Size = new System.Drawing.Size(299, 563);
            this.todayTickets.TabIndex = 0;
            // 
            // DoTime
            // 
            this.DoTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoTime.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoTime.Location = new System.Drawing.Point(13, 127);
            this.DoTime.Name = "DoTime";
            this.DoTime.Size = new System.Drawing.Size(252, 31);
            this.DoTime.TabIndex = 13;
            this.DoTime.Text = "Drop Off Time: ";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusBox.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(13, 247);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(171, 31);
            this.StatusBox.TabIndex = 14;
            this.StatusBox.Text = "Status";
            this.StatusBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.custPhone);
            this.panel1.Controls.Add(this.custEmail);
            this.panel1.Controls.Add(this.custName);
            this.panel1.Location = new System.Drawing.Point(359, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 134);
            this.panel1.TabIndex = 15;
            // 
            // custName
            // 
            this.custName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custName.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(13, 17);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(369, 31);
            this.custName.TabIndex = 16;
            this.custName.Text = "Customer Name: ";
            this.custName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // custEmail
            // 
            this.custEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custEmail.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEmail.Location = new System.Drawing.Point(13, 54);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(369, 31);
            this.custEmail.TabIndex = 17;
            this.custEmail.Text = "Customer Email: ";
            // 
            // custPhone
            // 
            this.custPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custPhone.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhone.Location = new System.Drawing.Point(13, 91);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(369, 31);
            this.custPhone.TabIndex = 18;
            this.custPhone.Text = "Customer Phone: ";
            this.custPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // TowsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1094, 672);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TowsWindow";
            this.Text = "Tow Truck Tracking - Tows";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem towsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trucksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox TicketNum;
        private System.Windows.Forms.CheckedListBox Status;
        private System.Windows.Forms.TextBox DriverName;
        private System.Windows.Forms.TextBox PuTime;
        private System.Windows.Forms.TextBox estCost;
        private System.Windows.Forms.TextBox DoLoc;
        private System.Windows.Forms.TextBox PuLoc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox todayTickets;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox DoTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.TextBox custEmail;
    }
}

