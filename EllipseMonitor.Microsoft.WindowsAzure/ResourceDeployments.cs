using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Common;

namespace EllipseMonitor.Microsoft.WindowsAzure
{
    public class ResourceDeployments
    {

        public ResourceDeployments()
        {


        }


        public DeploymentGetResponse GetDeployments(SubscriptionCloudCredentials credentials, string serviceName, DeploymentSlot deploymentSlot)
        {
            IComputeManagementClient ComputeManagementClient = new ComputeManagementClient();

            
            var deployments = ComputeManagementClient.Deployments.GetBySlot(serviceName, deploymentSlot);

            var state = deployments.RoleInstances.First().PowerState;

            return deployments;

        }
    }
}
