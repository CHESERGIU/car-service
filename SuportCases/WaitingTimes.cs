namespace CarService
{
    [System.Flags]
    public enum WaitingTimes
    {
        None,
        Scheduled,
        Delegated,
        DeadLine,
        Urgent
    }
}