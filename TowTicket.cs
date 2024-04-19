using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTracking
{
    internal class TowTicket
    {
        int TicketNumber;
        string DriverName;
        string PickUpTime;
        string DropOffTime;
        string PickUpLocation;
        string DropOffLocation;
        double EstimatedCost;
        string CustomerName;
        string CustomerEmail;
        string CustomerPhone;
        List<bool> StatusList;


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
    }
}
