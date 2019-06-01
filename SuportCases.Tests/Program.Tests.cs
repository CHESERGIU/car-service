using System;
using Xunit;

namespace CarService.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            var ticket1 = new Pocket("CJ01ABC", "Direction check", WaitingTime.Delegated);

            Pocket[] ticket = { ticket1 };
            
            Pocket[] resultTickets = { ticket1 };

            Assert.Equal(resultTickets, resultTickets);
        }
    }
}
