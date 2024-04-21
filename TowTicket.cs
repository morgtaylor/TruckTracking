using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    
    internal class TowTicket
    {
        private static int oldTicketNum = 0;

        // Properties
        public int TicketNumber { get; private set; }
        public string DriverName { get; }
        public string PickUpTime { get; }
        public string DropOffTime { get; }
        public string PickUpLocation { get; }
        public string DropOffLocation { get; }
        public double EstimatedCost { get; }
        public string CustomerName { get; }
        public string CustomerEmail { get; }
        public string CustomerPhone { get; }
        public List<bool> StatusList { get; }


        public TowTicket(int ticketNumber, string driverName, string pickUpTime, string dropOffTime, string pickUpLocation, string dropOffLocation, double estimatedCost, string customerName, string customerEmail, string customerPhone)
        {
            TicketNumber = ticketNumber;
            DriverName = driverName;
            PickUpTime = pickUpTime;
            DropOffTime = dropOffTime;
            PickUpLocation = pickUpLocation;
            DropOffLocation = dropOffLocation;
            EstimatedCost = estimatedCost;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
            StatusList = new List<bool>();
        }
        public TowTicket()
        {
        }
        public int getTicketNum()
        {
            oldTicketNum++;
            return oldTicketNum;
        }
    }
}
