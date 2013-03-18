using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject
{
    public class MobileReporsitory
    {
        public MobileBase Find(string mobileName)
        {
            if (mobileName.Contains("iphone"))
            {
                return new Iphone();
            }
            return MobileBase.Null;
        }

    }
}
