using System;
using System.Runtime.InteropServices;

namespace CarService
{
    public class Pocket
    {
        private readonly Ticket tickets;

        public Ticket Tickets { get; set; }
        

        public Pocket()
        {
            Tickets = tickets;
        }

        public void Enqueue(Ticket tickets)
        {
            Tickets = tickets;
        }
        
        public object Dequeue()
        {
            return Tickets;
        }
    }
}