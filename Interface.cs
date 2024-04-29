using System.Collections.Generic;

namespace TruckTracking
{
    public interface ITruckCollection
    {
        List<Truck> Trucks { get; }
    }
    public class TruckManager : ITruckCollection
    {
        public List<Truck> Trucks { get; } = new List<Truck>();
    }
}
