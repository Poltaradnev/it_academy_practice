using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] varArray = { "32", "A", "Hello" };
            GetArr(varArray);
            int tempInt = Convert.ToInt32(varArray[0]) + 10;
            string tempString = varArray[2] + ",guys!";
            varArray[2] = tempString;
            varArray[0] = Convert.ToString(tempInt);
            GetArr(varArray); 
        }
        static void GetArr(string[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write($"{tempArray[i]}");
            }
            Console.WriteLine();
        }
    }
}
