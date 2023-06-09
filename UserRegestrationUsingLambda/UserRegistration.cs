﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegestrationUsingLambda
{
    public class UserRegistration
    {
        List<UserDetails> userDetails = new List<UserDetails>();
        public UserRegistration()
        {
            UserDetails user = new UserDetails();
            userDetails.Add(user);
        }
        public void CheckFirstName(string firstName)
        {
            if (userDetails.Any(x => x.FirstName.IsMatch(firstName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (userDetails.Any(x => x.LastName.IsMatch(lastName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckEmailID(string emailId)
        {
            if (userDetails.Any(x => x.EmailID.IsMatch(emailId)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPhoneNumber(string phoneNumber)
        {
            if (userDetails.Any(x => x.PhoneNumber.IsMatch(phoneNumber)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPassword1(string password)
        {
            if (userDetails.Any(x => x.Password1.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPassword2(string password)
        {
            if (userDetails.Any(x => x.Password2.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPassword3(string password)
        {
            if (userDetails.Any(x => x.Password3.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPassword4(string password)
        {
            if (userDetails.Any(x => x.Password4.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckSampleEamils(string[] emails)
        {
            foreach (string inputs in emails)
                if (userDetails.Any(x => x.SampleEmails.IsMatch(inputs)))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
        }
    }
}
