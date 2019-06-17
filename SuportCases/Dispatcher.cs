using System;

namespace CarService
{
    public class Dispatcher
    {
        public Ticket[] Select(ref Ticket[] cars)
        {
            if (cars == null)
            {
                return cars;
            }

            for (int i = 0; i < cars.Length; i++)
            {
                var max = cars[0];
                if (max.Priority < cars[i].Priority)
                {
                    max = cars[i];
                    cars[i] = cars[0];
                    cars[0] = max;
                }
            }

            return cars;
        }

        public void Enqueue(ref Ticket[] tickets, Ticket ticket)
        {
            Array.Resize(ref tickets, tickets.Length + 1);
            tickets[tickets.Length - 1] = ticket;
        }

        public Ticket Dequeue(ref Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length - 1; i++)
            {
                tickets[i] = tickets[i + 1];
            }

            Array.Resize(ref tickets, tickets.Length - 1);
            return tickets[0];
        }
    }
}
