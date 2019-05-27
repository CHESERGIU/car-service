using System;
using Xunit;

namespace SupportCases.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_8_must_rearrange_in_priority_level()
        {
            var ticket1 = new Program.SupportTicket(1, "Incorrect behavior", Program.PriorityLevel.Medium);
            var ticket2 = new Program.SupportTicket(2, "Device not working", Program.PriorityLevel.Important);
            var ticket3 = new Program.SupportTicket(3, "Battery drain", Program.PriorityLevel.Important);
            var ticket4 = new Program.SupportTicket(4, "Device immediately turns off", Program.PriorityLevel.Critical);
            var ticket5 = new Program.SupportTicket(5, "Strange behavior", Program.PriorityLevel.Low);
            var ticket6 = new Program.SupportTicket(6, "Occasionally freeze", Program.PriorityLevel.Critical);
            var ticket7 = new Program.SupportTicket(7, "Application not working", Program.PriorityLevel.Low);
            var ticket8 = new Program.SupportTicket(8, "Internet connection problems", Program.PriorityLevel.Medium);
           
            Program.SupportTicket[] ticket = { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8};
            const int start = 0;
            var end = ticket.Length - 1;
            Program.Quick3Sort(ticket, start, end);
            Program.SupportTicket[] resultTickets = { ticket4, ticket6, ticket3, ticket2, ticket1, ticket5, ticket7, ticket8 };
            
            Assert.Equal(resultTickets, resultTickets);
        }
        
    }
}
