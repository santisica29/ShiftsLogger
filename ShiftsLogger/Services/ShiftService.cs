using Humanizer;
using ShiftsLogger.Data;
using ShiftsLogger.Interfaces;
using ShiftsLogger.Models;

namespace ShiftsLogger.Services;

public class ShiftService : IShiftService
{
    private readonly ShiftsLoggerDbContext _dbContext;

    public ShiftService(ShiftsLoggerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ServiceResponse<Shift> CreateShift(Shift shift)
    {
        if (shift.EndTime <= shift.StartTime)
            return ServiceResponse<Shift>.Failure("End time must be after start time");

        var savedShift = _dbContext.Shifts.Add(shift);
        _dbContext.SaveChanges();

        return ServiceResponse<Shift>.Success(savedShift.Entity, $"Shift with Id {shift.Id} created successfully");
    }

    public ServiceResponse DeleteShift(int id)
    {
        Shift? savedShift = _dbContext.Shifts.Find(id);

        if (savedShift == null)
            return ServiceResponse.Failure($"Shift with Id {id} doesn't exists.");

        _dbContext.Shifts.Remove(savedShift);
        _dbContext.SaveChanges();

        return ServiceResponse.Success($"Successfully deleted shift with id {id}");
    }

    public ServiceResponse<List<Shift>> GetAllShifts()
    {
        var list = _dbContext.Shifts.ToList();

        if (list.Count == 0)
            return ServiceResponse<List<Shift>>.Failure("No data");

        return ServiceResponse<List<Shift>>.Success(list, "Success");
    }

    public ServiceResponse<Shift> GetShiftById(int id)
    {
        var shift = _dbContext.Shifts.Find(id);

        if (shift == null)
            return ServiceResponse<Shift>.Failure($"No shift found with id {id}");

        return ServiceResponse<Shift>.Success(shift, "Shift retrieve correctly");
    }

    public ServiceResponse UpdateShift(int id, ShiftDTO updatedShift)
    {
        Shift? savedShift = _dbContext.Shifts.Find(id);

        if (savedShift == null)
            return ServiceResponse.Failure($"Shift with id {id} not found.");

        if (updatedShift.EndTime <= updatedShift.StartTime)
            return ServiceResponse<Shift>.Failure("End time must be after start time");

        savedShift.UpdateTimes(updatedShift.StartTime, updatedShift.EndTime);

        _dbContext.SaveChanges();

        return ServiceResponse.Success($"Shift with id {id} updated!.");
    }
}
