using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class Flatbed : Truck
    {
        int HourlyRate;

        // Constructor
        public Flatbed(int truckNum, int hourlyRate, int mileage)
        : base(truckNum)
        {
            HourlyRate = hourlyRate;
            Mileage = mileage;
        }
    }
}
