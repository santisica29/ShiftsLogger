namespace ShiftsLogger.Models;

public class Shift
{
    public int Id { get; set; }
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
    public required TimeSpan Duration { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public TimeSpan CalculateDuration()
    {
        return EndTime - StartTime;
    }

    // validate inside a setter?

}
