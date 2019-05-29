namespace SuportCases
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
        public readonly Level Priority;

        public PriorityLevel(Level priority)
        {
            Priority = priority;
        }
    }
}