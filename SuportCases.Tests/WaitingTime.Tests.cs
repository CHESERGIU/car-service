using Xunit;

namespace CarService.Tests
{
    public class PriorityLevelTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            var ticket1 = WaitingTime.Delegated;
            var ticket2 = WaitingTime.DeadLine;
            var ticket3 = WaitingTime.Scheduled;
            var ticket4 = WaitingTime.Urgent;

            WaitingTime[] tickets = { ticket1, ticket2, ticket3, ticket4 };

            WaitingTime[] resultTickets = { ticket1, ticket2, ticket3, ticket4 };

            Assert.Equal(resultTickets, tickets);
        }
    }
}