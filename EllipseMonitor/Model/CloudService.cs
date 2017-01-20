using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using Microsoft.WindowsAzure.Management.Models;
using System.Configuration;
using Microsoft.Azure;
using Microsoft.Rest;

namespace EllipseMonitor.Model
{
    public class CloudService
    {
        public CloudService()
        { }


        #region public methods
        public async Task<IEnumerable<HostedServiceListResponse.HostedService>> GetCloudServicesList(Microsoft.Azure.TokenCloudCredentials credential, string subscriptionId)
        {
            var result = CloudServiceList(credential);

            var resultList = await result;

            var providerList = resultList.AsEnumerable();

            return providerList;
        }


        #endregion



        #region private methods
        private async static Task<HostedServiceListResponse> CloudServiceList(Microsoft.Azure.SubscriptionCloudCredentials credentials)
        {
            using (var computeClient = new ComputeManagementClient(credentials))
            {
                var cloudService = await computeClient.HostedServices.ListAsync();


                //computeClient.HostedServices.GetAsync("asdas").g
                return cloudService;
            }
        }

        #endregion
    }
}
