﻿
namespace Kubernetes_GUI.Forms
{
    partial class PodsForm
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
            this.podsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.podsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.podsTab = new System.Windows.Forms.TabPage();
            this.podsDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLabels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRestarts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpuUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMemoryUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnEditPod = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnDeletePod = new System.Windows.Forms.DataGridViewImageColumn();
            this.createPodTab = new System.Windows.Forms.TabPage();
            this.btnCreatePod = new MaterialSkin.Controls.MaterialButton();
            this.txtPodImage = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPodImage = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxPodNamespace = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPodNamespace = new MaterialSkin.Controls.MaterialLabel();
            this.txtPodName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.editPodTab = new System.Windows.Forms.TabPage();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.podsTabControl.SuspendLayout();
            this.podsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podsDataGridView)).BeginInit();
            this.createPodTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // podsTabSelector
            // 
            this.podsTabSelector.BaseTabControl = this.podsTabControl;
            this.podsTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.podsTabSelector.Depth = 0;
            this.podsTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.podsTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.podsTabSelector.Location = new System.Drawing.Point(0, 0);
            this.podsTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.podsTabSelector.Name = "podsTabSelector";
            this.podsTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.podsTabSelector.TabIndex = 1;
            // 
            // podsTabControl
            // 
            this.podsTabControl.Controls.Add(this.podsTab);
            this.podsTabControl.Controls.Add(this.createPodTab);
            this.podsTabControl.Controls.Add(this.editPodTab);
            this.podsTabControl.Depth = 0;
            this.podsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podsTabControl.Location = new System.Drawing.Point(0, 48);
            this.podsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.podsTabControl.Multiline = true;
            this.podsTabControl.Name = "podsTabControl";
            this.podsTabControl.SelectedIndex = 0;
            this.podsTabControl.Size = new System.Drawing.Size(1519, 668);
            this.podsTabControl.TabIndex = 2;
            // 
            // podsTab
            // 
            this.podsTab.BackColor = System.Drawing.Color.White;
            this.podsTab.Controls.Add(this.podsDataGridView);
            this.podsTab.Location = new System.Drawing.Point(4, 25);
            this.podsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsTab.Name = "podsTab";
            this.podsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsTab.Size = new System.Drawing.Size(1511, 639);
            this.podsTab.TabIndex = 0;
            this.podsTab.Text = "Pods";
            // 
            // podsDataGridView
            // 
            this.podsDataGridView.AllowUserToAddRows = false;
            this.podsDataGridView.AllowUserToDeleteRows = false;
            this.podsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.podsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.podsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.podsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnNamespace,
            this.ColumnImages,
            this.ColumnLabels,
            this.ColumnNode,
            this.ColumnStatus,
            this.ColumnRestarts,
            this.ColumnCpuUsage,
            this.ColumnMemoryUsage,
            this.ColumnCreated,
            this.collumnEditPod,
            this.columnDeletePod});
            this.podsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podsDataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.podsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.podsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsDataGridView.Name = "podsDataGridView";
            this.podsDataGridView.ReadOnly = true;
            this.podsDataGridView.RowHeadersWidth = 51;
            this.podsDataGridView.RowTemplate.Height = 24;
            this.podsDataGridView.Size = new System.Drawing.Size(1505, 635);
            this.podsDataGridView.TabIndex = 1;
            this.podsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.podsDataGridView_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnNamespace
            // 
            this.ColumnNamespace.HeaderText = "Namespace";
            this.ColumnNamespace.MinimumWidth = 6;
            this.ColumnNamespace.Name = "ColumnNamespace";
            this.ColumnNamespace.ReadOnly = true;
            // 
            // ColumnImages
            // 
            this.ColumnImages.HeaderText = "Images";
            this.ColumnImages.MinimumWidth = 6;
            this.ColumnImages.Name = "ColumnImages";
            this.ColumnImages.ReadOnly = true;
            // 
            // ColumnLabels
            // 
            this.ColumnLabels.HeaderText = "Labels";
            this.ColumnLabels.MinimumWidth = 6;
            this.ColumnLabels.Name = "ColumnLabels";
            this.ColumnLabels.ReadOnly = true;
            // 
            // ColumnNode
            // 
            this.ColumnNode.HeaderText = "Node";
            this.ColumnNode.MinimumWidth = 6;
            this.ColumnNode.Name = "ColumnNode";
            this.ColumnNode.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnRestarts
            // 
            this.ColumnRestarts.HeaderText = "Restarts";
            this.ColumnRestarts.MinimumWidth = 6;
            this.ColumnRestarts.Name = "ColumnRestarts";
            this.ColumnRestarts.ReadOnly = true;
            // 
            // ColumnCpuUsage
            // 
            this.ColumnCpuUsage.HeaderText = "CPU Usage (cores)";
            this.ColumnCpuUsage.MinimumWidth = 6;
            this.ColumnCpuUsage.Name = "ColumnCpuUsage";
            this.ColumnCpuUsage.ReadOnly = true;
            // 
            // ColumnMemoryUsage
            // 
            this.ColumnMemoryUsage.HeaderText = "Memory Usage (bytes)";
            this.ColumnMemoryUsage.MinimumWidth = 6;
            this.ColumnMemoryUsage.Name = "ColumnMemoryUsage";
            this.ColumnMemoryUsage.ReadOnly = true;
            // 
            // ColumnCreated
            // 
            this.ColumnCreated.HeaderText = "Created";
            this.ColumnCreated.MinimumWidth = 6;
            this.ColumnCreated.Name = "ColumnCreated";
            this.ColumnCreated.ReadOnly = true;
            // 
            // collumnEditPod
            // 
            this.collumnEditPod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnEditPod.HeaderText = "Edit";
            this.collumnEditPod.Image = global::Kubernetes_GUI.Properties.Resources.edit_button;
            this.collumnEditPod.MinimumWidth = 6;
            this.collumnEditPod.Name = "collumnEditPod";
            this.collumnEditPod.ReadOnly = true;
            this.collumnEditPod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.collumnEditPod.Visible = false;
            this.collumnEditPod.Width = 50;
            // 
            // columnDeletePod
            // 
            this.columnDeletePod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnDeletePod.FillWeight = 28.877F;
            this.columnDeletePod.HeaderText = "Delete";
            this.columnDeletePod.Image = global::Kubernetes_GUI.Properties.Resources.remove__1_;
            this.columnDeletePod.MinimumWidth = 6;
            this.columnDeletePod.Name = "columnDeletePod";
            this.columnDeletePod.ReadOnly = true;
            this.columnDeletePod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDeletePod.Width = 50;
            // 
            // createPodTab
            // 
            this.createPodTab.BackColor = System.Drawing.Color.White;
            this.createPodTab.Controls.Add(this.btnCreatePod);
            this.createPodTab.Controls.Add(this.txtPodImage);
            this.createPodTab.Controls.Add(this.lblPodImage);
            this.createPodTab.Controls.Add(this.cmbBoxPodNamespace);
            this.createPodTab.Controls.Add(this.lblPodNamespace);
            this.createPodTab.Controls.Add(this.txtPodName);
            this.createPodTab.Controls.Add(this.materialLabel1);
            this.createPodTab.Location = new System.Drawing.Point(4, 25);
            this.createPodTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPodTab.Name = "createPodTab";
            this.createPodTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPodTab.Size = new System.Drawing.Size(1511, 639);
            this.createPodTab.TabIndex = 1;
            this.createPodTab.Text = "Create Pod";
            // 
            // btnCreatePod
            // 
            this.btnCreatePod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreatePod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreatePod.Depth = 0;
            this.btnCreatePod.HighEmphasis = true;
            this.btnCreatePod.Icon = null;
            this.btnCreatePod.Location = new System.Drawing.Point(350, 314);
            this.btnCreatePod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreatePod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreatePod.Name = "btnCreatePod";
            this.btnCreatePod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreatePod.Size = new System.Drawing.Size(76, 36);
            this.btnCreatePod.TabIndex = 7;
            this.btnCreatePod.Text = "Create";
            this.btnCreatePod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreatePod.UseAccentColor = false;
            this.btnCreatePod.UseVisualStyleBackColor = true;
            this.btnCreatePod.Click += new System.EventHandler(this.btnCreatePod_Click);
            // 
            // txtPodImage
            // 
            this.txtPodImage.AnimateReadOnly = false;
            this.txtPodImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPodImage.Depth = 0;
            this.txtPodImage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPodImage.LeadingIcon = null;
            this.txtPodImage.Location = new System.Drawing.Point(27, 236);
            this.txtPodImage.MaxLength = 50;
            this.txtPodImage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPodImage.Multiline = false;
            this.txtPodImage.Name = "txtPodImage";
            this.txtPodImage.Size = new System.Drawing.Size(399, 50);
            this.txtPodImage.TabIndex = 6;
            this.txtPodImage.Text = "";
            this.txtPodImage.TrailingIcon = null;
            // 
            // lblPodImage
            // 
            this.lblPodImage.AutoSize = true;
            this.lblPodImage.Depth = 0;
            this.lblPodImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPodImage.Location = new System.Drawing.Point(24, 214);
            this.lblPodImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPodImage.Name = "lblPodImage";
            this.lblPodImage.Size = new System.Drawing.Size(45, 19);
            this.lblPodImage.TabIndex = 5;
            this.lblPodImage.Text = "Image";
            // 
            // cmbBoxPodNamespace
            // 
            this.cmbBoxPodNamespace.AutoResize = false;
            this.cmbBoxPodNamespace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxPodNamespace.Depth = 0;
            this.cmbBoxPodNamespace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxPodNamespace.DropDownHeight = 174;
            this.cmbBoxPodNamespace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPodNamespace.DropDownWidth = 121;
            this.cmbBoxPodNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxPodNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxPodNamespace.FormattingEnabled = true;
            this.cmbBoxPodNamespace.IntegralHeight = false;
            this.cmbBoxPodNamespace.ItemHeight = 43;
            this.cmbBoxPodNamespace.Location = new System.Drawing.Point(27, 143);
            this.cmbBoxPodNamespace.MaxDropDownItems = 4;
            this.cmbBoxPodNamespace.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxPodNamespace.Name = "cmbBoxPodNamespace";
            this.cmbBoxPodNamespace.Size = new System.Drawing.Size(399, 49);
            this.cmbBoxPodNamespace.StartIndex = 0;
            this.cmbBoxPodNamespace.TabIndex = 4;
            // 
            // lblPodNamespace
            // 
            this.lblPodNamespace.AutoSize = true;
            this.lblPodNamespace.Depth = 0;
            this.lblPodNamespace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPodNamespace.Location = new System.Drawing.Point(24, 121);
            this.lblPodNamespace.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPodNamespace.Name = "lblPodNamespace";
            this.lblPodNamespace.Size = new System.Drawing.Size(85, 19);
            this.lblPodNamespace.TabIndex = 2;
            this.lblPodNamespace.Text = "Namespace";
            // 
            // txtPodName
            // 
            this.txtPodName.AnimateReadOnly = false;
            this.txtPodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPodName.Depth = 0;
            this.txtPodName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPodName.LeadingIcon = null;
            this.txtPodName.Location = new System.Drawing.Point(27, 49);
            this.txtPodName.MaxLength = 50;
            this.txtPodName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPodName.Multiline = false;
            this.txtPodName.Name = "txtPodName";
            this.txtPodName.Size = new System.Drawing.Size(399, 50);
            this.txtPodName.TabIndex = 1;
            this.txtPodName.Text = "";
            this.txtPodName.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Pod name";
            // 
            // editPodTab
            // 
            this.editPodTab.BackColor = System.Drawing.Color.White;
            this.editPodTab.Location = new System.Drawing.Point(4, 25);
            this.editPodTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPodTab.Name = "editPodTab";
            this.editPodTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPodTab.Size = new System.Drawing.Size(1511, 639);
            this.editPodTab.TabIndex = 3;
            this.editPodTab.Text = "Edit Pod";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.ReadOnly = false;
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox6.TabIndex = 0;
            this.materialCheckbox6.Text = "materialCheckbox6";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // PodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.podsTabControl);
            this.Controls.Add(this.podsTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PodsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ImagesForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.podsTabControl.ResumeLayout(false);
            this.podsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.podsDataGridView)).EndInit();
            this.createPodTab.ResumeLayout(false);
            this.createPodTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector podsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl podsTabControl;
        private System.Windows.Forms.TabPage podsTab;
        private System.Windows.Forms.DataGridView podsDataGridView;
        private System.Windows.Forms.TabPage createPodTab;
        private System.Windows.Forms.TabPage editPodTab;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialLabel lblPodImage;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxPodNamespace;
        private MaterialSkin.Controls.MaterialLabel lblPodNamespace;
        private MaterialSkin.Controls.MaterialTextBox txtPodName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPodImage;
        private MaterialSkin.Controls.MaterialButton btnCreatePod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRestarts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpuUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMemoryUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreated;
        private System.Windows.Forms.DataGridViewImageColumn collumnEditPod;
        private System.Windows.Forms.DataGridViewImageColumn columnDeletePod;
    }
}