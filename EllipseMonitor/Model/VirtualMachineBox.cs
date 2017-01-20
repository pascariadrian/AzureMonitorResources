using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipseMonitor.Model
{
    public class VirtualMachineBox
    {
        private string subscription;
        private string status;
        private string name;
        private string groupName;
        private VirtualMachine virtualMachines;



        public string Subscription
        {
            get { return subscription; }
            set { subscription = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public VirtualMachine VirtualMachines
        {
            get { return virtualMachines; }
            set { virtualMachines = value; }
        }

        public VirtualMachineBox(string _subscription, string _status, string _name, string _groupName, VirtualMachine _virtualMachines)
        {

            Subscription = _subscription;
            Status = _status;
            Name = _name;
            GroupName = _groupName;
            VirtualMachines = _virtualMachines;
        }


    }
}
