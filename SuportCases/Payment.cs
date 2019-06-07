using System;

namespace CarService
{
    public class Payment
    {
        private Ticket dispatcher;

        public void Enqueue(Ticket ticket)
        {
            dispatcher = ticket;
        }

        public object Dequeue()
        {
            return dispatcher;
        }
    }
}
