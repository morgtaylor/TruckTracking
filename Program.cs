using System;
using System.Windows.Forms;

namespace TruckTracking
{
    internal static class Program
    {
        public static ITruckCollection truckManager { get; } = new TruckManager();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            // Creating instance of Flatbed with truck number 8
            Flatbed flatbed1 = new Flatbed(8, Flatbed.HourlyRate, 50000);
            flatbed1.LastServiceDate = new DateTime(2023, 5, 10);
            flatbed1.VIN = "ABC123";
            flatbed1.EmptyWeight = 12000;
            truckManager.Trucks.Add(flatbed1);

            // Creating instance of Flatbed with truck number 10
            Flatbed flatbed2 = new Flatbed(10, Flatbed.HourlyRate, 60000);
            flatbed2.LastServiceDate = new DateTime(2023, 6, 15);
            flatbed2.VIN = "XYZ789";
            flatbed2.EmptyWeight = 11500;
            truckManager.Trucks.Add(flatbed2);

            // Creating instance of Semi with truck number 14
            Semi semi1 = new Semi(14, true, 240000, Semi.MileageRate);
            semi1.LastServiceDate = new DateTime(2023, 6, 15);
            semi1.VIN = "PQR765";
            semi1.EmptyWeight = 14500;
            truckManager.Trucks.Add(semi1);

            // Creating instance of HeavyDuty with truck number 3
            HeavyDuty heavyduty1 = new HeavyDuty(3, HeavyDuty.HourlyRate, 150000);
            heavyduty1.LastServiceDate = new DateTime(2023, 6, 15);
            heavyduty1.VIN = "XYZ789";
            heavyduty1.EmptyWeight = 16500;
            truckManager.Trucks.Add(heavyduty1);

            // Creating instance of HeavyDuty with truck number 13
            HeavyDuty heavyduty2 = new HeavyDuty(13, HeavyDuty.HourlyRate, 150000);
            heavyduty2.LastServiceDate = new DateTime(2023, 6, 15);
            heavyduty2.VIN = "XYZ789";
            heavyduty2.EmptyWeight = 16500;
            truckManager.Trucks.Add(heavyduty2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.InitializeDatabase();

            Application.Run(new TowsWindow(truckManager));
        }
    }
}
