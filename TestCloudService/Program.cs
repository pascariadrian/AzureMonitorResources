using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.WindowsAzure;
using System.Threading;
using System.Threading.Tasks;


namespace TestCloudService
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /*private static async string GetAuthorizationHeader()
        {
            AuthenticationResult result = null;
           

            var context = new AuthenticationContext(string.Format(
              "https://login.windows.net/{0}",
              "tenantId"));

            var cc = new ClientCredential("e5a0aafa-5f86-4b4c-8de9-652a8ca25981", "lSVdAGJ7x62zQB0AIa8sgrkoYVj9O/iG6TA1D6+vtk0=");

            var thread = new Thread(() =>
            {
                var result = await context.AcquireTokenAsync("https://management.core.windows.net/",cc);
            });
            
            /*
             var cc = new ClientCredential(ClientId, ClientSecret);
            string url = "https://login.windows.net/" + TenantId;
            var context = new AuthenticationContext(url);
            var token = await context.AcquireTokenAsync("https://management.core.windows.net/", cc);
            if (token == null)
            {
                throw new InvalidOperationException("Could not get the token");
            }
            return token;
             */

            /*
            thread.SetApartmentState(ApartmentState.STA);
            thread.Name = "AquireTokenThread";
            thread.Start();
            thread.Join();

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            string token = result.AccessToken;
            return token;
           
        }*/
    }
}
