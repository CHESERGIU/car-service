using CarService;
using System;
using Xunit;


namespace SupportCases
{
    public class PriorityLevelTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            var ticket1 = Points.WaitingTime.Delegated;

            Points.WaitingTime[] ticket = { ticket1 };

            Points.WaitingTime[] resultTickets = {  ticket1 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}