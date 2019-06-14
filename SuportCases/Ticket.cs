namespace CarService
{
    public class Ticket
    {
        internal readonly string Id;
        internal readonly string Problem;
        internal readonly WaitingTimes Priority;

        public Ticket(string id, string problem, WaitingTimes priority)
        {
            this.Id = id;
            this.Problem = problem;
            this.Priority = priority;
        }

        private WaitingTimes GetWaitingTime(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "urgent":
                    return WaitingTimes.Urgent;
                case "deadline":
                    return WaitingTimes.DeadLine;
                case "delegated":
                    return WaitingTimes.Delegated;
            }

            return WaitingTimes.Scheduled;
        }
    }
}