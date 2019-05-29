using System;
using Xunit;

namespace SuportCases.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_8_must_rearrange_in_priority_level()
        {
            var ticket1 = new SupportTicket(1, "Incorrect behavior", PriorityLevel.Level.Medium);
            var ticket2 = new SupportTicket(2, "Device not working", PriorityLevel.Level.Important);
            var ticket3 = new SupportTicket(3, "Battery drain", PriorityLevel.Level.Important);
            var ticket4 = new SupportTicket(4, "Device immediately turns off", PriorityLevel.Level.Critical);
            var ticket5 = new SupportTicket(5, "Strange behavior", PriorityLevel.Level.Low);
            var ticket6 = new SupportTicket(6, "Occasionally freeze", PriorityLevel.Level.Critical);
            var ticket7 = new SupportTicket(7, "Application not working", PriorityLevel.Level.Low);
            var ticket8 = new SupportTicket(8, "Internet connection problems", PriorityLevel.Level.Medium);

            SupportTicket[] ticket = { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 };
            const int start = 0;
            var end = ticket.Length - 1;
            SupportTicket.Quick3Sort(ticket, start, end);
            SupportTicket[] resultTickets = { ticket4, ticket6, ticket3, ticket2, ticket1, ticket5, ticket7, ticket8 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}
