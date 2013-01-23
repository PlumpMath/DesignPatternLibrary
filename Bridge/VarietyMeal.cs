using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Inteface;
namespace Bridge
{
    public class VarietyMeal:IKFCMeal
    {

        public void Print(ICombination combination)
        {
            Console.WriteLine("Variety meal selected");
            combination.AddOn();
        }
    }
}
