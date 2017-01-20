using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllipseMonitor;
using EllipseMonitor.VM;





namespace AzureMonitor.Console
{
    public class Class1
    {
        static void Main(string[] args)
        {
            API api = new API();
            //api.Credential

            var vm = api.GetVirtualMachine();
        }

    }
}
