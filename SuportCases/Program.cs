using System;
using static CarService.Pocket;

namespace CarService
{
    public class Program
    {
        public static void Main() => Print((Console.ReadLine()?.Split('-')));
        
        public static void Print(string[] input)
        {
            Console.WriteLine("{0} - {1} - {2}", input[0], input[1].Trim(), GetWaitingTime(input[2]));
            Console.Read();
        }
    }
}
