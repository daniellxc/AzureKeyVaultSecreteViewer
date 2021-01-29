namespace KeyVaultView
{
    partial class FormPrincipal
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
            this.cmbKeyVaults = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecretName = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.txtSecretValue = new System.Windows.Forms.TextBox();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveSecret = new System.Windows.Forms.Button();
            this.txtNewSecret = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSecretName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbKeyVaults);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Key Vault";
            // 
            // cmbKeyVaults
            // 
            this.cmbKeyVaults.DisplayMember = "KvAlias";
            this.cmbKeyVaults.FormattingEnabled = true;
            this.cmbKeyVaults.Location = new System.Drawing.Point(81, 24);
            this.cmbKeyVaults.Name = "cmbKeyVaults";
            this.cmbKeyVaults.Size = new System.Drawing.Size(275, 21);
            this.cmbKeyVaults.TabIndex = 0;
            this.cmbKeyVaults.ValueMember = "KvName";
            this.cmbKeyVaults.SelectedIndexChanged += new System.EventHandler(this.cmbKeyVaults_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Vault";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secret Name";
            // 
            // txtSecretName
            // 
            this.txtSecretName.Location = new System.Drawing.Point(81, 59);
            this.txtSecretName.Name = "txtSecretName";
            this.txtSecretName.Size = new System.Drawing.Size(275, 20);
            this.txtSecretName.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuery);
            this.tabControl.Controls.Add(this.tabCreate);
            this.tabControl.Location = new System.Drawing.Point(12, 119);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 253);
            this.tabControl.TabIndex = 4;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.txtSecretValue);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(768, 227);
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
            this.txtSecretValue.Size = new System.Drawing.Size(765, 166);
            this.txtSecretValue.TabIndex = 4;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.groupBox2);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(768, 227);
            this.tabCreate.TabIndex = 1;
            this.tabCreate.Text = "Create/Update";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveSecret);
            this.groupBox2.Controls.Add(this.txtNewSecret);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert secret value";
            // 
            // btnSaveSecret
            // 
            this.btnSaveSecret.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveSecret.Location = new System.Drawing.Point(610, 165);
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
            this.txtNewSecret.Size = new System.Drawing.Size(747, 140);
            this.txtNewSecret.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Key Vault Secrets Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecretName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKeyVaults;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TextBox txtSecretValue;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveSecret;
        private System.Windows.Forms.TextBox txtNewSecret;
        private System.Windows.Forms.Button btnSearch;
    }
}