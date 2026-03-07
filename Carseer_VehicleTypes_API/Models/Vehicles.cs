
namespace Carseer_VehicleTypes_API.Models
{
    public class Vehicles
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string? SearchCriteria { get; set; }
        public List<Vehicles_Details>? Results { get; set; }
    }

    public class Vehicles_Details{
        public long VehicleTypeId {get; set;}
        public string VehicleTypeName {get; set;}
    }
}