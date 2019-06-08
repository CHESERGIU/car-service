using System;

namespace CarService
{
    public class Dispatcher
    {
        internal Ticket[] Tickets;

        public void Enqueue(Ticket ticket)
        {
            Tickets = new[] { ticket };
            Array.Resize(ref Tickets, Tickets.Length);
        }

        public Ticket Dequeue() => Tickets[0];
    }
}
