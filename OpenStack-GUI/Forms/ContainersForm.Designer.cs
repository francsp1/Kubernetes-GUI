
namespace OpenStack_GUI.Forms
{
    partial class ContainersForm
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
            this.containersTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.containersTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.containersTabPage = new System.Windows.Forms.TabPage();
            this.containersGridView = new System.Windows.Forms.DataGridView();
            this.nameCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStateCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCollumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteCollumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.createContainerTabPage = new System.Windows.Forms.TabPage();
            this.lblContainerName = new MaterialSkin.Controls.MaterialLabel();
            this.txtContainerName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblContainerImage = new MaterialSkin.Controls.MaterialLabel();
            this.txtContainerImage = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCreateContainer = new MaterialSkin.Controls.MaterialButton();
            this.containersTabControl.SuspendLayout();
            this.containersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containersGridView)).BeginInit();
            this.createContainerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // containersTabSelector
            // 
            this.containersTabSelector.BaseTabControl = this.containersTabControl;
            this.containersTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.containersTabSelector.Depth = 0;
            this.containersTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.containersTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.containersTabSelector.Location = new System.Drawing.Point(0, 0);
            this.containersTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.containersTabSelector.Name = "containersTabSelector";
            this.containersTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.containersTabSelector.TabIndex = 0;
            // 
            // containersTabControl
            // 
            this.containersTabControl.Controls.Add(this.containersTabPage);
            this.containersTabControl.Controls.Add(this.createContainerTabPage);
            this.containersTabControl.Depth = 0;
            this.containersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containersTabControl.Location = new System.Drawing.Point(0, 48);
            this.containersTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.containersTabControl.Multiline = true;
            this.containersTabControl.Name = "containersTabControl";
            this.containersTabControl.SelectedIndex = 0;
            this.containersTabControl.Size = new System.Drawing.Size(1519, 668);
            this.containersTabControl.TabIndex = 1;
            // 
            // containersTabPage
            // 
            this.containersTabPage.BackColor = System.Drawing.Color.White;
            this.containersTabPage.Controls.Add(this.containersGridView);
            this.containersTabPage.Location = new System.Drawing.Point(4, 25);
            this.containersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTabPage.Name = "containersTabPage";
            this.containersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTabPage.Size = new System.Drawing.Size(1511, 639);
            this.containersTabPage.TabIndex = 0;
            this.containersTabPage.Text = "Containers";
            // 
            // containersGridView
            // 
            this.containersGridView.AllowUserToAddRows = false;
            this.containersGridView.AllowUserToDeleteRows = false;
            this.containersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.containersGridView.BackgroundColor = System.Drawing.Color.White;
            this.containersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCollumn,
            this.idCollumn,
            this.imageCollumn,
            this.statusCollumn,
            this.taskStateCollumn,
            this.editCollumn,
            this.deleteCollumn});
            this.containersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containersGridView.GridColor = System.Drawing.Color.White;
            this.containersGridView.Location = new System.Drawing.Point(3, 2);
            this.containersGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersGridView.Name = "containersGridView";
            this.containersGridView.ReadOnly = true;
            this.containersGridView.RowHeadersWidth = 51;
            this.containersGridView.RowTemplate.Height = 24;
            this.containersGridView.Size = new System.Drawing.Size(1505, 635);
            this.containersGridView.TabIndex = 0;
            this.containersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.containersGridView_CellClick);
            // 
            // nameCollumn
            // 
            this.nameCollumn.HeaderText = "Name";
            this.nameCollumn.MinimumWidth = 6;
            this.nameCollumn.Name = "nameCollumn";
            this.nameCollumn.ReadOnly = true;
            // 
            // idCollumn
            // 
            this.idCollumn.HeaderText = "ID";
            this.idCollumn.MinimumWidth = 6;
            this.idCollumn.Name = "idCollumn";
            this.idCollumn.ReadOnly = true;
            // 
            // imageCollumn
            // 
            this.imageCollumn.HeaderText = "Image";
            this.imageCollumn.MinimumWidth = 6;
            this.imageCollumn.Name = "imageCollumn";
            this.imageCollumn.ReadOnly = true;
            // 
            // statusCollumn
            // 
            this.statusCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusCollumn.HeaderText = "status";
            this.statusCollumn.MinimumWidth = 6;
            this.statusCollumn.Name = "statusCollumn";
            this.statusCollumn.ReadOnly = true;
            this.statusCollumn.Width = 125;
            // 
            // taskStateCollumn
            // 
            this.taskStateCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.taskStateCollumn.HeaderText = "Task State";
            this.taskStateCollumn.MinimumWidth = 6;
            this.taskStateCollumn.Name = "taskStateCollumn";
            this.taskStateCollumn.ReadOnly = true;
            this.taskStateCollumn.Width = 125;
            // 
            // editCollumn
            // 
            this.editCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editCollumn.HeaderText = "Edit";
            this.editCollumn.Image = global::OpenStack_GUI.Properties.Resources.edit_button;
            this.editCollumn.MinimumWidth = 6;
            this.editCollumn.Name = "editCollumn";
            this.editCollumn.ReadOnly = true;
            this.editCollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editCollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editCollumn.Width = 50;
            // 
            // deleteCollumn
            // 
            this.deleteCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteCollumn.HeaderText = "Delete";
            this.deleteCollumn.Image = global::OpenStack_GUI.Properties.Resources.remove__1_;
            this.deleteCollumn.MinimumWidth = 6;
            this.deleteCollumn.Name = "deleteCollumn";
            this.deleteCollumn.ReadOnly = true;
            this.deleteCollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteCollumn.Width = 50;
            // 
            // createContainerTabPage
            // 
            this.createContainerTabPage.BackColor = System.Drawing.Color.White;
            this.createContainerTabPage.Controls.Add(this.btnCreateContainer);
            this.createContainerTabPage.Controls.Add(this.txtContainerImage);
            this.createContainerTabPage.Controls.Add(this.lblContainerImage);
            this.createContainerTabPage.Controls.Add(this.txtContainerName);
            this.createContainerTabPage.Controls.Add(this.lblContainerName);
            this.createContainerTabPage.Location = new System.Drawing.Point(4, 25);
            this.createContainerTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createContainerTabPage.Name = "createContainerTabPage";
            this.createContainerTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createContainerTabPage.Size = new System.Drawing.Size(1511, 639);
            this.createContainerTabPage.TabIndex = 1;
            this.createContainerTabPage.Text = "Create Container";
            // 
            // lblContainerName
            // 
            this.lblContainerName.AutoSize = true;
            this.lblContainerName.Depth = 0;
            this.lblContainerName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContainerName.Location = new System.Drawing.Point(30, 22);
            this.lblContainerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContainerName.Name = "lblContainerName";
            this.lblContainerName.Size = new System.Drawing.Size(43, 19);
            this.lblContainerName.TabIndex = 0;
            this.lblContainerName.Text = "Name";
            // 
            // txtContainerName
            // 
            this.txtContainerName.AnimateReadOnly = false;
            this.txtContainerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContainerName.Depth = 0;
            this.txtContainerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContainerName.LeadingIcon = null;
            this.txtContainerName.Location = new System.Drawing.Point(33, 44);
            this.txtContainerName.MaxLength = 50;
            this.txtContainerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContainerName.Multiline = false;
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(737, 50);
            this.txtContainerName.TabIndex = 1;
            this.txtContainerName.Text = "";
            this.txtContainerName.TrailingIcon = null;
            // 
            // lblContainerImage
            // 
            this.lblContainerImage.AutoSize = true;
            this.lblContainerImage.Depth = 0;
            this.lblContainerImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContainerImage.Location = new System.Drawing.Point(30, 119);
            this.lblContainerImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContainerImage.Name = "lblContainerImage";
            this.lblContainerImage.Size = new System.Drawing.Size(113, 19);
            this.lblContainerImage.TabIndex = 2;
            this.lblContainerImage.Text = "Image Name/ID";
            // 
            // txtContainerImage
            // 
            this.txtContainerImage.AnimateReadOnly = false;
            this.txtContainerImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContainerImage.Depth = 0;
            this.txtContainerImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContainerImage.LeadingIcon = null;
            this.txtContainerImage.Location = new System.Drawing.Point(33, 141);
            this.txtContainerImage.MaxLength = 50;
            this.txtContainerImage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContainerImage.Multiline = false;
            this.txtContainerImage.Name = "txtContainerImage";
            this.txtContainerImage.Size = new System.Drawing.Size(737, 50);
            this.txtContainerImage.TabIndex = 3;
            this.txtContainerImage.Text = "";
            this.txtContainerImage.TrailingIcon = null;
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateContainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateContainer.Depth = 0;
            this.btnCreateContainer.HighEmphasis = true;
            this.btnCreateContainer.Icon = null;
            this.btnCreateContainer.Location = new System.Drawing.Point(33, 295);
            this.btnCreateContainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateContainer.Size = new System.Drawing.Size(158, 36);
            this.btnCreateContainer.TabIndex = 4;
            this.btnCreateContainer.Text = "Create Container";
            this.btnCreateContainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateContainer.UseAccentColor = false;
            this.btnCreateContainer.UseVisualStyleBackColor = true;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // ContainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.containersTabControl);
            this.Controls.Add(this.containersTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContainersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.White;
            this.containersTabControl.ResumeLayout(false);
            this.containersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containersGridView)).EndInit();
            this.createContainerTabPage.ResumeLayout(false);
            this.createContainerTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector containersTabSelector;
        private MaterialSkin.Controls.MaterialTabControl containersTabControl;
        private System.Windows.Forms.TabPage containersTabPage;
        private System.Windows.Forms.TabPage createContainerTabPage;
        private System.Windows.Forms.DataGridView containersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStateCollumn;
        private System.Windows.Forms.DataGridViewImageColumn editCollumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteCollumn;
        private MaterialSkin.Controls.MaterialTextBox txtContainerImage;
        private MaterialSkin.Controls.MaterialLabel lblContainerImage;
        private MaterialSkin.Controls.MaterialTextBox txtContainerName;
        private MaterialSkin.Controls.MaterialLabel lblContainerName;
        private MaterialSkin.Controls.MaterialButton btnCreateContainer;
    }
}