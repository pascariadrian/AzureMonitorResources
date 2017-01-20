
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;

namespace EllipseMonitor.Microsoft.WindowsAzure
{
    public static class LoginCredentials
    {

        private static SubscriptionCloudCredentials credentials;

        public static SubscriptionCloudCredentials Credentials
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

        static LoginCredentials()
        { }

        public static void InitCredentials(string subscriptionId, string certThumbprint)
        {

            X509Certificate2 cert = GetCertificate(certThumbprint);

            Credentials = new CertificateCloudCredentials(subscriptionId, cert);
        }


        #region private methods
        private static X509Certificate2 GetCertificate(string thumbprint)
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

        #endregion

    }
}
