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
using MaterialSkin.Controls;

namespace Kubernetes_GUI.Forms
{
    public partial class DeploymentsForm : Form
    {

        private MaterialTextBox[] txtsContainerNames;
        private MaterialTextBox[] txtstContainerImages;
        private MaterialTextBox[] txtsContainerPorts;
        public DeploymentsForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

            deploymentsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            deploymentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/apis/apps/v1/deployments";

                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Deployments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                JObject responseJsonObject = JObject.Parse(json);
                JArray deployments = (JArray)responseJsonObject["items"];

                for (int i = 0; i < deployments.Count; i++)
                {
                    var currentDeployment = deployments[i];
                    var name = currentDeployment["metadata"]["name"];

                    var nspace = currentDeployment["metadata"]["namespace"];

                    string images = null;
                    foreach (var item in currentDeployment["spec"]["template"]["spec"]["containers"])
                    {
                        images = images + item["image"].ToString() + "\n";

                    }
                    if (images != null)
                    {
                        images = images.Replace("\"", string.Empty);

                    }

                    string labels = null;
                    foreach (var item in currentDeployment["metadata"]["labels"])
                    {
                        labels = labels + item.ToString() + "\n";
                    }
                    if (labels != null)
                    {
                        labels = labels.Replace("\"", string.Empty);
                    }


                    string created = null;
                    var creationTimestamp = currentDeployment["metadata"]["creationTimestamp"];
                    if (creationTimestamp != null)
                    {
                        DateTime prevDate = Convert.ToDateTime(creationTimestamp).ToUniversalTime(); ;
                        DateTime today = DateTime.Now.ToUniversalTime();

                        var diffOfDate = (today - prevDate);
                        created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min. ago";
                    }

                    deploymentsDataGridView.Rows.Add(
                        name     is null ? "" : name.ToString(),
                        nspace   is null ? "" : name.ToString(),
                        images   is null ? "" : images.ToString(),
                        labels   is null ? "" : labels.ToString(),
                        "pods",
                        created  is null ? "" : created.ToString()
                        );

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not get the Deployments! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void btnCreateDeployment_Click(object sender, EventArgs e)
        {

        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void txtDeploymentNumberContainers_Leave(object sender, EventArgs e)
        {


            if(txtDeploymentNumberContainers.Text == "" || txtDeploymentNumberContainers.Text == "0")
            {
                txtDeploymentNumberContainers.Text = "1";
                return;
            }

            for (int i = 0; i < (txtsContainerNames == null ? 0: txtsContainerNames.Length); i++)
            {
                createDeploymentTab.Controls.Remove(txtsContainerNames[i]);
                createDeploymentTab.Controls.Remove(txtstContainerImages[i]);
                createDeploymentTab.Controls.Remove(txtsContainerPorts[i]);

            }

            int size = Convert.ToInt16(txtDeploymentNumberContainers.Text);

            txtsContainerNames = new MaterialTextBox[size];
            txtstContainerImages = new MaterialTextBox[size];
            txtsContainerPorts = new MaterialTextBox[size];

            for (int i = 0; i < size; i++)
            {
                txtsContainerNames[i] = new MaterialTextBox();

                txtstContainerImages[i] = new MaterialTextBox();

                txtsContainerPorts[i] = new MaterialTextBox();
                txtsContainerPorts[i].KeyPress += onlyNumbers_KeyPress;

            }
            int y = 343;
            for (int i=0; i < size; i++)
            {
                txtsContainerNames[i].Size = new System.Drawing.Size(299, 50);
                txtsContainerNames[i].Location = new Point(26, y);
                createDeploymentTab.Controls.Add(txtsContainerNames[i]);

                txtstContainerImages[i].Size = new System.Drawing.Size(299, 50);
                txtstContainerImages[i].Location = new Point(359, y);
                createDeploymentTab.Controls.Add(txtstContainerImages[i]);

                txtsContainerPorts[i].Size = new System.Drawing.Size(116, 50);
                txtsContainerPorts[i].Location = new Point(688, y);
                createDeploymentTab.Controls.Add(txtsContainerPorts[i]);

                y += 61;
            }

        }

        private void txtDeploymentNumberContainers_Leave_1(object sender, EventArgs e)
        {
            for (int i = 0; i < (txtsContainerNames == null ? 0 : txtsContainerNames.Length); i++)
            {
                createDeploymentTab.Controls.Remove(txtsContainerNames[i]);
                createDeploymentTab.Controls.Remove(txtstContainerImages[i]);
                createDeploymentTab.Controls.Remove(txtsContainerPorts[i]);

            }

            if (txtDeploymentNumberContainers.Text == "" || txtDeploymentNumberContainers.Text == "0")
            {
                txtDeploymentNumberContainers.Text = "1";
                return;
            }

            int size = Convert.ToInt16(txtDeploymentNumberContainers.Text);

            txtsContainerNames = new MaterialTextBox[size];
            txtstContainerImages = new MaterialTextBox[size];
            txtsContainerPorts = new MaterialTextBox[size];

            int y = 343;
            for (int i = 0; i < size; i++)
            {
                txtsContainerNames[i] = new MaterialTextBox();
                txtsContainerNames[i].Size = new System.Drawing.Size(299, 50);
                txtsContainerNames[i].Location = new Point(26, y);
                createDeploymentTab.Controls.Add(txtsContainerNames[i]);

                txtstContainerImages[i] = new MaterialTextBox();
                txtstContainerImages[i].Size = new System.Drawing.Size(299, 50);
                txtstContainerImages[i].Location = new Point(359, y);
                createDeploymentTab.Controls.Add(txtstContainerImages[i]);

                txtsContainerPorts[i] = new MaterialTextBox();
                txtsContainerPorts[i].KeyPress += onlyNumbers_KeyPress;
                txtsContainerPorts[i].Size = new System.Drawing.Size(116, 50);
                txtsContainerPorts[i].Location = new Point(688, y);
                createDeploymentTab.Controls.Add(txtsContainerPorts[i]);

                y += 61;
            }

        }
    }
}
