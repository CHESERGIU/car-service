namespace CarService
{
    public class Ticket
    {
        private readonly string carNumber;
        private readonly string problem;
        private readonly WaitingTimes priority;

        public Ticket(string id, string problem, WaitingTimes priority)
        {
            this.carNumber = id;
            this.problem = problem;
            this.priority = priority;
        }

        public string CarNumber => carNumber;

        public string Problem => problem;

        public WaitingTimes Priority => priority;

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