using System;
using System.Collections.Generic;
using System.Text;

namespace SupportCases
{
    public class SupportTicket
    {
        public enum PriorityLevel
        {
            Critical = 2,
            Important = 4,
            Medium = 8,
            Low = 16
        }
        public readonly long Id;
        public readonly string Description;
        public readonly PriorityLevel Priority;

        public SupportTicket(long id, string description, PriorityLevel priority)
        {
            this.Id = id;
            this.Description = description;
            this.Priority = priority;
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
        private static PriorityLevel GetPriorityLevel(string priority)
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
