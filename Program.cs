using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IInstance instance=new Instance();
            Console.WriteLine("GetIntValue = " + instance.GetIntValue());
            instance.UseParam(10);
            Console.WriteLine("UseParamGetIntValue = " + instance.UseParamGetIntValue(99));
            Console.ReadLine();
        }
    }
}
