
namespace Carseer_VehicleTypes_API.Models
{
    public class CarModels
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string? SearchCriteria { get; set; }
        public List<CarModels_Details>? Results { get; set; }
    }

    public class CarModels_Details{
        public long Make_ID {get; set;}
        public string Make_Name {get; set;}
         public long Model_ID {get; set;}
        public string Model_Name {get; set;}
    }
}