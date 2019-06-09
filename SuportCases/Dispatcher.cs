using System;

namespace CarService
{
    public class Dispatcher
    {
        private static Ticket[] tickets;

        public void Enqueue(Ticket ticket) => tickets = new[] { ticket };

        public Ticket Dequeue() => tickets[0];
    }
}
