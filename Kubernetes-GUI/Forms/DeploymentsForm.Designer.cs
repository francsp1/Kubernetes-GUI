
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
            this.deploymentsTabControl.SuspendLayout();
            this.deploymentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deploymentsDataGridView)).BeginInit();
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
            this.deploymentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.containersGridView_CellClick);
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
            this.createDeploymentTab.BackColor = System.Drawing.Color.White;
            this.createDeploymentTab.Location = new System.Drawing.Point(4, 25);
            this.createDeploymentTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDeploymentTab.Name = "createDeploymentTab";
            this.createDeploymentTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDeploymentTab.Size = new System.Drawing.Size(1511, 639);
            this.createDeploymentTab.TabIndex = 1;
            this.createDeploymentTab.Text = "Create deployments";
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
    }
}