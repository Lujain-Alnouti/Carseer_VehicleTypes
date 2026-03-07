using System.Net.Http;
using System.Threading.Tasks;
using Carseer_VehicleTypes_API.Models;
public class VehicleService
{
    private readonly HttpClient _httpClient;

    public VehicleService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

public async Task<CarMake> GetAllMakes()
{
    var response = await _httpClient.GetAsync("https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json");

    response.EnsureSuccessStatusCode();

    var result = await response.Content.ReadFromJsonAsync<CarMake>();

    return result;
}

public async Task<Vehicles> GetAllVehicles_ByMakeId(int MakeId)
{
    var response = await _httpClient.GetAsync($"https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{MakeId}?format=json");

    response.EnsureSuccessStatusCode();

    var result = await response.Content.ReadFromJsonAsync<Vehicles>();

    return result;
}
public async Task<CarModels> GetAllModels_ByMakeId(int MakeId,int Year)
{
    var response = await _httpClient.GetAsync($"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{MakeId}/modelyear/{Year}?format=json ");

    response.EnsureSuccessStatusCode();

    var result = await response.Content.ReadFromJsonAsync<CarModels>();

    return result;
}
}