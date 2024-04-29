using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class NewTicketWindow : Form
    {
        private TowTicket editedTicket { get; set; }
        private readonly ITruckCollection truckManager;
        public NewTicketWindow(ITruckCollection truckManager)
        {
            InitializeComponent();
            NTWPanel1.Visible = true;
            this.truckManager = truckManager;
            // Get Ticket Number
            TowTicket tempTicket = new TowTicket();
            int ticketNumber = tempTicket.getTicketNum();
            TicketNum.Text = ticketNumber.ToString();
        }
        // Constructor for editing an existing ticket
        public NewTicketWindow(TowTicket ticketToEdit, ITruckCollection truckManager) : this(truckManager)
        {
            // Store the ticket being edited
            editedTicket = ticketToEdit;
            PopulateUIToEditTicket();

        }
        private void PopulateUIToEditTicket()
        {
            // Populate UI controls with existing ticket information
            TicketNum.Text = editedTicket.TicketNumber.ToString();
            DriverName.Text = editedTicket.DriverName;
            TruckNumBox.Text = Convert.ToString(editedTicket.TruckNum);
            PuTime.Text = editedTicket.PickUpTime;
            DoTime.Text = editedTicket.DropOffTime;
            PUDate.Text = editedTicket.PickUpDate;
            DODate.Text = editedTicket.DropOffDate;
            PuLoc.Text = editedTicket.PickUpLocation;
            DoLoc.Text = editedTicket.DropOffLocation;
            estCost.Text = editedTicket.EstimatedCost.ToString();
            custNameNT.Text = editedTicket.CustomerName;
            custEmailNT.Text = editedTicket.CustomerEmail;
            custPhoneNT.Text = editedTicket.CustomerPhone;
        }
        internal void SaveButton_Click(object sender, EventArgs e)
        {
            // Implement saving logic for both new tickets and edited tickets
            if (editedTicket != null)
            {
                // Update existing ticket
                UpdateExistingTicket();
            }
            else
            {
                // Save new ticket
                SaveNewTicket();
            }
        }

        // Method to save a new ticket
        private void SaveNewTicket()
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
            if (!double.TryParse(estCost.Text, out estimatedCost))
            {
                MessageBox.Show("Invalid estimated cost value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new TowTicket object using the constructor with parameters
            TowTicket newTicket = new TowTicket(
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
            // Insert the new ticket into the database
            TicketDatabase.InsertTicketIntoDatabase(newTicket);
            // Clear UI controls
            ClearUIControls();
            // Show a success message
            MessageBox.Show("New ticket saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        // Method to update an existing ticket
        private void UpdateExistingTicket()
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
            if (!double.TryParse(estCost.Text, out estimatedCost))
            {
                MessageBox.Show("Invalid estimated cost value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the editedTicket properties with the new values
            editedTicket.DriverName = driverName;
            editedTicket.TruckNum = Convert.ToInt32(truckNum);
            editedTicket.PickUpTime = pickUpTime;
            editedTicket.DropOffTime = dropOffTime;
            editedTicket.PickUpDate = pickUpDate;
            editedTicket.DropOffDate = dropOffDate;
            editedTicket.PickUpLocation = pickUpLocation;
            editedTicket.DropOffLocation = dropOffLocation;
            editedTicket.EstimatedCost = estimatedCost;
            editedTicket.CustomerName = customerName;
            editedTicket.CustomerEmail = customerEmail;
            editedTicket.CustomerPhone = customerPhone;

            // Update the ticket in the database
            TicketDatabase.UpdateTicketInDatabase(editedTicket);

            // Clear UI controls
            ClearUIControls();

            // Show a success message
            MessageBox.Show("Ticket updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            // Retrieve the ticket number of the current ticket
            int ticketNumber = int.Parse(TicketNum.Text);
            // Create an instance of the completeTicket form
            CompleteTicket completeTicketForm = new CompleteTicket(ticketNumber, truckManager);
            // Show the completeTicket form
            completeTicketForm.Show();
            this.Close();
        }
    }
}
