using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes_GUI.Forms
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            fillDashboardTab();

            this.ShowDialog();

            
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == mainTabControl.TabPages["dashboardTab"])
            {
                fillDashboardTab();
            }

            if (mainTabControl.SelectedTab == mainTabControl.TabPages["nodesTab"])
            {
                fillNodesTab();
            }

            if (mainTabControl.SelectedTab == mainTabControl.TabPages["namespacesTab"])
            {
                fillNamespacesTab();
            }

            if (mainTabControl.SelectedTab == mainTabControl.TabPages["podsTab"])
            {
                fillPodsTab();
            }

            if (mainTabControl.SelectedTab == mainTabControl.TabPages["deploymentsTab"])
            {
                fillDeploymentsTab();
            }

            if (mainTabControl.SelectedTab == mainTabControl.TabPages["servicesTab"])
            {
                fillServicesTab();
            }


        }

        private void fillDashboardTab()
        {
            //MessageBox.Show("Implementar dashboard", "Implementar dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void fillNodesTab()
        {
            nodePanel.Controls.Clear();
            NodesForm nodesform = new NodesForm();
            nodesform.TopLevel = false;
            nodesform.AutoScroll = true;
            nodePanel.Controls.Add(nodesform);
            nodesform.Show();
            nodesform.Dock = DockStyle.Fill;
        }

        private void fillNamespacesTab()
        {
            namespacesPanel.Controls.Clear();
            NamespacesForm namespacesForm = new NamespacesForm();
            namespacesForm.TopLevel = false;
            namespacesForm.AutoScroll = true;
            namespacesPanel.Controls.Add(namespacesForm);
            namespacesForm.Show();
            namespacesForm.Dock = DockStyle.Fill;
        }

        private void fillPodsTab()
        {
            podsPanel.Controls.Clear();
            PodsForm podsForm = new PodsForm();
            podsForm.TopLevel = false;
            podsForm.AutoScroll = true;
            podsPanel.Controls.Add(podsForm);
            podsForm.Show();
            podsForm.Dock = DockStyle.Fill;
        }

        private void fillDeploymentsTab()
        {
            deploymentsPanel.Controls.Clear();
            DeploymentsForm deploymentsForm = new DeploymentsForm();
            deploymentsForm.TopLevel = false;
            deploymentsForm.AutoScroll = true;
            deploymentsPanel.Controls.Add(deploymentsForm);
            deploymentsForm.Show();
            deploymentsForm.Dock = DockStyle.Fill;

        }

        private void fillServicesTab()
        {
            servicesPanel.Controls.Clear();
            ServiceForm servicesForm = new ServiceForm();
            servicesForm.TopLevel = false;
            servicesForm.AutoScroll = true;
            servicesPanel.Controls.Add(servicesForm);
            servicesForm.Show();
            servicesForm.Dock = DockStyle.Fill;
        }


    }
}
