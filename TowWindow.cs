using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class TowsWindow : Form
    {
        internal readonly ITruckCollection truckManager;
        internal NewTicketWindow newTicketWindow;

        internal TowsWindow(ITruckCollection truckCollection)
        {
            InitializeComponent();
            PopulateTicketGrid();
            TruckPanel.Visible = false;
            this.truckManager = truckCollection;
        }

        private void TruckButton_Click(object sender, EventArgs e)
        {
            TowSplitContainer.Visible = false;
            TruckPanel.Visible = true;

            foreach (Truck truck in truckManager.Trucks)
            {
                switch (truck.TruckNum)
                {
                    case 3: // Flatbed - Truck 3
                        VIN3.Text = truck.VIN;
                        Mileage3.Text = truck.Mileage.ToString();
                        Service3.Text = truck.LastServiceDate.ToShortDateString();
                        break;
                    case 10: // Flatbed - Truck 10
                        VIN10.Text = truck.VIN;
                        Mileage10.Text = truck.Mileage.ToString();
                        Service10.Text = truck.LastServiceDate.ToShortDateString();
                        break;
                    case 14: // Semi - Truck 14
                        VIN14.Text = truck.VIN;
                        Mileage14.Text = truck.Mileage.ToString();
                        Service14.Text = truck.LastServiceDate.ToShortDateString();
                        break;
                    case 8: // HeavyDuty - Truck 8
                        VIN8.Text = truck.VIN;
                        Mileage8.Text = truck.Mileage.ToString();
                        Service8.Text = truck.LastServiceDate.ToShortDateString();
                        break;
                    case 13: // HeavyDuty - Truck 13
                        VIN13.Text = truck.VIN;
                        Mileage13.Text = truck.Mileage.ToString();
                        Service13.Text = truck.LastServiceDate.ToShortDateString();
                        break;
                }
            }
        }
        private void TowButton_Click(object sender, EventArgs e)
        {
            TowSplitContainer.Visible = true;
            TruckPanel.Visible = false;
        }
        private void NewTicketButton_Click(object sender, EventArgs e)
        {
            newTicketWindow = new NewTicketWindow(truckManager);
            newTicketWindow.Show();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Check if a ticket is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Get the selected ticket number from the DataGridView
            int ticketNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TicketNumber"].Value);
            // Retrieve the ticket information from the database based on the selected ticket number
            TowTicket ticket = TicketDatabase.GetTicketFromDatabase(ticketNumber);
            // Check if the ticket is found
            if (ticket == null)
            {
                MessageBox.Show("Failed to retrieve ticket information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }         
            NewTicketWindow editTicketWindow = new NewTicketWindow(ticket, truckManager);
            editTicketWindow.Show();
        }
        private void PopulateTicketGrid()
        {
            string selectQuery = "SELECT * FROM Tickets";

            DataTable dataTable = new DataTable();

            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView1.DataSource = dataTable;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the text boxes with data from the selected row
                TicketNumTW.Text = selectedRow.Cells["TicketNumber"].Value.ToString();
                DriverNameTW.Text = selectedRow.Cells["DriverName"].Value.ToString();
                TruckNumTW.Text = selectedRow.Cells["TruckNum"].Value.ToString();
                PuTimeTW.Text = selectedRow.Cells["PickUpTime"].Value.ToString();
                DoTimeTW.Text = selectedRow.Cells["DropOffTime"].Value.ToString();
                PickUpDateTW.Text = selectedRow.Cells["PickUpDate"].Value.ToString();
                DropOffDateTW.Text = selectedRow.Cells["DropOffDate"].Value.ToString();
                PuLocTW.Text = selectedRow.Cells["PickUpLocation"].Value.ToString();
                DoLocTW.Text = selectedRow.Cells["DropOffLocation"].Value.ToString();
                estCostTW.Text = selectedRow.Cells["EstimatedCost"].Value.ToString();
                custNameTW.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                custEmailTW.Text = selectedRow.Cells["CustomerEmail"].Value.ToString();
                custPhoneTW.Text = selectedRow.Cells["CustomerPhone"].Value.ToString();
            }
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            string selectQuery = "SELECT * FROM Tickets WHERE PickUpDate = @SelectedDate OR DropOffDate = @SelectedDate";

            DataTable dataTable = new DataTable();

            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView1.DataSource = dataTable;
        }

        private void RefreshTable_Click(object sender, EventArgs e)
        {
            PopulateTicketGrid();
        }
    }
}
