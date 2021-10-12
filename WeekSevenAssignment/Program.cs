using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string login;
            string Password;
            Console.WriteLine("Login:");
            login = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();
            Console.WriteLine("PIN-Kood:");
            var PINcode = Console.ReadLine();



            int counter = 0;

            foreach (char character in PINcode)


            {
                counter++;
                if(PINcode.Length < 4)
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    break;
                }
            }
            if ((login == "Admin") && (Password == "Pass1234") && (PINcode == "9999"))
            {
                Console.WriteLine("Tere Tulemast");
            }
            else if ((login != "Admin") && (Password == "Pass1234"))
            {
                Console.WriteLine("Saad ligi pääsu1");
            }
            else if ((login == "Admin") && (Password != "Pass1234"))
            {
                Console.WriteLine("Midagi läks valesti. Proovi uuesti!");
            }
        }
    }
    
}



/*int LoginAttempts = 0;

            for (int i = 0; i < 3; i++)
            {

                //Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != "Admin" || password != "9999")
                    LoginAttempts++;
                else
                    break;

                if (username = "Admin" || password = "9999")
                    Console.WriteLine("Tere Tulemast");
            }

            if (LoginAttempts > 2)
                Console.WriteLine("Login Failure");
            else
                Console.WriteLine("Login Password");

            Console.ReadKey();*/


//Kasutajatunnus = "Admin" & Parool = "9999"

//------------------------------------------------------------------------------------------------

/*Console.WriteLine("Palun sisesta kasutajatunnus ja seejärel parool");
string Kasutajatunnus = Console.ReadLine();
string Kasutajaparool = Console.ReadLine();
// && V; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi. 


if (Kasutajaparool.Length > 4)
{
    Console.WriteLine("Vale PIN, proovi uuesti");
}
else if (Kasutajaparool.Length == 4)
{
     if (Kasutajatunnus != "Admin" || Kasutajaparool != "9999")
    {
        Console.WriteLine("Login failed, please try again.");
    }
     else if (Kasutajatunnus == "Admin" || Kasutajaparool == "9999")
    {
        Console.WriteLine("Tere Tulemast");
    }
}




else
{
    Console.WriteLine("Something went wrong. Please try again.");
}*/



/*
if (Kasutajatunnus != "Admin" || Kasutajaparool != "TTHK")
{
    Console.WriteLine("Login failed, please try again.");
}
else
{
    Console.WriteLine("Login Success!");
*/

