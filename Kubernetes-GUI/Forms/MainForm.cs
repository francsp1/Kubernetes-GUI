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
            MessageBox.Show("Implementar nodes", "Implementar nodes", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void fillNamespacesTab()
        {
            MessageBox.Show("Implementar namespaces", "Implementar namespaces", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            MessageBox.Show("Implementar deploys", "Implementar deploys", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void fillServicesTab()
        {
            MessageBox.Show("Implementar services", "Implementar services", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}
