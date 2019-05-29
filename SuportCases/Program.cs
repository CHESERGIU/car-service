using System;
using static SuportCases.PriorityLevel;

namespace SuportCases
{
    public class Program
    {
        public static void Main()
        {
            var tickets = SupportTicket.ReadSupportTickets();
            SupportTicket.Quick3Sort(tickets, 0, tickets.Length - 1);
            Print(tickets);
            Console.Read();            
        }
        public static void Print(SupportTicket[] tickets)
        {
            for (var i = 0; i < tickets.Length; i++)
                Console.WriteLine(tickets[i].Id + " - " + tickets[i].Description + " - " + tickets[i].Priority);
        }
        
    }
}
