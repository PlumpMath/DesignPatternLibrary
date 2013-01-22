using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite.Interface;
namespace Composite
{
    public class PersonalEmail: IEmail
    {
        public string emailAddress;

        public PersonalEmail(string email)
        {
            emailAddress = email;
        }
        public void Send()
        {
            Console.WriteLine("email sent to " + emailAddress);
        }
    }
}
