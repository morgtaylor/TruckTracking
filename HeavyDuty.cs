using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class HeavyDuty : Truck
    {
        public static double HourlyRate { get; } = 200.00;
        // Constructor
        public HeavyDuty(int truckNum, double hourlyRate, int mileage)
        : base(truckNum)
        {
            Mileage = mileage;
        }
        public override double getTicketCost(double TicketTime)
        {
            // Calculate ticket cost for HeavyDuty
            // Eventually would add in drivers w/ their hourly cost to add in
            return TicketTime * HourlyRate;
        }
    }
}
