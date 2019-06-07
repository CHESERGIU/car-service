using System;

namespace CarService
{
    public class Dispatcher
    {
        private Ticket tickets;
        private Ticket[] queueTickets;

        public Dispatcher()
        {
            Tickets = new[] { tickets };
            queueTickets = Tickets;
        }

        public int Size { get; private set; }

        private static Ticket[] Tickets { get; set; }

        public void Enqueue(Ticket ticket)
        {
            if (ticket != null)
            {
                Size = ticket.Length;
                tickets = ticket;
            }

            Array.Resize(ref queueTickets, newSize: Tickets.Length + Size);
        }

        public object Dequeue()
        {
            return tickets;
        }
    }
}
