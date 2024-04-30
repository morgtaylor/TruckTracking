using System;

namespace TruckTracking
{
    public class Truck
    {
        public int TruckNum { get; }
        public int Mileage { get; set; }
        internal DateTime LastServiceDate { get; set; }
        public string VIN { get; set; }
        public int EmptyWeight { get; set; }
        public Truck(int truckNum)
        {
            TruckNum = truckNum;
        }
        public void UpdateMileage(int newMileage)
        {
            Mileage = newMileage;
        }
        public virtual double getTicketCost(double TicketTime)
        {
            throw new NotImplementedException("GetTicketCost method is not implemented for generic truck.");
        }
        public virtual double getTicketCost(double TicketTime, int newMileage)
        {
            throw new NotImplementedException("GetTicketCost method is not implemented for generic truck.");

        }
    }
}
