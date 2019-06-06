using System;
using static CarService.WaitingTime;

namespace CarService
{
    public class Ticket
    {
         public readonly string CarNumber;
         public readonly string Problem;
         public readonly WaitingTime Priority;

        public Ticket(string id, string problem, WaitingTime priority)
        {
            this.CarNumber = id;
            this.Problem = problem;
            this.Priority = priority;
        }
        
        private WaitingTime GetWaitingTime(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "urgent":
                    return WaitingTime.Urgent;
                case "deadline":
                    return WaitingTime.DeadLine;
                case "delegated":
                    return WaitingTime.Delegated;
            }
            return WaitingTime.Scheduled;
        }

       
    }
}