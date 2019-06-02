using System.Collections;
using Xunit;

namespace CarService.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            // ARRANGE
            var ticket1 = new Ticket("CJ01ABC", "Direction check", WaitingTime.Delegated);
            var ticket2 = new Ticket("CJ02DEF", "Lights not working", WaitingTime.DeadLine);

            var pocket = new Queue();

            pocket.Enqueue(ticket1);
            pocket.Enqueue(ticket2);
            
            //// ACT
            var actual = pocket.Dequeue();

            //// ASSERT
            Assert.Equal(ticket1, actual);
        }
    }
}
