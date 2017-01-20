using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.ManageDeployments
{
    public class ResourceDeployments
    {

        private SubscriptionCloudCredentials clientCredentials;

        public SubscriptionCloudCredentials ClientCredentials
        {
            get
            {
                return clientCredentials;
            }
            set
            {
                clientCredentials = value;
            }
        }

        public ResourceDeployments(string subscriptionId, string certThumbNumber)
        {
            try
            {
                X509Certificate2 x509Certificate = GetCertificate(certThumbNumber);
                ClientCredentials = new CertificateCloudCredentials(subscriptionId, x509Certificate);

                //ClientCredentials = new TokenCloudCredentials(subscriptionId, certThumbNumber);
            }
            catch
            {

            }
        }


        public IList<RoleInstance> GetDeployments(string serviceName, DeploymentSlot deploymentSlot)
        {
            IComputeManagementClient ComputeManagementClient = new ComputeManagementClient(ClientCredentials);


            var deployments = ComputeManagementClient.Deployments.GetBySlot(serviceName, deploymentSlot);

            var state = deployments.RoleInstances.First().PowerState;

            return deployments.RoleInstances;
        }


        public IList<RoleInstance> RestartRoleInstance(string serviceName, DeploymentSlot deploymentSlot)
        {
            IComputeManagementClient ComputeManagementClient = new ComputeManagementClient(ClientCredentials);


            var deployments = ComputeManagementClient.Deployments.GetBySlot(serviceName, deploymentSlot);

            var state = deployments.RoleInstances.First().PowerState;

            return deployments.RoleInstances;

            //DeploymentUpdateStatusParameters pr = new DeploymentUpdateStatusParameters(UpdatedDeploymentStatus.Running)
        }




        private X509Certificate2 GetCertificate(string thumbprint)
        {
            List<StoreLocation> locations = new List<StoreLocation> {
                StoreLocation.CurrentUser,
                StoreLocation.LocalMachine };

            foreach (var location in locations)
            {
                X509Store store = new X509Store("My", location);
                try
                {
                    store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                    X509Certificate2Collection certificates = store.Certificates.Find(
                      X509FindType.FindByThumbprint, thumbprint, false);

                    if (certificates.Count == 1)
                    {
                        return certificates[0];
                    }
                    else
                    {
                        foreach (var cer in store.Certificates)
                        {
                            if (cer.Thumbprint.ToLower() == thumbprint.ToLower())
                            {
                                return cer;
                            }
                        }
                    }
                }
                finally
                {
                    store.Close();
                }
            }

            throw new ArgumentException(string.Format(
              "A certificate with thumbprint '{0}' could not be located.",
              thumbprint));
        }



        /*public IList<RoleInstance> GetDeploymentsFromAzure(string serviceName, DeploymentSlot deploymentSlot)
        {
            IComputeManagementClient ComputeManagementClient = new ComputeManagementClient(ClientCredentials);


            var deployments = ComputeManagementClient.Deployments. // .Deployments.GetBySlot(serviceName, deploymentSlot);

            var state = deployments.RoleInstances.First().PowerState;

            return deployments.RoleInstances;

            var computeManagementClient2 = Microsoft.Azure.Mangement






                //new Microsoft.WindowsAzure.Management.Compute.ComputeManagementClient
        }*/




    }
}
