using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            string hellow = "Hello World!";
            int counter = 0;

            foreach(char c in hellow)
            {
                counter++;
            }
            Console.WriteLine($"Lauses '{hellow}' on {counter} sümbolit.");
        }
    }
}
