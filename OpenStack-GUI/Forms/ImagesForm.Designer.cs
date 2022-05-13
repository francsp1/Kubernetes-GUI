
namespace OpenStack_GUI.Forms
{
    partial class ImagesForm
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
            this.imagesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.imagesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.imagesTab = new System.Windows.Forms.TabPage();
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.collumnLineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.collumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnImageDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProtected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDiskFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnMinimumDisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnMinimumRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnContainerFormt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnEditImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnDeleteImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.createImageTab = new System.Windows.Forms.TabPage();
            this.txtImageDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCreateImage = new MaterialSkin.Controls.MaterialButton();
            this.switchImageProtected = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbImageBoxVisibility = new MaterialSkin.Controls.MaterialComboBox();
            this.lblImageVisibility = new MaterialSkin.Controls.MaterialLabel();
            this.txtImageMinimumRam = new MaterialSkin.Controls.MaterialTextBox();
            this.txtImageMinimumDisk = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageMinimumRam = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageMinimimDisk = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageDiskFormat = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxImageDiskFormat = new MaterialSkin.Controls.MaterialComboBox();
            this.btnImageBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtImageFile = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageFile = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtImageName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageName = new MaterialSkin.Controls.MaterialLabel();
            this.editImageTab = new System.Windows.Forms.TabPage();
            this.editImageRow = new System.Windows.Forms.NumericUpDown();
            this.btnCancelEditImage = new MaterialSkin.Controls.MaterialButton();
            this.txtEditImageDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.btnUpdateImage = new MaterialSkin.Controls.MaterialButton();
            this.switchEditImageProtected = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbBoxEditImageVisibility = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEditVisibility = new MaterialSkin.Controls.MaterialLabel();
            this.txtEditImageMinimumRam = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditImageMinimumDisk = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEditImageMinimumRam = new MaterialSkin.Controls.MaterialLabel();
            this.lblEditMinimumDisk = new MaterialSkin.Controls.MaterialLabel();
            this.lblEditDisskFormat = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxEditImageDiskFormat = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEditImageDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtEditImageName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEditImageName = new MaterialSkin.Controls.MaterialLabel();
            this.imagesTabControl.SuspendLayout();
            this.imagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            this.createImageTab.SuspendLayout();
            this.editImageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editImageRow)).BeginInit();
            this.SuspendLayout();
            // 
            // imagesTabSelector
            // 
            this.imagesTabSelector.BaseTabControl = this.imagesTabControl;
            this.imagesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.imagesTabSelector.Depth = 0;
            this.imagesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imagesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.imagesTabSelector.Margin = new System.Windows.Forms.Padding(2);
            this.imagesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabSelector.Name = "imagesTabSelector";
            this.imagesTabSelector.Size = new System.Drawing.Size(1139, 39);
            this.imagesTabSelector.TabIndex = 1;
            // 
            // imagesTabControl
            // 
            this.imagesTabControl.Controls.Add(this.imagesTab);
            this.imagesTabControl.Controls.Add(this.createImageTab);
            this.imagesTabControl.Controls.Add(this.editImageTab);
            this.imagesTabControl.Depth = 0;
            this.imagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTabControl.Location = new System.Drawing.Point(0, 39);
            this.imagesTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.imagesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabControl.Multiline = true;
            this.imagesTabControl.Name = "imagesTabControl";
            this.imagesTabControl.SelectedIndex = 0;
            this.imagesTabControl.Size = new System.Drawing.Size(1139, 543);
            this.imagesTabControl.TabIndex = 2;
            // 
            // imagesTab
            // 
            this.imagesTab.BackColor = System.Drawing.Color.White;
            this.imagesTab.Controls.Add(this.imagesDataGridView);
            this.imagesTab.Location = new System.Drawing.Point(4, 22);
            this.imagesTab.Margin = new System.Windows.Forms.Padding(2);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(2);
            this.imagesTab.Size = new System.Drawing.Size(1131, 517);
            this.imagesTab.TabIndex = 0;
            this.imagesTab.Text = "Images";
            // 
            // imagesDataGridView
            // 
            this.imagesDataGridView.AllowUserToAddRows = false;
            this.imagesDataGridView.AllowUserToDeleteRows = false;
            this.imagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.imagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collumnLineNumber,
            this.check,
            this.collumnID,
            this.collumnProjectId,
            this.collumnName,
            this.collumnImageDescription,
            this.collumnStatus,
            this.collumnVisibility,
            this.collumnProtected,
            this.collumnDiskFormat,
            this.collumnMinimumDisk,
            this.collumnMinimumRam,
            this.collumnContainerFormt,
            this.collumnSize,
            this.collumnEditImage,
            this.columnDeleteImage});
            this.imagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesDataGridView.GridColor = System.Drawing.Color.White;
            this.imagesDataGridView.Location = new System.Drawing.Point(2, 2);
            this.imagesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.ReadOnly = true;
            this.imagesDataGridView.RowHeadersWidth = 51;
            this.imagesDataGridView.RowTemplate.Height = 24;
            this.imagesDataGridView.Size = new System.Drawing.Size(1127, 513);
            this.imagesDataGridView.TabIndex = 1;
            this.imagesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imagesDataGridView_CellClick);
            // 
            // collumnLineNumber
            // 
            this.collumnLineNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnLineNumber.HeaderText = "";
            this.collumnLineNumber.MinimumWidth = 6;
            this.collumnLineNumber.Name = "collumnLineNumber";
            this.collumnLineNumber.ReadOnly = true;
            this.collumnLineNumber.Visible = false;
            this.collumnLineNumber.Width = 20;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.check.FillWeight = 28.877F;
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 20;
            // 
            // collumnID
            // 
            this.collumnID.HeaderText = "ID";
            this.collumnID.MinimumWidth = 6;
            this.collumnID.Name = "collumnID";
            this.collumnID.ReadOnly = true;
            this.collumnID.Visible = false;
            // 
            // collumnProjectId
            // 
            this.collumnProjectId.HeaderText = "Project ID";
            this.collumnProjectId.MinimumWidth = 6;
            this.collumnProjectId.Name = "collumnProjectId";
            this.collumnProjectId.ReadOnly = true;
            this.collumnProjectId.Visible = false;
            // 
            // collumnName
            // 
            this.collumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnName.FillWeight = 668.984F;
            this.collumnName.HeaderText = "Name";
            this.collumnName.MinimumWidth = 6;
            this.collumnName.Name = "collumnName";
            this.collumnName.ReadOnly = true;
            this.collumnName.Width = 200;
            // 
            // collumnImageDescription
            // 
            this.collumnImageDescription.HeaderText = "Description";
            this.collumnImageDescription.MinimumWidth = 6;
            this.collumnImageDescription.Name = "collumnImageDescription";
            this.collumnImageDescription.ReadOnly = true;
            this.collumnImageDescription.Visible = false;
            // 
            // collumnStatus
            // 
            this.collumnStatus.FillWeight = 28.877F;
            this.collumnStatus.HeaderText = "Status";
            this.collumnStatus.MinimumWidth = 6;
            this.collumnStatus.Name = "collumnStatus";
            this.collumnStatus.ReadOnly = true;
            // 
            // collumnVisibility
            // 
            this.collumnVisibility.FillWeight = 28.877F;
            this.collumnVisibility.HeaderText = "Visibility";
            this.collumnVisibility.MinimumWidth = 6;
            this.collumnVisibility.Name = "collumnVisibility";
            this.collumnVisibility.ReadOnly = true;
            // 
            // collumnProtected
            // 
            this.collumnProtected.FillWeight = 28.877F;
            this.collumnProtected.HeaderText = "Protected";
            this.collumnProtected.MinimumWidth = 6;
            this.collumnProtected.Name = "collumnProtected";
            this.collumnProtected.ReadOnly = true;
            // 
            // collumnDiskFormat
            // 
            this.collumnDiskFormat.FillWeight = 28.877F;
            this.collumnDiskFormat.HeaderText = "Disk Format";
            this.collumnDiskFormat.MinimumWidth = 6;
            this.collumnDiskFormat.Name = "collumnDiskFormat";
            this.collumnDiskFormat.ReadOnly = true;
            // 
            // collumnMinimumDisk
            // 
            this.collumnMinimumDisk.HeaderText = "Minimum Disk";
            this.collumnMinimumDisk.MinimumWidth = 6;
            this.collumnMinimumDisk.Name = "collumnMinimumDisk";
            this.collumnMinimumDisk.ReadOnly = true;
            this.collumnMinimumDisk.Visible = false;
            // 
            // collumnMinimumRam
            // 
            this.collumnMinimumRam.HeaderText = "Minimum Ram";
            this.collumnMinimumRam.MinimumWidth = 6;
            this.collumnMinimumRam.Name = "collumnMinimumRam";
            this.collumnMinimumRam.ReadOnly = true;
            this.collumnMinimumRam.Visible = false;
            // 
            // collumnContainerFormt
            // 
            this.collumnContainerFormt.FillWeight = 28.877F;
            this.collumnContainerFormt.HeaderText = "Container Format";
            this.collumnContainerFormt.MinimumWidth = 6;
            this.collumnContainerFormt.Name = "collumnContainerFormt";
            this.collumnContainerFormt.ReadOnly = true;
            // 
            // collumnSize
            // 
            this.collumnSize.FillWeight = 28.877F;
            this.collumnSize.HeaderText = "Size";
            this.collumnSize.MinimumWidth = 6;
            this.collumnSize.Name = "collumnSize";
            this.collumnSize.ReadOnly = true;
            // 
            // collumnEditImage
            // 
            this.collumnEditImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnEditImage.HeaderText = "Edit";
            this.collumnEditImage.Image = global::OpenStack_GUI.Properties.Resources.edit_button;
            this.collumnEditImage.MinimumWidth = 6;
            this.collumnEditImage.Name = "collumnEditImage";
            this.collumnEditImage.ReadOnly = true;
            this.collumnEditImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.collumnEditImage.Width = 50;
            // 
            // columnDeleteImage
            // 
            this.columnDeleteImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnDeleteImage.FillWeight = 28.877F;
            this.columnDeleteImage.HeaderText = "Delete";
            this.columnDeleteImage.Image = global::OpenStack_GUI.Properties.Resources.remove__1_;
            this.columnDeleteImage.MinimumWidth = 6;
            this.columnDeleteImage.Name = "columnDeleteImage";
            this.columnDeleteImage.ReadOnly = true;
            this.columnDeleteImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDeleteImage.Width = 50;
            // 
            // createImageTab
            // 
            this.createImageTab.BackColor = System.Drawing.Color.White;
            this.createImageTab.Controls.Add(this.txtImageDescription);
            this.createImageTab.Controls.Add(this.btnCreateImage);
            this.createImageTab.Controls.Add(this.switchImageProtected);
            this.createImageTab.Controls.Add(this.cmbImageBoxVisibility);
            this.createImageTab.Controls.Add(this.lblImageVisibility);
            this.createImageTab.Controls.Add(this.txtImageMinimumRam);
            this.createImageTab.Controls.Add(this.txtImageMinimumDisk);
            this.createImageTab.Controls.Add(this.lblImageMinimumRam);
            this.createImageTab.Controls.Add(this.lblImageMinimimDisk);
            this.createImageTab.Controls.Add(this.lblImageDiskFormat);
            this.createImageTab.Controls.Add(this.cmbBoxImageDiskFormat);
            this.createImageTab.Controls.Add(this.btnImageBrowse);
            this.createImageTab.Controls.Add(this.txtImageFile);
            this.createImageTab.Controls.Add(this.lblImageFile);
            this.createImageTab.Controls.Add(this.lblImageDescription);
            this.createImageTab.Controls.Add(this.txtImageName);
            this.createImageTab.Controls.Add(this.lblImageName);
            this.createImageTab.Location = new System.Drawing.Point(4, 22);
            this.createImageTab.Margin = new System.Windows.Forms.Padding(2);
            this.createImageTab.Name = "createImageTab";
            this.createImageTab.Padding = new System.Windows.Forms.Padding(2);
            this.createImageTab.Size = new System.Drawing.Size(1131, 517);
            this.createImageTab.TabIndex = 1;
            this.createImageTab.Text = "Create Image";
            // 
            // txtImageDescription
            // 
            this.txtImageDescription.AnimateReadOnly = false;
            this.txtImageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageDescription.Depth = 0;
            this.txtImageDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageDescription.LeadingIcon = null;
            this.txtImageDescription.Location = new System.Drawing.Point(394, 123);
            this.txtImageDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageDescription.MaxLength = 255;
            this.txtImageDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageDescription.Multiline = false;
            this.txtImageDescription.Name = "txtImageDescription";
            this.txtImageDescription.Size = new System.Drawing.Size(375, 50);
            this.txtImageDescription.TabIndex = 18;
            this.txtImageDescription.Text = "";
            this.txtImageDescription.TrailingIcon = null;
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateImage.Depth = 0;
            this.btnCreateImage.HighEmphasis = true;
            this.btnCreateImage.Icon = null;
            this.btnCreateImage.Location = new System.Drawing.Point(35, 396);
            this.btnCreateImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCreateImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateImage.Size = new System.Drawing.Size(125, 36);
            this.btnCreateImage.TabIndex = 17;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateImage.UseAccentColor = false;
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // switchImageProtected
            // 
            this.switchImageProtected.AutoSize = true;
            this.switchImageProtected.Depth = 0;
            this.switchImageProtected.Location = new System.Drawing.Point(252, 396);
            this.switchImageProtected.Margin = new System.Windows.Forms.Padding(0);
            this.switchImageProtected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchImageProtected.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchImageProtected.Name = "switchImageProtected";
            this.switchImageProtected.Ripple = true;
            this.switchImageProtected.Size = new System.Drawing.Size(125, 37);
            this.switchImageProtected.TabIndex = 16;
            this.switchImageProtected.Text = "Protected";
            this.switchImageProtected.UseVisualStyleBackColor = true;
            // 
            // cmbImageBoxVisibility
            // 
            this.cmbImageBoxVisibility.AutoResize = false;
            this.cmbImageBoxVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbImageBoxVisibility.Depth = 0;
            this.cmbImageBoxVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbImageBoxVisibility.DropDownHeight = 174;
            this.cmbImageBoxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageBoxVisibility.DropDownWidth = 121;
            this.cmbImageBoxVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbImageBoxVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbImageBoxVisibility.FormattingEnabled = true;
            this.cmbImageBoxVisibility.IntegralHeight = false;
            this.cmbImageBoxVisibility.ItemHeight = 43;
            this.cmbImageBoxVisibility.Items.AddRange(new object[] {
            "shared",
            "public",
            "private",
            "community"});
            this.cmbImageBoxVisibility.Location = new System.Drawing.Point(35, 313);
            this.cmbImageBoxVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.cmbImageBoxVisibility.MaxDropDownItems = 4;
            this.cmbImageBoxVisibility.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbImageBoxVisibility.Name = "cmbImageBoxVisibility";
            this.cmbImageBoxVisibility.Size = new System.Drawing.Size(140, 49);
            this.cmbImageBoxVisibility.StartIndex = 0;
            this.cmbImageBoxVisibility.TabIndex = 15;
            // 
            // lblImageVisibility
            // 
            this.lblImageVisibility.AutoSize = true;
            this.lblImageVisibility.Depth = 0;
            this.lblImageVisibility.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageVisibility.Location = new System.Drawing.Point(33, 295);
            this.lblImageVisibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageVisibility.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageVisibility.Name = "lblImageVisibility";
            this.lblImageVisibility.Size = new System.Drawing.Size(61, 19);
            this.lblImageVisibility.TabIndex = 14;
            this.lblImageVisibility.Text = "Visibility";
            // 
            // txtImageMinimumRam
            // 
            this.txtImageMinimumRam.AnimateReadOnly = false;
            this.txtImageMinimumRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageMinimumRam.Depth = 0;
            this.txtImageMinimumRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImageMinimumRam.LeadingIcon = null;
            this.txtImageMinimumRam.Location = new System.Drawing.Point(252, 312);
            this.txtImageMinimumRam.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageMinimumRam.MaxLength = 50;
            this.txtImageMinimumRam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumRam.Multiline = false;
            this.txtImageMinimumRam.Name = "txtImageMinimumRam";
            this.txtImageMinimumRam.Size = new System.Drawing.Size(116, 50);
            this.txtImageMinimumRam.TabIndex = 13;
            this.txtImageMinimumRam.Text = "0";
            this.txtImageMinimumRam.TrailingIcon = null;
            this.txtImageMinimumRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumRam_KeyPress);
            // 
            // txtImageMinimumDisk
            // 
            this.txtImageMinimumDisk.AnimateReadOnly = false;
            this.txtImageMinimumDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageMinimumDisk.Depth = 0;
            this.txtImageMinimumDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImageMinimumDisk.LeadingIcon = null;
            this.txtImageMinimumDisk.Location = new System.Drawing.Point(252, 219);
            this.txtImageMinimumDisk.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageMinimumDisk.MaxLength = 50;
            this.txtImageMinimumDisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumDisk.Multiline = false;
            this.txtImageMinimumDisk.Name = "txtImageMinimumDisk";
            this.txtImageMinimumDisk.Size = new System.Drawing.Size(116, 50);
            this.txtImageMinimumDisk.TabIndex = 12;
            this.txtImageMinimumDisk.Text = "0";
            this.txtImageMinimumDisk.TrailingIcon = null;
            this.txtImageMinimumDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumDisk_KeyPress);
            // 
            // lblImageMinimumRam
            // 
            this.lblImageMinimumRam.AutoSize = true;
            this.lblImageMinimumRam.Depth = 0;
            this.lblImageMinimumRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageMinimumRam.Location = new System.Drawing.Point(250, 295);
            this.lblImageMinimumRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageMinimumRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageMinimumRam.Name = "lblImageMinimumRam";
            this.lblImageMinimumRam.Size = new System.Drawing.Size(146, 19);
            this.lblImageMinimumRam.TabIndex = 11;
            this.lblImageMinimumRam.Text = "Minimum RAM (MB)";
            // 
            // lblImageMinimimDisk
            // 
            this.lblImageMinimimDisk.AutoSize = true;
            this.lblImageMinimimDisk.Depth = 0;
            this.lblImageMinimimDisk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageMinimimDisk.Location = new System.Drawing.Point(250, 201);
            this.lblImageMinimimDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageMinimimDisk.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageMinimimDisk.Name = "lblImageMinimimDisk";
            this.lblImageMinimimDisk.Size = new System.Drawing.Size(140, 19);
            this.lblImageMinimimDisk.TabIndex = 10;
            this.lblImageMinimimDisk.Text = "Minimum Disk (GB)";
            // 
            // lblImageDiskFormat
            // 
            this.lblImageDiskFormat.AutoSize = true;
            this.lblImageDiskFormat.Depth = 0;
            this.lblImageDiskFormat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageDiskFormat.Location = new System.Drawing.Point(33, 201);
            this.lblImageDiskFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageDiskFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageDiskFormat.Name = "lblImageDiskFormat";
            this.lblImageDiskFormat.Size = new System.Drawing.Size(87, 19);
            this.lblImageDiskFormat.TabIndex = 9;
            this.lblImageDiskFormat.Text = "Disk Format";
            // 
            // cmbBoxImageDiskFormat
            // 
            this.cmbBoxImageDiskFormat.AutoResize = false;
            this.cmbBoxImageDiskFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxImageDiskFormat.Depth = 0;
            this.cmbBoxImageDiskFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxImageDiskFormat.DropDownHeight = 174;
            this.cmbBoxImageDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxImageDiskFormat.DropDownWidth = 121;
            this.cmbBoxImageDiskFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxImageDiskFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxImageDiskFormat.FormattingEnabled = true;
            this.cmbBoxImageDiskFormat.IntegralHeight = false;
            this.cmbBoxImageDiskFormat.ItemHeight = 43;
            this.cmbBoxImageDiskFormat.Items.AddRange(new object[] {
            "QCOW2",
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
            "VDI",
            "PLOOP",
            "ISO"});
            this.cmbBoxImageDiskFormat.Location = new System.Drawing.Point(35, 219);
            this.cmbBoxImageDiskFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxImageDiskFormat.MaxDropDownItems = 4;
            this.cmbBoxImageDiskFormat.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxImageDiskFormat.Name = "cmbBoxImageDiskFormat";
            this.cmbBoxImageDiskFormat.Size = new System.Drawing.Size(140, 49);
            this.cmbBoxImageDiskFormat.StartIndex = 0;
            this.cmbBoxImageDiskFormat.TabIndex = 8;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImageBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImageBrowse.Depth = 0;
            this.btnImageBrowse.HighEmphasis = true;
            this.btnImageBrowse.Icon = null;
            this.btnImageBrowse.Location = new System.Drawing.Point(709, 32);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnImageBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImageBrowse.Size = new System.Drawing.Size(80, 36);
            this.btnImageBrowse.TabIndex = 7;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImageBrowse.UseAccentColor = false;
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // txtImageFile
            // 
            this.txtImageFile.AnimateReadOnly = false;
            this.txtImageFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageFile.Depth = 0;
            this.txtImageFile.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageFile.LeadingIcon = null;
            this.txtImageFile.Location = new System.Drawing.Point(35, 28);
            this.txtImageFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageFile.MaxLength = 260;
            this.txtImageFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageFile.Multiline = false;
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.Size = new System.Drawing.Size(655, 50);
            this.txtImageFile.TabIndex = 6;
            this.txtImageFile.Text = "";
            this.txtImageFile.TrailingIcon = null;
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Depth = 0;
            this.lblImageFile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageFile.Location = new System.Drawing.Point(33, 11);
            this.lblImageFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageFile.Name = "lblImageFile";
            this.lblImageFile.Size = new System.Drawing.Size(138, 19);
            this.lblImageFile.TabIndex = 5;
            this.lblImageFile.Text = "Image Source (File)";
            // 
            // lblImageDescription
            // 
            this.lblImageDescription.AutoSize = true;
            this.lblImageDescription.Depth = 0;
            this.lblImageDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageDescription.Location = new System.Drawing.Point(392, 105);
            this.lblImageDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageDescription.Name = "lblImageDescription";
            this.lblImageDescription.Size = new System.Drawing.Size(129, 19);
            this.lblImageDescription.TabIndex = 4;
            this.lblImageDescription.Text = "Image Description";
            // 
            // txtImageName
            // 
            this.txtImageName.AnimateReadOnly = false;
            this.txtImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageName.Depth = 0;
            this.txtImageName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageName.LeadingIcon = null;
            this.txtImageName.Location = new System.Drawing.Point(35, 122);
            this.txtImageName.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageName.MaxLength = 50;
            this.txtImageName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageName.Multiline = false;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(316, 50);
            this.txtImageName.TabIndex = 2;
            this.txtImageName.Text = "";
            this.txtImageName.TrailingIcon = null;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Depth = 0;
            this.lblImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageName.Location = new System.Drawing.Point(33, 105);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(91, 19);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image Name";
            // 
            // editImageTab
            // 
            this.editImageTab.BackColor = System.Drawing.Color.White;
            this.editImageTab.Controls.Add(this.editImageRow);
            this.editImageTab.Controls.Add(this.btnCancelEditImage);
            this.editImageTab.Controls.Add(this.txtEditImageDescription);
            this.editImageTab.Controls.Add(this.btnUpdateImage);
            this.editImageTab.Controls.Add(this.switchEditImageProtected);
            this.editImageTab.Controls.Add(this.cmbBoxEditImageVisibility);
            this.editImageTab.Controls.Add(this.lblEditVisibility);
            this.editImageTab.Controls.Add(this.txtEditImageMinimumRam);
            this.editImageTab.Controls.Add(this.txtEditImageMinimumDisk);
            this.editImageTab.Controls.Add(this.lblEditImageMinimumRam);
            this.editImageTab.Controls.Add(this.lblEditMinimumDisk);
            this.editImageTab.Controls.Add(this.lblEditDisskFormat);
            this.editImageTab.Controls.Add(this.cmbBoxEditImageDiskFormat);
            this.editImageTab.Controls.Add(this.lblEditImageDescription);
            this.editImageTab.Controls.Add(this.txtEditImageName);
            this.editImageTab.Controls.Add(this.lblEditImageName);
            this.editImageTab.Location = new System.Drawing.Point(4, 22);
            this.editImageTab.Margin = new System.Windows.Forms.Padding(2);
            this.editImageTab.Name = "editImageTab";
            this.editImageTab.Padding = new System.Windows.Forms.Padding(2);
            this.editImageTab.Size = new System.Drawing.Size(1131, 517);
            this.editImageTab.TabIndex = 3;
            this.editImageTab.Text = "Edit Image";
            // 
            // editImageRow
            // 
            this.editImageRow.Location = new System.Drawing.Point(447, 104);
            this.editImageRow.Margin = new System.Windows.Forms.Padding(2);
            this.editImageRow.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.editImageRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.editImageRow.Name = "editImageRow";
            this.editImageRow.Size = new System.Drawing.Size(90, 20);
            this.editImageRow.TabIndex = 20;
            this.editImageRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.editImageRow.Visible = false;
            // 
            // btnCancelEditImage
            // 
            this.btnCancelEditImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelEditImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelEditImage.Depth = 0;
            this.btnCancelEditImage.HighEmphasis = true;
            this.btnCancelEditImage.Icon = null;
            this.btnCancelEditImage.Location = new System.Drawing.Point(197, 386);
            this.btnCancelEditImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelEditImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelEditImage.Name = "btnCancelEditImage";
            this.btnCancelEditImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelEditImage.Size = new System.Drawing.Size(77, 36);
            this.btnCancelEditImage.TabIndex = 19;
            this.btnCancelEditImage.Text = "Cancel";
            this.btnCancelEditImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelEditImage.UseAccentColor = false;
            this.btnCancelEditImage.UseVisualStyleBackColor = true;
            this.btnCancelEditImage.Click += new System.EventHandler(this.btnCancelEditImage_Click);
            // 
            // txtEditImageDescription
            // 
            this.txtEditImageDescription.AnimateReadOnly = false;
            this.txtEditImageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditImageDescription.Depth = 0;
            this.txtEditImageDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditImageDescription.LeadingIcon = null;
            this.txtEditImageDescription.Location = new System.Drawing.Point(395, 32);
            this.txtEditImageDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditImageDescription.MaxLength = 255;
            this.txtEditImageDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditImageDescription.Multiline = false;
            this.txtEditImageDescription.Name = "txtEditImageDescription";
            this.txtEditImageDescription.Size = new System.Drawing.Size(375, 50);
            this.txtEditImageDescription.TabIndex = 18;
            this.txtEditImageDescription.Text = "";
            this.txtEditImageDescription.TrailingIcon = null;
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateImage.Depth = 0;
            this.btnUpdateImage.HighEmphasis = true;
            this.btnUpdateImage.Icon = null;
            this.btnUpdateImage.Location = new System.Drawing.Point(34, 386);
            this.btnUpdateImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateImage.Size = new System.Drawing.Size(126, 36);
            this.btnUpdateImage.TabIndex = 17;
            this.btnUpdateImage.Text = "Update Image";
            this.btnUpdateImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateImage.UseAccentColor = false;
            this.btnUpdateImage.UseVisualStyleBackColor = true;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // switchEditImageProtected
            // 
            this.switchEditImageProtected.AutoSize = true;
            this.switchEditImageProtected.Depth = 0;
            this.switchEditImageProtected.Location = new System.Drawing.Point(35, 303);
            this.switchEditImageProtected.Margin = new System.Windows.Forms.Padding(0);
            this.switchEditImageProtected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchEditImageProtected.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchEditImageProtected.Name = "switchEditImageProtected";
            this.switchEditImageProtected.Ripple = true;
            this.switchEditImageProtected.Size = new System.Drawing.Size(125, 37);
            this.switchEditImageProtected.TabIndex = 16;
            this.switchEditImageProtected.Text = "Protected";
            this.switchEditImageProtected.UseVisualStyleBackColor = true;
            // 
            // cmbBoxEditImageVisibility
            // 
            this.cmbBoxEditImageVisibility.AutoResize = false;
            this.cmbBoxEditImageVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxEditImageVisibility.Depth = 0;
            this.cmbBoxEditImageVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxEditImageVisibility.DropDownHeight = 174;
            this.cmbBoxEditImageVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEditImageVisibility.DropDownWidth = 121;
            this.cmbBoxEditImageVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxEditImageVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxEditImageVisibility.FormattingEnabled = true;
            this.cmbBoxEditImageVisibility.IntegralHeight = false;
            this.cmbBoxEditImageVisibility.ItemHeight = 43;
            this.cmbBoxEditImageVisibility.Items.AddRange(new object[] {
            "shared",
            "public",
            "private",
            "community"});
            this.cmbBoxEditImageVisibility.Location = new System.Drawing.Point(35, 219);
            this.cmbBoxEditImageVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxEditImageVisibility.MaxDropDownItems = 4;
            this.cmbBoxEditImageVisibility.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxEditImageVisibility.Name = "cmbBoxEditImageVisibility";
            this.cmbBoxEditImageVisibility.Size = new System.Drawing.Size(140, 49);
            this.cmbBoxEditImageVisibility.StartIndex = 0;
            this.cmbBoxEditImageVisibility.TabIndex = 15;
            // 
            // lblEditVisibility
            // 
            this.lblEditVisibility.AutoSize = true;
            this.lblEditVisibility.Depth = 0;
            this.lblEditVisibility.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditVisibility.Location = new System.Drawing.Point(33, 201);
            this.lblEditVisibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditVisibility.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditVisibility.Name = "lblEditVisibility";
            this.lblEditVisibility.Size = new System.Drawing.Size(61, 19);
            this.lblEditVisibility.TabIndex = 14;
            this.lblEditVisibility.Text = "Visibility";
            // 
            // txtEditImageMinimumRam
            // 
            this.txtEditImageMinimumRam.AnimateReadOnly = false;
            this.txtEditImageMinimumRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditImageMinimumRam.Depth = 0;
            this.txtEditImageMinimumRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEditImageMinimumRam.LeadingIcon = null;
            this.txtEditImageMinimumRam.Location = new System.Drawing.Point(252, 218);
            this.txtEditImageMinimumRam.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditImageMinimumRam.MaxLength = 50;
            this.txtEditImageMinimumRam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditImageMinimumRam.Multiline = false;
            this.txtEditImageMinimumRam.Name = "txtEditImageMinimumRam";
            this.txtEditImageMinimumRam.Size = new System.Drawing.Size(116, 50);
            this.txtEditImageMinimumRam.TabIndex = 13;
            this.txtEditImageMinimumRam.Text = "0";
            this.txtEditImageMinimumRam.TrailingIcon = null;
            this.txtEditImageMinimumRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumRam_KeyPress);
            // 
            // txtEditImageMinimumDisk
            // 
            this.txtEditImageMinimumDisk.AnimateReadOnly = false;
            this.txtEditImageMinimumDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditImageMinimumDisk.Depth = 0;
            this.txtEditImageMinimumDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEditImageMinimumDisk.LeadingIcon = null;
            this.txtEditImageMinimumDisk.Location = new System.Drawing.Point(252, 125);
            this.txtEditImageMinimumDisk.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditImageMinimumDisk.MaxLength = 50;
            this.txtEditImageMinimumDisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditImageMinimumDisk.Multiline = false;
            this.txtEditImageMinimumDisk.Name = "txtEditImageMinimumDisk";
            this.txtEditImageMinimumDisk.Size = new System.Drawing.Size(116, 50);
            this.txtEditImageMinimumDisk.TabIndex = 12;
            this.txtEditImageMinimumDisk.Text = "0";
            this.txtEditImageMinimumDisk.TrailingIcon = null;
            this.txtEditImageMinimumDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumDisk_KeyPress);
            // 
            // lblEditImageMinimumRam
            // 
            this.lblEditImageMinimumRam.AutoSize = true;
            this.lblEditImageMinimumRam.Depth = 0;
            this.lblEditImageMinimumRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditImageMinimumRam.Location = new System.Drawing.Point(250, 201);
            this.lblEditImageMinimumRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditImageMinimumRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditImageMinimumRam.Name = "lblEditImageMinimumRam";
            this.lblEditImageMinimumRam.Size = new System.Drawing.Size(146, 19);
            this.lblEditImageMinimumRam.TabIndex = 11;
            this.lblEditImageMinimumRam.Text = "Minimum RAM (MB)";
            // 
            // lblEditMinimumDisk
            // 
            this.lblEditMinimumDisk.AutoSize = true;
            this.lblEditMinimumDisk.Depth = 0;
            this.lblEditMinimumDisk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditMinimumDisk.Location = new System.Drawing.Point(250, 106);
            this.lblEditMinimumDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditMinimumDisk.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditMinimumDisk.Name = "lblEditMinimumDisk";
            this.lblEditMinimumDisk.Size = new System.Drawing.Size(140, 19);
            this.lblEditMinimumDisk.TabIndex = 10;
            this.lblEditMinimumDisk.Text = "Minimum Disk (GB)";
            // 
            // lblEditDisskFormat
            // 
            this.lblEditDisskFormat.AutoSize = true;
            this.lblEditDisskFormat.Depth = 0;
            this.lblEditDisskFormat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditDisskFormat.Location = new System.Drawing.Point(33, 106);
            this.lblEditDisskFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditDisskFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditDisskFormat.Name = "lblEditDisskFormat";
            this.lblEditDisskFormat.Size = new System.Drawing.Size(87, 19);
            this.lblEditDisskFormat.TabIndex = 9;
            this.lblEditDisskFormat.Text = "Disk Format";
            // 
            // cmbBoxEditImageDiskFormat
            // 
            this.cmbBoxEditImageDiskFormat.AutoResize = false;
            this.cmbBoxEditImageDiskFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxEditImageDiskFormat.Depth = 0;
            this.cmbBoxEditImageDiskFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxEditImageDiskFormat.DropDownHeight = 174;
            this.cmbBoxEditImageDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEditImageDiskFormat.DropDownWidth = 121;
            this.cmbBoxEditImageDiskFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxEditImageDiskFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxEditImageDiskFormat.FormattingEnabled = true;
            this.cmbBoxEditImageDiskFormat.IntegralHeight = false;
            this.cmbBoxEditImageDiskFormat.ItemHeight = 43;
            this.cmbBoxEditImageDiskFormat.Items.AddRange(new object[] {
            "QCOW2",
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
            "VDI",
            "PLOOP",
            "ISO"});
            this.cmbBoxEditImageDiskFormat.Location = new System.Drawing.Point(35, 125);
            this.cmbBoxEditImageDiskFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxEditImageDiskFormat.MaxDropDownItems = 4;
            this.cmbBoxEditImageDiskFormat.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxEditImageDiskFormat.Name = "cmbBoxEditImageDiskFormat";
            this.cmbBoxEditImageDiskFormat.Size = new System.Drawing.Size(140, 49);
            this.cmbBoxEditImageDiskFormat.StartIndex = 0;
            this.cmbBoxEditImageDiskFormat.TabIndex = 8;
            // 
            // lblEditImageDescription
            // 
            this.lblEditImageDescription.AutoSize = true;
            this.lblEditImageDescription.Depth = 0;
            this.lblEditImageDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditImageDescription.Location = new System.Drawing.Point(392, 11);
            this.lblEditImageDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditImageDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditImageDescription.Name = "lblEditImageDescription";
            this.lblEditImageDescription.Size = new System.Drawing.Size(129, 19);
            this.lblEditImageDescription.TabIndex = 4;
            this.lblEditImageDescription.Text = "Image Description";
            // 
            // txtEditImageName
            // 
            this.txtEditImageName.AnimateReadOnly = false;
            this.txtEditImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditImageName.Depth = 0;
            this.txtEditImageName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditImageName.LeadingIcon = null;
            this.txtEditImageName.Location = new System.Drawing.Point(34, 32);
            this.txtEditImageName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditImageName.MaxLength = 50;
            this.txtEditImageName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditImageName.Multiline = false;
            this.txtEditImageName.Name = "txtEditImageName";
            this.txtEditImageName.Size = new System.Drawing.Size(316, 50);
            this.txtEditImageName.TabIndex = 2;
            this.txtEditImageName.Text = "";
            this.txtEditImageName.TrailingIcon = null;
            // 
            // lblEditImageName
            // 
            this.lblEditImageName.AutoSize = true;
            this.lblEditImageName.Depth = 0;
            this.lblEditImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditImageName.Location = new System.Drawing.Point(33, 11);
            this.lblEditImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditImageName.Name = "lblEditImageName";
            this.lblEditImageName.Size = new System.Drawing.Size(91, 19);
            this.lblEditImageName.TabIndex = 0;
            this.lblEditImageName.Text = "Image Name";
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 582);
            this.ControlBox = false;
            this.Controls.Add(this.imagesTabControl);
            this.Controls.Add(this.imagesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ImagesForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.imagesTabControl.ResumeLayout(false);
            this.imagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            this.createImageTab.ResumeLayout(false);
            this.createImageTab.PerformLayout();
            this.editImageTab.ResumeLayout(false);
            this.editImageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editImageRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector imagesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl imagesTabControl;
        private System.Windows.Forms.TabPage imagesTab;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.TabPage createImageTab;
        private MaterialSkin.Controls.MaterialSwitch switchImageProtected;
        private MaterialSkin.Controls.MaterialComboBox cmbImageBoxVisibility;
        private MaterialSkin.Controls.MaterialLabel lblImageVisibility;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumRam;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimumRam;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimimDisk;
        private MaterialSkin.Controls.MaterialLabel lblImageDiskFormat;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxImageDiskFormat;
        private MaterialSkin.Controls.MaterialButton btnImageBrowse;
        private MaterialSkin.Controls.MaterialTextBox txtImageFile;
        private MaterialSkin.Controls.MaterialLabel lblImageFile;
        private MaterialSkin.Controls.MaterialLabel lblImageDescription;
        private MaterialSkin.Controls.MaterialTextBox txtImageName;
        private MaterialSkin.Controls.MaterialLabel lblImageName;
        private MaterialSkin.Controls.MaterialButton btnCreateImage;
        private MaterialSkin.Controls.MaterialTextBox txtImageDescription;
        private System.Windows.Forms.TabPage editImageTab;
        private MaterialSkin.Controls.MaterialTextBox txtEditImageDescription;
        private MaterialSkin.Controls.MaterialButton btnUpdateImage;
        private MaterialSkin.Controls.MaterialSwitch switchEditImageProtected;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxEditImageVisibility;
        private MaterialSkin.Controls.MaterialLabel lblEditVisibility;
        private MaterialSkin.Controls.MaterialTextBox txtEditImageMinimumRam;
        private MaterialSkin.Controls.MaterialTextBox txtEditImageMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblEditImageMinimumRam;
        private MaterialSkin.Controls.MaterialLabel lblEditMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblEditDisskFormat;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxEditImageDiskFormat;
        private MaterialSkin.Controls.MaterialLabel lblEditImageDescription;
        private MaterialSkin.Controls.MaterialTextBox txtEditImageName;
        private MaterialSkin.Controls.MaterialLabel lblEditImageName;
        private MaterialSkin.Controls.MaterialButton btnCancelEditImage;
        private System.Windows.Forms.NumericUpDown editImageRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnLineNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnImageDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProtected;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDiskFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnMinimumDisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnMinimumRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnContainerFormt;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnSize;
        private System.Windows.Forms.DataGridViewImageColumn collumnEditImage;
        private System.Windows.Forms.DataGridViewImageColumn columnDeleteImage;
    }
}