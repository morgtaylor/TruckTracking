using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using Newtonsoft.Json;


namespace TruckTracking
{
    internal class TicketDatabase
    {
        internal static void InsertTicketIntoDatabase(TowTicket ticket)
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
        internal static void UpdateTicketInDatabase(TowTicket editedTicket)
        {
            string updateQuery = @"UPDATE Tickets 
                       SET DriverName = @DriverName, 
                           TruckNum = @TruckNum, 
                           PickUpTime = @PickUpTime, 
                           DropOffTime = @DropOffTime, 
                           PickUpDate = @PickUpDate, 
                           DropOffDate = @DropOffDate, 
                           PickUpLocation = @PickUpLocation, 
                           DropOffLocation = @DropOffLocation, 
                           EstimatedCost = @EstimatedCost, 
                           CustomerName = @CustomerName, 
                           CustomerEmail = @CustomerEmail, 
                           CustomerPhone = @CustomerPhone
                       WHERE TicketNumber = @TicketNumber";

            // Execute the query
            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    // Bind parameters
                    command.Parameters.AddWithValue("@TicketNumber", editedTicket.TicketNumber);
                    command.Parameters.AddWithValue("@DriverName", editedTicket.DriverName);
                    command.Parameters.AddWithValue("@TruckNum", editedTicket.TruckNum);
                    command.Parameters.AddWithValue("@PickUpTime", editedTicket.PickUpTime);
                    command.Parameters.AddWithValue("@DropOffTime", editedTicket.DropOffTime);
                    command.Parameters.AddWithValue("@PickUpDate", editedTicket.PickUpDate);
                    command.Parameters.AddWithValue("@DropOffDate", editedTicket.DropOffDate);
                    command.Parameters.AddWithValue("@PickUpLocation", editedTicket.PickUpLocation);
                    command.Parameters.AddWithValue("@DropOffLocation", editedTicket.DropOffLocation);
                    command.Parameters.AddWithValue("@EstimatedCost", editedTicket.EstimatedCost);
                    command.Parameters.AddWithValue("@CustomerName", editedTicket.CustomerName);
                    command.Parameters.AddWithValue("@CustomerEmail", editedTicket.CustomerEmail);
                    command.Parameters.AddWithValue("@CustomerPhone", editedTicket.CustomerPhone);
                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
