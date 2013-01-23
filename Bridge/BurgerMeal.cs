using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Inteface;
namespace Bridge
{
    public class BurgerMeal: IKFCMeal
    {
        public void Print(ICombination combination)
        {
            Console.WriteLine("Burge meal selected");
            combination.AddOn();
        }
    }
}
