using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma nimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine($"Sinu nimi on {userFirstName.Length} sümbolit pikk.");
        }
    }
}
