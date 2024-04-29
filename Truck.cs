using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TruckTracking
{
    public class Truck
    {
        public IEnumerable<Truck> truckCollection;

        public int TruckNum { get; set; }
        public int Mileage { get; set; }
        public int TicketTime { get; set; }
        public DateTime LastServiceDate { get; set; }
        public string VIN { get; set; }
        public int EmptyWeight { get; set; }
        public double TicketCost { get; set; }
        public Truck(int truckNum)
        {
            TruckNum = truckNum;
        }
        public void UpdateMileage(int newMileage)
        {
            Mileage = newMileage;
        }
        public void UpdateMileage(int truckNum, int newMileage)
        {
            // Find the truck corresponding to the truck number
            Truck truck = truckCollection.FirstOrDefault(t => t.TruckNum == truckNum);

            if (truck != null)
            {
                // Update the mileage of the truck
                truck.Mileage = newMileage;
            }
            else
            {
                MessageBox.Show("Truck not found for the provided truck number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
