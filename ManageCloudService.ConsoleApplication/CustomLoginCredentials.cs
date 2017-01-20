
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageCloudService.ConsoleApplication
{
    class CustomLoginCredentials : ServiceClientCredentials
    {
        private string AuthenticationToken { get; set; }
        public async override void InitializeServiceClient<T>(ServiceClient<T> client)
        {
            var authenticationContext =
                new AuthenticationContext("https://login.windows.net/5476bed1-8973-4c10-b96b-4538cd9297f9");
            var credential = new ClientCredential(clientId: "e5a0aafa-5f86-4b4c-8de9-652a8ca25981", clientSecret: "lSVdAGJ7x62zQB0AIa8sgrkoYVj9O/iG6TA1D6+vtk0=");

            var result = authenticationContext.AcquireTokenAsync(resource: "https://management.core.windows.net/",
                clientCredential: credential);

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            var accessToken = await result;
            
            AuthenticationToken = accessToken.AccessToken;
        }
        public override async Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (AuthenticationToken == null)
            {
                throw new InvalidOperationException("Token Provider Cannot Be Null");
            }



            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AuthenticationToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //request.Version = new Version(apiVersion);
            await base.ProcessHttpRequestAsync(request, cancellationToken);

        }
    }
}
