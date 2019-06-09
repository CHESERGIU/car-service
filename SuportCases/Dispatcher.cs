using System;

namespace CarService
{
    public class Dispatcher
    {
        private static Ticket[] tickets;

        public static Ticket Check(Ticket ticket, Ticket actual)
        {
            var check = ticket;
            if (actual != null && (ticket != null && ticket.Priority == actual.Priority))
            {
                ticket = actual;
            }

            return ticket;
        }

        public void Enqueue(Ticket ticket) => tickets = new[] { ticket };

        public Ticket Dequeue() => tickets[0];

        public Ticket Dequeue(Ticket ticket)
        {
            return tickets[0] = ticket;
        }
    }
}
