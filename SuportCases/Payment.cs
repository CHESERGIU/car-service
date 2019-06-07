using System;

namespace CarService
{
    public class Payment
    {
        public Ticket Receipt;
        
        public void Enqueue(Ticket ticket)
        {
            Receipt = ticket;
        }
        public object Dequeue()
        {
            return Receipt;
        }
    }
}
