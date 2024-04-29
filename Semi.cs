namespace TruckTracking
{
    internal class Semi : Truck
    {
        public bool RequireTrailer { get; set; }
        public static int MileageRate { get; } = 5;

        // Constructor
        public Semi(int truckNum, bool requireTrailer, int mileage, int mileageRate)
        : base(truckNum)
       {
            RequireTrailer = requireTrailer;
            Mileage = mileage; // Initialize mileage specific to Semi class
        }
        public override double getTicketCost(double TicketTime, int newMileage)
        {
        // Calculate ticket cost for Semi
        // Eventually would add in drivers w/ their hourly cost to add in
            return newMileage * MileageRate;
        }
    }
}
