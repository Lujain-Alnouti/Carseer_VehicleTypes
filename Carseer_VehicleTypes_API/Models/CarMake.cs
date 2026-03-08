
namespace Carseer_VehicleTypes_API.Models
{
    public class CarMake
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string? SearchCriteria { get; set; }
        public List<CarMake_Details>? Results { get; set; }
    }

    public class CarMake_Details{
        public long make_ID {get; set;}
        public string make_Name {get; set;}
    }
}