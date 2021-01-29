namespace KeyVaultView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveNewValue = new System.Windows.Forms.Button();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyVault = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblTenantId = new System.Windows.Forms.Label();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.txtSecretValue = new System.Windows.Forms.TextBox();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveSecret = new System.Windows.Forms.Button();
            this.txtNewSecret = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveNewValue);
            this.groupBox1.Controls.Add(this.cbEditMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSecretName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKeyVault);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClientSecret);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClientId);
            this.groupBox1.Controls.Add(this.lblTenantId);
            this.groupBox1.Controls.Add(this.txtTenantId);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // btnSaveNewValue
            // 
            this.btnSaveNewValue.Location = new System.Drawing.Point(539, 106);
            this.btnSaveNewValue.Name = "btnSaveNewValue";
            this.btnSaveNewValue.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewValue.TabIndex = 15;
            this.btnSaveNewValue.Text = "Update";
            this.btnSaveNewValue.UseVisualStyleBackColor = true;
            this.btnSaveNewValue.Visible = false;
            // 
            // cbEditMode
            // 
            this.cbEditMode.AutoSize = true;
            this.cbEditMode.Location = new System.Drawing.Point(460, 112);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(73, 17);
            this.cbEditMode.TabIndex = 14;
            this.cbEditMode.Text = "Edit mode";
            this.cbEditMode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Secret Name";
            // 
            // txtSecretName
            // 
            this.txtSecretName.Location = new System.Drawing.Point(95, 125);
            this.txtSecretName.Name = "txtSecretName";
            this.txtSecretName.Size = new System.Drawing.Size(161, 20);
            this.txtSecretName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key Vault Name";
            // 
            // txtKeyVault
            // 
            this.txtKeyVault.Location = new System.Drawing.Point(95, 99);
            this.txtKeyVault.Name = "txtKeyVault";
            this.txtKeyVault.Size = new System.Drawing.Size(161, 20);
            this.txtKeyVault.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(303, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Secret";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(95, 65);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(659, 20);
            this.txtClientSecret.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client ID";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(460, 28);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(294, 20);
            this.txtClientId.TabIndex = 2;
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.Location = new System.Drawing.Point(6, 31);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(55, 13);
            this.lblTenantId.TabIndex = 1;
            this.lblTenantId.Text = "Tenant ID";
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(95, 28);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(294, 20);
            this.txtTenantId.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuery);
            this.tabControl1.Controls.Add(this.tabCreate);
            this.tabControl1.Location = new System.Drawing.Point(8, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 254);
            this.tabControl1.TabIndex = 3;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.txtSecretValue);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(768, 228);
            this.tabQuery.TabIndex = 0;
            this.tabQuery.Text = "Query";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // txtSecretValue
            // 
            this.txtSecretValue.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSecretValue.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSecretValue.Location = new System.Drawing.Point(0, 3);
            this.txtSecretValue.Multiline = true;
            this.txtSecretValue.Name = "txtSecretValue";
            this.txtSecretValue.ReadOnly = true;
            this.txtSecretValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecretValue.Size = new System.Drawing.Size(765, 219);
            this.txtSecretValue.TabIndex = 4;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.groupBox2);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(768, 228);
            this.tabCreate.TabIndex = 1;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveSecret);
            this.groupBox2.Controls.Add(this.txtNewSecret);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert secret value";
            // 
            // btnSaveSecret
            // 
            this.btnSaveSecret.Location = new System.Drawing.Point(610, 150);
            this.btnSaveSecret.Name = "btnSaveSecret";
            this.btnSaveSecret.Size = new System.Drawing.Size(143, 44);
            this.btnSaveSecret.TabIndex = 2;
            this.btnSaveSecret.Text = "Save";
            this.btnSaveSecret.UseVisualStyleBackColor = true;
            this.btnSaveSecret.Click += new System.EventHandler(this.btnSaveSecret_Click);
            // 
            // txtNewSecret
            // 
            this.txtNewSecret.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtNewSecret.ForeColor = System.Drawing.Color.Lime;
            this.txtNewSecret.Location = new System.Drawing.Point(0, 19);
            this.txtNewSecret.Multiline = true;
            this.txtNewSecret.Name = "txtNewSecret";
            this.txtNewSecret.Size = new System.Drawing.Size(747, 125);
            this.txtNewSecret.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Key Vault Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveNewValue;
        private System.Windows.Forms.CheckBox cbEditMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecretName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyVault;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblTenantId;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TextBox txtSecretValue;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveSecret;
        private System.Windows.Forms.TextBox txtNewSecret;
    }
}

