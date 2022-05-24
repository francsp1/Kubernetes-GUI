
namespace Kubernetes_GUI.Forms
{
    partial class ServiceForm
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
            this.keysTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.servicesGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageCreateService = new System.Windows.Forms.TabPage();
            this.CreateKeyButton = new MaterialSkin.Controls.MaterialButton();
            this.typekeyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.typeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.txtkeyName = new MaterialSkin.Controls.MaterialTextBox();
            this.keyName = new MaterialSkin.Controls.MaterialLabel();
            this.Servicepanel = new System.Windows.Forms.Panel();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSpaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView1)).BeginInit();
            this.tabPageCreateService.SuspendLayout();
            this.SuspendLayout();
            // 
            // keysTabSelector1
            // 
            this.keysTabSelector1.BaseTabControl = this.materialTabControl1;
            this.keysTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.keysTabSelector1.Depth = 0;
            this.keysTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.keysTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keysTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.keysTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.keysTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.keysTabSelector1.Name = "keysTabSelector1";
            this.keysTabSelector1.Size = new System.Drawing.Size(1139, 39);
            this.keysTabSelector1.TabIndex = 0;
            this.keysTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageServices);
            this.materialTabControl1.Controls.Add(this.tabPageCreateService);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 39);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1139, 504);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPageServices
            // 
            this.tabPageServices.BackColor = System.Drawing.Color.White;
            this.tabPageServices.Controls.Add(this.servicesGridView1);
            this.tabPageServices.Controls.Add(this.Servicepanel);
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(1131, 478);
            this.tabPageServices.TabIndex = 0;
            this.tabPageServices.Text = "Services";
            // 
            // servicesGridView1
            // 
            this.servicesGridView1.AllowUserToAddRows = false;
            this.servicesGridView1.BackgroundColor = System.Drawing.Color.White;
            this.servicesGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.servicesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.nameSpaceColumn,
            this.labelsColumn,
            this.typeColumn,
            this.ipColumn,
            this.endpointColumn1,
            this.externalColumn,
            this.createdColumn,
            this.deleteColumn});
            this.servicesGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesGridView1.Location = new System.Drawing.Point(3, 3);
            this.servicesGridView1.Name = "servicesGridView1";
            this.servicesGridView1.RowHeadersWidth = 51;
            this.servicesGridView1.Size = new System.Drawing.Size(1125, 472);
            this.servicesGridView1.TabIndex = 0;
            this.servicesGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick_delete);
            this.servicesGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesGridView1_CellContentClick);
            // 
            // tabPageCreateService
            // 
            this.tabPageCreateService.BackColor = System.Drawing.Color.White;
            this.tabPageCreateService.Controls.Add(this.CreateKeyButton);
            this.tabPageCreateService.Controls.Add(this.typekeyLabel);
            this.tabPageCreateService.Controls.Add(this.typeComboBox);
            this.tabPageCreateService.Controls.Add(this.txtkeyName);
            this.tabPageCreateService.Controls.Add(this.keyName);
            this.tabPageCreateService.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateService.Name = "tabPageCreateService";
            this.tabPageCreateService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateService.Size = new System.Drawing.Size(1131, 478);
            this.tabPageCreateService.TabIndex = 1;
            this.tabPageCreateService.Text = "Create Service";
            // 
            // CreateKeyButton
            // 
            this.CreateKeyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateKeyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateKeyButton.Depth = 0;
            this.CreateKeyButton.HighEmphasis = true;
            this.CreateKeyButton.Icon = null;
            this.CreateKeyButton.Location = new System.Drawing.Point(12, 279);
            this.CreateKeyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateKeyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateKeyButton.Name = "CreateKeyButton";
            this.CreateKeyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateKeyButton.Size = new System.Drawing.Size(142, 36);
            this.CreateKeyButton.TabIndex = 21;
            this.CreateKeyButton.Text = "Create Key Pair";
            this.CreateKeyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateKeyButton.UseAccentColor = false;
            this.CreateKeyButton.UseVisualStyleBackColor = true;
            this.CreateKeyButton.Click += new System.EventHandler(this.CreateKeyButton_Click);
            // 
            // typekeyLabel
            // 
            this.typekeyLabel.AutoSize = true;
            this.typekeyLabel.Depth = 0;
            this.typekeyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typekeyLabel.Location = new System.Drawing.Point(18, 159);
            this.typekeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typekeyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.typekeyLabel.Name = "typekeyLabel";
            this.typekeyLabel.Size = new System.Drawing.Size(66, 19);
            this.typekeyLabel.TabIndex = 18;
            this.typekeyLabel.Text = "Key Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoResize = false;
            this.typeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeComboBox.Depth = 0;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeComboBox.DropDownHeight = 174;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.DropDownWidth = 121;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.IntegralHeight = false;
            this.typeComboBox.ItemHeight = 43;
            this.typeComboBox.Items.AddRange(new object[] {
            "SSH Key",
            "X509 Certificate"});
            this.typeComboBox.Location = new System.Drawing.Point(12, 181);
            this.typeComboBox.MaxDropDownItems = 4;
            this.typeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(571, 49);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 17;
            // 
            // txtkeyName
            // 
            this.txtkeyName.AnimateReadOnly = false;
            this.txtkeyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkeyName.Depth = 0;
            this.txtkeyName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtkeyName.LeadingIcon = null;
            this.txtkeyName.Location = new System.Drawing.Point(12, 71);
            this.txtkeyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtkeyName.MaxLength = 50;
            this.txtkeyName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtkeyName.Multiline = false;
            this.txtkeyName.Name = "txtkeyName";
            this.txtkeyName.Size = new System.Drawing.Size(571, 50);
            this.txtkeyName.TabIndex = 4;
            this.txtkeyName.Text = "";
            this.txtkeyName.TrailingIcon = null;
            // 
            // keyName
            // 
            this.keyName.AutoSize = true;
            this.keyName.Depth = 0;
            this.keyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keyName.Location = new System.Drawing.Point(18, 50);
            this.keyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyName.Name = "keyName";
            this.keyName.Size = new System.Drawing.Size(105, 19);
            this.keyName.TabIndex = 3;
            this.keyName.Text = "Key Pair Name";
            // 
            // Servicepanel
            // 
            this.Servicepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Servicepanel.Location = new System.Drawing.Point(3, 3);
            this.Servicepanel.Name = "Servicepanel";
            this.Servicepanel.Size = new System.Drawing.Size(1125, 472);
            this.Servicepanel.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // nameSpaceColumn
            // 
            this.nameSpaceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nameSpaceColumn.HeaderText = "Namespace";
            this.nameSpaceColumn.Name = "nameSpaceColumn";
            this.nameSpaceColumn.Width = 89;
            // 
            // labelsColumn
            // 
            this.labelsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.labelsColumn.HeaderText = "Labels";
            this.labelsColumn.Name = "labelsColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // ipColumn
            // 
            this.ipColumn.HeaderText = "Cluster IP";
            this.ipColumn.Name = "ipColumn";
            // 
            // endpointColumn1
            // 
            this.endpointColumn1.HeaderText = "Internal Endpoints";
            this.endpointColumn1.Name = "endpointColumn1";
            // 
            // externalColumn
            // 
            this.externalColumn.HeaderText = "External Endpoints";
            this.externalColumn.Name = "externalColumn";
            // 
            // createdColumn
            // 
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.Name = "createdColumn";
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = global::Kubernetes_GUI.Properties.Resources.remove__1_;
            this.deleteColumn.Name = "deleteColumn";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1139, 543);
            this.ControlBox = false;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.keysTabSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "KeyPairForm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView1)).EndInit();
            this.tabPageCreateService.ResumeLayout(false);
            this.tabPageCreateService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector keysTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageCreateService;
        private System.Windows.Forms.DataGridView servicesGridView1;
        private MaterialSkin.Controls.MaterialTextBox txtkeyName;
        private MaterialSkin.Controls.MaterialLabel keyName;
        private MaterialSkin.Controls.MaterialLabel typekeyLabel;
        private MaterialSkin.Controls.MaterialComboBox typeComboBox;
        private MaterialSkin.Controls.MaterialButton CreateKeyButton;
        private System.Windows.Forms.Panel Servicepanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSpaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}