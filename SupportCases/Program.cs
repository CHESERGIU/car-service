using System;

namespace SupportCases
{
    public class Program
    {
        public enum PriorityLevel
        {
            Critical = 2,
            Important = 4,
            Medium = 8,
            Low = 16
        }

        public struct SupportTicket
        {
            public readonly long Id;
            public readonly string Description;
            public readonly PriorityLevel Priority;

            public SupportTicket(long id, string description, PriorityLevel priority)
            {
                this.Id = id;
                this.Description = description;
                this.Priority = priority;
            }

        }

        public static void Main(string[] args)
        {
            var tickets = ReadSupportTickets();
            Quick3Sort(tickets, 0, tickets.Length - 1);
            Print(tickets);
            Console.Read();
        }

        private static int Partition(SupportTicket[] tickets, int start, int end)
        {
            var pivot = (int)tickets[end].Priority;
            var partitionIndex = start;
            for (var i = start; i < end; i++)
            {
                if ((int) tickets[i].Priority > pivot) continue;
                var temp = tickets[partitionIndex];
                tickets[partitionIndex] = tickets[i];
                tickets[i] = temp;
                partitionIndex++;
            }
            var temp1 = tickets[partitionIndex];
            tickets[partitionIndex] = tickets[end];
            tickets[end] = temp1;
            return partitionIndex;
        }

        public static void Quick3Sort(SupportTicket[] tickets, int start, int end)
        {
            while (true)
            {
                if (start >= end)
                    return;
                var partitionIndex = Partition(tickets, start, end);
                Quick3Sort(tickets,start,partitionIndex - 1);
                start = partitionIndex + 1;
            }
        }

        private static void Print(SupportTicket[] tickets)
        {
            for (var i = 0; i < tickets.Length; i++)
                Console.WriteLine(tickets[i].Id + " - " + tickets[i].Description + " - " + tickets[i].Priority);
        }

        private static SupportTicket[] ReadSupportTickets()
        {
            var ticketsNumber = Convert.ToInt32(Console.ReadLine());
            var result = new SupportTicket[ticketsNumber];

            for (var i = 0; i < ticketsNumber; i++)
            {
                var ticketData = Console.ReadLine()?.Split('-');
                if (ticketData != null)
                {
                    var id = Convert.ToInt64(ticketData[0]);
                    result[i] = new SupportTicket(id, ticketData[1].Trim(), GetPriorityLevel(ticketData[2]));
                }
            }

            return result;
        }

        public static PriorityLevel GetPriorityLevel(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "critical":
                    return PriorityLevel.Critical;
                case "important":
                    return PriorityLevel.Important;
                case "medium":
                    return PriorityLevel.Medium;
            }
            return PriorityLevel.Low;
        }
    }
}
