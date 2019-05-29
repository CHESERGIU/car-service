using System;
using Xunit;


namespace SupportCases
{
    public class PriorityLevel
    {
        [Fact]
        public void When_tickets_for_support_request_are_8_must_rearrange_in_priority_level()
        {
            var ticket1 = Program.PriorityLevel.Medium;
            var ticket2 = Program.PriorityLevel.Important;
            var ticket3 = Program.PriorityLevel.Important;
            var ticket4 = Program.PriorityLevel.Critical;
            var ticket5 = Program.PriorityLevel.Low;
            var ticket6 = Program.PriorityLevel.Critical;
            var ticket7 = Program.PriorityLevel.Low;
            var ticket8 = Program.PriorityLevel.Medium;

            Program.PriorityLevel[] ticket = { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 };
                       
            Program.PriorityLevel[] resultTickets = { ticket4, ticket6, ticket3, ticket2, ticket1, ticket5, ticket7, ticket8 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}