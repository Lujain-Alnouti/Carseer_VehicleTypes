using Microsoft.AspNetCore.Mvc;
using Carseer_VehicleTypes_API.Models;
namespace Carseer_VehicleTypes_API.Controller{

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
 private readonly VehicleService _vehicleService;

    public VehiclesController(VehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpGet("Makes")]
    public async Task<IActionResult> GetMakes()
    {
        CarMake result = new CarMake();
         result = await _vehicleService.GetAllMakes();

        return Ok(result);
    }

     [HttpGet("Vehicles")]
    public async Task<IActionResult> GetVehicles_ByMakeId(int MakeId)
    {
        Vehicles result = new Vehicles();
        
         result = await _vehicleService.GetAllVehicles_ByMakeId(MakeId);

        return Ok(result);
    }
    
         [HttpGet("CarModels")]
    public async Task<IActionResult> GetAllModels_ByMakeId(int MakeId,int Year)
    {
        CarModels result = new CarModels();
         result = await _vehicleService.GetAllModels_ByMakeId(MakeId,Year);

        return Ok(result);
    }
}

}