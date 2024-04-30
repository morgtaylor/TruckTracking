using System;
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
        
    }
}
