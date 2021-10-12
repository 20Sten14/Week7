using System;

namespace Task1Tryagain
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr = 0;
            while(ctr < 3)
            {
                Console.WriteLine("Sisestage PIN");
                string pin = Console.ReadLine();
                Console.WriteLine("Sisestage Nimi");
                string Nimi = Console.ReadLine();
                Console.WriteLine("Sisestage parool");
                string parool = Console.ReadLine();

                if (pin.Length == 4)
                {
                    if (Nimi != "Admin" || parool != "1234" || pin != "9999")
                    {
                        Console.WriteLine("Midagi läks valesti. Proovige uuesti.");
                        ctr++;
                    }
                    else if (Nimi == "Admin" && parool == "1234" && pin == "9999")
                    {
                        Console.Write("\n The password entered successfully!\n\n");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Vale PIN. Proovige uuesti");
                    continue;
                }



            }       
        }
    }
}
