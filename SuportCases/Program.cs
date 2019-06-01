using System;

namespace CarService
{
    public class Program
    {
        public static void Main()
        {
            Pocket ticket1 = new Pocket("CJ01ABC", "Direction check", WaitingTime.Delegated);
            Pocket ticket2 = new Pocket("CJ02DEF", "Lights not working", WaitingTime.DeadLine);
            Pocket ticket3 = new Pocket("CJ03GHI ", "Battery drain", WaitingTime.Scheduled);
            Pocket ticket4 = new Pocket("CJ04JKL  ", "Engine break critical", WaitingTime.Urgent);

            Pocket[] tickets = { ticket1, ticket2, ticket3, ticket4 };

            for (var i = tickets.Length - 1; i >= 0; i--)
                Console.WriteLine(tickets[i].CarNumber + " - " + tickets[i].Problem + " - " + tickets[i].Priority);
            Console.Read();
        }
    }
}
