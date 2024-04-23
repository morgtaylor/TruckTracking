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
            this.TowSplitContainer = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NewTicketButton = new System.Windows.Forms.Button();
            this.DropOffDateTW = new System.Windows.Forms.TextBox();
            this.PickUpDateTW = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TruckNumTW = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.DoTimeTW = new System.Windows.Forms.TextBox();
            this.custPhoneTW = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.custEmailTW = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.DoLocTW = new System.Windows.Forms.TextBox();
            this.custNameTW = new System.Windows.Forms.TextBox();
            this.PuLocTW = new System.Windows.Forms.TextBox();
            this.PuTimeTW = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.TicketNumTW = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.DriverNameTW = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.estCostTW = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.TruckButton = new System.Windows.Forms.Button();
            this.TowButton = new System.Windows.Forms.Button();
            this.TruckPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompTickets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TowSplitContainer)).BeginInit();
            this.TowSplitContainer.Panel1.SuspendLayout();
            this.TowSplitContainer.Panel2.SuspendLayout();
            this.TowSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TruckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.BackColor = System.Drawing.Color.LightGray;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyName.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(878, 13);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Size = new System.Drawing.Size(181, 40);
            this.CompanyName.TabIndex = 30;
            this.CompanyName.TabStop = false;
            this.CompanyName.Text = "Stan\'s Towing";
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
            this.Status.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Status.Location = new System.Drawing.Point(763, 184);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(214, 186);
            this.Status.TabIndex = 6;
            // 
            // TowSplitContainer
            // 
            this.TowSplitContainer.Location = new System.Drawing.Point(9, 54);
            this.TowSplitContainer.Name = "TowSplitContainer";
            this.TowSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TowSplitContainer.Panel1
            // 
            this.TowSplitContainer.Panel1.Controls.Add(this.monthCalendar1);
            this.TowSplitContainer.Panel1.Controls.Add(this.dataGridView1);
            this.TowSplitContainer.Panel1.Controls.Add(this.NewTicketButton);
            // 
            // TowSplitContainer.Panel2
            // 
            this.TowSplitContainer.Panel2.Controls.Add(this.DropOffDateTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.PickUpDateTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox8);
            this.TowSplitContainer.Panel2.Controls.Add(this.TruckNumTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox5);
            this.TowSplitContainer.Panel2.Controls.Add(this.DoTimeTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.custPhoneTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox13);
            this.TowSplitContainer.Panel2.Controls.Add(this.custEmailTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox10);
            this.TowSplitContainer.Panel2.Controls.Add(this.DoLocTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.custNameTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.PuLocTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.PuTimeTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox11);
            this.TowSplitContainer.Panel2.Controls.Add(this.TicketNumTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox12);
            this.TowSplitContainer.Panel2.Controls.Add(this.DriverNameTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox7);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox9);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox6);
            this.TowSplitContainer.Panel2.Controls.Add(this.estCostTW);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox4);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox3);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox2);
            this.TowSplitContainer.Panel2.Controls.Add(this.textBox1);
            this.TowSplitContainer.Panel2.Controls.Add(this.Status);
            this.TowSplitContainer.Panel2.Controls.Add(this.StatusBox);
            this.TowSplitContainer.Size = new System.Drawing.Size(1065, 601);
            this.TowSplitContainer.SplitterDistance = 210;
            this.TowSplitContainer.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(829, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(819, 162);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // DropOffDateTW
            // 
            this.DropOffDateTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropOffDateTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropOffDateTW.Location = new System.Drawing.Point(515, 327);
            this.DropOffDateTW.Name = "DropOffDateTW";
            this.DropOffDateTW.ReadOnly = true;
            this.DropOffDateTW.Size = new System.Drawing.Size(218, 31);
            this.DropOffDateTW.TabIndex = 79;
            // 
            // PickUpDateTW
            // 
            this.PickUpDateTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PickUpDateTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDateTW.Location = new System.Drawing.Point(515, 219);
            this.PickUpDateTW.Name = "PickUpDateTW";
            this.PickUpDateTW.ReadOnly = true;
            this.PickUpDateTW.Size = new System.Drawing.Size(218, 31);
            this.PickUpDateTW.TabIndex = 78;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.LightGray;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(367, 332);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(169, 24);
            this.textBox8.TabIndex = 59;
            this.textBox8.Text = "Drop Off Date: ";
            // 
            // TruckNumTW
            // 
            this.TruckNumTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TruckNumTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruckNumTW.Location = new System.Drawing.Point(169, 51);
            this.TruckNumTW.Name = "TruckNumTW";
            this.TruckNumTW.ReadOnly = true;
            this.TruckNumTW.Size = new System.Drawing.Size(128, 31);
            this.TruckNumTW.TabIndex = 77;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(367, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 24);
            this.textBox5.TabIndex = 58;
            this.textBox5.Text = "Pick Up Date:";
            // 
            // DoTimeTW
            // 
            this.DoTimeTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoTimeTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoTimeTW.Location = new System.Drawing.Point(191, 316);
            this.DoTimeTW.Name = "DoTimeTW";
            this.DoTimeTW.ReadOnly = true;
            this.DoTimeTW.Size = new System.Drawing.Size(136, 31);
            this.DoTimeTW.TabIndex = 71;
            // 
            // custPhoneTW
            // 
            this.custPhoneTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custPhoneTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhoneTW.Location = new System.Drawing.Point(525, 58);
            this.custPhoneTW.Name = "custPhoneTW";
            this.custPhoneTW.ReadOnly = true;
            this.custPhoneTW.Size = new System.Drawing.Size(369, 31);
            this.custPhoneTW.TabIndex = 74;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.LightGray;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(15, 58);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(169, 24);
            this.textBox13.TabIndex = 76;
            this.textBox13.Text = "Truck Number: ";
            // 
            // custEmailTW
            // 
            this.custEmailTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custEmailTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEmailTW.Location = new System.Drawing.Point(525, 95);
            this.custEmailTW.Name = "custEmailTW";
            this.custEmailTW.ReadOnly = true;
            this.custEmailTW.Size = new System.Drawing.Size(369, 31);
            this.custEmailTW.TabIndex = 73;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.LightGray;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(359, 60);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(169, 24);
            this.textBox10.TabIndex = 75;
            this.textBox10.Text = "Customer Phone: ";
            // 
            // DoLocTW
            // 
            this.DoLocTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoLocTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoLocTW.Location = new System.Drawing.Point(191, 279);
            this.DoLocTW.Name = "DoLocTW";
            this.DoLocTW.ReadOnly = true;
            this.DoLocTW.Size = new System.Drawing.Size(300, 31);
            this.DoLocTW.TabIndex = 69;
            // 
            // custNameTW
            // 
            this.custNameTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custNameTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameTW.Location = new System.Drawing.Point(525, 18);
            this.custNameTW.Name = "custNameTW";
            this.custNameTW.ReadOnly = true;
            this.custNameTW.Size = new System.Drawing.Size(369, 31);
            this.custNameTW.TabIndex = 72;
            // 
            // PuLocTW
            // 
            this.PuLocTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuLocTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuLocTW.Location = new System.Drawing.Point(191, 170);
            this.PuLocTW.Name = "PuLocTW";
            this.PuLocTW.ReadOnly = true;
            this.PuLocTW.Size = new System.Drawing.Size(300, 31);
            this.PuLocTW.TabIndex = 68;
            // 
            // PuTimeTW
            // 
            this.PuTimeTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PuTimeTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuTimeTW.Location = new System.Drawing.Point(191, 207);
            this.PuTimeTW.Name = "PuTimeTW";
            this.PuTimeTW.ReadOnly = true;
            this.PuTimeTW.Size = new System.Drawing.Size(136, 31);
            this.PuTimeTW.TabIndex = 67;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.LightGray;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(360, 97);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(169, 24);
            this.textBox11.TabIndex = 74;
            this.textBox11.Text = "Customer Email: ";
            // 
            // TicketNumTW
            // 
            this.TicketNumTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketNumTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketNumTW.Location = new System.Drawing.Point(169, 14);
            this.TicketNumTW.Name = "TicketNumTW";
            this.TicketNumTW.ReadOnly = true;
            this.TicketNumTW.Size = new System.Drawing.Size(173, 31);
            this.TicketNumTW.TabIndex = 65;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.LightGray;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(360, 18);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(169, 24);
            this.textBox12.TabIndex = 73;
            this.textBox12.Text = "Customer Name: ";
            // 
            // DriverNameTW
            // 
            this.DriverNameTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverNameTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNameTW.Location = new System.Drawing.Point(105, 125);
            this.DriverNameTW.Name = "DriverNameTW";
            this.DriverNameTW.ReadOnly = true;
            this.DriverNameTW.Size = new System.Drawing.Size(128, 31);
            this.DriverNameTW.TabIndex = 66;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.LightGray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(16, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 24);
            this.textBox7.TabIndex = 72;
            this.textBox7.Text = "Drop Off Time: ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightGray;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(5, 281);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(169, 24);
            this.textBox9.TabIndex = 71;
            this.textBox9.Text = "Drop Off Location: ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LightGray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 24);
            this.textBox6.TabIndex = 70;
            this.textBox6.Text = "Pick Up Time:";
            // 
            // estCostTW
            // 
            this.estCostTW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estCostTW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estCostTW.Location = new System.Drawing.Point(105, 88);
            this.estCostTW.Name = "estCostTW";
            this.estCostTW.ReadOnly = true;
            this.estCostTW.Size = new System.Drawing.Size(115, 31);
            this.estCostTW.TabIndex = 70;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(5, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 24);
            this.textBox4.TabIndex = 69;
            this.textBox4.Text = "Pick Up Location:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 24);
            this.textBox3.TabIndex = 68;
            this.textBox3.Text = "Driver:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 24);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "Est. Cost:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 24);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Ticket Number: ";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusBox.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(763, 147);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(214, 31);
            this.StatusBox.TabIndex = 14;
            this.StatusBox.Text = "Status";
            this.StatusBox.TextChanged += new System.EventHandler(this.StatusBox_TextChanged);
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
            // TruckPanel
            // 
            this.TruckPanel.Controls.Add(this.label6);
            this.TruckPanel.Controls.Add(this.label5);
            this.TruckPanel.Controls.Add(this.label4);
            this.TruckPanel.Controls.Add(this.label3);
            this.TruckPanel.Controls.Add(this.label2);
            this.TruckPanel.Controls.Add(this.label1);
            this.TruckPanel.Location = new System.Drawing.Point(9, 54);
            this.TruckPanel.Name = "TruckPanel";
            this.TruckPanel.Size = new System.Drawing.Size(1074, 602);
            this.TruckPanel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label6.Location = new System.Drawing.Point(967, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "#14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label5.Location = new System.Drawing.Point(493, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "#10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label4.Location = new System.Drawing.Point(729, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "#13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label3.Location = new System.Drawing.Point(274, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "#8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "#3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Truck Number";
            // 
            // CompTickets
            // 
            this.CompTickets.BackColor = System.Drawing.Color.Azure;
            this.CompTickets.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.CompTickets.Location = new System.Drawing.Point(633, 13);
            this.CompTickets.Name = "CompTickets";
            this.CompTickets.Size = new System.Drawing.Size(226, 35);
            this.CompTickets.TabIndex = 18;
            this.CompTickets.Text = "Completed Tickets";
            this.CompTickets.UseVisualStyleBackColor = false;
            // 
            // TowsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1095, 668);
            this.Controls.Add(this.CompTickets);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.TowButton);
            this.Controls.Add(this.TruckButton);
            this.Controls.Add(this.TruckPanel);
            this.Controls.Add(this.TowSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TowsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tow Truck Tracking";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.TowSplitContainer.Panel1.ResumeLayout(false);
            this.TowSplitContainer.Panel2.ResumeLayout(false);
            this.TowSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TowSplitContainer)).EndInit();
            this.TowSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TruckPanel.ResumeLayout(false);
            this.TruckPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyName;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckedListBox Status;
        private System.Windows.Forms.SplitContainer TowSplitContainer;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button TruckButton;
        private System.Windows.Forms.Button TowButton;
        private System.Windows.Forms.Button NewTicketButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DoTimeTW;
        private System.Windows.Forms.TextBox custPhoneTW;
        private System.Windows.Forms.TextBox custEmailTW;
        private System.Windows.Forms.TextBox DoLocTW;
        private System.Windows.Forms.TextBox custNameTW;
        private System.Windows.Forms.TextBox PuLocTW;
        private System.Windows.Forms.TextBox PuTimeTW;
        private System.Windows.Forms.TextBox TicketNumTW;
        private System.Windows.Forms.TextBox DriverNameTW;
        private System.Windows.Forms.TextBox estCostTW;
        private System.Windows.Forms.TextBox TruckNumTW;
        private System.Windows.Forms.TextBox DropOffDateTW;
        private System.Windows.Forms.TextBox PickUpDateTW;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel TruckPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CompTickets;
    }
}

