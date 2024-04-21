using System;
using System.Collections.Generic;
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
            
            double estimatedCost = 0;

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
            TowTicket ticket = new TowTicket(int.Parse(TicketNum.Text), driverName, pickUpTime, dropOffTime, pickUpLocation, dropOffLocation, estimatedCost, customerName, customerEmail, customerPhone);

            ClearUIControls();

            // Optionally, you can show a message indicating that the ticket has been saved successfully
            MessageBox.Show("Ticket saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
