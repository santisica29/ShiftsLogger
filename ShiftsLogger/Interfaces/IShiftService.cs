using ShiftsLogger.Models;
using ShiftsLogger.Services;

namespace ShiftsLogger.Interfaces;
public interface IShiftService
{
    public ServiceResponse<List<Shift>> GetAllShifts();
    public ServiceResponse<Shift> GetShiftById(int id);
    public ServiceResponse<Shift> CreateShift(Shift shift);
    public ServiceResponse UpdateShift(int id, ShiftDTO updatedShift);
    public ServiceResponse DeleteShift(int id);
}
