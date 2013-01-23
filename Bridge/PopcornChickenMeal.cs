using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Inteface;
namespace Bridge
{
    public class PopcornChickenMeal:IKFCMeal
    {

        public void Print(ICombination combination)
        {
            Console.WriteLine("Popcorn chicken meal selected");
            combination.AddOn();
        }
    }
}
