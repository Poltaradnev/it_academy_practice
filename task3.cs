using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranArray = new int[13];
            int tempNum = 0;

            Random ranNum = new Random();
            for (int i = 0; i < ranArray.Length; i++)
            {
                ranArray[i] = ranNum.Next(600);
            }

            for (int i = 0; i < ranArray.Length; i++)
            {
                if (tempNum < ranArray[i])
                    tempNum = ranArray[i];
            }

            for (int i = 0; i < ranArray.Length; i++)
            {
                Console.Write($"{ranArray[i]}\n");
            }
            Console.WriteLine($"\nMaximum array value = {tempNum}");

            Console.Read();




        }
    }
}
