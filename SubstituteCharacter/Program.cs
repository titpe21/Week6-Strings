using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis
            Console.WriteLine("sisesta oma eesnimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastName}".ToLower();

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);
        }
    }
}
