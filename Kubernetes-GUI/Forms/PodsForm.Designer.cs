
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
            this.editPodTab = new System.Windows.Forms.TabPage();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
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
            this.podsDataGridView.GridColor = System.Drawing.Color.White;
            this.podsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.podsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podsDataGridView.Name = "podsDataGridView";
            this.podsDataGridView.ReadOnly = true;
            this.podsDataGridView.RowHeadersWidth = 51;
            this.podsDataGridView.RowTemplate.Height = 24;
            this.podsDataGridView.Size = new System.Drawing.Size(1505, 635);
            this.podsDataGridView.TabIndex = 1;
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
            this.createPodTab.Controls.Add(this.materialCheckedListBox1);
            this.createPodTab.Location = new System.Drawing.Point(4, 25);
            this.createPodTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPodTab.Name = "createPodTab";
            this.createPodTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPodTab.Size = new System.Drawing.Size(1511, 639);
            this.createPodTab.TabIndex = 1;
            this.createPodTab.Text = "Create Pod";
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
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(511, 227);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(200, 100);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 5;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector podsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl podsTabControl;
        private System.Windows.Forms.TabPage podsTab;
        private System.Windows.Forms.DataGridView podsDataGridView;
        private System.Windows.Forms.TabPage createPodTab;
        private System.Windows.Forms.TabPage editPodTab;
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
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
    }
}