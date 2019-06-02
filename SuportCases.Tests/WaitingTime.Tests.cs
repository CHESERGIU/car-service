using System.Collections;
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