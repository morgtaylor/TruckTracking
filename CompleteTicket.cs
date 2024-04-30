using System;
using System.Linq;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class CompleteTicket : Form
    {
        private TowTicket ticket { get; set; }
        private double ticketTime;
        private readonly ITruckCollection truckManager;
        public CompleteTicket(int ticketNumber, ITruckCollection truckManager)
        {
            InitializeComponent();
            this.truckManager = truckManager;
            // Retrieve the ticket object using the ticket number
            ticket = TicketDatabase.GetTicketFromDatabase(ticketNumber);
            CTTicketNum.Text = ticket.TicketNumber.ToString();
            CTTruckNum.Text = ticket.TruckNum.ToString();
        }

        private void CloseTicket_Click(object sender, EventArgs e)
        {
            // Retrieve additional data from form controls
            int truckMileage = Convert.ToInt32(CTTruckMileage.Text);
            // Update the mileage for the truck associated with the ticket
            UpdateTruckMileage(ticket.TruckNum, truckMileage);
            // Close the form
            this.Close();
        }
        private void UpdateTruckMileage(int truckNum, int newMileage)
        {
            // Find the truck corresponding to the truck number
            Truck truck = truckManager.Trucks.FirstOrDefault(t => t.TruckNum == truckNum);

            if (truck != null)
            {
                // Update the mileage of the truck
                truck.UpdateMileage(newMileage);
            }
            else
            {
                MessageBox.Show("Truck not found for the provided truck number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CTTruckMileage_LoadClick(object sender, EventArgs e)
        {
            int truckNum = ticket.TruckNum;
            // Calculate actual cost based on the specific truck subclass
            double actualCost = CalcTicketCost(truckNum);
            CTActCost.Text = actualCost.ToString();
        }
        private double CalcTicketCost(int truckNum)
        {
            int newMiles = int.Parse(CTTruckMileage.Text);
            ticketTime = double.Parse(CTTime.Text);
            // Find the truck corresponding to the truck number
            Truck truck = truckManager.Trucks.FirstOrDefault(t => t.TruckNum == truckNum);

            if (truckNum != 14)
            {
                // Call the appropriate method to calculate the ticket cost based on the truck subclass
                return truck.getTicketCost(ticketTime);
            }
            else
            {
                return truck.getTicketCost(ticketTime, newMiles);

            }
        }
    }
}