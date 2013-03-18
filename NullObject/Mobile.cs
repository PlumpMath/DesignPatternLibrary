using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
    public abstract class MobileBase
    {
        public abstract string Type { get; }
        public abstract string Description { get; }
        public abstract void Order();

        static readonly NullMobile nullMobile = new NullMobile();

        public static NullMobile Null
        {
            get { return nullMobile; }
        }

        public class NullMobile : MobileBase
        {
            public override string Type
            {
                get { return "null type"; }
            } 

            public override string Description
            {
                get { return "null description"; }
            }

            public override void Order()
            {
                Console.WriteLine("cannot order a null mobile");
            }
        }
    }

    public class Iphone : MobileBase
    {
        public override string Type
        {
            get { return "Iphone"; }
        }

        public override string Description
        {
            get { return "Iphone 6"; }
        }
        public override void Order()
        {
            Console.WriteLine("iphone ordered!");
        }
    }
}
