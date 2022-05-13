
namespace OpenStack_GUI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ImageServiceTab = new System.Windows.Forms.TabPage();
            this.panelImageService = new System.Windows.Forms.Panel();
            this.volumesTab = new System.Windows.Forms.TabPage();
            this.panelVolumes = new System.Windows.Forms.Panel();
            this.instanceTab = new System.Windows.Forms.TabPage();
            this.panelInstances = new System.Windows.Forms.Panel();
            this.KeyPairtabPage = new System.Windows.Forms.TabPage();
            this.panelKeyPair = new System.Windows.Forms.Panel();
            this.containersTab = new System.Windows.Forms.TabPage();
            this.panelContainers = new System.Windows.Forms.Panel();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.labelProjects = new MaterialSkin.Controls.MaterialLabel();
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.volumesTab.SuspendLayout();
            this.instanceTab.SuspendLayout();
            this.KeyPairtabPage.SuspendLayout();
            this.containersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ImageServiceTab);
            this.mainTabControl.Controls.Add(this.volumesTab);
            this.mainTabControl.Controls.Add(this.instanceTab);
            this.mainTabControl.Controls.Add(this.KeyPairtabPage);
            this.mainTabControl.Controls.Add(this.containersTab);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabControlImageList;
            this.mainTabControl.Location = new System.Drawing.Point(3, 64);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1550, 818);
            this.mainTabControl.TabIndex = 0;
            // 
            // ImageServiceTab
            // 
            this.ImageServiceTab.BackColor = System.Drawing.Color.White;
            this.ImageServiceTab.Controls.Add(this.panelImageService);
            this.ImageServiceTab.ImageKey = "image.png";
            this.ImageServiceTab.Location = new System.Drawing.Point(4, 39);
            this.ImageServiceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageServiceTab.Name = "ImageServiceTab";
            this.ImageServiceTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageServiceTab.Size = new System.Drawing.Size(1542, 775);
            this.ImageServiceTab.TabIndex = 0;
            this.ImageServiceTab.Text = "Image Service";
            // 
            // panelImageService
            // 
            this.panelImageService.BackColor = System.Drawing.Color.White;
            this.panelImageService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageService.Location = new System.Drawing.Point(3, 2);
            this.panelImageService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImageService.Name = "panelImageService";
            this.panelImageService.Size = new System.Drawing.Size(1536, 771);
            this.panelImageService.TabIndex = 0;
            // 
            // volumesTab
            // 
            this.volumesTab.BackColor = System.Drawing.Color.White;
            this.volumesTab.Controls.Add(this.panelVolumes);
            this.volumesTab.ImageKey = "hard-drive.png";
            this.volumesTab.Location = new System.Drawing.Point(4, 39);
            this.volumesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumesTab.Name = "volumesTab";
            this.volumesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumesTab.Size = new System.Drawing.Size(1542, 775);
            this.volumesTab.TabIndex = 1;
            this.volumesTab.Text = "Volumes";
            // 
            // panelVolumes
            // 
            this.panelVolumes.BackColor = System.Drawing.Color.White;
            this.panelVolumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVolumes.Location = new System.Drawing.Point(3, 2);
            this.panelVolumes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVolumes.Name = "panelVolumes";
            this.panelVolumes.Size = new System.Drawing.Size(1536, 771);
            this.panelVolumes.TabIndex = 0;
            // 
            // instanceTab
            // 
            this.instanceTab.BackColor = System.Drawing.Color.White;
            this.instanceTab.Controls.Add(this.panelInstances);
            this.instanceTab.ImageKey = "data-server.png";
            this.instanceTab.Location = new System.Drawing.Point(4, 39);
            this.instanceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instanceTab.Name = "instanceTab";
            this.instanceTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instanceTab.Size = new System.Drawing.Size(1542, 775);
            this.instanceTab.TabIndex = 2;
            this.instanceTab.Text = "Instances";
            // 
            // panelInstances
            // 
            this.panelInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInstances.Location = new System.Drawing.Point(3, 2);
            this.panelInstances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInstances.Name = "panelInstances";
            this.panelInstances.Size = new System.Drawing.Size(1536, 771);
            this.panelInstances.TabIndex = 0;
            // 
            // KeyPairtabPage
            // 
            this.KeyPairtabPage.BackColor = System.Drawing.Color.White;
            this.KeyPairtabPage.Controls.Add(this.panelKeyPair);
            this.KeyPairtabPage.ImageKey = "key (1).png";
            this.KeyPairtabPage.Location = new System.Drawing.Point(4, 39);
            this.KeyPairtabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KeyPairtabPage.Name = "KeyPairtabPage";
            this.KeyPairtabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KeyPairtabPage.Size = new System.Drawing.Size(1542, 775);
            this.KeyPairtabPage.TabIndex = 4;
            this.KeyPairtabPage.Text = "Key Pair";
            // 
            // panelKeyPair
            // 
            this.panelKeyPair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKeyPair.Location = new System.Drawing.Point(3, 2);
            this.panelKeyPair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelKeyPair.Name = "panelKeyPair";
            this.panelKeyPair.Size = new System.Drawing.Size(1536, 771);
            this.panelKeyPair.TabIndex = 0;
            // 
            // containersTab
            // 
            this.containersTab.BackColor = System.Drawing.Color.White;
            this.containersTab.Controls.Add(this.panelContainers);
            this.containersTab.ImageKey = "docker.png";
            this.containersTab.Location = new System.Drawing.Point(4, 39);
            this.containersTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTab.Name = "containersTab";
            this.containersTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containersTab.Size = new System.Drawing.Size(1542, 775);
            this.containersTab.TabIndex = 3;
            this.containersTab.Text = "Containers";
            // 
            // panelContainers
            // 
            this.panelContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainers.Location = new System.Drawing.Point(3, 2);
            this.panelContainers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainers.Name = "panelContainers";
            this.panelContainers.Size = new System.Drawing.Size(1536, 771);
            this.panelContainers.TabIndex = 0;
            // 
            // mainTabControlImageList
            // 
            this.mainTabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabControlImageList.ImageStream")));
            this.mainTabControlImageList.TransparentColor = System.Drawing.Color.White;
            this.mainTabControlImageList.Images.SetKeyName(0, "image.png");
            this.mainTabControlImageList.Images.SetKeyName(1, "database.png");
            this.mainTabControlImageList.Images.SetKeyName(2, "hard-drive.png");
            this.mainTabControlImageList.Images.SetKeyName(3, "data-server.png");
            this.mainTabControlImageList.Images.SetKeyName(4, "key (1).png");
            this.mainTabControlImageList.Images.SetKeyName(5, "docker.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(1045, 39);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(255, 24);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(1372, 16);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(78, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "logout";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.BackColor = System.Drawing.Color.Transparent;
            this.labelProjects.Depth = 0;
            this.labelProjects.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelProjects.ForeColor = System.Drawing.Color.White;
            this.labelProjects.Location = new System.Drawing.Point(865, 28);
            this.labelProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(62, 19);
            this.labelProjects.TabIndex = 0;
            this.labelProjects.Text = "Projects:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.labelProjects);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.ImageServiceTab.ResumeLayout(false);
            this.volumesTab.ResumeLayout(false);
            this.instanceTab.ResumeLayout(false);
            this.KeyPairtabPage.ResumeLayout(false);
            this.containersTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage ImageServiceTab;
        private System.Windows.Forms.TabPage volumesTab;
        private System.Windows.Forms.ImageList mainTabControlImageList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.Panel panelVolumes;
        private System.Windows.Forms.Panel panelImageService;
        private System.Windows.Forms.TabPage instanceTab;
        private System.Windows.Forms.Panel panelInstances;
        private System.Windows.Forms.TabPage containersTab;
        private System.Windows.Forms.Panel panelContainers;
        private System.Windows.Forms.TabPage KeyPairtabPage;
        private System.Windows.Forms.Panel panelKeyPair;
        private MaterialSkin.Controls.MaterialLabel labelProjects;
    }
}