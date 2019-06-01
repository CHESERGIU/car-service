using System;
using static CarService.Pocket;

namespace CarService
{
    public class Program
    {
        public static void Main() => Print(Tickets(Console.ReadLine()?.Split('-')));

        public static Pocket Tickets(string[] input)
        {
            var tickets = new Pocket(input[0], input[1].Trim(), GetWaitingTime(input[2]));
            return tickets;
        }

        public static void Print(Pocket tickets)
        {
            Console.WriteLine(tickets.CarNumber + " - " + tickets.Problem + " - " + tickets.Priority);
            Console.Read();
        }
    }
}
