using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVaultHelper47
{
    public class KeyVaultService
    {
        private readonly string KEY_VAULT_NAME;
        private readonly string TENANT_ID;
        private readonly string CLIENT_ID;
        private readonly string CLIENT_SECRET;
        private SecretClient secretClient;

     
        public KeyVaultService(string keyVaultName, string tenantId, string clientId, string clientSecret)
        {
            this.KEY_VAULT_NAME = keyVaultName;
            this.TENANT_ID = tenantId;
            this.CLIENT_ID = clientId;
            this.CLIENT_SECRET = clientSecret;
        }
        private SecretClient GetKeyVaultClient()
        {
            var keyVaultUri = $"https://{KEY_VAULT_NAME}.vault.azure.net/";
            var clientCre = new ClientSecretCredential(TENANT_ID, CLIENT_ID, CLIENT_SECRET);

            if(secretClient == null)
            {
                this.secretClient = new SecretClient(new Uri(keyVaultUri), clientCre);
            }
            
            return secretClient;
        }

        public bool CriaSegredo(string name, string value)
        {
            try
            {
                
                this.GetKeyVaultClient().SetSecret(new KeyVaultSecret(name, value));
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao cadastrar secret",ex);
            }
        }

        public string RecuperaSegredo(string secretName)
        {
            try
            {
                var cliente = this.GetKeyVaultClient();
                var secret =  cliente.GetSecret(secretName);
                return secret.Value.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao ler o secret", ex);
            }
        }
    }
}
