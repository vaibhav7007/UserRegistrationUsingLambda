using System;

namespace UserRegestrationUsingLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda Expression");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:First Name\n2:Check Last Name\n3:Check Email Id\n4:Check Phone Number\n5:Check Password1\n6:Check Password2\n7:Check Password3\n8:Check Password4\n9:Check Sample Emails");
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
                case 4:
                    userRegistration.CheckPhoneNumber("91 8983922703");
                    break;
                case 5:
                    userRegistration.CheckPassword1("VaibhaviD");
                    break;
                case 6:
                    userRegistration.CheckPassword2("VaibhaviD");
                    break;
                case 7:
                    userRegistration.CheckPassword3("Vaibhav11");
                    break;
                case 8:
                    userRegistration.CheckPassword4("Rahul11@");
                    break;
                case 9:
                    userRegistration.CheckSampleEamils(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" });
                    userRegistration.CheckSampleEamils(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" });
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}