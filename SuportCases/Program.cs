using System;

namespace CarService
{
    public class Program
    {
        public static void Main()
        {
            var a = new Ticket(id: "CJ01ABC", problem: "Direction check", priority: WaitingTimes.Urgent);
            var b = new Ticket(id: "CJ02DEF", problem: "Lights not working", priority: WaitingTimes.DeadLine);
            var c = new Ticket(id: "CJ02GHI", problem: "Change oil", priority: WaitingTimes.Scheduled);

            Ticket[] tickets = { a, b, c };
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.Id + " - " + ticket.Problem + " - " + ticket.Priority);
            }

            Console.Read();
        }
    }
}
