using System;

namespace CarService
{
    public class Dispatcher
    {
        private Ticket tickets;

        private Ticket[] queueTickets;

        public Dispatcher() => queueTickets = new[] { tickets };

        public void Enqueue(Ticket ticket)
        {
            tickets = ticket;
            Array.Resize(ref queueTickets, tickets.Length + ticket.Length);
        }

        public object Dequeue() => tickets;
    }
}
