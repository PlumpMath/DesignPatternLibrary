using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Component;
namespace Decorator.ConcreteComponent
{
    public class _24MonthMobilePlan: MobilePlan
    {
        public _24MonthMobilePlan()
        {
            MonthlyCost = 30;
            InitialCost = 249;
            ContractLengh = 24;
            PhoneType = "IPHONE";
        }

        public override string GetDescription()
        {
            return "18 Month Contract";
        }
        public override double CaculateCost()
        {
            return InitialCost + MonthlyCost * ContractLengh;
        }
    }
}
