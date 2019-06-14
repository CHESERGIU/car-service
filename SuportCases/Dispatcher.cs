namespace CarService
{
    public class Dispatcher
    {
        private static Ticket[] tickets;

        public void Enqueue(Ticket ticket) => tickets = new[] { ticket };

        public Ticket Dequeue() => tickets[0];

        public Ticket Dequeue(Ticket ticket) => tickets[0] = ticket;
    }
}
