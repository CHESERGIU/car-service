using System;
using static CarService.WaitingTime;

namespace CarService
{
    public class Pocket
    {
        private readonly string CarNumber;
        private readonly string Problem;
        private readonly WaitingTime Priority;

        public Pocket(string id, string problem, WaitingTime priority)
        {
            this.CarNumber = id;
            this.Problem = problem;
            this.Priority = priority;
        }

        private static WaitingTime GetWaitingTime(string priority)
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

        public static void Print(Pocket[] tickets)
        {
            for (var i = tickets.Length - 1; i >= 0; i--)
                Console.WriteLine(tickets[i].CarNumber + " - " + tickets[i].Problem + " - " + tickets[i].Priority);
            Console.Read();
        }

        public static Pocket[] Input()
        {
            var ticket1 = new Pocket("CJ01ABC", "Direction check", WaitingTime.Delegated);
            var ticket2 = new Pocket("CJ02DEF", "Lights not working", DeadLine);
            var ticket3 = new Pocket("CJ03GHI ", "Battery drain", Scheduled);
            var ticket4 = new Pocket("CJ04JKL  ", "Engine break critical", WaitingTime.Urgent);

            Pocket[] tickets = { ticket1, ticket2, ticket3, ticket4 };
            
            return tickets;
        }

    }
}