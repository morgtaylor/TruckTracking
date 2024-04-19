using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class NewTicketWindow : Form
    {
        public Panel Panel2 { get { return panel2; } }

        public NewTicketWindow()
        {
            InitializeComponent();
            panel2.Visible = true;
        }
        private Dictionary<int, TowTicket> ticketDictionary = new Dictionary<int, TowTicket>(); // Declaration of the dictionary
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int ticketNumber;
            double estimatedCost;

            if (!int.TryParse(TicketNum.Text, out ticketNumber) || !double.TryParse(estCost.Text, out estimatedCost))
            {
                MessageBox.Show("Please enter valid values for ticket number and estimated cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ticketDictionary.ContainsKey(ticketNumber))
            {
                MessageBox.Show("Ticket number already exists. Please enter a unique ticket number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gather information from UI controls
            string driverName = DriverName.Text;
            string pickUpTime = PuTime.Text;
            string dropOffTime = DoTime.Text;
            string puDate = PUDate.Text;
            string doDate = DODate.Text;
            string pickUpLocation = PuLoc.Text;
            string dropOffLocation = DoLoc.Text;
            string customerName = custNameNT.Text;
            string customerEmail = custEmailNT.Text;
            string customerPhone = custPhoneNT.Text;

            // Create TowTicket object using the constructor with parameters
            TowTicket ticket = new TowTicket(ticketNumber, driverName, pickUpTime, dropOffTime, pickUpLocation, dropOffLocation, estimatedCost, customerName, customerEmail, customerPhone);

            // Add the ticket to the dictionary with ticketNumber as the key
            ticketDictionary.Add(ticketNumber, ticket);

            // Optionally, you can clear the UI controls after saving the ticket
            ClearUIControls();

            // Optionally, you can show a message indicating that the ticket has been saved successfully
            MessageBox.Show("Ticket saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
