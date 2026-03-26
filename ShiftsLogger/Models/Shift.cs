namespace ShiftsLogger.Models;

public class Shift
{
    public int Id { get; set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public TimeSpan Duration { get; private set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public Shift(DateTime startTime, DateTime endTime, int employeeId)
    {
        SetTimes(startTime, endTime);
        EmployeeId = employeeId;
    }

    public void UpdateTimes(DateTime start, DateTime end)
    {
        SetTimes(start, end);
    }

    private void SetTimes(DateTime start, DateTime end)
    {
        if (end < start)
            throw new ArgumentException("End time can't be before start time");

        if (end == start)
            throw new ArgumentException("times cannot be equal");

        StartTime = start;
        EndTime = end;
        Duration = end - start;
    }

}
