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
        return Ok(_shiftService.GetAllShifts());
    }

    [HttpGet("{id}")]
    public ActionResult<Shift> GetShiftById(int id)
    {
        return Ok(_shiftService.GetShiftById(id));
    }

    [HttpPost]
    public ActionResult<Shift> CreateShift(Shift Shift)
    {
        return Ok(_shiftService.CreateShift(Shift));
    }

    [HttpPut("{id}")]
    public ActionResult<Shift> UpdateShift(int id, Shift updatedShift)
    {
        return Ok(_shiftService.UpdateShift(id, updatedShift));
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteShift(int id)
    {
        return Ok(_shiftService.DeleteShift(id));
    }
}


