namespace CarService
{
    public class Program
    {
        public static void Main()
        {    
            var tickets = Pocket.GetTickets();
            Print(tickets);                    
        }
        public static void Print(Pocket[] tickets)
        {
            for (var i = tickets.Length - 1; i >= 0; i--)
                System.Console.WriteLine(tickets[i].CarNumber + " - " + tickets[i].Problem + " - " + tickets[i].Priority);
            System.Console.Read();
        }
    }
}
