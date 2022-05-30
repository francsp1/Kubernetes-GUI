
namespace Kubernetes_GUI.Forms
{
    partial class DashboardForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesPodColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodePodsColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDepColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CountPodmaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountServicesmaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountDepmaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.imagesPodColumn1,
            this.nodePodsColumn1,
            this.statusColumn});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1519, 187);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // imagesPodColumn1
            // 
            this.imagesPodColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagesPodColumn1.HeaderText = "Images";
            this.imagesPodColumn1.MinimumWidth = 6;
            this.imagesPodColumn1.Name = "imagesPodColumn1";
            this.imagesPodColumn1.ReadOnly = true;
            // 
            // nodePodsColumn1
            // 
            this.nodePodsColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nodePodsColumn1.HeaderText = "Node";
            this.nodePodsColumn1.MinimumWidth = 6;
            this.nodePodsColumn1.Name = "nodePodsColumn1";
            this.nodePodsColumn1.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn1});
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(0, 281);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1519, 172);
            this.dataGridView2.TabIndex = 2;
            // 
            // nameColumn1
            // 
            this.nameColumn1.HeaderText = "Name";
            this.nameColumn1.MinimumWidth = 6;
            this.nameColumn1.Name = "nameColumn1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDepColumn1,
            this.imageColumn,
            this.podColumn});
            this.dataGridView3.GridColor = System.Drawing.Color.White;
            this.dataGridView3.Location = new System.Drawing.Point(0, 506);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1519, 183);
            this.dataGridView3.TabIndex = 3;
            // 
            // nameDepColumn1
            // 
            this.nameDepColumn1.HeaderText = "Name";
            this.nameDepColumn1.MinimumWidth = 6;
            this.nameDepColumn1.Name = "nameDepColumn1";
            // 
            // imageColumn
            // 
            this.imageColumn.HeaderText = "Image";
            this.imageColumn.MinimumWidth = 6;
            this.imageColumn.Name = "imageColumn";
            // 
            // podColumn
            // 
            this.podColumn.HeaderText = "Pods";
            this.podColumn.MinimumWidth = 6;
            this.podColumn.Name = "podColumn";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 11);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Total Pods: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 254);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Total Services: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 479);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(139, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Total Deployments:";
            // 
            // CountPodmaterialLabel
            // 
            this.CountPodmaterialLabel.AutoSize = true;
            this.CountPodmaterialLabel.Depth = 0;
            this.CountPodmaterialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountPodmaterialLabel.Location = new System.Drawing.Point(131, 11);
            this.CountPodmaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountPodmaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountPodmaterialLabel.Name = "CountPodmaterialLabel";
            this.CountPodmaterialLabel.Size = new System.Drawing.Size(1, 0);
            this.CountPodmaterialLabel.TabIndex = 7;
            // 
            // CountServicesmaterialLabel
            // 
            this.CountServicesmaterialLabel.AutoSize = true;
            this.CountServicesmaterialLabel.Depth = 0;
            this.CountServicesmaterialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountServicesmaterialLabel.Location = new System.Drawing.Point(156, 254);
            this.CountServicesmaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountServicesmaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountServicesmaterialLabel.Name = "CountServicesmaterialLabel";
            this.CountServicesmaterialLabel.Size = new System.Drawing.Size(1, 0);
            this.CountServicesmaterialLabel.TabIndex = 8;
            // 
            // CountDepmaterialLabel
            // 
            this.CountDepmaterialLabel.AutoSize = true;
            this.CountDepmaterialLabel.Depth = 0;
            this.CountDepmaterialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountDepmaterialLabel.Location = new System.Drawing.Point(209, 479);
            this.CountDepmaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountDepmaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountDepmaterialLabel.Name = "CountDepmaterialLabel";
            this.CountDepmaterialLabel.Size = new System.Drawing.Size(1, 0);
            this.CountDepmaterialLabel.TabIndex = 9;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.CountDepmaterialLabel);
            this.Controls.Add(this.CountServicesmaterialLabel);
            this.Controls.Add(this.CountPodmaterialLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagesPodColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodePodsColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podColumn;
        private MaterialSkin.Controls.MaterialLabel CountPodmaterialLabel;
        private MaterialSkin.Controls.MaterialLabel CountServicesmaterialLabel;
        private MaterialSkin.Controls.MaterialLabel CountDepmaterialLabel;
    }
}