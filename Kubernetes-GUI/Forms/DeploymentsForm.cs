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
using Newtonsoft.Json;

namespace Kubernetes_GUI.Forms
{
    public partial class DeploymentsForm : Form
    {

        private MaterialTextBox[] txtsContainerNames;
        private MaterialTextBox[] txtsContainerImages;
        //private MaterialTextBox[] txtsContainerPorts = new MaterialTextBox[1];
        public DeploymentsForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

            deploymentsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            deploymentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            fillDeploymentsDataGridView();

            getNamespaces();
            cmbBoxDeploymentNamespace.Text = "default";

            txtsContainerNames = new MaterialTextBox[1];
            txtsContainerNames[0] = new MaterialTextBox();
            txtsContainerNames[0].Size = new System.Drawing.Size(299, 50);
            txtsContainerNames[0].Location = new Point(26, 343);
            createDeploymentTab.Controls.Add(txtsContainerNames[0]);

            txtsContainerImages = new MaterialTextBox[1];
            txtsContainerImages[0] = new MaterialTextBox();
            txtsContainerImages[0].Size = new System.Drawing.Size(299, 50);
            txtsContainerImages[0].Location = new Point(359, 343);
            createDeploymentTab.Controls.Add(txtsContainerImages[0]);

            /*
            txtsContainerPorts[0] = new MaterialTextBox();
            txtsContainerPorts[0].KeyPress += onlyNumbers_KeyPress;
            txtsContainerPorts[0].Size = new System.Drawing.Size(116, 50);
            txtsContainerPorts[0].Location = new Point(688, 343);
            createDeploymentTab.Controls.Add(txtsContainerPorts[0]);
            */




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

        private void getNamespaces()
        {
            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces";

                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Namespaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                JObject responseJsonObject = JObject.Parse(json);
                JArray namespaces = (JArray)responseJsonObject["items"];

                for (int i = 0; i < namespaces.Count; i++)
                {

                    var currentNamespace = namespaces[i];
                    var name = currentNamespace["metadata"]["name"].ToString();

                    if (name == null || name == "kube-system" || name == "kube-public" || name == "kube-node-lease")
                    {
                        continue;
                    }

                    cmbBoxDeploymentNamespace.Items.Add(name);

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not get the Namespaces! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCreateDeployment_Click(object sender, EventArgs e)
        {

            string deploymentName = txtDeploymentName.Text;
            if (String.IsNullOrWhiteSpace(deploymentName))
            {
                MessageBox.Show("Please, enter a valid Deployment name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string deploymentNamespace = cmbBoxDeploymentNamespace.SelectedItem.ToString();
            string replicas = txtDeploymentReplicas.Text;
            if (!int.TryParse(replicas, out int replicasInt))
            {
                MessageBox.Show("Please, enter a valid number of Replicas", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string numberOfContainers = txtDeploymentNumberContainers.Text;
            if (!int.TryParse(numberOfContainers, out int numberOfContainersInt))
            {
                MessageBox.Show("Invalid number of Containers!", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtsContainerNames == null || txtsContainerImages ==null || txtsContainerNames.Length == 0 || txtsContainerImages.Length == 0)
            {
                MessageBox.Show("You need at least one container name and one container image!", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Models.Container[] containers  = new Models.Container[numberOfContainersInt];

            for (int i = 0; i < numberOfContainersInt; i++)
            {

                string deploymentContainerName = txtsContainerNames[i].Text;
                string deploymentContainerimage = txtsContainerImages[i].Text;
                
                if (String.IsNullOrWhiteSpace(deploymentContainerName) || String.IsNullOrWhiteSpace(deploymentContainerimage))
                {
                    MessageBox.Show("Please, fill all containers fields", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                containers[i] = new Models.Container
                {
                    name = deploymentContainerName,
                    image = deploymentContainerimage
                };

            }

            Models.Deplayment deployment = new Models.Deplayment
            {
                apiVersion = "apps/v1",
                kind = "Deployment",
                metadata = new Models.Metadata
                {
                    name = deploymentName,
                    labels = new Models.Labels
                    {
                        app = deploymentName,
                        name = deploymentName
                    },
                },
                spec = new Models.Spec
                {
                    replicas = replicasInt,
                    selector = new Models.Selector
                    {
                        matchLabels = new Models.Matchlabels
                        {
                            app = deploymentName
                        },
                    },
                    template = new Template
                    {
                        metadata = new Models.TemplateMetadata
                        {
                            labels = new TemplateLabels
                            {
                                app = deploymentName,
                                name = deploymentName
                            },
                        },
                        spec = new TemplateSpec
                        {
                            containers = containers
                        },
                    },
                },
            };


            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/apis/apps/v1/namespaces/" + deploymentNamespace + "/deployments";

                string requestJson = JsonConvert.SerializeObject(deployment);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = payload,
                };

                var client = GlobalSessionDetails._clientFactory.CreateClient();

                client.DefaultRequestHeaders.Add("X-Auth-Token", "gAAAAABiVfjacfcmk3McvrzNohg3zqvGVTYeaiuJdGgNhOAcHOcGC7-rJbqOtot-wVk3o3xfpk72Ak1RkBHbFthZV0-rhEtK2wykmwztA8V8Gp7K8ICazSjobHQ_vpslc2bZWELeVbtFfAN4fS2HrzcEfyBulTfBWJnz5AbUbelZQZg_Bg1g3D0");

                client.DefaultRequestHeaders.ExpectContinue = false;

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not create the Deployment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Deployment created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not create the Deployment!" + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            deploymentsTabControl.SelectedTab = deploymentsTab;
            fillDeploymentsDataGridView();

        }

        private void btnDeploymentApply_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (txtsContainerNames == null ? 0 : txtsContainerNames.Length); i++)
            {
                createDeploymentTab.Controls.Remove(txtsContainerNames[i]);
                createDeploymentTab.Controls.Remove(txtsContainerImages[i]);
                //createDeploymentTab.Controls.Remove(txtsContainerPorts[i]);

            }

            if (txtDeploymentNumberContainers.Text == "" || txtDeploymentNumberContainers.Text == "0")
            {
                txtDeploymentNumberContainers.Text = "1";
            }

            int size = Convert.ToInt16(txtDeploymentNumberContainers.Text);

            txtsContainerNames = null;
            txtsContainerNames = new MaterialTextBox[size];
            txtsContainerImages = null;
            txtsContainerImages = new MaterialTextBox[size];
            //txtsContainerPorts = new MaterialTextBox[size];

            int y = 343;
            for (int i = 0; i < size; i++)
            {
                txtsContainerNames[i] = new MaterialTextBox();
                txtsContainerNames[i].Size = new System.Drawing.Size(299, 50);
                txtsContainerNames[i].Location = new Point(26, y);
                createDeploymentTab.Controls.Add(txtsContainerNames[i]);

                txtsContainerImages[i] = new MaterialTextBox();
                txtsContainerImages[i].Size = new System.Drawing.Size(299, 50);
                txtsContainerImages[i].Location = new Point(359, y);
                createDeploymentTab.Controls.Add(txtsContainerImages[i]);

                /*
                txtsContainerPorts[i] = new MaterialTextBox();
                txtsContainerPorts[i].KeyPress += onlyNumbers_KeyPress;
                txtsContainerPorts[i].Size = new System.Drawing.Size(116, 50);
                txtsContainerPorts[i].Location = new Point(688, y);
                createDeploymentTab.Controls.Add(txtsContainerPorts[i]);
                */

                y += 61;
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

       

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        
    }
}
