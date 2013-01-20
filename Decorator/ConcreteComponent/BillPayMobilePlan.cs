using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Component;
namespace Decorator.ConcreteComponent
{
    public class BillPayMobilePlan: MobilePlan
    {
        private int MonthOfUseCount;
        public BillPayMobilePlan(int monthOfUseCount, int monthlyCost)
        {
            MonthlyCost = monthlyCost;
            InitialCost = 679;
            ContractLengh = 0;
            PhoneType = "IPHONE";
            MonthOfUseCount = monthOfUseCount;
        }

        public override string GetDescription()
        {
            return "Bill Pay Plan";
        }
        public override double CaculateCost()
        {
            return InitialCost + MonthlyCost * MonthOfUseCount;
        }
    }
}
