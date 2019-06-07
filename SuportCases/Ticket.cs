using System;
using static CarService.WaitingTimes;

namespace CarService
{
    public class Ticket
    {
        public Ticket(string id, string problem, WaitingTimes priority)
        {
            this.CarNumber = id;
            this.Problem = problem;
            this.Priority = priority;
        }

        public string CarNumber { get; }

        public string Problem { get; }

        public WaitingTimes Priority { get; }

        public int Length { get; set; }

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