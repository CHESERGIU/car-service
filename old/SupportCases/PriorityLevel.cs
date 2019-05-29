using System;
using System.Collections.Generic;
using System.Text;

namespace SupportCases
{
    public class PriorityLevel
    {
        public enum Level
        {
            Low = 16,
            Medium = 8,
            Important = 4,
            Critical = 2
        }
        public readonly PriorityLevel Priority;

        public PriorityLevel(PriorityLevel priority)
        {
            Priority = priority;
        }

        public static Level GetPriorityLevel(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "critical":
                    return Level.Critical;
                case "important":
                    return Level.Important;
                case "medium":
                    return Level.Medium;
            }

            return Level.Low;
        }
    }

    

    
}
