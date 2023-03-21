using System;

namespace UserRegestrationUsingLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda Expression");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:First Name");
            int option = Convert.ToInt32(Console.ReadLine());
            UserRegistration userRegistration = new UserRegistration();
            switch (option)
            {
                case 1:
                    userRegistration.CheckFirstName("Shivani");
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}