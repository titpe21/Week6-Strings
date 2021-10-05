using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja perekonnanimes kokku on

            // char a = 'a';

            Console.WriteLine("sisesta oma eesnimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastName}".ToLower();



            /*foreach(char character in fullName)
            {
                if(character == 'a')
                {
                    counter++; //counter = counter + 1
                }
            }*/

           
           /* int i = fullName.Length-1;

            while (i >= 0)
            {
                Console.WriteLine(fullName[i]);
                if (fullName[i] == 'a')
                {
                    counter++;
                }
                i--;
            }*/

            int counter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
        }
    }
}
