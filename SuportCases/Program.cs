using System;

namespace CarService
{
    public class Program
    {
        public static void Main()
        {
            var ticket1 = new Ticket("CJ01ABC", "Direction check", WaitingTimes.Urgent);
            var ticket2 = new Ticket("CJ02DEF", "Lights not working", WaitingTimes.DeadLine);
            var ticket3 = new Ticket("CJ02GHI", "Change oil", WaitingTimes.Scheduled);

            Ticket[] tickets = { ticket1, ticket2, ticket3 };
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.CarNumber + " - " + ticket.Problem + " - " + ticket.Priority);
            }

            Console.Read();
        }
    }
}
