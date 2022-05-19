
namespace Kubernetes_GUI.Forms
{
    partial class NamespacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamespacesForm));
            this.namespacesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.namespacesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.namespacesTab = new System.Windows.Forms.TabPage();
            this.namespacesDataGridView = new System.Windows.Forms.DataGridView();
            this.createNamespaceTab = new System.Windows.Forms.TabPage();
            this.editNamespacesTab = new System.Windows.Forms.TabPage();
            this.dataGridViewImageEditNamepace = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageDeleteNamespace = new System.Windows.Forms.DataGridViewImageColumn();
            this.collumnNamespaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnNamespaceLabels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnNamespacePhase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnNamespaceCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnNamespaceEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.collumnNamespaceDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.namespacesTabControl.SuspendLayout();
            this.namespacesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namespacesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // namespacesTabSelector
            // 
            this.namespacesTabSelector.BaseTabControl = this.namespacesTabControl;
            this.namespacesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.namespacesTabSelector.Depth = 0;
            this.namespacesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.namespacesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.namespacesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.namespacesTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namespacesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.namespacesTabSelector.Name = "namespacesTabSelector";
            this.namespacesTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.namespacesTabSelector.TabIndex = 0;
            // 
            // namespacesTabControl
            // 
            this.namespacesTabControl.Controls.Add(this.namespacesTab);
            this.namespacesTabControl.Controls.Add(this.createNamespaceTab);
            this.namespacesTabControl.Controls.Add(this.editNamespacesTab);
            this.namespacesTabControl.Depth = 0;
            this.namespacesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namespacesTabControl.Location = new System.Drawing.Point(0, 48);
            this.namespacesTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namespacesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.namespacesTabControl.Multiline = true;
            this.namespacesTabControl.Name = "namespacesTabControl";
            this.namespacesTabControl.SelectedIndex = 0;
            this.namespacesTabControl.Size = new System.Drawing.Size(1519, 668);
            this.namespacesTabControl.TabIndex = 1;
            // 
            // namespacesTab
            // 
            this.namespacesTab.Controls.Add(this.namespacesDataGridView);
            this.namespacesTab.Location = new System.Drawing.Point(4, 25);
            this.namespacesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namespacesTab.Name = "namespacesTab";
            this.namespacesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namespacesTab.Size = new System.Drawing.Size(1511, 639);
            this.namespacesTab.TabIndex = 0;
            this.namespacesTab.Text = "Namespaces";
            this.namespacesTab.UseVisualStyleBackColor = true;
            // 
            // namespacesDataGridView
            // 
            this.namespacesDataGridView.AllowUserToAddRows = false;
            this.namespacesDataGridView.AllowUserToDeleteRows = false;
            this.namespacesDataGridView.AllowUserToOrderColumns = true;
            this.namespacesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.namespacesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.namespacesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namespacesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namespacesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collumnNamespaceName,
            this.collumnNamespaceLabels,
            this.collumnNamespacePhase,
            this.collumnNamespaceCreated,
            this.collumnNamespaceEdit,
            this.collumnNamespaceDelete});
            this.namespacesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namespacesDataGridView.GridColor = System.Drawing.Color.White;
            this.namespacesDataGridView.Location = new System.Drawing.Point(3, 2);
            this.namespacesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.namespacesDataGridView.Name = "namespacesDataGridView";
            this.namespacesDataGridView.ReadOnly = true;
            this.namespacesDataGridView.RowHeadersWidth = 51;
            this.namespacesDataGridView.Size = new System.Drawing.Size(1505, 635);
            this.namespacesDataGridView.TabIndex = 0;
            this.namespacesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.namespacesDataGridView_CellContentClick);
            // 
            // createNamespaceTab
            // 
            this.createNamespaceTab.BackColor = System.Drawing.Color.White;
            this.createNamespaceTab.Location = new System.Drawing.Point(4, 25);
            this.createNamespaceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNamespaceTab.Name = "createNamespaceTab";
            this.createNamespaceTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNamespaceTab.Size = new System.Drawing.Size(1511, 639);
            this.createNamespaceTab.TabIndex = 1;
            this.createNamespaceTab.Text = "Create Namespace";
            // 
            // editNamespaceStab
            // 
            this.editNamespacesTab.BackColor = System.Drawing.Color.White;
            this.editNamespacesTab.Location = new System.Drawing.Point(4, 25);
            this.editNamespacesTab.Margin = new System.Windows.Forms.Padding(4);
            this.editNamespacesTab.Name = "editNamespaceStab";
            this.editNamespacesTab.Padding = new System.Windows.Forms.Padding(4);
            this.editNamespacesTab.Size = new System.Drawing.Size(1511, 639);
            this.editNamespacesTab.TabIndex = 2;
            this.editNamespacesTab.Text = "Edit Namespace";
            // 
            // dataGridViewImageEditNamepace
            // 
            this.dataGridViewImageEditNamepace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageEditNamepace.HeaderText = "Edit";
            this.dataGridViewImageEditNamepace.Image = global::Kubernetes_GUI.Properties.Resources.edit_button;
            this.dataGridViewImageEditNamepace.MinimumWidth = 6;
            this.dataGridViewImageEditNamepace.Name = "dataGridViewImageEditNamepace";
            this.dataGridViewImageEditNamepace.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageEditNamepace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageEditNamepace.Width = 125;
            // 
            // dataGridViewImageDeleteNamespace
            // 
            this.dataGridViewImageDeleteNamespace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageDeleteNamespace.HeaderText = "Delete";
            this.dataGridViewImageDeleteNamespace.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageDeleteNamespace.Image")));
            this.dataGridViewImageDeleteNamespace.MinimumWidth = 6;
            this.dataGridViewImageDeleteNamespace.Name = "dataGridViewImageDeleteNamespace";
            this.dataGridViewImageDeleteNamespace.Width = 125;
            // 
            // collumnNamespaceName
            // 
            this.collumnNamespaceName.HeaderText = "Name";
            this.collumnNamespaceName.MinimumWidth = 6;
            this.collumnNamespaceName.Name = "collumnNamespaceName";
            this.collumnNamespaceName.ReadOnly = true;
            // 
            // collumnNamespaceLabels
            // 
            this.collumnNamespaceLabels.HeaderText = "Labels";
            this.collumnNamespaceLabels.MinimumWidth = 6;
            this.collumnNamespaceLabels.Name = "collumnNamespaceLabels";
            this.collumnNamespaceLabels.ReadOnly = true;
            // 
            // collumnNamespacePhase
            // 
            this.collumnNamespacePhase.HeaderText = "Phase";
            this.collumnNamespacePhase.MinimumWidth = 6;
            this.collumnNamespacePhase.Name = "collumnNamespacePhase";
            this.collumnNamespacePhase.ReadOnly = true;
            // 
            // collumnNamespaceCreated
            // 
            this.collumnNamespaceCreated.HeaderText = "Created";
            this.collumnNamespaceCreated.MinimumWidth = 6;
            this.collumnNamespaceCreated.Name = "collumnNamespaceCreated";
            this.collumnNamespaceCreated.ReadOnly = true;
            // 
            // collumnNamespaceEdit
            // 
            this.collumnNamespaceEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.collumnNamespaceEdit.HeaderText = "Edit";
            this.collumnNamespaceEdit.Image = global::Kubernetes_GUI.Properties.Resources.edit_button;
            this.collumnNamespaceEdit.MinimumWidth = 6;
            this.collumnNamespaceEdit.Name = "collumnNamespaceEdit";
            this.collumnNamespaceEdit.ReadOnly = true;
            this.collumnNamespaceEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.collumnNamespaceEdit.Width = 38;
            // 
            // collumnNamespaceDelete
            // 
            this.collumnNamespaceDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.collumnNamespaceDelete.HeaderText = "Delete";
            this.collumnNamespaceDelete.Image = global::Kubernetes_GUI.Properties.Resources.remove__1_;
            this.collumnNamespaceDelete.MinimumWidth = 6;
            this.collumnNamespaceDelete.Name = "collumnNamespaceDelete";
            this.collumnNamespaceDelete.ReadOnly = true;
            this.collumnNamespaceDelete.Width = 55;
            // 
            // NamespacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.namespacesTabControl);
            this.Controls.Add(this.namespacesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NamespacesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Volumes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.namespacesTabControl.ResumeLayout(false);
            this.namespacesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namespacesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector namespacesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl namespacesTabControl;
        private System.Windows.Forms.TabPage namespacesTab;
        private System.Windows.Forms.TabPage createNamespaceTab;
        private System.Windows.Forms.DataGridView namespacesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageEditNamepace;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageDeleteNamespace;
        private System.Windows.Forms.TabPage editNamespacesTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnNamespaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnNamespaceLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnNamespacePhase;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnNamespaceCreated;
        private System.Windows.Forms.DataGridViewImageColumn collumnNamespaceEdit;
        private System.Windows.Forms.DataGridViewImageColumn collumnNamespaceDelete;
    }
}