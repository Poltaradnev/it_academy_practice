using System;

namespace for_letters_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            char word = 'a';
            int count = 0;
            string text = Convert.ToString(Console.ReadLine());
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            if (text[i] == word)
            count++;                 
            Console.WriteLine($"Numbers of letters a = {count}");
            Console.Read();
        }

    }

}








    
    

