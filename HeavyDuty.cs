using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class HeavyDuty : Truck
    {
        static int HourlyRate = 150;

        // Constructor
        public HeavyDuty(int truckNum, int hourlyRate, int mileage)
        : base(truckNum)
        {
            HourlyRate = hourlyRate;
            Mileage = mileage;
        }
    }
}
