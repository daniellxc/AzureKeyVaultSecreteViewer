using KeyVaultHelper47;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVaultView
{
    public class KeyVaultHelper
    {

        public static KeyVaultService GetKeyVaultService(string keyVaultName, string tenantId, string clientId, string clientSecret)
        {
            try
            {
                var service = new KeyVaultService(keyVaultName, tenantId, clientId, clientSecret);
                return service;
            }
            catch (Exception ex)
            {
                throw new Exception($"Key Vault connection fail. {ex.Message}", ex);
            }
        }
    }
}
