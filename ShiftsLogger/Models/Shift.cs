namespace ShiftsLogger.Models;

public class Shift
{
    public int Id { get; set; }
    public required Employee Employee { get; set; }
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
}
