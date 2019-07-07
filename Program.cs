using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan  date1 = DateTime.Now.TimeOfDay;
            Int32 hour1 = date1.Hours;

            if (hour1 >= 9 && hour1 < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (hour1 >= 12 && hour1 < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (hour1 >= 15 && hour1 < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
        }
    }
}         