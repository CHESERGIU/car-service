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
            var ticket2 = new Pocket("CJ02DEF", "Lights not working", WaitingTime.DeadLine);
            var ticket3 = new Pocket("CJ03GHI ", "Battery drain", WaitingTime.Scheduled);
            var ticket4 = new Pocket("CJ04JKL  ", "Engine break critical", WaitingTime.Urgent);

            Pocket[] tickets = { ticket1, ticket2, ticket3, ticket4 };
            
            Pocket[] resultTickets = { ticket1, ticket2, ticket3, ticket4 };

            Assert.Equal(resultTickets, tickets);
        }
    }
}
