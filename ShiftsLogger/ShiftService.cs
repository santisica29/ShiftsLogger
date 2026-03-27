using ShiftsLogger.Data;
using ShiftsLogger.Interfaces;
using ShiftsLogger.Models;

namespace ShiftsLogger;

public class ShiftService : IShiftService
{
    private readonly ShiftsLoggerDbContext _dbContext;

    public ShiftService(ShiftsLoggerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Shift CreateShift(Shift Shift)
    {
        var savedShift = _dbContext.Shifts.Add(Shift);
        _dbContext.SaveChanges();
        return savedShift.Entity;
    }

    public string? DeleteShift(int id)
    {
        Shift? savedShift = _dbContext.Shifts.Find(id);

        if (savedShift == null)
            return null;

        _dbContext.Shifts.Remove(savedShift);
        _dbContext.SaveChanges();

        return $"Successfully deleted shift with id {id}";
    }

    public List<Shift> GetAllShifts()
    {
        return _dbContext.Shifts.ToList();
    }

    public Shift? GetShiftById(int id)
    {
        return _dbContext.Shifts.Find(id);
    }

    public Shift UpdateShift(int id, Shift updatedShift)
    {
        Shift? savedShift = _dbContext.Shifts.Find(id);

        if (savedShift == null)
            return null;

        _dbContext.Entry(savedShift).CurrentValues.SetValues(updatedShift);
        _dbContext.SaveChanges();

        return savedShift;
    }
}
