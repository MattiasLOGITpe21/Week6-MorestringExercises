using System;

namespace MoretringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab "racecar" tagurpidi

            string racecar = "racecar";

            for (int i = racecar.Length - 1; i >= 0; i--)
            {
                Console.Write(racecar[i]);
            }

        }
    }
}
