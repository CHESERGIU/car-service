using SuportCases;
using System;
using Xunit;


namespace SupportCases
{
    public class PriorityLevelTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_8_must_rearrange_in_priority_level()
        {
            var ticket1 = PriorityLevel.Level.Medium;
            var ticket2 = PriorityLevel.Level.Important;
            var ticket3 = PriorityLevel.Level.Important;
            var ticket4 = PriorityLevel.Level.Critical;
            var ticket5 = PriorityLevel.Level.Low;
            var ticket6 = PriorityLevel.Level.Critical;
            var ticket7 = PriorityLevel.Level.Low;
            var ticket8 = PriorityLevel.Level.Medium;

            PriorityLevel.Level[] ticket = { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 };

            PriorityLevel.Level[] resultTickets = { ticket4, ticket6, ticket3, ticket2, ticket1, ticket5, ticket7, ticket8 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}