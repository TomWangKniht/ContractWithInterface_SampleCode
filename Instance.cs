using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractWithInterface
{
    public class Instance : IInstance
    {
        public virtual int GetIntValue()
        {
            return 1234;
        }

        public virtual void UseParam(int intValue)
        {
            Console.WriteLine("UseParam()的輸入為:" + intValue);
        }

        public virtual int UseParamGetIntValue(int intValue)
        {
            Console.WriteLine("UseParamGetIntValue()的輸入為:" + intValue);
            return intValue + 10;
        }

    }
}
