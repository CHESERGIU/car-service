using static SuportCases.PriorityLevel;

namespace SuportCases
{
    public class SupportTicket
    {
        public readonly long Id;
        public readonly string Description;
        public readonly Level Priority;

        public SupportTicket(long id, string description, Level priority)
        {
            this.Id = id;
            this.Description = description;
            this.Priority = priority;
        }
        public static void Print(SupportTicket[] tickets)
        {
            for (var i = 0; i < tickets.Length; i++)
                System.Console.WriteLine(tickets[i].Id + " - " + tickets[i].Description + " - " + tickets[i].Priority);
            System.Console.Read();
        }
    }
}