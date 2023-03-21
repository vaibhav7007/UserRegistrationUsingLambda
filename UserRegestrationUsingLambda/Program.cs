using System;

namespace UserRegestrationUsingLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda Expression");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:First Name\n2:Check Last Name\n3:Check Email Id");
            int option = Convert.ToInt32(Console.ReadLine());
            UserRegistration userRegistration = new UserRegistration();
            switch (option)
            {
                case 1:
                    userRegistration.CheckFirstName("Vaibhav");
                    break;
                case 2:
                    userRegistration.CheckLastName("Mehta");
                    break;
                case 3:
                    userRegistration.CheckEmailID("abc.xyz@bridgelabz.co.in");
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}