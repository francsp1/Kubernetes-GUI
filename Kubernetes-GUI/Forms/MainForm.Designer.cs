
namespace Kubernetes_GUI.Forms
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
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.nodesTab = new System.Windows.Forms.TabPage();
            this.namespacesTab = new System.Windows.Forms.TabPage();
            this.namespacesPanel = new System.Windows.Forms.Panel();
            this.podsTab = new System.Windows.Forms.TabPage();
            this.podsPanel = new System.Windows.Forms.Panel();
            this.deploymentsTab = new System.Windows.Forms.TabPage();
            this.deploymentsPanel = new System.Windows.Forms.Panel();
            this.servicesTab = new System.Windows.Forms.TabPage();
            this.servicesPanel = new System.Windows.Forms.Panel();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.nodePanel = new System.Windows.Forms.Panel();
            this.mainTabControl.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.nodesTab.SuspendLayout();
            this.namespacesTab.SuspendLayout();
            this.podsTab.SuspendLayout();
            this.deploymentsTab.SuspendLayout();
            this.servicesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.dashboardTab);
            this.mainTabControl.Controls.Add(this.nodesTab);
            this.mainTabControl.Controls.Add(this.namespacesTab);
            this.mainTabControl.Controls.Add(this.podsTab);
            this.mainTabControl.Controls.Add(this.deploymentsTab);
            this.mainTabControl.Controls.Add(this.servicesTab);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabControlImageList;
            this.mainTabControl.Location = new System.Drawing.Point(2, 52);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1196, 677);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.White;
            this.dashboardTab.Controls.Add(this.dashboardPanel);
            this.dashboardTab.ImageKey = "dashboard (1).png";
            this.dashboardTab.Location = new System.Drawing.Point(4, 39);
            this.dashboardTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardTab.Size = new System.Drawing.Size(1188, 634);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(2, 2);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1184, 630);
            this.dashboardPanel.TabIndex = 0;
            // 
            // nodesTab
            // 
            this.nodesTab.Controls.Add(this.nodePanel);
            this.nodesTab.Location = new System.Drawing.Point(4, 39);
            this.nodesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nodesTab.Name = "nodesTab";
            this.nodesTab.Size = new System.Drawing.Size(1188, 634);
            this.nodesTab.TabIndex = 5;
            this.nodesTab.Text = "Nodes";
            this.nodesTab.UseVisualStyleBackColor = true;
            // 
            // namespacesTab
            // 
            this.namespacesTab.BackColor = System.Drawing.Color.White;
            this.namespacesTab.Controls.Add(this.namespacesPanel);
            this.namespacesTab.Location = new System.Drawing.Point(4, 39);
            this.namespacesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namespacesTab.Name = "namespacesTab";
            this.namespacesTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namespacesTab.Size = new System.Drawing.Size(1188, 634);
            this.namespacesTab.TabIndex = 1;
            this.namespacesTab.Text = "Namespaces";
            // 
            // namespacesPanel
            // 
            this.namespacesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namespacesPanel.Location = new System.Drawing.Point(2, 2);
            this.namespacesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namespacesPanel.Name = "namespacesPanel";
            this.namespacesPanel.Size = new System.Drawing.Size(1184, 630);
            this.namespacesPanel.TabIndex = 0;
            // 
            // podsTab
            // 
            this.podsTab.BackColor = System.Drawing.Color.White;
            this.podsTab.Controls.Add(this.podsPanel);
            this.podsTab.Location = new System.Drawing.Point(4, 39);
            this.podsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.podsTab.Name = "podsTab";
            this.podsTab.Size = new System.Drawing.Size(1188, 634);
            this.podsTab.TabIndex = 2;
            this.podsTab.Text = "Pods";
            // 
            // podsPanel
            // 
            this.podsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podsPanel.Location = new System.Drawing.Point(0, 0);
            this.podsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.podsPanel.Name = "podsPanel";
            this.podsPanel.Size = new System.Drawing.Size(1188, 634);
            this.podsPanel.TabIndex = 0;
            // 
            // deploymentsTab
            // 
            this.deploymentsTab.BackColor = System.Drawing.Color.White;
            this.deploymentsTab.Controls.Add(this.deploymentsPanel);
            this.deploymentsTab.Location = new System.Drawing.Point(4, 39);
            this.deploymentsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deploymentsTab.Name = "deploymentsTab";
            this.deploymentsTab.Size = new System.Drawing.Size(1188, 634);
            this.deploymentsTab.TabIndex = 3;
            this.deploymentsTab.Text = "Deployments";
            // 
            // deploymentsPanel
            // 
            this.deploymentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deploymentsPanel.Location = new System.Drawing.Point(0, 0);
            this.deploymentsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deploymentsPanel.Name = "deploymentsPanel";
            this.deploymentsPanel.Size = new System.Drawing.Size(1188, 634);
            this.deploymentsPanel.TabIndex = 0;
            // 
            // servicesTab
            // 
            this.servicesTab.BackColor = System.Drawing.Color.White;
            this.servicesTab.Controls.Add(this.servicesPanel);
            this.servicesTab.Location = new System.Drawing.Point(4, 39);
            this.servicesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicesTab.Name = "servicesTab";
            this.servicesTab.Size = new System.Drawing.Size(1188, 634);
            this.servicesTab.TabIndex = 4;
            this.servicesTab.Text = "Services";
            // 
            // servicesPanel
            // 
            this.servicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesPanel.Location = new System.Drawing.Point(0, 0);
            this.servicesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Size = new System.Drawing.Size(1188, 634);
            this.servicesPanel.TabIndex = 0;
            // 
            // mainTabControlImageList
            // 
            this.mainTabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabControlImageList.ImageStream")));
            this.mainTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainTabControlImageList.Images.SetKeyName(0, "dashboard.png");
            this.mainTabControlImageList.Images.SetKeyName(1, "dashboard (1).png");
            // 
            // nodePanel
            // 
            this.nodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodePanel.Location = new System.Drawing.Point(0, 0);
            this.nodePanel.Name = "nodePanel";
            this.nodePanel.Size = new System.Drawing.Size(1188, 634);
            this.nodePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.mainTabControl);
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.nodesTab.ResumeLayout(false);
            this.namespacesTab.ResumeLayout(false);
            this.podsTab.ResumeLayout(false);
            this.deploymentsTab.ResumeLayout(false);
            this.servicesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage namespacesTab;
        private System.Windows.Forms.TabPage podsTab;
        private System.Windows.Forms.TabPage deploymentsTab;
        private System.Windows.Forms.TabPage servicesTab;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel namespacesPanel;
        private System.Windows.Forms.Panel podsPanel;
        private System.Windows.Forms.Panel deploymentsPanel;
        private System.Windows.Forms.Panel servicesPanel;
        private System.Windows.Forms.ImageList mainTabControlImageList;
        private System.Windows.Forms.TabPage nodesTab;
        private System.Windows.Forms.Panel nodePanel;
    }
}