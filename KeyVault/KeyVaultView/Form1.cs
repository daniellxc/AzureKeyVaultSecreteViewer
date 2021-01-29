using KeyVaultHelper47;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadApp();
        }

        private void LoadApp()
        {
            cbEditMode.Visible = false;
        }

        #region Properties
        public string TenantId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtTenantId.Text))
                {
                    throw new Exception("Tenant Id can not be null.");
                }
                return txtTenantId.Text;

            }
        }

        public string ClientId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtClientId.Text))
                {
                    throw new Exception("Client Id can not be null.");
                }
                return txtClientId.Text;

            }
        }

        public string ClientSecret
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtClientSecret.Text))
                {
                    throw new Exception("Client Secret can not be null.");
                }
                return txtClientSecret.Text;

            }
        }

        public string KeyVaultName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtKeyVault.Text))
                {
                    throw new Exception("Key Vault Name can not be null.");
                }
                return txtKeyVault.Text;

            }
        }

        public string SecretName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtSecretName.Text))
                {
                    throw new Exception("Secret Name can not be null.");
                }
                return txtSecretName.Text;

            }
        }

        public string SecretValue
        {
            get
            {
                return txtSecretValue.Text;
            }
            set
            {
                txtSecretValue.Text = value;
            }
        }

        public string NewSecretValue
        {
            get
            {
                return txtNewSecret.Text;
            }
            set
            {
                txtNewSecret.Text = value;
            }
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchSecret();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message + ex.InnerException.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSecret()
        {
            try
            {
                var helper = GetKeyVaultService();
                this.SecretValue = helper.RecuperaSegredo(SecretName);
                cbEditMode.Visible = true;
            }
            catch
            {
                throw;
            }
        }

        private void UpdateSecret()
        {
            try
            {
                var helper = GetKeyVaultService();
                helper.CriaSegredo(SecretName, SecretValue);
            }
            catch
            {
                throw;
            }
        }

        private void CreteSecret()
        {
            try
            {
                var helper = GetKeyVaultService();
                helper.CriaSegredo(SecretName, NewSecretValue);
            }
            catch
            {
                throw;
            }
        }

        protected KeyVaultService GetKeyVaultService()
        {
            try
            {
                var service = new KeyVaultService(KeyVaultName, TenantId, ClientId, ClientSecret);
                return service;
            }
            catch (Exception ex)
            {
                throw new Exception($"Key Vault connection fail. {ex.Message}", ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EditMode(((CheckBox)sender).Checked);
        }

        private void EditMode(bool editOn)
        {
            txtSecretValue.ReadOnly = !editOn;
            btnSaveNewValue.Visible = editOn;


        }

        private void btnSaveNewValue_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSecret();
                MessageBox.Show("Secret updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveSecret_Click(object sender, EventArgs e)
        {
            try
            {
                CreteSecret();
                MessageBox.Show("Secret created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
