using Xunit;

namespace CarService.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WWhenTicketsForSupportRequestAre3MustReturn1()
        {
            Ticket[] tickets = { };
            var payment = new Dispatcher();

            // ARRANGE
            var ticket1 = new Ticket("CJ01ABC", "Direction check", WaitingTimes.Delegated);
            var ticket2 = new Ticket("CJ02DEF", "Lights not working", WaitingTimes.DeadLine);
            var ticket3 = new Ticket("CJ02GHI", "Change oil", WaitingTimes.Scheduled);

            payment.Enqueue(ref tickets, ticket1);
            payment.Enqueue(ref tickets, ticket2);
            payment.Enqueue(ref tickets, ticket3);
            //// ACT
            payment.Select(ref tickets);
            payment.Dequeue(ref tickets);

            //// ASSERT
            Assert.DoesNotContain(ticket2, tickets);
        }

        [Fact]
        public void WhenHaveASingleTest()
        {
            Ticket[] tickets = { };

            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Delegated);
            var b = new Ticket("B", "B", WaitingTimes.Urgent);
            var payment = new Dispatcher();
            payment.Enqueue(ref tickets, a);
            payment.Enqueue(ref tickets, b);

            // ACT
            payment.Select(ref tickets);
            var actual = payment.Dequeue(ref tickets);

            // ASSERT
            Assert.Equal(a, actual);
        }

        [Fact]
        public void WhenHaveASingleTestWithPriorityUrgent()
        {
            Ticket[] tickets = { };

            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Urgent);
            var b = new Ticket("B", "B", WaitingTimes.Scheduled);
            var c = new Ticket("C", "C", WaitingTimes.Delegated);
            var payment = new Dispatcher();
            payment.Enqueue(ref tickets, a);
            payment.Enqueue(ref tickets, b);
            payment.Enqueue(ref tickets, c);

            // ACT
            payment.Select(ref tickets);
            var actual = payment.Dequeue(ref tickets);

            // ASSERT
            Assert.DoesNotContain(a, tickets);
        }

        [Fact]
        public void WhenPriorityUrgentMustBeTestedForActual()
        {
            Ticket[] tickets = { };
            var payment = new Dispatcher();

            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Delegated);
            var b = new Ticket("B", "B", WaitingTimes.Scheduled);
            var c = new Ticket("C", "C", WaitingTimes.Urgent);
            var d = new Ticket("D", "D", WaitingTimes.DeadLine);
            payment.Enqueue(ref tickets, a);
            payment.Enqueue(ref tickets, b);
            payment.Enqueue(ref tickets, c);
            payment.Enqueue(ref tickets, d);

            // ACT
            payment.Select(ref tickets);
            var actual = payment.Dequeue(ref tickets);

            // ASSERT
            Assert.DoesNotContain(c, tickets);
        }
    }
}
