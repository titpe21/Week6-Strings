using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            string partToLookFor = "hello";

            bool isThere;

            isThere = helloWorld.ToLower().Contains(partToLookFor);

            if (isThere)
            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {partToLookFor}");
            }


        }
    }
}
