using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Component
{
    public abstract class MobilePlan
    {
        public string PhoneType;
        public double InitialCost;
        public double MonthlyCost;
        public int ContractLengh;
        public string Description;

        public abstract string GetDescription();
        public abstract double CaculateCost();

    }
}
