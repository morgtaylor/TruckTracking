using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class NewTicketWindow : Form
    {
        public NewTicketWindow()
        {
            InitializeComponent();
            panel2.Visible = true;

            TowTicket tempTicket = new TowTicket();
            int ticketNumber = tempTicket.getTicketNum();

            // Display the generated ticket number in the UI
            TicketNum.Text = ticketNumber.ToString();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Gather information from UI controls
            string driverName = DriverName.Text;
            string truckNum = TruckNumBox.Text;
            string pickUpTime = PuTime.Text;
            string dropOffTime = DoTime.Text;
            string pickUpDate = PUDate.Text;
            string dropOffDate = DODate.Text;
            string pickUpLocation = PuLoc.Text;
            string dropOffLocation = DoLoc.Text;
            string customerName = custNameNT.Text;
            string customerEmail = custEmailNT.Text;
            string customerPhone = custPhoneNT.Text;

            double estimatedCost; 
            if(!double.TryParse(estCost.Text, out estimatedCost))
            {
                MessageBox.Show("Invalid estimated cost value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create TowTicket object using the constructor with parameters
            TowTicket ticket = new TowTicket(
                    int.Parse(TicketNum.Text),
                    driverName,
                    truckNum,
                    pickUpTime,
                    dropOffTime,
                    pickUpDate,
                    dropOffDate,
                    pickUpLocation,
                    dropOffLocation,
                    estimatedCost,
                    customerName,
                    customerEmail,
                    customerPhone
                );

            InsertTicketIntoDatabase(ticket);

            ClearUIControls();

            // Optionally, you can show a message indicating that the ticket has been saved successfully
            MessageBox.Show("Ticket saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void InsertTicketIntoDatabase(TowTicket ticket)
        {
            // SQL query to insert ticket information into the Tickets table
            string insertQuery = @"INSERT INTO Tickets (TicketNumber, DriverName, TruckNum, PickUpTime, DropOffTime, PickUpDate, DropOffDate, PickUpLocation, DropOffLocation, EstimatedCost, CustomerName, CustomerEmail, CustomerPhone)
                            VALUES (@TicketNumber, @DriverName, @TruckNum, @PickUpTime, @DropOffTime, @PickUpDate, @DropOffDate, @PickUpLocation, @DropOffLocation, @EstimatedCost, @CustomerName, @CustomerEmail, @CustomerPhone)";

            // Execute the query
            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    // Bind parameters
                    command.Parameters.AddWithValue("@TicketNumber", ticket.TicketNumber);
                    command.Parameters.AddWithValue("@DriverName", ticket.DriverName);
                    command.Parameters.AddWithValue("@TruckNum", ticket.TruckNum);
                    command.Parameters.AddWithValue("@PickUpTime", ticket.PickUpTime);
                    command.Parameters.AddWithValue("@DropOffTime", ticket.DropOffTime);
                    command.Parameters.AddWithValue("@PickUpDate", ticket.PickUpDate);
                    command.Parameters.AddWithValue("@DropOffDate", ticket.DropOffDate);
                    command.Parameters.AddWithValue("@PickUpLocation", ticket.PickUpLocation);
                    command.Parameters.AddWithValue("@DropOffLocation", ticket.DropOffLocation);
                    command.Parameters.AddWithValue("@EstimatedCost", ticket.EstimatedCost);
                    command.Parameters.AddWithValue("@CustomerName", ticket.CustomerName);
                    command.Parameters.AddWithValue("@CustomerEmail", ticket.CustomerEmail);
                    command.Parameters.AddWithValue("@CustomerPhone", ticket.CustomerPhone);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
        private void ClearUIControls()
        {
            TicketNum.Text = "";
            DriverName.Text = "";
            PuTime.Text = "";
            DoTime.Text = "";
            PUDate.Text = "";
            DODate.Text = "";
            PuLoc.Text = "";
            DoLoc.Text = "";
            estCost.Text = "";
            custNameNT.Text = "";
            custEmailNT.Text = "";
            custPhoneNT.Text = "";
        }
    }
}
