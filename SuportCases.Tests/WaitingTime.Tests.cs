using System.Collections;
using Xunit;

namespace CarService.Tests
{
    public class PriorityLevelTests
    {
        [Fact]
        public void WhenTicketsForSupportRequestAre1MustReturn1()
        {
            Ticket ticket1 = new Ticket("1", "1", WaitingTimes.Delegated);
            var payment = new Payment();
            payment.Enqueue(ticket1);
            //// ACT
            var actual = payment.Dequeue();
            //// ASSERT
            Assert.Equal(ticket1, actual);
        }

        [Fact]
        public void WhenTicketsForSupportRequestAre3MustReturn1()
        {
            Ticket ticket1 = new Ticket("1", "1", WaitingTimes.Delegated);
            Ticket ticket2 = new Ticket("2", "2", WaitingTimes.DeadLine);
            Ticket ticket3 = new Ticket("3", "3", WaitingTimes.Scheduled);

            var payment = new Payment();

            payment.Enqueue(ticket1);
            payment.Enqueue(ticket2);
            payment.Enqueue(ticket3);

            //// ACT
            var actual = payment.Dequeue();

            //// ASSERT
            Assert.Equal(ticket3, actual);
        }
    }
}