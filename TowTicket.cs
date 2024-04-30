using System;
using System.Data.SQLite;

namespace TruckTracking
{
    public class TowTicket
    {
        // Properties
        public int TicketNumber { get; }
        public string DriverName { get; internal set; }
        public int TruckNum { get; internal set; }
        public string PickUpTime { get; internal set; }
        public string DropOffTime { get; internal set; }
        public string PickUpDate { get; internal set; }
        public string DropOffDate { get; internal set; }
        public string PickUpLocation { get; internal set; }
        public string DropOffLocation { get; internal set; }
        public double EstimatedCost { get; internal set; }
        public string CustomerName { get; internal set; }
        public string CustomerEmail { get; internal set; }
        public string CustomerPhone { get; internal set; }

        //Parameterized Constructor
        public TowTicket(int ticketNumber, string driverName, string truckNum, string pickUpTime, string dropOffTime, string pickUpDate, string dropOffDate, string pickUpLocation, string dropOffLocation, double estimatedCost, string customerName, string customerEmail, string customerPhone)
        {
            TicketNumber = ticketNumber;
            DriverName = driverName;
            TruckNum = Convert.ToInt32(truckNum);
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
        }
        //Empty Constructor
        public TowTicket()
        {

        }
        //method to get ticket number for new tickets
        public int getTicketNum()
        {
            int nextTicketNum = 1;
            try
            {
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
            }
            catch (Exception ex)
            {
                // Handle exceptions here (e.g., log error, display error message)
                Console.WriteLine($"Error retrieving next ticket number: {ex.Message}");
            }
            return nextTicketNum;
        }
    }
}
