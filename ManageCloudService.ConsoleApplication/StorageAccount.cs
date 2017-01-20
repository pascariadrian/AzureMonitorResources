using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;
using Microsoft.WindowsAzure.Management.Storage;
using Microsoft.WindowsAzure.Management.Storage.Models;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace ManageCloudService.ConsoleApplication
{
    public  static class StorageAccount
    {


        /*
         SubscriptionCloudCredentials certificate = new CertificateCloudCredentials(subscriptionId, x509Certificate);

IComputeManagementClient ComputeManagementClient = new ComputeManagementClient(certificate);

var deployments = ComputeManagementClient.Deployments.GetBySlot(hostedServiceName, DeploymentSlot.YourDeploymentSlot);

var state = deployments.RoleInstances.First().PowerState;
         */

        public static void testHostedService()
        {
            

        }


        public static void test(string subscriptionId, X509Certificate2 x509Certificate)
        {
            //SubscriptionCloudCredentials certificate = new CertificateCloudCredentials(subscriptionId, x509Certificate);

            SubscriptionCloudCredentials tokenTest = new TokenCloudCredentials(subscriptionId, "");
//            Microsoft.WindowsAzure.SubscriptionCloudCredentials

            IComputeManagementClient ComputeManagementClient = new ComputeManagementClient(tokenTest/*certificate*/);

            var deployments = ComputeManagementClient.Deployments.GetBySlot("DEV-21-AOS-D2", DeploymentSlot.Production);

            var state = deployments.RoleInstances.First().PowerState;


            
            //
            //SubscriptionCloudCredentials sb = new 

        }

        public static X509Certificate2 GetCertificate(string thumbprint)
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

    }
}
