using Xunit;

namespace CarService.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WWhenTicketsForSupportRequestAre3MustReturn1()
        {
            // ARRANGE
            var ticket1 = new Ticket("CJ01ABC", "Direction check", WaitingTimes.Delegated);
            var ticket2 = new Ticket("CJ02DEF", "Lights not working", WaitingTimes.DeadLine);
            var ticket3 = new Ticket("CJ02GHI", "Change oil", WaitingTimes.Scheduled);
            var payment = new Dispatcher();

            payment.Enqueue(ticket1);
            payment.Enqueue(ticket2);
            payment.Enqueue(ticket3);
            //// ACT
            var actual = payment.Dequeue();

            //// ASSERT
            Assert.Equal(ticket3, actual);
        }

        [Fact]
        public void WhenHaveASingleTest()
        {
            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Delegated);
            var b = new Ticket("B", "B", WaitingTimes.Urgent);
            var payment = new Dispatcher();

            payment.Enqueue(a);
            payment.Enqueue(b);

            // ACT
            var actual = payment.Dequeue();

            // ASSERT
            Assert.Equal(b, actual);
        }

        [Fact]
        public void WhenHaveASingleTestWithPriorityUrgent()
        {
            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Urgent);
            var b = new Ticket("B", "B", WaitingTimes.Scheduled);
            var c = new Ticket("C", "C", WaitingTimes.Delegated);
            var payment = new Dispatcher();

            payment.Enqueue(a);
            payment.Enqueue(b);
            payment.Enqueue(c);

            // ACT
            var actual = payment.Dequeue();

            // ASSERT
            Assert.Equal(c, actual);
        }

        [Fact]
        public void WhenPriorityUrgentMustBeTestedForActual()
        {
            // ARRANGE
            var a = new Ticket("A", "A", WaitingTimes.Delegated);
            var b = new Ticket("B", "B", WaitingTimes.Scheduled);
            var c = new Ticket("C", "C", WaitingTimes.Urgent);
            var d = new Ticket("D", "D", WaitingTimes.DeadLine);
            var payment = new Dispatcher();

            payment.Enqueue(a);
            payment.Enqueue(b);
            payment.Enqueue(c);
            payment.Enqueue(d);

            var ticket = new Ticket(null, null, WaitingTimes.None);
            var priority = new Dispatcher();

            if (priority.Check(a))
            {
                ticket = a;
            }

            if (priority.Check(b))
            {
                ticket = b;
            }

            if (priority.Check(c))
            {
                ticket = c;
            }

            if (priority.Check(d))
            {
                ticket = d;
            }

            // ACT
            var actual = payment.Dequeue(ticket);

            // ASSERT
            Assert.Equal(c, actual);
        }
    }
}
