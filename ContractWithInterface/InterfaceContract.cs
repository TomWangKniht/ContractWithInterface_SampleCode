using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ContractWithInterface
{
    [ContractClassFor(typeof(IInstance))]
    public abstract class InterfaceContract : IInstance
    {
        int IInstance.GetIntValue()
        {
            Contract.Ensures(0 <= Contract.Result<int>());
            return default(int); //dummy return
        }

        void IInstance.UseParam(int intValue)
        {
            Contract.Requires(0 <= intValue);
        }

        int IInstance.UseParamGetIntValue(int intValue)
        {
            //Requires與Ensures的先後順序不能顛倒
            Contract.Requires(0 <= intValue);
            Contract.Ensures(0 <= Contract.Result<int>());
            return default(int);
        }

    }
}
