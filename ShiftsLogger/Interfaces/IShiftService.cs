using ShiftsLogger.Models;

namespace ShiftsLogger.Interfaces;
public interface IShiftService
{
    public List<Shift> GetAllShifts();
    public Shift? GetShiftById(int id);
    public Shift CreateShift(Shift Shift);
    public Shift UpdateShift(int id, Shift updatedShift);
    public string? DeleteShift(int id);
}
