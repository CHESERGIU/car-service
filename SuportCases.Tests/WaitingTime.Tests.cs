﻿using System.Collections;
using Xunit;

namespace CarService.Tests
{
    public class PriorityLevelTests
    {
        [Fact]
        public void When_tickets_for_support_request_are_1_must_return_1()
        {
            Ticket ticket1 = new Ticket("1", "1", WaitingTime.Delegated);
            
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
            Ticket ticket1 = new Ticket("1", "1", WaitingTime.Delegated);
            Ticket ticket2 = new Ticket("2", "2", WaitingTime.DeadLine);
            Ticket ticket3 = new Ticket("3", "3", WaitingTime.Scheduled);

            var pocket = new Pocket();

            pocket.Enqueue(ticket1);
            pocket.Enqueue(ticket2);
            pocket.Enqueue(ticket3);

            //// ACT
            var actual = pocket.Dequeue();

            //// ASSERT
            Assert.Equal(ticket3, actual);
        }
    }
}