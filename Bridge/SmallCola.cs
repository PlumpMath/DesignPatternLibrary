using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Inteface;
namespace Bridge
{
    public class SmallCola : ICombination
    {
        public void AddOn()
        {
            Console.WriteLine("Small Cola Added on");
        }
    }
}
