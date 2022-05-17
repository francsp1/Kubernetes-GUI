
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
            this.createPodTab = new System.Windows.Forms.TabPage();
            this.editPodTab = new System.Windows.Forms.TabPage();
            this.collumnEditPod = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnDeletePod = new System.Windows.Forms.DataGridViewImageColumn();
            this.podsTabControl.SuspendLayout();
            this.podsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podsDataGridView)).BeginInit();
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
            // createPodTab
            // 
            this.createPodTab.BackColor = System.Drawing.Color.White;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector podsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl podsTabControl;
        private System.Windows.Forms.TabPage podsTab;
        private System.Windows.Forms.DataGridView podsDataGridView;
        private System.Windows.Forms.TabPage createPodTab;
        private System.Windows.Forms.TabPage editPodTab;
        private System.Windows.Forms.DataGridViewImageColumn collumnEditPod;
        private System.Windows.Forms.DataGridViewImageColumn columnDeletePod;
    }
}