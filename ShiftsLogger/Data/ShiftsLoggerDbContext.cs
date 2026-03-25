using Microsoft.EntityFrameworkCore;
using ShiftsLogger.Models;

namespace ShiftsLogger.Data;
public class ShiftsLoggerDbContext : DbContext
{
    public ShiftsLoggerDbContext(DbContextOptions<ShiftsLoggerDbContext> options) : base(options)
    {

    }

    public DbSet<Shift> Shifts { get; set; }
    public DbSet<Employee> Employees { get; set; }

}
