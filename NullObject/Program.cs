using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
    public class Program
    {
        static void Main()
        {
            var mobileReporsitory = new MobileReporsitory();
            var mobile = mobileReporsitory.Find("iphone");
            mobile.Order();

            Console.WriteLine("---------------------------");

            var mobile2 = mobileReporsitory.Find("blackberry");
            mobile2.Order();

            
        }
    }
}
