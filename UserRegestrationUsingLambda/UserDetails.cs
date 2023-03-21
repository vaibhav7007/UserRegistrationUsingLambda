using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegestrationUsingLambda
{
    public class UserDetails
    {
        public Regex FirstName = new Regex(@"^[A-z]{1}[a-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-z]{1}[a-z]{2,}$");
        public Regex EmailID = new Regex(@"^[a-zA-z]{3}[.][a-zA-Z]{3}@[a-zA-z]{10}[.][a-z]{2}[.][a-z]{2}$");
        public Regex PhoneNumber = new Regex(@"^[0-9]{2}[ ][0-9]{10}$");
        public Regex Password1 = new Regex(@"^[A-Za-z]{8,}$");
        public Regex Password2 = new Regex(@"^[A-Za-z]{1,}$");
        public Regex Password3 = new Regex(@"^[A-Za-z0-9]{1,}$");
        public Regex Password4 = new Regex(@"^[A-Za-z0-9]{1,}[@|$|#|&|!|_]{1}$");
        public Regex SampleEmails = new Regex(@"^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$");
    }
}