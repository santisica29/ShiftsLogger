using ShiftsLogger.Models;
using ShiftsLogger.Services;

namespace ShiftsLogger.Interfaces;
public interface IShiftService
{
    public ServiceResponse<List<Shift>> GetAllShifts();
    public ServiceResponse<Shifts> GetShiftById(int id);
    public ServiceResponse<Shift> CreateShift(Shift Shift);
    public ServiceResponse<Shift> UpdateShift(int id, Shift updatedShift);
    public ServiceResponse DeleteShift(int id);
}
