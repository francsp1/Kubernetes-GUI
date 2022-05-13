
namespace OpenStack_GUI.Forms
{
    partial class VolumesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolumesForm));
            this.volumesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.volumesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.volumesGridView = new System.Windows.Forms.DataGridView();
            this.IDVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAvailabilityZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBootable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEncrypted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateVolumeButton = new MaterialSkin.Controls.MaterialButton();
            this.availabilityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.typeLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.sourceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lblVolumeName = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.availabilityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.sizeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.sourceComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.VolumeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblVolumeId = new MaterialSkin.Controls.MaterialLabel();
            this.lblId = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelEditVolume = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateVolume = new MaterialSkin.Controls.MaterialButton();
            this.switchEditBoot = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.editTextBoxDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.editTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.volumesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumesGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // volumesTabSelector
            // 
            this.volumesTabSelector.BaseTabControl = this.volumesTabControl;
            this.volumesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.volumesTabSelector.Depth = 0;
            this.volumesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.volumesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.volumesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.volumesTabSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volumesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabSelector.Name = "volumesTabSelector";
            this.volumesTabSelector.Size = new System.Drawing.Size(1139, 39);
            this.volumesTabSelector.TabIndex = 0;
            this.volumesTabSelector.Text = "materialTabSelector1";
            // 
            // volumesTabControl
            // 
            this.volumesTabControl.Controls.Add(this.tabPage1);
            this.volumesTabControl.Controls.Add(this.tabPage2);
            this.volumesTabControl.Controls.Add(this.tabPage3);
            this.volumesTabControl.Depth = 0;
            this.volumesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumesTabControl.Location = new System.Drawing.Point(0, 39);
            this.volumesTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volumesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabControl.Multiline = true;
            this.volumesTabControl.Name = "volumesTabControl";
            this.volumesTabControl.SelectedIndex = 0;
            this.volumesTabControl.Size = new System.Drawing.Size(1139, 543);
            this.volumesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.volumesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1131, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Volumes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // volumesGridView
            // 
            this.volumesGridView.AllowUserToAddRows = false;
            this.volumesGridView.AllowUserToDeleteRows = false;
            this.volumesGridView.AllowUserToOrderColumns = true;
            this.volumesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.volumesGridView.BackgroundColor = System.Drawing.Color.White;
            this.volumesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.volumesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVolume,
            this.columnName,
            this.columnDescription,
            this.columnSize,
            this.columnStatus,
            this.columnGroup,
            this.columnType,
            this.columnAvailabilityZone,
            this.columnBootable,
            this.columnEncrypted,
            this.deleteColumn,
            this.edit,
            this.delete});
            this.volumesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumesGridView.GridColor = System.Drawing.Color.White;
            this.volumesGridView.Location = new System.Drawing.Point(2, 2);
            this.volumesGridView.Name = "volumesGridView";
            this.volumesGridView.ReadOnly = true;
            this.volumesGridView.RowHeadersWidth = 51;
            this.volumesGridView.Size = new System.Drawing.Size(1127, 513);
            this.volumesGridView.TabIndex = 0;
            this.volumesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDVolume
            // 
            this.IDVolume.HeaderText = "ID";
            this.IDVolume.MinimumWidth = 6;
            this.IDVolume.Name = "IDVolume";
            this.IDVolume.ReadOnly = true;
            this.IDVolume.Visible = false;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.MinimumWidth = 6;
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.ReadOnly = true;
            // 
            // columnSize
            // 
            this.columnSize.HeaderText = "Size";
            this.columnSize.MinimumWidth = 6;
            this.columnSize.Name = "columnSize";
            this.columnSize.ReadOnly = true;
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.MinimumWidth = 6;
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            // 
            // columnGroup
            // 
            this.columnGroup.HeaderText = "Group";
            this.columnGroup.MinimumWidth = 6;
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.MinimumWidth = 6;
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // columnAvailabilityZone
            // 
            this.columnAvailabilityZone.HeaderText = "Availability Zone";
            this.columnAvailabilityZone.MinimumWidth = 6;
            this.columnAvailabilityZone.Name = "columnAvailabilityZone";
            this.columnAvailabilityZone.ReadOnly = true;
            // 
            // columnBootable
            // 
            this.columnBootable.HeaderText = "Bootable";
            this.columnBootable.MinimumWidth = 6;
            this.columnBootable.Name = "columnBootable";
            this.columnBootable.ReadOnly = true;
            // 
            // columnEncrypted
            // 
            this.columnEncrypted.HeaderText = "Encrypted";
            this.columnEncrypted.MinimumWidth = 6;
            this.columnEncrypted.Name = "columnEncrypted";
            this.columnEncrypted.ReadOnly = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Visible = false;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.edit.HeaderText = "Edit";
            this.edit.Image = global::OpenStack_GUI.Properties.Resources.edit_button;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 31;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.delete.HeaderText = "Delete";
            this.delete.Image = global::OpenStack_GUI.Properties.Resources.remove__1_;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.CreateVolumeButton);
            this.tabPage2.Controls.Add(this.availabilityLabel);
            this.tabPage2.Controls.Add(this.SizeLabel);
            this.tabPage2.Controls.Add(this.typeLabel1);
            this.tabPage2.Controls.Add(this.sourceLabel);
            this.tabPage2.Controls.Add(this.DescriptionLabel);
            this.tabPage2.Controls.Add(this.lblVolumeName);
            this.tabPage2.Controls.Add(this.DescriptionTextBox);
            this.tabPage2.Controls.Add(this.availabilityComboBox);
            this.tabPage2.Controls.Add(this.sizeTextBox);
            this.tabPage2.Controls.Add(this.TypeComboBox);
            this.tabPage2.Controls.Add(this.sourceComboBox);
            this.tabPage2.Controls.Add(this.VolumeTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1131, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Volumes";
            // 
            // CreateVolumeButton
            // 
            this.CreateVolumeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateVolumeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateVolumeButton.Depth = 0;
            this.CreateVolumeButton.HighEmphasis = true;
            this.CreateVolumeButton.Icon = null;
            this.CreateVolumeButton.Location = new System.Drawing.Point(31, 388);
            this.CreateVolumeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateVolumeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateVolumeButton.Name = "CreateVolumeButton";
            this.CreateVolumeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateVolumeButton.Size = new System.Drawing.Size(138, 36);
            this.CreateVolumeButton.TabIndex = 20;
            this.CreateVolumeButton.Text = "Create Volume";
            this.CreateVolumeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateVolumeButton.UseAccentColor = false;
            this.CreateVolumeButton.UseVisualStyleBackColor = true;
            this.CreateVolumeButton.Click += new System.EventHandler(this.CreateVolumeButton_Click);
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.Depth = 0;
            this.availabilityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availabilityLabel.Location = new System.Drawing.Point(461, 266);
            this.availabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availabilityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(119, 19);
            this.availabilityLabel.TabIndex = 19;
            this.availabilityLabel.Text = "Availability Zone";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Depth = 0;
            this.SizeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SizeLabel.Location = new System.Drawing.Point(28, 266);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(31, 19);
            this.SizeLabel.TabIndex = 18;
            this.SizeLabel.Text = "Size";
            // 
            // typeLabel1
            // 
            this.typeLabel1.AutoSize = true;
            this.typeLabel1.Depth = 0;
            this.typeLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeLabel1.Location = new System.Drawing.Point(456, 136);
            this.typeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeLabel1.Name = "typeLabel1";
            this.typeLabel1.Size = new System.Drawing.Size(36, 19);
            this.typeLabel1.TabIndex = 17;
            this.typeLabel1.Text = "Type";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Depth = 0;
            this.sourceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceLabel.Location = new System.Drawing.Point(28, 136);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sourceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(108, 19);
            this.sourceLabel.TabIndex = 16;
            this.sourceLabel.Text = "Volume Source";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionLabel.Location = new System.Drawing.Point(456, 20);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(81, 19);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description";
            // 
            // lblVolumeName
            // 
            this.lblVolumeName.AutoSize = true;
            this.lblVolumeName.Depth = 0;
            this.lblVolumeName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVolumeName.Location = new System.Drawing.Point(28, 20);
            this.lblVolumeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVolumeName.Name = "lblVolumeName";
            this.lblVolumeName.Size = new System.Drawing.Size(101, 19);
            this.lblVolumeName.TabIndex = 14;
            this.lblVolumeName.Text = "Volume Name";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AnimateReadOnly = false;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Depth = 0;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionTextBox.LeadingIcon = null;
            this.DescriptionTextBox.Location = new System.Drawing.Point(459, 42);
            this.DescriptionTextBox.MaxLength = 50;
            this.DescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionTextBox.Multiline = false;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(332, 50);
            this.DescriptionTextBox.TabIndex = 13;
            this.DescriptionTextBox.Text = "";
            this.DescriptionTextBox.TrailingIcon = null;
            // 
            // availabilityComboBox
            // 
            this.availabilityComboBox.AutoResize = false;
            this.availabilityComboBox.BackColor = System.Drawing.Color.White;
            this.availabilityComboBox.Depth = 0;
            this.availabilityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.availabilityComboBox.DropDownHeight = 174;
            this.availabilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availabilityComboBox.DropDownWidth = 121;
            this.availabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.availabilityComboBox.ForeColor = System.Drawing.Color.Black;
            this.availabilityComboBox.FormattingEnabled = true;
            this.availabilityComboBox.IntegralHeight = false;
            this.availabilityComboBox.ItemHeight = 43;
            this.availabilityComboBox.Items.AddRange(new object[] {
            "nova"});
            this.availabilityComboBox.Location = new System.Drawing.Point(459, 289);
            this.availabilityComboBox.MaxDropDownItems = 4;
            this.availabilityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.availabilityComboBox.Name = "availabilityComboBox";
            this.availabilityComboBox.Size = new System.Drawing.Size(332, 49);
            this.availabilityComboBox.StartIndex = 0;
            this.availabilityComboBox.TabIndex = 12;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.AnimateReadOnly = false;
            this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeTextBox.Depth = 0;
            this.sizeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sizeTextBox.LeadingIcon = null;
            this.sizeTextBox.Location = new System.Drawing.Point(31, 288);
            this.sizeTextBox.MaxLength = 50;
            this.sizeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sizeTextBox.Multiline = false;
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(329, 50);
            this.sizeTextBox.TabIndex = 10;
            this.sizeTextBox.Text = "";
            this.sizeTextBox.TrailingIcon = null;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.AutoResize = false;
            this.TypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeComboBox.Depth = 0;
            this.TypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TypeComboBox.DropDownHeight = 174;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.DropDownWidth = 121;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.IntegralHeight = false;
            this.TypeComboBox.ItemHeight = 43;
            this.TypeComboBox.Items.AddRange(new object[] {
            "_DEFAULT_"});
            this.TypeComboBox.Location = new System.Drawing.Point(459, 167);
            this.TypeComboBox.MaxDropDownItems = 4;
            this.TypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(332, 49);
            this.TypeComboBox.StartIndex = 0;
            this.TypeComboBox.TabIndex = 8;
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.AutoResize = false;
            this.sourceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sourceComboBox.Depth = 0;
            this.sourceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sourceComboBox.DropDownHeight = 174;
            this.sourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceComboBox.DropDownWidth = 121;
            this.sourceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sourceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.IntegralHeight = false;
            this.sourceComboBox.ItemHeight = 43;
            this.sourceComboBox.Items.AddRange(new object[] {
            "No source, empty volume",
            "Image",
            "Volume"});
            this.sourceComboBox.Location = new System.Drawing.Point(31, 167);
            this.sourceComboBox.MaxDropDownItems = 4;
            this.sourceComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(329, 49);
            this.sourceComboBox.StartIndex = 0;
            this.sourceComboBox.TabIndex = 6;
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.AnimateReadOnly = false;
            this.VolumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VolumeTextBox.Depth = 0;
            this.VolumeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VolumeTextBox.LeadingIcon = null;
            this.VolumeTextBox.Location = new System.Drawing.Point(31, 42);
            this.VolumeTextBox.MaxLength = 50;
            this.VolumeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.VolumeTextBox.Multiline = false;
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(332, 50);
            this.VolumeTextBox.TabIndex = 0;
            this.VolumeTextBox.Text = "";
            this.VolumeTextBox.TrailingIcon = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.lblVolumeId);
            this.tabPage3.Controls.Add(this.lblId);
            this.tabPage3.Controls.Add(this.btnCancelEditVolume);
            this.tabPage3.Controls.Add(this.btnUpdateVolume);
            this.tabPage3.Controls.Add(this.switchEditBoot);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.editTextBoxDesc);
            this.tabPage3.Controls.Add(this.editTextBoxName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1131, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Volume";
            // 
            // lblVolumeId
            // 
            this.lblVolumeId.AutoSize = true;
            this.lblVolumeId.Depth = 0;
            this.lblVolumeId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVolumeId.Location = new System.Drawing.Point(30, 16);
            this.lblVolumeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVolumeId.Name = "lblVolumeId";
            this.lblVolumeId.Size = new System.Drawing.Size(16, 19);
            this.lblVolumeId.TabIndex = 24;
            this.lblVolumeId.Text = "ID";
            this.lblVolumeId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Depth = 0;
            this.lblId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblId.Location = new System.Drawing.Point(8, 16);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "ID: ";
            this.lblId.Visible = false;
            // 
            // btnCancelEditVolume
            // 
            this.btnCancelEditVolume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelEditVolume.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelEditVolume.Depth = 0;
            this.btnCancelEditVolume.HighEmphasis = true;
            this.btnCancelEditVolume.Icon = null;
            this.btnCancelEditVolume.Location = new System.Drawing.Point(174, 282);
            this.btnCancelEditVolume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelEditVolume.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelEditVolume.Name = "btnCancelEditVolume";
            this.btnCancelEditVolume.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelEditVolume.Size = new System.Drawing.Size(77, 36);
            this.btnCancelEditVolume.TabIndex = 22;
            this.btnCancelEditVolume.Text = "Cancel";
            this.btnCancelEditVolume.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelEditVolume.UseAccentColor = false;
            this.btnCancelEditVolume.UseVisualStyleBackColor = true;
            this.btnCancelEditVolume.Click += new System.EventHandler(this.btnCancelEditVolume_Click);
            // 
            // btnUpdateVolume
            // 
            this.btnUpdateVolume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateVolume.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateVolume.Depth = 0;
            this.btnUpdateVolume.HighEmphasis = true;
            this.btnUpdateVolume.Icon = null;
            this.btnUpdateVolume.Location = new System.Drawing.Point(10, 282);
            this.btnUpdateVolume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateVolume.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateVolume.Name = "btnUpdateVolume";
            this.btnUpdateVolume.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateVolume.Size = new System.Drawing.Size(139, 36);
            this.btnUpdateVolume.TabIndex = 21;
            this.btnUpdateVolume.Text = "Update Volume";
            this.btnUpdateVolume.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateVolume.UseAccentColor = false;
            this.btnUpdateVolume.UseVisualStyleBackColor = true;
            this.btnUpdateVolume.Click += new System.EventHandler(this.btnUpdateVolume_Click);
            // 
            // switchEditBoot
            // 
            this.switchEditBoot.AutoSize = true;
            this.switchEditBoot.Depth = 0;
            this.switchEditBoot.Location = new System.Drawing.Point(10, 190);
            this.switchEditBoot.Margin = new System.Windows.Forms.Padding(0);
            this.switchEditBoot.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchEditBoot.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchEditBoot.Name = "switchEditBoot";
            this.switchEditBoot.Ripple = true;
            this.switchEditBoot.Size = new System.Drawing.Size(125, 37);
            this.switchEditBoot.TabIndex = 20;
            this.switchEditBoot.Text = "Bootable ";
            this.switchEditBoot.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(435, 54);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Description";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.White;
            this.materialLabel2.Location = new System.Drawing.Point(7, 54);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Volume Name";
            // 
            // editTextBoxDesc
            // 
            this.editTextBoxDesc.AnimateReadOnly = false;
            this.editTextBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBoxDesc.Depth = 0;
            this.editTextBoxDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editTextBoxDesc.LeadingIcon = null;
            this.editTextBoxDesc.Location = new System.Drawing.Point(438, 76);
            this.editTextBoxDesc.MaxLength = 50;
            this.editTextBoxDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.editTextBoxDesc.Multiline = false;
            this.editTextBoxDesc.Name = "editTextBoxDesc";
            this.editTextBoxDesc.Size = new System.Drawing.Size(332, 50);
            this.editTextBoxDesc.TabIndex = 17;
            this.editTextBoxDesc.Text = "";
            this.editTextBoxDesc.TrailingIcon = null;
            // 
            // editTextBoxName
            // 
            this.editTextBoxName.AnimateReadOnly = false;
            this.editTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTextBoxName.Depth = 0;
            this.editTextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editTextBoxName.ForeColor = System.Drawing.Color.White;
            this.editTextBoxName.LeadingIcon = null;
            this.editTextBoxName.Location = new System.Drawing.Point(10, 76);
            this.editTextBoxName.MaxLength = 50;
            this.editTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.editTextBoxName.Multiline = false;
            this.editTextBoxName.Name = "editTextBoxName";
            this.editTextBoxName.Size = new System.Drawing.Size(332, 50);
            this.editTextBoxName.TabIndex = 16;
            this.editTextBoxName.Text = "";
            this.editTextBoxName.TrailingIcon = null;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::OpenStack_GUI.Properties.Resources.edit_button;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // VolumesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 582);
            this.ControlBox = false;
            this.Controls.Add(this.volumesTabControl);
            this.Controls.Add(this.volumesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Volumes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Volumes_Load);
            this.volumesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumesGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector volumesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl volumesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView volumesGridView;
        private MaterialSkin.Controls.MaterialTextBox VolumeTextBox;
        private MaterialSkin.Controls.MaterialComboBox sourceComboBox;
        private MaterialSkin.Controls.MaterialComboBox TypeComboBox;
        private MaterialSkin.Controls.MaterialComboBox availabilityComboBox;
        private MaterialSkin.Controls.MaterialTextBox sizeTextBox;
        private MaterialSkin.Controls.MaterialTextBox DescriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
        private MaterialSkin.Controls.MaterialLabel lblVolumeName;
        private MaterialSkin.Controls.MaterialLabel sourceLabel;
        private MaterialSkin.Controls.MaterialLabel typeLabel1;
        private MaterialSkin.Controls.MaterialLabel SizeLabel;
        private MaterialSkin.Controls.MaterialLabel availabilityLabel;
        private MaterialSkin.Controls.MaterialButton CreateVolumeButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox editTextBoxDesc;
        private MaterialSkin.Controls.MaterialTextBox editTextBoxName;
        private MaterialSkin.Controls.MaterialSwitch switchEditBoot;
        private MaterialSkin.Controls.MaterialButton btnCancelEditVolume;
        private MaterialSkin.Controls.MaterialButton btnUpdateVolume;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAvailabilityZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBootable;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEncrypted;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private MaterialSkin.Controls.MaterialLabel lblId;
        private MaterialSkin.Controls.MaterialLabel lblVolumeId;
    }
}