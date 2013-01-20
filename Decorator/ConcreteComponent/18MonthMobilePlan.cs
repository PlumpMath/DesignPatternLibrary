using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Component;
namespace Decorator.ConcreteComponent
{
    public class _18MonthMobilePlan : MobilePlan
    {
        public _18MonthMobilePlan()
        {
            MonthlyCost = 30;
            InitialCost = 349;
            ContractLengh = 18;
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
