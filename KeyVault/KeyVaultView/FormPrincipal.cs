using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyVaultView
{
    public partial class FormPrincipal : Form
    {
        private List<KeyVaultModel> KeyVaults = new List<KeyVaultModel>();

        #region Properties

        public string SelectedKeyVault
        {
            get
            {
                return this.cmbKeyVaults.SelectedValue.ToString();
            }
        }

        public string SecretName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtSecretName.Text))
                {
                    throw new Exception("Enter a secret name");
                }
                return this.txtSecretName.Text;
            }
        }

        public string NewSecretValue
        {
            get
            {
                return txtNewSecret.Text;
            }
        }

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
            this.LoadView();
        }

        private void LoadView()
        {
            this.LoadKeyVaults();
            cmbKeyVaults.DataSource = this.KeyVaults;

        }

        private void LoadKeyVaults()
        {
            /****Add yours key vaults here ****/

            this.KeyVaults.Add(new KeyVaultModel
            {
                KvAlias = "KV1",
                KvName = "kv-name-1",
                ClientId = "KvClientId1",
                ClientSecret = "kvClientSecret1",
                TenantId = "KvTenantId1"
            });
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SearchSecret(this.SelectedKeyVault, this.SecretName);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSecret(string keyVault, string secretName)
        {
            try
            {
                var kvModel = this.KeyVaults.Find(x => x.KvName.Equals(keyVault));
                var helper = KeyVaultHelper.GetKeyVaultService(kvModel.KvName, kvModel.TenantId, kvModel.ClientId, kvModel.ClientSecret);
                var secret = helper.RecuperaSegredo(secretName);
                txtSecretValue.Text = secret;
                txtNewSecret.Text = secret;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateSecret(string keyVault)
        {
            try
            {
                var kvModel = this.KeyVaults.Find(x => x.KvName.Equals(keyVault));
                var helper = KeyVaultHelper.GetKeyVaultService(kvModel.KvName, kvModel.TenantId, kvModel.ClientId, kvModel.ClientSecret);
                var success = helper.CriaSegredo(SecretName,NewSecretValue);
                if (success)
                {
                    var secret = helper.RecuperaSegredo(SecretName);
                    txtSecretValue.Text = secret;
                    txtNewSecret.Text = secret;
                }
               
            }
            catch
            {
                throw;
            }
        }

        private void btnSaveSecret_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSecret(SelectedKeyVault);
                MessageBox.Show("Secret updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKeyVaults_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyVault = this.KeyVaults.Find(x => x.KvName.Equals(SelectedKeyVault));
            btnSaveSecret.Enabled = !keyVault.KvAlias.Equals("PROD");
        }
    }
}
