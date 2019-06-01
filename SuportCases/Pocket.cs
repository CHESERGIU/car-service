using System;
using static CarService.WaitingTime;

namespace CarService
{
    public class Pocket
    {
        public readonly WaitingTime Priority;

        public Pocket(string id, string problem, WaitingTime priority) => this.Priority = priority;

        public static WaitingTime GetWaitingTime(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "Urgent":
                    return WaitingTime.Urgent;
                case "DeadLine":
                    return WaitingTime.DeadLine;
                case "Delegated":
                    return WaitingTime.Delegated;
            }

            return WaitingTime.Scheduled;
        }

    }
}