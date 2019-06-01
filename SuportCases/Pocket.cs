using System;
using static CarService.Points;

namespace CarService
{
    public class Pocket
    {
        public readonly string CarNumber;
        public readonly string Problem;              
        public readonly WaitingTime Priority;

        public Pocket(string id, string problem, WaitingTime priority)
        {
            this.CarNumber = id;
            this.Problem = problem;
            this.Priority = priority;
        }

        public static Pocket[] GetTickets()
        {
            var ticketsNumber = Convert.ToInt32(Console.ReadLine());
            var result = new Pocket[ticketsNumber];

            for (var i = 0; i < ticketsNumber; i++)
            {
                var ticketData = Console.ReadLine()?.Split('-');
                if (ticketData == null) continue;
                var id = ticketData[0];
                result[i] = new Pocket(id, ticketData[1].Trim(), GetPriorityLevel(ticketData[2]));
            }
            return result;
        }

       
    }
}