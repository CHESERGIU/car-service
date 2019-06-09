using System;

namespace CarService
{
    public class Program
    {
        public static void Main()
        {
            var a = new Ticket("CJ01ABC", "Direction check", WaitingTimes.Urgent);
            var b = new Ticket("CJ02DEF", "Lights not working", WaitingTimes.DeadLine);
            var c = new Ticket("CJ02GHI", "Change oil", WaitingTimes.Scheduled);

            Ticket[] tickets = { a, b, c };
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.CarNumber + " - " + ticket.Problem + " - " + ticket.Priority);
            }

            Console.Read();
        }
    }
}
