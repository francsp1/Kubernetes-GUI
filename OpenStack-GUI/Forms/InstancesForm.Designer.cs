
namespace OpenStack_GUI.Forms
{
    partial class InstancesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstancesForm));
            this.instancesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.instancesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.instancesGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.instancesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instancesGridView)).BeginInit();
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
            this.instancesTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instancesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabSelector.Name = "instancesTabSelector";
            this.instancesTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.instancesTabSelector.TabIndex = 0;
            this.instancesTabSelector.Text = "materialTabSelector1";
            // 
            // instancesTabControl
            // 
            this.instancesTabControl.Controls.Add(this.tabPage1);
            this.instancesTabControl.Controls.Add(this.tabPage2);
            this.instancesTabControl.Depth = 0;
            this.instancesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesTabControl.Location = new System.Drawing.Point(0, 48);
            this.instancesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.instancesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabControl.Multiline = true;
            this.instancesTabControl.Name = "instancesTabControl";
            this.instancesTabControl.SelectedIndex = 0;
            this.instancesTabControl.Size = new System.Drawing.Size(1519, 668);
            this.instancesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.instancesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1511, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // instancesGridView
            // 
            this.instancesGridView.AllowUserToAddRows = false;
            this.instancesGridView.AllowUserToDeleteRows = false;
            this.instancesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instancesGridView.BackgroundColor = System.Drawing.Color.White;
            this.instancesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instancesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instancesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.imgNameColumn,
            this.ipColumn,
            this.flavorColumn,
            this.keyColumn,
            this.statusColumn,
            this.zoneColumn,
            this.taskColumn,
            this.powerColumn,
            this.ageColumn,
            this.editColumn,
            this.deleteColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instancesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.instancesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesGridView.GridColor = System.Drawing.Color.White;
            this.instancesGridView.Location = new System.Drawing.Point(4, 4);
            this.instancesGridView.Margin = new System.Windows.Forms.Padding(4);
            this.instancesGridView.Name = "instancesGridView";
            this.instancesGridView.ReadOnly = true;
            this.instancesGridView.RowHeadersWidth = 51;
            this.instancesGridView.RowTemplate.Height = 60;
            this.instancesGridView.Size = new System.Drawing.Size(1503, 631);
            this.instancesGridView.TabIndex = 0;
            this.instancesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instancesGridView_CellClick);
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
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NameColumn.FillWeight = 58.25241F;
            this.NameColumn.HeaderText = "Instance Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 120;
            // 
            // imgNameColumn
            // 
            this.imgNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.imgNameColumn.FillWeight = 58.25241F;
            this.imgNameColumn.HeaderText = "Image Name";
            this.imgNameColumn.MinimumWidth = 6;
            this.imgNameColumn.Name = "imgNameColumn";
            this.imgNameColumn.ReadOnly = true;
            this.imgNameColumn.Width = 107;
            // 
            // ipColumn
            // 
            this.ipColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ipColumn.FillWeight = 475.7282F;
            this.ipColumn.HeaderText = "IP Address";
            this.ipColumn.MinimumWidth = 6;
            this.ipColumn.Name = "ipColumn";
            this.ipColumn.ReadOnly = true;
            this.ipColumn.Width = 250;
            // 
            // flavorColumn
            // 
            this.flavorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flavorColumn.FillWeight = 58.25241F;
            this.flavorColumn.HeaderText = "Flavor";
            this.flavorColumn.MinimumWidth = 6;
            this.flavorColumn.Name = "flavorColumn";
            this.flavorColumn.ReadOnly = true;
            // 
            // keyColumn
            // 
            this.keyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keyColumn.FillWeight = 58.25241F;
            this.keyColumn.HeaderText = "Key Pair";
            this.keyColumn.MinimumWidth = 6;
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusColumn.FillWeight = 58.25241F;
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // zoneColumn
            // 
            this.zoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zoneColumn.FillWeight = 58.25241F;
            this.zoneColumn.HeaderText = "Availability Zone";
            this.zoneColumn.MinimumWidth = 6;
            this.zoneColumn.Name = "zoneColumn";
            this.zoneColumn.ReadOnly = true;
            // 
            // taskColumn
            // 
            this.taskColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskColumn.FillWeight = 58.25241F;
            this.taskColumn.HeaderText = "Task";
            this.taskColumn.MinimumWidth = 6;
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            // 
            // powerColumn
            // 
            this.powerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.powerColumn.FillWeight = 58.25241F;
            this.powerColumn.HeaderText = "Power State";
            this.powerColumn.MinimumWidth = 6;
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.ReadOnly = true;
            // 
            // ageColumn
            // 
            this.ageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ageColumn.FillWeight = 58.25241F;
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.MinimumWidth = 6;
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1511, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cretate Instances";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InstancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.instancesTabControl);
            this.Controls.Add(this.instancesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstancesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Instances";
            this.TransparencyKey = System.Drawing.Color.White;
            this.instancesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instancesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector instancesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl instancesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView instancesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}