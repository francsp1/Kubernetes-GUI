
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
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSpaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Servicepanel = new System.Windows.Forms.Panel();
            this.tabPageCreateService = new System.Windows.Forms.TabPage();
            this.cmbBoxServiceDeploymentName = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCreateService = new MaterialSkin.Controls.MaterialButton();
            this.lblServiceTargetPort = new MaterialSkin.Controls.MaterialLabel();
            this.txtServiceTargetPort = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServicePort = new MaterialSkin.Controls.MaterialTextBox();
            this.lblServicePort = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxServiceProtocol = new MaterialSkin.Controls.MaterialComboBox();
            this.lblServiceProtocol = new MaterialSkin.Controls.MaterialLabel();
            this.lblServiceDeployment = new MaterialSkin.Controls.MaterialLabel();
            this.txtServiceName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDeploymentName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
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
            this.keysTabSelector1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPageServices.Controls.Add(this.servicesDataGridView);
            this.tabPageServices.Controls.Add(this.Servicepanel);
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageServices.Size = new System.Drawing.Size(1131, 478);
            this.tabPageServices.TabIndex = 0;
            this.tabPageServices.Text = "Services";
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.servicesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.nameSpaceColumn,
            this.labelsColumn,
            this.typeColumn,
            this.ipColumn,
            this.endpointColumn1,
            this.externalColumn,
            this.createdColumn,
            this.deleteColumn});
            this.servicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.RowHeadersWidth = 51;
            this.servicesDataGridView.Size = new System.Drawing.Size(1125, 472);
            this.servicesDataGridView.TabIndex = 0;
            this.servicesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick_delete);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // nameSpaceColumn
            // 
            this.nameSpaceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nameSpaceColumn.HeaderText = "Namespace";
            this.nameSpaceColumn.MinimumWidth = 6;
            this.nameSpaceColumn.Name = "nameSpaceColumn";
            this.nameSpaceColumn.Width = 89;
            // 
            // labelsColumn
            // 
            this.labelsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.labelsColumn.HeaderText = "Labels";
            this.labelsColumn.MinimumWidth = 6;
            this.labelsColumn.Name = "labelsColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.MinimumWidth = 6;
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Width = 125;
            // 
            // ipColumn
            // 
            this.ipColumn.HeaderText = "Cluster IP";
            this.ipColumn.MinimumWidth = 6;
            this.ipColumn.Name = "ipColumn";
            this.ipColumn.Width = 125;
            // 
            // endpointColumn1
            // 
            this.endpointColumn1.HeaderText = "Internal Endpoints";
            this.endpointColumn1.MinimumWidth = 6;
            this.endpointColumn1.Name = "endpointColumn1";
            this.endpointColumn1.Width = 125;
            // 
            // externalColumn
            // 
            this.externalColumn.HeaderText = "External Endpoints";
            this.externalColumn.MinimumWidth = 6;
            this.externalColumn.Name = "externalColumn";
            this.externalColumn.Width = 125;
            // 
            // createdColumn
            // 
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.MinimumWidth = 6;
            this.createdColumn.Name = "createdColumn";
            this.createdColumn.Width = 125;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = global::Kubernetes_GUI.Properties.Resources.remove__1_;
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Width = 125;
            // 
            // Servicepanel
            // 
            this.Servicepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Servicepanel.Location = new System.Drawing.Point(3, 3);
            this.Servicepanel.Name = "Servicepanel";
            this.Servicepanel.Size = new System.Drawing.Size(1125, 472);
            this.Servicepanel.TabIndex = 1;
            // 
            // tabPageCreateService
            // 
            this.tabPageCreateService.BackColor = System.Drawing.Color.White;
            this.tabPageCreateService.Controls.Add(this.cmbBoxServiceDeploymentName);
            this.tabPageCreateService.Controls.Add(this.btnCreateService);
            this.tabPageCreateService.Controls.Add(this.lblServiceTargetPort);
            this.tabPageCreateService.Controls.Add(this.txtServiceTargetPort);
            this.tabPageCreateService.Controls.Add(this.txtServicePort);
            this.tabPageCreateService.Controls.Add(this.lblServicePort);
            this.tabPageCreateService.Controls.Add(this.cmbBoxServiceProtocol);
            this.tabPageCreateService.Controls.Add(this.lblServiceProtocol);
            this.tabPageCreateService.Controls.Add(this.lblServiceDeployment);
            this.tabPageCreateService.Controls.Add(this.txtServiceName);
            this.tabPageCreateService.Controls.Add(this.lblDeploymentName);
            this.tabPageCreateService.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateService.Name = "tabPageCreateService";
            this.tabPageCreateService.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageCreateService.Size = new System.Drawing.Size(1131, 478);
            this.tabPageCreateService.TabIndex = 1;
            this.tabPageCreateService.Text = "Create Service";
            // 
            // cmbBoxServiceDeploymentName
            // 
            this.cmbBoxServiceDeploymentName.AutoResize = false;
            this.cmbBoxServiceDeploymentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxServiceDeploymentName.Depth = 0;
            this.cmbBoxServiceDeploymentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxServiceDeploymentName.DropDownHeight = 174;
            this.cmbBoxServiceDeploymentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxServiceDeploymentName.DropDownWidth = 121;
            this.cmbBoxServiceDeploymentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxServiceDeploymentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxServiceDeploymentName.FormattingEnabled = true;
            this.cmbBoxServiceDeploymentName.IntegralHeight = false;
            this.cmbBoxServiceDeploymentName.ItemHeight = 43;
            this.cmbBoxServiceDeploymentName.Location = new System.Drawing.Point(28, 114);
            this.cmbBoxServiceDeploymentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxServiceDeploymentName.MaxDropDownItems = 4;
            this.cmbBoxServiceDeploymentName.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxServiceDeploymentName.Name = "cmbBoxServiceDeploymentName";
            this.cmbBoxServiceDeploymentName.Size = new System.Drawing.Size(300, 49);
            this.cmbBoxServiceDeploymentName.StartIndex = 0;
            this.cmbBoxServiceDeploymentName.TabIndex = 51;
            // 
            // btnCreateService
            // 
            this.btnCreateService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateService.Depth = 0;
            this.btnCreateService.HighEmphasis = true;
            this.btnCreateService.Icon = null;
            this.btnCreateService.Location = new System.Drawing.Point(251, 252);
            this.btnCreateService.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCreateService.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateService.Size = new System.Drawing.Size(76, 36);
            this.btnCreateService.TabIndex = 50;
            this.btnCreateService.Text = "Create";
            this.btnCreateService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateService.UseAccentColor = false;
            this.btnCreateService.UseVisualStyleBackColor = true;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // lblServiceTargetPort
            // 
            this.lblServiceTargetPort.AutoSize = true;
            this.lblServiceTargetPort.Depth = 0;
            this.lblServiceTargetPort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServiceTargetPort.Location = new System.Drawing.Point(244, 171);
            this.lblServiceTargetPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceTargetPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServiceTargetPort.Name = "lblServiceTargetPort";
            this.lblServiceTargetPort.Size = new System.Drawing.Size(79, 19);
            this.lblServiceTargetPort.TabIndex = 49;
            this.lblServiceTargetPort.Text = "Target port";
            // 
            // txtServiceTargetPort
            // 
            this.txtServiceTargetPort.AnimateReadOnly = false;
            this.txtServiceTargetPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceTargetPort.Depth = 0;
            this.txtServiceTargetPort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceTargetPort.LeadingIcon = null;
            this.txtServiceTargetPort.Location = new System.Drawing.Point(247, 188);
            this.txtServiceTargetPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceTargetPort.MaxLength = 50;
            this.txtServiceTargetPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServiceTargetPort.Multiline = false;
            this.txtServiceTargetPort.Name = "txtServiceTargetPort";
            this.txtServiceTargetPort.Size = new System.Drawing.Size(80, 50);
            this.txtServiceTargetPort.TabIndex = 48;
            this.txtServiceTargetPort.Text = "";
            this.txtServiceTargetPort.TrailingIcon = null;
            this.txtServiceTargetPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // txtServicePort
            // 
            this.txtServicePort.AnimateReadOnly = false;
            this.txtServicePort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicePort.Depth = 0;
            this.txtServicePort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicePort.LeadingIcon = null;
            this.txtServicePort.Location = new System.Drawing.Point(145, 190);
            this.txtServicePort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServicePort.MaxLength = 50;
            this.txtServicePort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicePort.Multiline = false;
            this.txtServicePort.Name = "txtServicePort";
            this.txtServicePort.Size = new System.Drawing.Size(80, 50);
            this.txtServicePort.TabIndex = 47;
            this.txtServicePort.Text = "";
            this.txtServicePort.TrailingIcon = null;
            this.txtServicePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // lblServicePort
            // 
            this.lblServicePort.AutoSize = true;
            this.lblServicePort.Depth = 0;
            this.lblServicePort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServicePort.Location = new System.Drawing.Point(142, 171);
            this.lblServicePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicePort.Name = "lblServicePort";
            this.lblServicePort.Size = new System.Drawing.Size(30, 19);
            this.lblServicePort.TabIndex = 46;
            this.lblServicePort.Text = "Port";
            // 
            // cmbBoxServiceProtocol
            // 
            this.cmbBoxServiceProtocol.AutoResize = false;
            this.cmbBoxServiceProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxServiceProtocol.Depth = 0;
            this.cmbBoxServiceProtocol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxServiceProtocol.DropDownHeight = 174;
            this.cmbBoxServiceProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxServiceProtocol.DropDownWidth = 121;
            this.cmbBoxServiceProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxServiceProtocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxServiceProtocol.FormattingEnabled = true;
            this.cmbBoxServiceProtocol.IntegralHeight = false;
            this.cmbBoxServiceProtocol.ItemHeight = 43;
            this.cmbBoxServiceProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.cmbBoxServiceProtocol.Location = new System.Drawing.Point(28, 189);
            this.cmbBoxServiceProtocol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxServiceProtocol.MaxDropDownItems = 4;
            this.cmbBoxServiceProtocol.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxServiceProtocol.Name = "cmbBoxServiceProtocol";
            this.cmbBoxServiceProtocol.Size = new System.Drawing.Size(92, 49);
            this.cmbBoxServiceProtocol.StartIndex = 0;
            this.cmbBoxServiceProtocol.TabIndex = 45;
            // 
            // lblServiceProtocol
            // 
            this.lblServiceProtocol.AutoSize = true;
            this.lblServiceProtocol.Depth = 0;
            this.lblServiceProtocol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServiceProtocol.Location = new System.Drawing.Point(26, 171);
            this.lblServiceProtocol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceProtocol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServiceProtocol.Name = "lblServiceProtocol";
            this.lblServiceProtocol.Size = new System.Drawing.Size(60, 19);
            this.lblServiceProtocol.TabIndex = 44;
            this.lblServiceProtocol.Text = "Protocol";
            // 
            // lblServiceDeployment
            // 
            this.lblServiceDeployment.AutoSize = true;
            this.lblServiceDeployment.Depth = 0;
            this.lblServiceDeployment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServiceDeployment.Location = new System.Drawing.Point(26, 96);
            this.lblServiceDeployment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceDeployment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServiceDeployment.Name = "lblServiceDeployment";
            this.lblServiceDeployment.Size = new System.Drawing.Size(132, 19);
            this.lblServiceDeployment.TabIndex = 42;
            this.lblServiceDeployment.Text = "Deployment Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.AnimateReadOnly = false;
            this.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceName.Depth = 0;
            this.txtServiceName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceName.LeadingIcon = null;
            this.txtServiceName.Location = new System.Drawing.Point(28, 37);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceName.MaxLength = 50;
            this.txtServiceName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServiceName.Multiline = false;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(299, 50);
            this.txtServiceName.TabIndex = 30;
            this.txtServiceName.Text = "";
            this.txtServiceName.TrailingIcon = null;
            // 
            // lblDeploymentName
            // 
            this.lblDeploymentName.AutoSize = true;
            this.lblDeploymentName.Depth = 0;
            this.lblDeploymentName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentName.Location = new System.Drawing.Point(26, 20);
            this.lblDeploymentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeploymentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentName.Name = "lblDeploymentName";
            this.lblDeploymentName.Size = new System.Drawing.Size(96, 19);
            this.lblDeploymentName.TabIndex = 29;
            this.lblDeploymentName.Text = "Service name";
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
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.tabPageCreateService.ResumeLayout(false);
            this.tabPageCreateService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector keysTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageCreateService;
        private System.Windows.Forms.DataGridView servicesDataGridView;
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
        private MaterialSkin.Controls.MaterialTextBox txtServiceName;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentName;
        private MaterialSkin.Controls.MaterialLabel lblServiceDeployment;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxServiceProtocol;
        private MaterialSkin.Controls.MaterialLabel lblServiceProtocol;
        private MaterialSkin.Controls.MaterialTextBox txtServicePort;
        private MaterialSkin.Controls.MaterialLabel lblServicePort;
        private MaterialSkin.Controls.MaterialTextBox txtServiceTargetPort;
        private MaterialSkin.Controls.MaterialLabel lblServiceTargetPort;
        private MaterialSkin.Controls.MaterialButton btnCreateService;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxServiceDeploymentName;
    }
}