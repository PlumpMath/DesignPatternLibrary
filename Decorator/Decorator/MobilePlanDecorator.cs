using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Component;
namespace Decorator.Decorator
{
    public class MobilePlanDecorator:MobilePlan
    {
        protected MobilePlan _mobilePlan;

        public MobilePlanDecorator(MobilePlan mobilePlan)
        {
            _mobilePlan = mobilePlan;
        }
        public override string GetDescription()
        {
            return _mobilePlan.Description;
        }
        public override double CaculateCost()
        {
            return _mobilePlan.CaculateCost();
        }
    }
}
