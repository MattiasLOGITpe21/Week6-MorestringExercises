using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //eesnime ja perekonnanime pikkus kokku
            //ei tohi kasutada Lengthi

            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}";
            int counter = 0;

            foreach (char c in fullName)
            {
                counter++;
            }
            Console.WriteLine($"Nimes {fullName} on {counter} sümbolit.");
        }
    }
}
