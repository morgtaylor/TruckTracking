using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class Truck
    {
        public int TruckNum { get; set; }
        public int Mileage { get; set; }
        public DateTime LastServiceDate { get; set; }
        public string VIN { get; set; }
        public int EmptyWeight { get; set; }
        public int LoadedWeight { get; set; }
        public string Status { get; set; }

        public Truck(int truckNum)
        {
            TruckNum = truckNum;
        }
    }
}
