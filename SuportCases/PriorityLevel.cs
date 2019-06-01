namespace CarService
{
    public class Points
    {
        public enum WaitingTime
        {
            Scheduled = 16,
            Delegated = 8,
            Deadline = 4,
            Urgent = 2
        }
        readonly WaitingTime Priority;

        Points(WaitingTime points)
        {
            Priority = points;
        }

        public static WaitingTime GetPriorityLevel(string pointsPriority)
        {
            switch (pointsPriority.ToLower().Trim())
            {
                case "urgent":
                    return Points.WaitingTime.Urgent;
                case "deadLine":
                    return Points.WaitingTime.Deadline;
                case "delegated":
                    return Points.WaitingTime.Delegated;
            }
            return Points.WaitingTime.Scheduled;
        }
    }
}