namespace CarService
{
    [System.Flags]
    public enum WaitingTimes
    {
        None = 0,
        Scheduled = 16,
        Delegated = 8,
        DeadLine = 4,
        Urgent = 2
    }
}