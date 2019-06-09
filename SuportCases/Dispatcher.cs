namespace CarService
{
    public class Dispatcher
    {
        private static Ticket[] tickets;

        public bool Check(Ticket actual) => actual?.Priority == WaitingTimes.Urgent;

        public void Enqueue(Ticket ticket) => tickets = new[] { ticket };

        public Ticket Dequeue() => tickets[0];

        public Ticket Dequeue(Ticket ticket)
        {
            return tickets[0] = ticket;
        }
    }
}
