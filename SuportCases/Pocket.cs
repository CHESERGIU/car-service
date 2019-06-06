namespace CarService
{
    public class Pocket
    {
        public Ticket Tickets { get; private set; }

        public void Enqueue(Ticket tickets) => Tickets = tickets;

        public object Dequeue() => Tickets;
    }
}