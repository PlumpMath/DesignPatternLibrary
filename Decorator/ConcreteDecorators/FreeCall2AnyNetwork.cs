using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Decorator;
using Decorator.Component;
namespace Decorator.ConcreteDecorators
{
    public class FreeCall2AnyNetwork: MobilePlanDecorator
    {
        public double FreeCall2AnyNetworkPrice;
        public FreeCall2AnyNetwork(MobilePlan mobilePlan)
            : base(mobilePlan)
        {
            Description = "Free Call to any network for 200 munites per month";
            FreeCall2AnyNetworkPrice = 7;
        }
        public override string GetDescription()
        {
            return string.Format("{0},{1}", _mobilePlan.GetDescription(), Description);
        }
        public override double CaculateCost()
        {
            return _mobilePlan.CaculateCost() + _mobilePlan.ContractLengh * 7;
        }
    }
}
