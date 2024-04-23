using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class Semi : Truck
    {
        public bool RequireTrailer { get; set; }
        public static int MileageRate { get; } = 5;

        // Constructor
        public Semi(int truckNum, bool requireTrailer, int mileage)
        : base(truckNum)
        {
            RequireTrailer = requireTrailer;
            Mileage = mileage; // Initialize mileage specific to Semi class
        }
    }
}
