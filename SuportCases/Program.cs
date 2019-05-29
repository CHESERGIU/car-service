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
            SupportTicket.Print(tickets);                    
        }      
    }
}
