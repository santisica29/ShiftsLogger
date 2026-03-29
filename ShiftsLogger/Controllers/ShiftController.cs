using Azure;
using Microsoft.AspNetCore.Mvc;
using ShiftsLogger.Interfaces;
using ShiftsLogger.Models;

namespace ShiftsLogger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShiftController : Controller
{
    private readonly IShiftService _shiftService;
    public ShiftController(IShiftService shiftService)
    {
        _shiftService = shiftService;
    }

    [HttpGet]
    public ActionResult<List<Shift>> GetAllShifts()
    {
        var response = _shiftService.GetAllShifts();

        return response.IsSuccessful ? Ok(response) : BadRequest(response); 
    }

    [HttpGet("{id}")]
    public ActionResult<Shift> GetShiftById(int id)
    {
        var response = _shiftService.GetShiftById(id);

        return response.IsSuccessful ? Ok(response) : BadRequest(response);
    }

    [HttpPost]
    public ActionResult<Shift> CreateShift(Shift shift)
    {
        var response = _shiftService.CreateShift(shift);

        return response.IsSuccessful ? Ok(response) : BadRequest(response);
    }

    [HttpPut("{id}")]
    public ActionResult<Shift> UpdateShift(int id, ShiftDTO updatedShift)
    {
        var response = _shiftService.UpdateShift(id, updatedShift);

        return response.IsSuccessful ? Ok(response) : BadRequest(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteShift(int id)
    {
        var response = _shiftService.DeleteShift(id);

        return response.IsSuccessful ? Ok(response) : BadRequest(response);
    }
}


