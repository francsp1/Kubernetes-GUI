
namespace OpenStack_GUI.Forms
{
    partial class KeyPairForm
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
            this.tabPageKeyPair = new System.Windows.Forms.TabPage();
            this.keysGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageCreateKey = new System.Windows.Forms.TabPage();
            this.txtkeyName = new MaterialSkin.Controls.MaterialTextBox();
            this.keyName = new MaterialSkin.Controls.MaterialLabel();
            this.typekeyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.typeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.CreateKeyButton = new MaterialSkin.Controls.MaterialButton();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerprintColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPageKeyPair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysGridView1)).BeginInit();
            this.tabPageCreateKey.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabPageKeyPair);
            this.materialTabControl1.Controls.Add(this.tabPageCreateKey);
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
            // tabPageKeyPair
            // 
            this.tabPageKeyPair.BackColor = System.Drawing.Color.White;
            this.tabPageKeyPair.Controls.Add(this.keysGridView1);
            this.tabPageKeyPair.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyPair.Name = "tabPageKeyPair";
            this.tabPageKeyPair.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageKeyPair.Size = new System.Drawing.Size(1131, 478);
            this.tabPageKeyPair.TabIndex = 0;
            this.tabPageKeyPair.Text = "Key Pairs";
            // 
            // keysGridView1
            // 
            this.keysGridView1.AllowUserToAddRows = false;
            this.keysGridView1.BackgroundColor = System.Drawing.Color.White;
            this.keysGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keysGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.keysGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keysGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.fingerprintColumn,
            this.deleteColumn});
            this.keysGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysGridView1.Location = new System.Drawing.Point(3, 3);
            this.keysGridView1.Name = "keysGridView1";
            this.keysGridView1.RowHeadersWidth = 51;
            this.keysGridView1.Size = new System.Drawing.Size(1125, 472);
            this.keysGridView1.TabIndex = 0;
            this.keysGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick_delete);
            // 
            // tabPageCreateKey
            // 
            this.tabPageCreateKey.BackColor = System.Drawing.Color.White;
            this.tabPageCreateKey.Controls.Add(this.CreateKeyButton);
            this.tabPageCreateKey.Controls.Add(this.typekeyLabel);
            this.tabPageCreateKey.Controls.Add(this.typeComboBox);
            this.tabPageCreateKey.Controls.Add(this.txtkeyName);
            this.tabPageCreateKey.Controls.Add(this.keyName);
            this.tabPageCreateKey.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateKey.Name = "tabPageCreateKey";
            this.tabPageCreateKey.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageCreateKey.Size = new System.Drawing.Size(1131, 478);
            this.tabPageCreateKey.TabIndex = 1;
            this.tabPageCreateKey.Text = "Create Key Pair";
            // 
            // txtkeyName
            // 
            this.txtkeyName.AnimateReadOnly = false;
            this.txtkeyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkeyName.Depth = 0;
            this.txtkeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            // 
            // fingerprintColumn
            // 
            this.fingerprintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fingerprintColumn.HeaderText = "Fingerprint";
            this.fingerprintColumn.MinimumWidth = 6;
            this.fingerprintColumn.Name = "fingerprintColumn";
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = global::OpenStack_GUI.Properties.Resources.remove__1_;
            this.deleteColumn.Name = "deleteColumn";
            // 
            // KeyPairForm
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
            this.Name = "KeyPairForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "KeyPairForm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageKeyPair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keysGridView1)).EndInit();
            this.tabPageCreateKey.ResumeLayout(false);
            this.tabPageCreateKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector keysTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageKeyPair;
        private System.Windows.Forms.TabPage tabPageCreateKey;
        private System.Windows.Forms.DataGridView keysGridView1;
        private MaterialSkin.Controls.MaterialTextBox txtkeyName;
        private MaterialSkin.Controls.MaterialLabel keyName;
        private MaterialSkin.Controls.MaterialLabel typekeyLabel;
        private MaterialSkin.Controls.MaterialComboBox typeComboBox;
        private MaterialSkin.Controls.MaterialButton CreateKeyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerprintColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}