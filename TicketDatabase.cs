using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
