using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõne pikkust Length omaduse kasutamata

            //foreach Loop
            //foreach(element in string)

            string helloWorld = "Hello world!";

            int counter = 0;

            foreach(char character in helloWorld)
            {
                counter = counter + 1;
                //counter++;
            }

            Console.WriteLine($"{helloWorld} on {counter} sümbolit pikk.");
        }
    }
}
