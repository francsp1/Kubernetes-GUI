
namespace Kubernetes_GUI.Forms
{
    partial class DeploymentsForm
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
            this.deploymentsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.deploymentsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.deploymentsTab = new System.Windows.Forms.TabPage();
            this.deploymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.columnDeploymentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeploymentNamespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeploymentImages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeploymentLabels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeploymentPods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeploymentCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCollumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteCollumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.createDeploymentTab = new System.Windows.Forms.TabPage();
            this.btnDeploymentApply = new MaterialSkin.Controls.MaterialButton();
            this.txtDeploymentNumberContainers = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDeploymentContainerPort = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeploymentContainerImage = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeploymentContainerName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeploymentNumberContainers = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeploymentReplicas = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDeploymentReplicas = new MaterialSkin.Controls.MaterialLabel();
            this.btnCreateDeployment = new MaterialSkin.Controls.MaterialButton();
            this.cmbBoxDeploymentNamespace = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDeploymentNamespace = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeploymentName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDeploymentName = new MaterialSkin.Controls.MaterialLabel();
            this.deploymentsTabControl.SuspendLayout();
            this.deploymentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deploymentsDataGridView)).BeginInit();
            this.createDeploymentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // deploymentsTabSelector
            // 
            this.deploymentsTabSelector.BaseTabControl = this.deploymentsTabControl;
            this.deploymentsTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.deploymentsTabSelector.Depth = 0;
            this.deploymentsTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.deploymentsTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deploymentsTabSelector.Location = new System.Drawing.Point(0, 0);
            this.deploymentsTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deploymentsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.deploymentsTabSelector.Name = "deploymentsTabSelector";
            this.deploymentsTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.deploymentsTabSelector.TabIndex = 0;
            // 
            // deploymentsTabControl
            // 
            this.deploymentsTabControl.Controls.Add(this.deploymentsTab);
            this.deploymentsTabControl.Controls.Add(this.createDeploymentTab);
            this.deploymentsTabControl.Depth = 0;
            this.deploymentsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deploymentsTabControl.Location = new System.Drawing.Point(0, 48);
            this.deploymentsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deploymentsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.deploymentsTabControl.Multiline = true;
            this.deploymentsTabControl.Name = "deploymentsTabControl";
            this.deploymentsTabControl.SelectedIndex = 0;
            this.deploymentsTabControl.Size = new System.Drawing.Size(1519, 668);
            this.deploymentsTabControl.TabIndex = 1;
            // 
            // deploymentsTab
            // 
            this.deploymentsTab.BackColor = System.Drawing.Color.White;
            this.deploymentsTab.Controls.Add(this.deploymentsDataGridView);
            this.deploymentsTab.Location = new System.Drawing.Point(4, 25);
            this.deploymentsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deploymentsTab.Name = "deploymentsTab";
            this.deploymentsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deploymentsTab.Size = new System.Drawing.Size(1511, 639);
            this.deploymentsTab.TabIndex = 0;
            this.deploymentsTab.Text = "Deployments";
            // 
            // deploymentsDataGridView
            // 
            this.deploymentsDataGridView.AllowUserToAddRows = false;
            this.deploymentsDataGridView.AllowUserToDeleteRows = false;
            this.deploymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deploymentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.deploymentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deploymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deploymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDeploymentName,
            this.columnDeploymentNamespace,
            this.columnDeploymentImages,
            this.columnDeploymentLabels,
            this.columnDeploymentPods,
            this.columnDeploymentCreated,
            this.editCollumn,
            this.deleteCollumn});
            this.deploymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deploymentsDataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.deploymentsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.deploymentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deploymentsDataGridView.Name = "deploymentsDataGridView";
            this.deploymentsDataGridView.ReadOnly = true;
            this.deploymentsDataGridView.RowHeadersWidth = 51;
            this.deploymentsDataGridView.RowTemplate.Height = 24;
            this.deploymentsDataGridView.Size = new System.Drawing.Size(1505, 635);
            this.deploymentsDataGridView.TabIndex = 0;
            this.deploymentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deploymentsDataGridView_CellClick);
            // 
            // columnDeploymentName
            // 
            this.columnDeploymentName.HeaderText = "Name";
            this.columnDeploymentName.MinimumWidth = 6;
            this.columnDeploymentName.Name = "columnDeploymentName";
            this.columnDeploymentName.ReadOnly = true;
            // 
            // columnDeploymentNamespace
            // 
            this.columnDeploymentNamespace.HeaderText = "Namespace";
            this.columnDeploymentNamespace.MinimumWidth = 6;
            this.columnDeploymentNamespace.Name = "columnDeploymentNamespace";
            this.columnDeploymentNamespace.ReadOnly = true;
            // 
            // columnDeploymentImages
            // 
            this.columnDeploymentImages.HeaderText = "Images";
            this.columnDeploymentImages.MinimumWidth = 6;
            this.columnDeploymentImages.Name = "columnDeploymentImages";
            this.columnDeploymentImages.ReadOnly = true;
            // 
            // columnDeploymentLabels
            // 
            this.columnDeploymentLabels.HeaderText = "Labls";
            this.columnDeploymentLabels.MinimumWidth = 6;
            this.columnDeploymentLabels.Name = "columnDeploymentLabels";
            this.columnDeploymentLabels.ReadOnly = true;
            // 
            // columnDeploymentPods
            // 
            this.columnDeploymentPods.HeaderText = "Pods";
            this.columnDeploymentPods.MinimumWidth = 6;
            this.columnDeploymentPods.Name = "columnDeploymentPods";
            this.columnDeploymentPods.ReadOnly = true;
            // 
            // columnDeploymentCreated
            // 
            this.columnDeploymentCreated.HeaderText = "Created";
            this.columnDeploymentCreated.MinimumWidth = 6;
            this.columnDeploymentCreated.Name = "columnDeploymentCreated";
            this.columnDeploymentCreated.ReadOnly = true;
            // 
            // editCollumn
            // 
            this.editCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editCollumn.HeaderText = "Edit";
            this.editCollumn.Image = global::Kubernetes_GUI.Properties.Resources.edit_button;
            this.editCollumn.MinimumWidth = 6;
            this.editCollumn.Name = "editCollumn";
            this.editCollumn.ReadOnly = true;
            this.editCollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editCollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editCollumn.Visible = false;
            this.editCollumn.Width = 50;
            // 
            // deleteCollumn
            // 
            this.deleteCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteCollumn.HeaderText = "Delete";
            this.deleteCollumn.Image = global::Kubernetes_GUI.Properties.Resources.remove__1_;
            this.deleteCollumn.MinimumWidth = 6;
            this.deleteCollumn.Name = "deleteCollumn";
            this.deleteCollumn.ReadOnly = true;
            this.deleteCollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteCollumn.Width = 50;
            // 
            // createDeploymentTab
            // 
            this.createDeploymentTab.AutoScroll = true;
            this.createDeploymentTab.BackColor = System.Drawing.Color.White;
            this.createDeploymentTab.Controls.Add(this.btnDeploymentApply);
            this.createDeploymentTab.Controls.Add(this.txtDeploymentNumberContainers);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentContainerPort);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentContainerImage);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentContainerName);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentNumberContainers);
            this.createDeploymentTab.Controls.Add(this.txtDeploymentReplicas);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentReplicas);
            this.createDeploymentTab.Controls.Add(this.btnCreateDeployment);
            this.createDeploymentTab.Controls.Add(this.cmbBoxDeploymentNamespace);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentNamespace);
            this.createDeploymentTab.Controls.Add(this.txtDeploymentName);
            this.createDeploymentTab.Controls.Add(this.lblDeploymentName);
            this.createDeploymentTab.Location = new System.Drawing.Point(4, 25);
            this.createDeploymentTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDeploymentTab.Name = "createDeploymentTab";
            this.createDeploymentTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDeploymentTab.Size = new System.Drawing.Size(1511, 639);
            this.createDeploymentTab.TabIndex = 1;
            this.createDeploymentTab.Text = "Create deployments";
            // 
            // btnDeploymentApply
            // 
            this.btnDeploymentApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeploymentApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeploymentApply.Depth = 0;
            this.btnDeploymentApply.HighEmphasis = true;
            this.btnDeploymentApply.Icon = null;
            this.btnDeploymentApply.Location = new System.Drawing.Point(169, 338);
            this.btnDeploymentApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeploymentApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeploymentApply.Name = "btnDeploymentApply";
            this.btnDeploymentApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeploymentApply.Size = new System.Drawing.Size(67, 36);
            this.btnDeploymentApply.TabIndex = 28;
            this.btnDeploymentApply.Text = "Apply";
            this.btnDeploymentApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeploymentApply.UseAccentColor = false;
            this.btnDeploymentApply.UseVisualStyleBackColor = true;
            this.btnDeploymentApply.Click += new System.EventHandler(this.btnDeploymentApply_Click);
            // 
            // txtDeploymentNumberContainers
            // 
            this.txtDeploymentNumberContainers.AnimateReadOnly = false;
            this.txtDeploymentNumberContainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeploymentNumberContainers.Depth = 0;
            this.txtDeploymentNumberContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtDeploymentNumberContainers.LeadingIcon = null;
            this.txtDeploymentNumberContainers.Location = new System.Drawing.Point(35, 328);
            this.txtDeploymentNumberContainers.MaxLength = 50;
            this.txtDeploymentNumberContainers.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeploymentNumberContainers.Multiline = false;
            this.txtDeploymentNumberContainers.Name = "txtDeploymentNumberContainers";
            this.txtDeploymentNumberContainers.Size = new System.Drawing.Size(127, 50);
            this.txtDeploymentNumberContainers.TabIndex = 27;
            this.txtDeploymentNumberContainers.Text = "1";
            this.txtDeploymentNumberContainers.TrailingIcon = null;
            this.txtDeploymentNumberContainers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // lblDeploymentContainerPort
            // 
            this.lblDeploymentContainerPort.AutoSize = true;
            this.lblDeploymentContainerPort.Depth = 0;
            this.lblDeploymentContainerPort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentContainerPort.Location = new System.Drawing.Point(914, 400);
            this.lblDeploymentContainerPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentContainerPort.Name = "lblDeploymentContainerPort";
            this.lblDeploymentContainerPort.Size = new System.Drawing.Size(102, 19);
            this.lblDeploymentContainerPort.TabIndex = 23;
            this.lblDeploymentContainerPort.Text = "Container Port";
            this.lblDeploymentContainerPort.Visible = false;
            // 
            // lblDeploymentContainerImage
            // 
            this.lblDeploymentContainerImage.AutoSize = true;
            this.lblDeploymentContainerImage.Depth = 0;
            this.lblDeploymentContainerImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentContainerImage.Location = new System.Drawing.Point(476, 400);
            this.lblDeploymentContainerImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentContainerImage.Name = "lblDeploymentContainerImage";
            this.lblDeploymentContainerImage.Size = new System.Drawing.Size(117, 19);
            this.lblDeploymentContainerImage.TabIndex = 22;
            this.lblDeploymentContainerImage.Text = "Container Image";
            // 
            // lblDeploymentContainerName
            // 
            this.lblDeploymentContainerName.AutoSize = true;
            this.lblDeploymentContainerName.Depth = 0;
            this.lblDeploymentContainerName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentContainerName.Location = new System.Drawing.Point(32, 400);
            this.lblDeploymentContainerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentContainerName.Name = "lblDeploymentContainerName";
            this.lblDeploymentContainerName.Size = new System.Drawing.Size(115, 19);
            this.lblDeploymentContainerName.TabIndex = 21;
            this.lblDeploymentContainerName.Text = "Container Name";
            // 
            // lblDeploymentNumberContainers
            // 
            this.lblDeploymentNumberContainers.AutoSize = true;
            this.lblDeploymentNumberContainers.Depth = 0;
            this.lblDeploymentNumberContainers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentNumberContainers.Location = new System.Drawing.Point(32, 306);
            this.lblDeploymentNumberContainers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentNumberContainers.Name = "lblDeploymentNumberContainers";
            this.lblDeploymentNumberContainers.Size = new System.Drawing.Size(156, 19);
            this.lblDeploymentNumberContainers.TabIndex = 19;
            this.lblDeploymentNumberContainers.Text = "Number of Containers";
            // 
            // txtDeploymentReplicas
            // 
            this.txtDeploymentReplicas.AnimateReadOnly = false;
            this.txtDeploymentReplicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeploymentReplicas.Depth = 0;
            this.txtDeploymentReplicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtDeploymentReplicas.LeadingIcon = null;
            this.txtDeploymentReplicas.Location = new System.Drawing.Point(35, 234);
            this.txtDeploymentReplicas.MaxLength = 50;
            this.txtDeploymentReplicas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeploymentReplicas.Multiline = false;
            this.txtDeploymentReplicas.Name = "txtDeploymentReplicas";
            this.txtDeploymentReplicas.Size = new System.Drawing.Size(127, 50);
            this.txtDeploymentReplicas.TabIndex = 17;
            this.txtDeploymentReplicas.Text = "1";
            this.txtDeploymentReplicas.TrailingIcon = null;
            this.txtDeploymentReplicas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // lblDeploymentReplicas
            // 
            this.lblDeploymentReplicas.AutoSize = true;
            this.lblDeploymentReplicas.Depth = 0;
            this.lblDeploymentReplicas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentReplicas.Location = new System.Drawing.Point(32, 212);
            this.lblDeploymentReplicas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentReplicas.Name = "lblDeploymentReplicas";
            this.lblDeploymentReplicas.Size = new System.Drawing.Size(61, 19);
            this.lblDeploymentReplicas.TabIndex = 16;
            this.lblDeploymentReplicas.Text = "Replicas";
            // 
            // btnCreateDeployment
            // 
            this.btnCreateDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDeployment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateDeployment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateDeployment.Depth = 0;
            this.btnCreateDeployment.HighEmphasis = true;
            this.btnCreateDeployment.Icon = null;
            this.btnCreateDeployment.Location = new System.Drawing.Point(1245, 549);
            this.btnCreateDeployment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateDeployment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateDeployment.Name = "btnCreateDeployment";
            this.btnCreateDeployment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateDeployment.Size = new System.Drawing.Size(76, 36);
            this.btnCreateDeployment.TabIndex = 14;
            this.btnCreateDeployment.Text = "Create";
            this.btnCreateDeployment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateDeployment.UseAccentColor = false;
            this.btnCreateDeployment.UseVisualStyleBackColor = true;
            this.btnCreateDeployment.Click += new System.EventHandler(this.btnCreateDeployment_Click);
            // 
            // cmbBoxDeploymentNamespace
            // 
            this.cmbBoxDeploymentNamespace.AutoResize = false;
            this.cmbBoxDeploymentNamespace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxDeploymentNamespace.Depth = 0;
            this.cmbBoxDeploymentNamespace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxDeploymentNamespace.DropDownHeight = 174;
            this.cmbBoxDeploymentNamespace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDeploymentNamespace.DropDownWidth = 121;
            this.cmbBoxDeploymentNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxDeploymentNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxDeploymentNamespace.FormattingEnabled = true;
            this.cmbBoxDeploymentNamespace.IntegralHeight = false;
            this.cmbBoxDeploymentNamespace.ItemHeight = 43;
            this.cmbBoxDeploymentNamespace.Location = new System.Drawing.Point(35, 141);
            this.cmbBoxDeploymentNamespace.MaxDropDownItems = 4;
            this.cmbBoxDeploymentNamespace.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxDeploymentNamespace.Name = "cmbBoxDeploymentNamespace";
            this.cmbBoxDeploymentNamespace.Size = new System.Drawing.Size(399, 49);
            this.cmbBoxDeploymentNamespace.StartIndex = 0;
            this.cmbBoxDeploymentNamespace.TabIndex = 11;
            // 
            // lblDeploymentNamespace
            // 
            this.lblDeploymentNamespace.AutoSize = true;
            this.lblDeploymentNamespace.Depth = 0;
            this.lblDeploymentNamespace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentNamespace.Location = new System.Drawing.Point(32, 119);
            this.lblDeploymentNamespace.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentNamespace.Name = "lblDeploymentNamespace";
            this.lblDeploymentNamespace.Size = new System.Drawing.Size(85, 19);
            this.lblDeploymentNamespace.TabIndex = 10;
            this.lblDeploymentNamespace.Text = "Namespace";
            // 
            // txtDeploymentName
            // 
            this.txtDeploymentName.AnimateReadOnly = false;
            this.txtDeploymentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeploymentName.Depth = 0;
            this.txtDeploymentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeploymentName.LeadingIcon = null;
            this.txtDeploymentName.Location = new System.Drawing.Point(35, 47);
            this.txtDeploymentName.MaxLength = 50;
            this.txtDeploymentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeploymentName.Multiline = false;
            this.txtDeploymentName.Name = "txtDeploymentName";
            this.txtDeploymentName.Size = new System.Drawing.Size(399, 50);
            this.txtDeploymentName.TabIndex = 9;
            this.txtDeploymentName.Text = "";
            this.txtDeploymentName.TrailingIcon = null;
            // 
            // lblDeploymentName
            // 
            this.lblDeploymentName.AutoSize = true;
            this.lblDeploymentName.Depth = 0;
            this.lblDeploymentName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeploymentName.Location = new System.Drawing.Point(32, 25);
            this.lblDeploymentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeploymentName.Name = "lblDeploymentName";
            this.lblDeploymentName.Size = new System.Drawing.Size(130, 19);
            this.lblDeploymentName.TabIndex = 8;
            this.lblDeploymentName.Text = "Deployment name";
            // 
            // DeploymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.deploymentsTabControl);
            this.Controls.Add(this.deploymentsTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeploymentsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.White;
            this.deploymentsTabControl.ResumeLayout(false);
            this.deploymentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deploymentsDataGridView)).EndInit();
            this.createDeploymentTab.ResumeLayout(false);
            this.createDeploymentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector deploymentsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl deploymentsTabControl;
        private System.Windows.Forms.TabPage deploymentsTab;
        private System.Windows.Forms.TabPage createDeploymentTab;
        private System.Windows.Forms.DataGridView deploymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentNamespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentPods;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeploymentCreated;
        private System.Windows.Forms.DataGridViewImageColumn editCollumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteCollumn;
        private MaterialSkin.Controls.MaterialButton btnCreateDeployment;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxDeploymentNamespace;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentNamespace;
        private MaterialSkin.Controls.MaterialTextBox txtDeploymentName;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentName;
        private MaterialSkin.Controls.MaterialTextBox txtDeploymentReplicas;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentReplicas;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentContainerPort;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentContainerImage;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentContainerName;
        private MaterialSkin.Controls.MaterialLabel lblDeploymentNumberContainers;
        private MaterialSkin.Controls.MaterialTextBox txtDeploymentNumberContainers;
        private MaterialSkin.Controls.MaterialButton btnDeploymentApply;
    }
}