using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //kõik a tähed muutuvad (*)

            Console.WriteLine("Sisestage eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi:");
            string perekonnanimi = Console.ReadLine();

            string fullname = $"{eesnimi} {perekonnanimi}";
            fullname = fullname.Replace('a', '*');

            Console.WriteLine(fullname);
        }
    }
}
