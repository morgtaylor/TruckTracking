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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Status = new System.Windows.Forms.CheckedListBox();
            this.TicketNum = new System.Windows.Forms.TextBox();
            this.DriverName = new System.Windows.Forms.TextBox();
            this.PuTime = new System.Windows.Forms.TextBox();
            this.PuLoc = new System.Windows.Forms.TextBox();
            this.DoLoc = new System.Windows.Forms.TextBox();
            this.estCost = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NewTicketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.DoTime = new System.Windows.Forms.TextBox();
            this.TruckButton = new System.Windows.Forms.Button();
            this.TowButton = new System.Windows.Forms.Button();
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
            this.CompanyName.Location = new System.Drawing.Point(878, 13);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(181, 40);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "Stan\'s Towing";
            this.CompanyName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.NewTicketButton);
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
            // NewTicketButton
            // 
            this.NewTicketButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NewTicketButton.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.NewTicketButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewTicketButton.Location = new System.Drawing.Point(0, 0);
            this.NewTicketButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewTicketButton.Name = "NewTicketButton";
            this.NewTicketButton.Size = new System.Drawing.Size(305, 35);
            this.NewTicketButton.TabIndex = 17;
            this.NewTicketButton.Text = "New Tow Ticket";
            this.NewTicketButton.UseVisualStyleBackColor = false;
            this.NewTicketButton.Click += new System.EventHandler(this.NewTicketButton_Click);
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
            // DoTime
            // 
            this.DoTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoTime.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoTime.Location = new System.Drawing.Point(13, 127);
            this.DoTime.Name = "DoTime";
            this.DoTime.Size = new System.Drawing.Size(252, 31);
            this.DoTime.TabIndex = 13;
            this.DoTime.Text = "Drop Off Time: ";
            this.DoTime.TextChanged += new System.EventHandler(this.DoTime_TextChanged);
            // 
            // TruckButton
            // 
            this.TruckButton.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.TruckButton.Location = new System.Drawing.Point(106, 13);
            this.TruckButton.Name = "TruckButton";
            this.TruckButton.Size = new System.Drawing.Size(87, 35);
            this.TruckButton.TabIndex = 15;
            this.TruckButton.Text = "Trucks";
            this.TruckButton.UseVisualStyleBackColor = true;
            this.TruckButton.Click += new System.EventHandler(this.TruckButton_Click);
            // 
            // TowButton
            // 
            this.TowButton.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.TowButton.Location = new System.Drawing.Point(13, 13);
            this.TowButton.Name = "TowButton";
            this.TowButton.Size = new System.Drawing.Size(87, 35);
            this.TowButton.TabIndex = 16;
            this.TowButton.Text = "Tows";
            this.TowButton.UseVisualStyleBackColor = true;
            this.TowButton.Click += new System.EventHandler(this.TowButton_Click);
            // 
            // TowsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1094, 672);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.TowButton);
            this.Controls.Add(this.TruckButton);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TowsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tow Truck Tracking";
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox TicketNum;
        private System.Windows.Forms.CheckedListBox Status;
        private System.Windows.Forms.TextBox DriverName;
        private System.Windows.Forms.TextBox PuTime;
        private System.Windows.Forms.TextBox estCost;
        private System.Windows.Forms.TextBox DoLoc;
        private System.Windows.Forms.TextBox PuLoc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox DoTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.Button TruckButton;
        private System.Windows.Forms.Button TowButton;
        private System.Windows.Forms.Button NewTicketButton;
    }
}

