using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class Flatbed : Truck
    {
        public static double HourlyRate { get; } = 100.00;

        // Constructor
        public Flatbed(int truckNum, double hourlyRate, int mileage)
        : base(truckNum)
        {
            Mileage = mileage;
        }
        public override double getTicketCost(double TicketTime)
        {
            // Calculate ticket cost for Flatbed
            // Eventually would add in drivers w/ their hourly cost to add in
            return TicketTime * HourlyRate;
        }
    }
}
