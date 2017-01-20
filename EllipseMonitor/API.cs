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
using System.Configuration;
using System.Threading;

namespace EllipseMonitor
{
    public static class API
    {
        private static TokenCredentials credentials;
        private static string subscriptionId;
        private static string tenantId ;
        private static string clientId ;
        private static string clientSecret;
        private static TokenCloudCredentials cloudCredentials;
        private static string certThumbPrint;
        private static string tokenKey;


        public static TokenCredentials Credential
        {
            get
            {
                return credentials;
            }
            set
            {
                credentials = value;
            }
        }

        public static TokenCloudCredentials CloudCredential
        {
            get
            {
                return cloudCredentials;
            }
            set
            {
                cloudCredentials = value;
            }
        }

        public static string SubscriptionId
        {
            get
            {
                return subscriptionId;
            }
            set
            {
                subscriptionId = value;
            }
        }

        public static string TenantId
        {
            get
            {
                return tenantId;
            }
            set
            {
                tenantId = value;
            }
        }

        public static string ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
            }
        }

        public static string ClientSecret
        {
            get
            {
                return clientSecret;
            }
            set
            {
                clientSecret = value;
            }
        }

        public static string CertThumbPrint
        {
            get
            {
                return certThumbPrint;
            }
            set
            {
                certThumbPrint = value;
            }
        }

        public static string TokenKey
        {
            get
            {
                return tokenKey;
            }
            set
            {
                tokenKey = value;
            }
        }


        public async static Task <Boolean> Init()
        {
            try
            {
                var token = GetAccessTokenAsync();
                var tokenResult = await token;
                Credential = new TokenCredentials(token.Result.AccessToken);


                var cloudToken = GetAccessTokenAsyncCloud();
                var cloudTokenResult = await cloudToken;

                CloudCredential = new TokenCloudCredentials(SubscriptionId, cloudTokenResult.AccessToken);
                TokenKey = cloudTokenResult.AccessToken;
            }
            catch (Exception exc)
            {
                new Exception("Token error " + exc.Message);
                return false;
            }

            return true;
        }


        public async static Task<String> GetToken()
        {
            try
            {
                var token = GetAccessTokenAsyncCloud();
                var tokenResult = await token;

                return tokenResult.AccessToken;
            }
            catch (Exception exc)
            {
                new Exception("Token error " + exc.Message);
            }

            return "";
        }




        #region public methods

        #endregion


        #region private methods

        private static async Task<AuthenticationResult> GetAccessTokenAsync()
        {
            var cc = new ClientCredential(ClientId, ClientSecret);
            string url = "https://login.windows.net/" + TenantId;
            var context = new AuthenticationContext(url);
            var token = await context.AcquireTokenAsync("https://management.azure.com/", cc);
            if (token == null)
            {
                throw new InvalidOperationException("Could not get the token");
            }
            return token;
        }

        private static async Task<AuthenticationResult> GetAccessTokenAsyncCloud()
        {
            var cc = new ClientCredential(ClientId, ClientSecret);
            string url = "https://login.windows.net/" + TenantId;
            var context = new AuthenticationContext(url);
            var token = await context.AcquireTokenAsync("https://management.core.windows.net/", cc);
            if (token == null)
            {
                throw new InvalidOperationException("Could not get the token");
            }
            return token;
        }



        #endregion



    }
}
