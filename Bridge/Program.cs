using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Program
    {
        static void Main()
        {
            var popcornChickenMeal = new PopcornChickenMeal();
            var largeCola = new LargeCola();
            popcornChickenMeal.Print(largeCola);

            var varietyMeal = new VarietyMeal();
            var smallCola = new SmallCola();
            varietyMeal.Print(smallCola);


            Console.WriteLine("-----------------------------------------");
        }
    }
}
