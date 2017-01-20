using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipseMonitor.WindowsForm.Utils
{
    public class AzureCredentials
    {
        private string subscriptionId;
        private string subscriptionName;
        private string tenantId;
        private string clientId;
        private string clientSecret;
        private string certThumbPrint;

        public string SubscriptionId
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

        public string SubscriptionName
        {
            get
            {
                return subscriptionName;
            }
            set
            {
                subscriptionName = value;
            }
        }

        public string TenantId
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

        public string ClientId
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

        public  string ClientSecret
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

        public  string CertThumbPrint
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

        public AzureCredentials()
        {

        }

        public AzureCredentials(string _subscriptionId, string _subscriptionName, string _tenantId, string _clientId, string _clientSecret, string _certThumbPrint)
        {

            SubscriptionId = _subscriptionId;
            SubscriptionName = _subscriptionName;
            TenantId = _tenantId;
            ClientId = _clientId;
            ClientSecret =_clientSecret;
            CertThumbPrint = _certThumbPrint;

        }

        public AzureCredentials find(List<Utils.AzureCredentials> _azureCredentialsList, string _subscription)
        {
            
            var result = _azureCredentialsList.Find(x => x.SubscriptionId.Contains(_subscription));
            return result;
        }
    }
}
