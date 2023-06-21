using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    public class InitialMenuOptions: LogIn
    {
       public static void InitialMenu()
        {
            try
            {
                Console.WriteLine("Welcome To MyBankApp!");

                int initialResponse = 0;

                while (initialResponse > 2 || initialResponse <= 0)
                {
                    Console.WriteLine("Please Select an Option Below:");
                    Console.WriteLine("1. Existing User? Log In.");
                    Console.WriteLine("2. New User? Create a Customer Account.");
                    initialResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
                }


                if (initialResponse == 1)
                {
                    Console.Clear();
                    LogIn.LogInDetails();
                }
                else
                {
                    Console.Clear();
                    CreateCustomerAccount.RegistrationInfo();
                }


            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid input Format!");
                InitialMenu();
            }


        }

    }
}
