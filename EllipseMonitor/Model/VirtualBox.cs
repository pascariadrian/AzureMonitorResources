using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Rest;

namespace EllipseMonitor.Model
{
    public class VirtualBox
    {
        private Microsoft.Azure.Management.Compute.Models.VirtualMachine virtualMachineDetails;

        public VirtualMachine VirtualMachineDetails
        {
            get
            {
                return virtualMachineDetails;
            }
            set
            {
                virtualMachineDetails = value;
            }    
        }
        public VirtualBox()
        {

        }

        #region Public methods
        public async Task<Microsoft.Azure.Management.Compute.Models.VirtualMachine> GetVirtualMachine(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            var result = GetVirtualMachineAsync(credential, groupName, vmName, subscriptionId);

            VirtualMachineDetails = await result;

            return VirtualMachineDetails;
        }

        public async Task<Boolean> StartVirtualMachine(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            var result = StartVirtualMachineAsync(credential, groupName, vmName, subscriptionId);

            return await result;
        }

        public async Task<Boolean> StopVirtualMachine(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            var result = StopVirtualMachineAsync(credential, groupName, vmName, subscriptionId);

            return await result;
        }

        public async Task<Boolean> RestartVirtualMachine(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            var result = RestartVirtualMachineAsync(credential, groupName, vmName, subscriptionId);

            return await result;
        }

        public async Task<IEnumerable<Microsoft.Azure.Management.Compute.Models.VirtualMachine>> GetAllVirtualMachines(TokenCredentials credential, string subscriptionId)
        {
            var result = GetAllVirtualMachinesAsync(credential, subscriptionId);

            var resultList = await result;
            var virtualMachineList = resultList.AsEnumerable();

            return virtualMachineList;
        }

        #endregion

        #region Private methods

        private async Task<Microsoft.Azure.Management.Compute.Models.VirtualMachine> GetVirtualMachineAsync(TokenCredentials credential, string groupName,  string vmName,   string subscriptionId)
        {
            var computeManagementClient = new ComputeManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var vmResult = await computeManagementClient.VirtualMachines.GetAsync(
              groupName,
              vmName,
              InstanceViewTypes.InstanceView);

            return vmResult;

        }

        

        private async Task<Microsoft.Rest.Azure.IPage<Microsoft.Azure.Management.Compute.Models.VirtualMachine>> GetAllVirtualMachinesAsync(TokenCredentials credential, string subscriptionId)
        {
            var computeManagementClient = new ComputeManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var vmResult = await computeManagementClient.VirtualMachines.ListAllAsync();


            return vmResult;
        }

        private async Task<Boolean> StartVirtualMachineAsync(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            try
            {
                var computeManagementClient = new ComputeManagementClient(credential)
                { SubscriptionId = subscriptionId };

                computeManagementClient.VirtualMachines.StartAsync(groupName, vmName);
            }
            catch (Exception exc)
            {
                new Exception("Start vm Exception + " + exc.Message);
                return false;
            }
              
            return true;
        }

        private async Task<Boolean> StopVirtualMachineAsync(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            try
            {
                var computeManagementClient = new ComputeManagementClient(credential)
                { SubscriptionId = subscriptionId };

                computeManagementClient.VirtualMachines.PowerOffAsync(groupName, vmName);
            }
            catch (Exception exc)
            {
                new Exception("Start vm Exception + " + exc.Message);
                return false;
            }

            return true;
        }

        private async Task<Boolean> RestartVirtualMachineAsync(TokenCredentials credential, string groupName, string vmName, string subscriptionId)
        {
            try
            {
                var computeManagementClient = new ComputeManagementClient(credential)
                { SubscriptionId = subscriptionId };

                computeManagementClient.VirtualMachines.RestartAsync(groupName, vmName);
            }
            catch (Exception exc)
            {
                new Exception("Start vm Exception + " + exc.Message);
                return false;
            }

            return true;
        }


        #endregion
    }
}
