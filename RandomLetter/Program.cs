using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi!");
            string Nimi = Console.ReadLine();

            if (Nimi.Length > 5)
            {
                for (int i = Nimi.Length - 1; i  >= 0; i--)
                {
                    Console.WriteLine(Nimi[i]);
                }
            }

            else
            {
                Console.WriteLine(Nimi);
            }

        }
    }
}
