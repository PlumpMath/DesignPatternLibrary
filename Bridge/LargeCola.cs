using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Inteface;
namespace Bridge
{
    public class LargeCola: ICombination
    {
        public void AddOn()
        {
            Console.WriteLine("Large Cola Added on");
        }
    }
}
