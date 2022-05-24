using Newtonsoft.Json.Linq;
using Kubernetes_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes_GUI.Forms
{
    public partial class DeploymentsForm : Form
    {
        public DeploymentsForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

            fillDeploymentsDataGridView();

        }

        private void fillDeploymentsDataGridView()
        {
            deploymentsDataGridView.Rows.Clear();
            deploymentsDataGridView.Refresh(); ;

            getDeployments();
        }

        private void getDeployments()
        {
            
        }

        private void containersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == deploymentsDataGridView.Columns["deleteCollumn"].Index)
            {
                //deleteContainer(containersGridView[0, e.RowIndex].Value.ToString());
                fillDeploymentsDataGridView();

            }
        }

        private void deleteContainer(string containerId)
        {
            
        }

        
    }
}
