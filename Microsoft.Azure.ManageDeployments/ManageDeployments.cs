using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Rest;

namespace Microsoft.Azure.ManageDeployments
{
    class ManageDeployments
    {

        public void test()
        {
            ServiceClientCredentials credentials = new TokenCredentials("");
            var test = new Management.ResourceManager.ResourceManagementClient(credentials);

            //   var test2 = test.Deployments.

            Microsoft.Azure.Management.Resource.Fluent.ResourceManagementClient client = new Management.Resource.Fluent.ResourceManagementClient(credentials);


            //var test2 = test.Deployments.
            //var deployments = client.de.   .Deployments.GetBySlot(serviceName, deploymentSlot);

        }
    }
}
