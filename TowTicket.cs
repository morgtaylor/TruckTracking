using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    
    public class TowTicket
    {
        // Properties
        public int TicketNumber { get; private set; }
        public string DriverName { get; }
        public string TruckNum { get; }
        public string PickUpTime { get; }
        public string DropOffTime { get; }
        public string PickUpDate { get; }
        public string DropOffDate { get; }
        public string PickUpLocation { get; }
        public string DropOffLocation { get; }
        public double EstimatedCost { get; }
        public string CustomerName { get; }
        public string CustomerEmail { get; }
        public string CustomerPhone { get; }
        public List<bool> StatusList { get; }

        //Parameterized Constructor
        public TowTicket(int ticketNumber, string driverName, string truckNum, string pickUpTime, string dropOffTime, string pickUpDate, string dropOffDate, string pickUpLocation, string dropOffLocation, double estimatedCost, string customerName, string customerEmail, string customerPhone)
        {
            TicketNumber = ticketNumber;
            DriverName = driverName;
            TruckNum = truckNum;
            PickUpTime = pickUpTime;
            DropOffTime = dropOffTime;
            PickUpDate = pickUpDate;
            DropOffDate = dropOffDate;
            PickUpLocation = pickUpLocation;
            DropOffLocation = dropOffLocation;
            EstimatedCost = estimatedCost;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
            StatusList = new List<bool>();
        }
        //Empty Constructor
        public TowTicket()
        {

        }
        //method to get ticket number for new tickets
        public int getTicketNum()
        {
            int nextTicketNum = 1;

            // SQL query to select the maximum ticket number from the Tickets table
            string selectMaxTicketNumQuery = "SELECT MAX(TicketNumber) FROM Tickets";

            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(selectMaxTicketNumQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        // If there are existing tickets, increment the maximum ticket number
                        nextTicketNum = Convert.ToInt32(result) + 1;
                    }
                }
            }

            return nextTicketNum;
        }
    }
}
