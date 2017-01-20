using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManageCloudService.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            X509Certificate2 cert = StorageAccount.GetCertificate("8D62824B45A8E2B8F6F81709F0286E6C37FF1317");

            StorageAccount.test("f4859832-b7da-43a5-a172-da517ee71132", cert);

            


           /* var netClient = new Microsoft.Azure.Management.Compute.ComputeManagementClient(new CustomLoginCredentials());

            netClient.SubscriptionId = "f4859832-b7da-43a5-a172-da517ee71132";*/

            


            Console.ReadKey();
        }
    }
}
