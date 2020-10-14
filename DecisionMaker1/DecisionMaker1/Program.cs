using System;

namespace DecisionMaker1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Enter your name:");
            username = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine(" Must enter your name to continue.");
                    username = Console.ReadLine();

                }
                else { break; }

            }

            Console.WriteLine(username + "Please enter number between 1 and 100.");

            string Userinput = Console.ReadLine();
            UInt32 Userinputnumber = Convert.ToUInt32(Userinput);

            if (Userinputnumber % 2 == 0 && Userinputnumber > 2 && Userinputnumber < 25)
            {
                Console.WriteLine("Number is even and less than 25," + username);
            }
            else if (Userinputnumber % 2 != 0 && Userinputnumber < 101)
            {
                Console.WriteLine("Number is odd," + username);
            }
            else if (Userinputnumber % 2 == 0 && Userinputnumber > 26 && Userinputnumber < 60)
            {
                Console.WriteLine("Number is even," + username);
            }
            else if (Userinputnumber % 2 == 0 && Userinputnumber > 26 && Userinputnumber < 60)
            {
                Console.WriteLine("Number is even and less than 60," + username);
            }
            else if (Userinputnumber % 2 == 0 && Userinputnumber > 59 && Userinputnumber < 101)
            {
                Console.WriteLine("Number is even and greater than 60," + username);
            }
            else if (Userinputnumber % 2 == 0 && Userinputnumber > 59 && Userinputnumber < 101)
            {
                Console.WriteLine("Number is odd and greater than 60," + username);
            }



            //while (Userinputnumber < 0 && Userinputnumber > 100)
            //{ }



            Console.WriteLine("Would you like to continue." + username + "? Yes/No");
            string userresponse = Console.ReadLine();
            if (userresponse != "yes")



            {
                Console.WriteLine("Have a good day." + username);

            }
        }
    }
}
