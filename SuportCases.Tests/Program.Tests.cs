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
            
            var pocket = new Pocket();

            pocket.Enqueue(ticket1);
            
            //// ACT
            var actual = pocket.Dequeue();

            //// ASSERT
            Assert.Equal(ticket1, actual);
        }

        [Fact]
        public void When_tickets_for_support_request_are_3_must_return_1()
        {
            // ARRANGE
            var ticket1 = new Ticket("CJ01ABC", "Direction check", WaitingTime.Delegated);
            var ticket2 = new Ticket("CJ02DEF", "Lights not working", WaitingTime.DeadLine);
            var ticket3 = new Ticket("CJ02GHI", "Change oil", WaitingTime.Scheduled);
            var pocket = new Pocket();

            void Pocket(Ticket ticket) => pocket.Enqueue(ticket);

            Pocket(ticket1);
            Pocket(ticket2);
            Pocket(ticket3);


            //// ACT
            var actual = pocket.Dequeue();

            //// ASSERT
            Assert.Equal(ticket3, actual);
        }
        [Fact]
        public void When_have_a_test()
        {
            // ARRANGE
            var a = new Ticket("A", "A", WaitingTime.Delegated);
            var b = new Ticket("B", "B", WaitingTime.Urgent);
            var pocket = new Pocket();
            pocket.Enqueue(a);
            pocket.Enqueue(b);

            // ACT
            var actual = pocket.Dequeue();

            // ASSERT
            Assert.Equal(b, actual);
        }
        [Fact]
        public void When_have_a_test_with_priority_urgent()
        {
            // ARRANGE
            var a = new Ticket("A", "A", WaitingTime.Urgent);
            var b = new Ticket("B", "B", WaitingTime.Scheduled);
            var c = new Ticket("C", "C", WaitingTime.Delegated);
            var pocket = new Pocket();
            pocket.Enqueue(a);
            pocket.Enqueue(b);
            pocket.Enqueue(c);

            // ACT
            var actual = pocket.Dequeue();

            // ASSERT
            Assert.Equal(c, actual);
        }

    }
}
