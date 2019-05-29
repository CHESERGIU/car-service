﻿using static SuportCases.PriorityLevel;

namespace SuportCases
{
    public class SupportTicket
    {
        public readonly long Id;
        public readonly string Description;
        public readonly Level Priority;

        public SupportTicket(long id, string description, Level priority)
        {
            this.Id = id;
            this.Description = description;
            this.Priority = priority;
        }
        
        public static int Partition(SupportTicket[] tickets, int start, int end)
        {
            var pivot = (int)tickets[end].Priority;
            var partitionIndex = start;
            for (var i = start; i < end; i++)
            {
                if ((int)tickets[i].Priority > pivot) continue;
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
        public static SupportTicket[] ReadSupportTickets()
        {
            var ticketsNumber = System.Convert.ToInt32(System.Console.ReadLine());
            var result = new SupportTicket[ticketsNumber];

            for (var i = 0; i < ticketsNumber; i++)
            {
                var ticketData = System.Console.ReadLine()?.Split('-');
                if (ticketData != null)
                {
                    var id = System.Convert.ToInt64(ticketData[0]);
                    result[i] = new SupportTicket(id, ticketData[1].Trim(), GetPriorityLevel(ticketData[2]));
                }
            }

            return result;
        }
        public static void Quick3Sort(SupportTicket[] tickets, int start, int end)
        {
            while (true)
            {
                if (start >= end)
                    return;
                var partitionIndex = Partition(tickets, start, end);
                Quick3Sort(tickets, start, partitionIndex - 1);
                start = partitionIndex + 1;
            }
        }
    }
}