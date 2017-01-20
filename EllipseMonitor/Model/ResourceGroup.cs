using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Azure.Management.Resources.Models;

namespace EllipseMonitor.Model
{
    public class ResourceGroup
    {
        private Microsoft.Azure.Management.ResourceManager.Models.Resource resouceGroup;

        public Microsoft.Azure.Management.ResourceManager.Models.Resource ResouceGroup
        {
            get
            {
                return resouceGroup;
            }
            set
            {
                resouceGroup = value;
            }
        }


        public ResourceGroup()
        {

        }

        #region public methods
        public async Task<Microsoft.Azure.Management.ResourceManager.Models.ResourceGroup> GetResourceGroup(TokenCredentials credential, string groupName, string subscriptionId)
        {
            var result = GetResourceGroupAsync(credential, groupName, subscriptionId);

            return await result;
        }
        public async Task<IEnumerable<Microsoft.Azure.Management.ResourceManager.Models.ResourceGroup>> GetResourceGroupList(TokenCredentials credential, string subscriptionId)
        {
            var result = GetResourceGroupListAsync(credential, subscriptionId);

            var resultList = await result;

            var resourceGroupList = resultList.AsEnumerable();

            return resourceGroupList;
        }

        public async Task<IEnumerable<Microsoft.Azure.Management.ResourceManager.Models.GenericResource>> ResourceGroupListResources(TokenCredentials credential, string resourceGroupName, string subscriptionId)
        {
            var result = ResourceGroupListResourcesAsync(credential, resourceGroupName, subscriptionId);

            var resultList = await result;

            var resourceGroupList = resultList.AsEnumerable();

            return resourceGroupList;
        }

        public async Task<Microsoft.Azure.Management.ResourceManager.Models.Provider> GetResourceProvider(TokenCredentials credential, string resourceProviderName, string subscriptionId)
        {
            var result = GetResourceProviderAsync(credential, resourceProviderName, subscriptionId);

            var resourceProvider = await result;

            return resourceProvider;
        }

        public async Task<IEnumerable<Microsoft.Azure.Management.ResourceManager.Models.Provider>> GetResourceProviderList(TokenCredentials credential, string subscriptionId)
        {
            var result = GetResourceProviderListAsync(credential, subscriptionId);

            var resultList = await result;

            var providerList = resultList.AsEnumerable();

            return providerList;
        }

        public async Task<TaskStatus> GetStatusTask(TokenCredentials credential, string resourceId, string resourceGroupName, string resourceProviderName, string parentResourcePath, string resourceType, string resourceName, string apiVersion, string subscriptionId)
        {
            var result = GetStatusTaskAsync(credential, resourceId, resourceGroupName, resourceProviderName, parentResourcePath, resourceType, resourceName, apiVersion, subscriptionId);

            var resultList = await result;


            return resultList;
        }
        #endregion


        #region Private methods

        private async Task<Microsoft.Azure.Management.ResourceManager.Models.ResourceGroup> GetResourceGroupAsync(TokenCredentials credential, string groupName, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
                { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.ResourceGroups.GetAsync(groupName);

            return resourceGroups;
        }

        private async Task<Microsoft.Rest.Azure.IPage<Microsoft.Azure.Management.ResourceManager.Models.ResourceGroup>> GetResourceGroupListAsync(TokenCredentials credential, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.ResourceGroups.ListAsync();

            return resourceGroups;
        }

        private async Task<Microsoft.Rest.Azure.IPage<Microsoft.Azure.Management.ResourceManager.Models.GenericResource>> ResourceGroupListResourcesAsync(TokenCredentials credential, string resourceGroupName, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.ResourceGroups.ListResourcesAsync(resourceGroupName);

            return resourceGroups;
        }

        private async Task<Microsoft.Azure.Management.ResourceManager.Models.Provider> GetResourceProviderAsync(TokenCredentials credential, string resourceProviderName, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.Providers.GetAsync(resourceProviderName);

            return resourceGroups;
        }

        private async Task<Microsoft.Rest.Azure.IPage<Microsoft.Azure.Management.ResourceManager.Models.Provider>> GetResourceProviderListAsync(TokenCredentials credential, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.Providers.ListAsync();

            return resourceGroups;

            /*var computeClient = new ComputeManagementClient(credential)
            { SubscriptionId = subscriptionId };
            
            var test = await computeClient.*/
            //resourceManagementClient.ResourceGroups.GetAsync("").s


        }

        private async Task<TaskStatus> GetStatusTaskAsync(TokenCredentials credential, string resourceId, string groupName, string resourceProviderName, string parentResourcePath, string resourceType, string resourceName, string apiVersion, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };

            var resourceGroups = await resourceManagementClient.ResourceGroups.ListResourcesAsync(groupName);

            

            //return resourceGroups;
            TaskStatus ts = TaskStatus.Faulted;


            var resource = resourceManagementClient.Resources.GetByIdAsync(resourceId, apiVersion);  //GetAsync(groupName, resourceProviderName, parentResourcePath, resourceType, resourceName, apiVersion);
            var test2 = await resource;
            var testStatus = resource;


            
            return ts;

            
            //Microsoft.WindowsAzure.Management.Compute.Models.RoleInstanceStatus rs = new Microsoft.WindowsAzure.Management.Compute.Models.RoleInstanceStatus();





        }

       /* private async Task<TaskStatus> GetDeploymentsAsync(TokenCredentials credential, string groupName, string resourceProviderName, string parentResourcePath, string resourceType, string resourceName, string apiVersion, string subscriptionId)
        {

            var resourceManagementClient = new ResourceManagementClient(credential)
            { SubscriptionId = subscriptionId };


            var v1ComputeParams = new ResourceListParameters { ResourceType = "Microsoft.ClassicCompute/virtualMachines" };
            var v2ComputeParams = new ResourceListParameters { ResourceType = "Microsoft.Compute/virtualMachines" };


            var test = resourceManagementClient.Resources.ListAsync();

            var test2 = await test;
            
            //var v1ComputeResult = await resourceManagementClient.ListRecursiveAsync(v1ComputeParams, null);
            //var v2ComputeResult = await resourceManagementClient.ListRecursiveAsync(v2ComputeParams, null);

            //var resourceGroups = await resourceManagementClient.Deployments.GetAsync("","").







            return ts;


            //Microsoft.WindowsAzure.Management.Compute.Models.RoleInstanceStatus rs = new Microsoft.WindowsAzure.Management.Compute.Models.RoleInstanceStatus();





        }*/

        /*public static async Task<IList<GenericResourceExtended>> ListRecursiveAsync(this ResourceManagementClient client, ResourceListParameters listParams, string nextLink)
        {
            var rValue = new List<GenericResourceExtended>();

            ResourceListResult computeList = null;

            if (!string.IsNullOrWhiteSpace(nextLink))
            {
                computeList = await client.Resources.ListNextAsync(nextLink);
            }
            else
            {
                computeList = await client.Resources.ListAsync(listParams);
            }

            rValue.AddRange(computeList.Resources);

            if (!string.IsNullOrWhiteSpace(computeList.NextLink))
            {
                var nextResult = await ListRecursiveAsync(client, null, computeList.NextLink);
                rValue.AddRange(nextResult);
            }

            return rValue;
        }*/

        #endregion

    }
}
