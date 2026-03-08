
namespace Carseer_VehicleTypes_API.Models
{
    public class Vehicles
    {
        public int count { get; set; }
        public string message { get; set; }
        public string? searchCriteria { get; set; }
        public List<Vehicles_Details>? results { get; set; }
    }

    public class Vehicles_Details{
        public long VehicleTypeId {get; set;}
        public string VehicleTypeName {get; set;}
    }
}