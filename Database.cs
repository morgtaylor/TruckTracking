using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace TruckTracking
{
    internal class Database
    {
        internal static string connectionString = $"Data Source=..\\..\\Files\\TicketTracking.db;Version=3;";

        public static void InitializeDatabase()
        {
            string dbFilePath = @"..\..\Files\TicketTracking.db";

            if (!File.Exists(dbFilePath))
            {
                Console.WriteLine("Database file does not exist. Creating a new database file.");

                SQLiteConnection.CreateFile(dbFilePath);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Create Tickets table
                    string createTicketTableQuery = @"CREATE TABLE IF NOT EXISTS Tickets (
                                                TicketNumber INTEGER PRIMARY KEY,
                                                DriverName TEXT,
                                                TruckNum TEXT,
                                                PickUpTime TEXT,
                                                DropOffTime TEXT,
                                                PickUpDate TEXT,
                                                DropOffDate TEXT,
                                                PickUpLocation TEXT,
                                                DropOffLocation TEXT,
                                                EstimatedCost REAL,
                                                CustomerName TEXT,
                                                CustomerEmail TEXT,
                                                CustomerPhone TEXT
                                              );";

                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createTicketTableQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static TowTicket GetTicketFromDatabase(int ticketNumber)
        {
            // Define the SQL query to retrieve ticket information based on the ticket number
            string selectQuery = "SELECT * FROM Tickets WHERE TicketNumber = @TicketNumber";

            // Create a new TowTicket object to hold the retrieved ticket information
            TowTicket ticket = null;

            // Establish a connection to the database
            using (var connection = new SQLiteConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a command with the select query and parameters
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    // Add the ticket number parameter to the command
                    command.Parameters.AddWithValue("@TicketNumber", ticketNumber);

                    // Execute the query and read the results
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if there are any rows returned
                        if (reader.Read())
                        {
                            // Create a new TowTicket object with the retrieved data
                            ticket = new TowTicket(
                                Convert.ToInt32(reader["TicketNumber"]),
                                Convert.ToString(reader["DriverName"]),
                                Convert.ToString(reader["TruckNum"]),
                                Convert.ToString(reader["PickUpTime"]),
                                Convert.ToString(reader["DropOffTime"]),
                                Convert.ToString(reader["PickUpDate"]),
                                Convert.ToString(reader["DropOffDate"]),
                                Convert.ToString(reader["PickUpLocation"]),
                                Convert.ToString(reader["DropOffLocation"]),
                                Convert.ToDouble(reader["EstimatedCost"]),
                                Convert.ToString(reader["CustomerName"]),
                                Convert.ToString(reader["CustomerEmail"]),
                                Convert.ToString(reader["CustomerPhone"])
                            );
                        }
                    }
                }
            }
            // Return the retrieved ticket (or null if not found)
            return ticket;
        }
    }
}
