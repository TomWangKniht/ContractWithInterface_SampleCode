using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ContractWithInterface
{
    [ContractClass(typeof(InterfaceContract))]
    public interface IInstance
    {
        int GetIntValue();

        void UseParam(int intValue);

        int UseParamGetIntValue(int intValue);

    }
}
