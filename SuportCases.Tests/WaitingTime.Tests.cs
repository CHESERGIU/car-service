using Xunit;

namespace CarService.Tests
{
    public class PriorityLevelTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            var ticket1 = WaitingTime.Delegated;

            WaitingTime[] ticket = { ticket1 };

            WaitingTime[] resultTickets = {  ticket1 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}