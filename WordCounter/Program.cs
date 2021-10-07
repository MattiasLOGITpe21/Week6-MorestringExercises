using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string hellow = "Hello, World!";
            int wordcounter = 1;

            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == ' ')
                {
                    wordcounter++;
                }
                
            }
            Console.WriteLine($"Lauses '{hellow}' on {wordcounter} sõna");
            Console.ReadLine();
        }
    }
}
