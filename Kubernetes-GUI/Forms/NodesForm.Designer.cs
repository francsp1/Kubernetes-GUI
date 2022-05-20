
namespace Kubernetes_GUI.Forms
{
    partial class NodesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodesForm));
            this.instancesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.instancesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nodesGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuLimitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryLimColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.instancesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // instancesTabSelector
            // 
            this.instancesTabSelector.BackColor = System.Drawing.Color.White;
            this.instancesTabSelector.BaseTabControl = this.instancesTabControl;
            this.instancesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.instancesTabSelector.Depth = 0;
            this.instancesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.instancesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.instancesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.instancesTabSelector.Margin = new System.Windows.Forms.Padding(2);
            this.instancesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabSelector.Name = "instancesTabSelector";
            this.instancesTabSelector.Size = new System.Drawing.Size(1139, 39);
            this.instancesTabSelector.TabIndex = 0;
            this.instancesTabSelector.Text = "materialTabSelector1";
            // 
            // instancesTabControl
            // 
            this.instancesTabControl.Controls.Add(this.tabPage1);
            this.instancesTabControl.Controls.Add(this.tabPage2);
            this.instancesTabControl.Depth = 0;
            this.instancesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesTabControl.Location = new System.Drawing.Point(0, 39);
            this.instancesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabControl.Multiline = true;
            this.instancesTabControl.Name = "instancesTabControl";
            this.instancesTabControl.SelectedIndex = 0;
            this.instancesTabControl.Size = new System.Drawing.Size(1139, 543);
            this.instancesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nodesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nodes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nodesGridView
            // 
            this.nodesGridView.AllowUserToAddRows = false;
            this.nodesGridView.AllowUserToDeleteRows = false;
            this.nodesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nodesGridView.BackgroundColor = System.Drawing.Color.White;
            this.nodesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nodesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.LabelColumn,
            this.readyColumn,
            this.cpuColumn,
            this.cpuLimitsColumn,
            this.memoryColumn,
            this.memoryLimColumn,
            this.podsColumn,
            this.createdColumn,
            this.editColumn,
            this.deleteColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.nodesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodesGridView.GridColor = System.Drawing.Color.White;
            this.nodesGridView.Location = new System.Drawing.Point(3, 3);
            this.nodesGridView.Name = "nodesGridView";
            this.nodesGridView.ReadOnly = true;
            this.nodesGridView.RowHeadersWidth = 51;
            this.nodesGridView.RowTemplate.Height = 60;
            this.nodesGridView.Size = new System.Drawing.Size(1125, 511);
            this.nodesGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cretate Nodes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.FillWeight = 58.25241F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // LabelColumn
            // 
            this.LabelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LabelColumn.FillWeight = 58.25241F;
            this.LabelColumn.HeaderText = "Label";
            this.LabelColumn.MinimumWidth = 6;
            this.LabelColumn.Name = "LabelColumn";
            this.LabelColumn.ReadOnly = true;
            this.LabelColumn.Width = 58;
            // 
            // readyColumn
            // 
            this.readyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.readyColumn.FillWeight = 475.7282F;
            this.readyColumn.HeaderText = "Ready";
            this.readyColumn.MinimumWidth = 6;
            this.readyColumn.Name = "readyColumn";
            this.readyColumn.ReadOnly = true;
            this.readyColumn.Width = 63;
            // 
            // cpuColumn
            // 
            this.cpuColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpuColumn.FillWeight = 58.25241F;
            this.cpuColumn.HeaderText = "CPU Requests";
            this.cpuColumn.MinimumWidth = 6;
            this.cpuColumn.Name = "cpuColumn";
            this.cpuColumn.ReadOnly = true;
            // 
            // cpuLimitsColumn
            // 
            this.cpuLimitsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpuLimitsColumn.FillWeight = 58.25241F;
            this.cpuLimitsColumn.HeaderText = "CPU Limits";
            this.cpuLimitsColumn.MinimumWidth = 6;
            this.cpuLimitsColumn.Name = "cpuLimitsColumn";
            this.cpuLimitsColumn.ReadOnly = true;
            // 
            // memoryColumn
            // 
            this.memoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memoryColumn.FillWeight = 58.25241F;
            this.memoryColumn.HeaderText = "Memory Request";
            this.memoryColumn.MinimumWidth = 6;
            this.memoryColumn.Name = "memoryColumn";
            this.memoryColumn.ReadOnly = true;
            // 
            // memoryLimColumn
            // 
            this.memoryLimColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memoryLimColumn.FillWeight = 58.25241F;
            this.memoryLimColumn.HeaderText = "Memory Limit";
            this.memoryLimColumn.MinimumWidth = 6;
            this.memoryLimColumn.Name = "memoryLimColumn";
            this.memoryLimColumn.ReadOnly = true;
            // 
            // podsColumn
            // 
            this.podsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.podsColumn.FillWeight = 58.25241F;
            this.podsColumn.HeaderText = "Pods";
            this.podsColumn.MinimumWidth = 6;
            this.podsColumn.Name = "podsColumn";
            this.podsColumn.ReadOnly = true;
            // 
            // createdColumn
            // 
            this.createdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdColumn.FillWeight = 58.25241F;
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.MinimumWidth = 6;
            this.createdColumn.Name = "createdColumn";
            this.createdColumn.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editColumn.HeaderText = "Edit";
            this.editColumn.Image = ((System.Drawing.Image)(resources.GetObject("editColumn.Image")));
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 50;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumn.Image")));
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 50;
            // 
            // NodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 582);
            this.ControlBox = false;
            this.Controls.Add(this.instancesTabControl);
            this.Controls.Add(this.instancesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NodesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Instances";
            this.TransparencyKey = System.Drawing.Color.White;
            this.instancesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nodesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector instancesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl instancesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView nodesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuLimitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryLimColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}