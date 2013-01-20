using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.ConcreteDecorators;
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.Decorator;
namespace Decorator
{
    public class Program
    {
        static void Main()
        {
            MobilePlan mobilePlan18 = new _18MonthMobilePlan();

            Console.WriteLine(mobilePlan18.GetDescription());
            Console.WriteLine(mobilePlan18.CaculateCost());

            mobilePlan18 = new FreeCall2AnyNetwork(mobilePlan18);
            Console.WriteLine(mobilePlan18.GetDescription());
            Console.WriteLine(mobilePlan18.CaculateCost());

            MobilePlan billPay = new BillPayMobilePlan(18,30);
            Console.WriteLine(billPay.GetDescription());
            Console.WriteLine(billPay.CaculateCost());

            MobilePlan mobilePlan24 = new _24MonthMobilePlan();
            Console.WriteLine(mobilePlan24.GetDescription());
            Console.WriteLine(mobilePlan24.CaculateCost());

            mobilePlan24 = new FreeCall2AnyNetwork(mobilePlan24);
            Console.WriteLine(mobilePlan24.GetDescription());
            Console.WriteLine(mobilePlan24.CaculateCost());

            Console.WriteLine("-----------------------------");
                        
        }
    }
}
