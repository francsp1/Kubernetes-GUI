using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kubernetes_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes_GUI.Forms
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();

            //servicesDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //servicesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            fillServicesDataGridView();

            fillCmbBoxServiceDeploymentName();

        }

        

        private void fillCmbBoxServiceDeploymentName()
        {

            var deployments = DeploymentsForm.getDeployments();
            if (deployments == null)
            {
                return;
            }

            for (int i = 0; i < deployments.Count; i++)
            {

                var currentNamespace = deployments[i];
                var name = currentNamespace["metadata"]["name"].ToString();

                if (name == null || 
                    name == "kubernetes-dashboard" || 
                    name == "dashboard-metrics-scraper" || 
                    name == "hostpath-provisioner" ||
                    name == "metrics-server" ||
                    name == "coredns" ||
                    name == "calico-kube-controllers" 
                    )
                {
                    continue;
                }

                cmbBoxServiceDeploymentName.Items.Add(name);

            }
        }
        private void fillServicesDataGridView()
        {
            servicesDataGridView.Rows.Clear();
            servicesDataGridView.Refresh();

            getServices();
        }
        private void getServices()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/services";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Services", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray services = (JArray)responseJsonObject["items"];

            for (int i = 0; i < services.Count; i++)
            {
                var currentService = services[i];

                var name = currentService["metadata"]["name"];
                
                var namespac = currentService["metadata"]["namespace"];

                string labels = null;
                if(currentService["metadata"]["labels"] != null)
                {
                    foreach (var item in currentService["metadata"]["labels"])
                    {
                        labels = labels + item.ToString() + currentService["component"] + currentService["provider"] + " \n ";
                    }
                }
                
                if (labels != null)
                {
                    labels = labels.Replace("\"", string.Empty);
                }

                var type = currentService["spec"]["type"];

                var cluster = currentService["spec"]["clusterIP"];

                //var interna = currentService["spec"]["ports"];

                string interna = null;
                foreach (var item in currentService["spec"]["ports"])
                {
                    interna = interna + item.ToString() + currentService["protocol"]  +  " \n ";
                }

                string external = null;
                if (external != null)
                {
                    external = external.Replace("\"", string.Empty);
                }

                string created = null;
                var creationTimestamp = currentService["metadata"]["creationTimestamp"];
                if (creationTimestamp != null)
                {
                    DateTime prevDate = Convert.ToDateTime(creationTimestamp).ToUniversalTime(); ;
                    DateTime today = DateTime.Now.ToUniversalTime();

                    var diffOfDate = (today - prevDate);
                    created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min. ago";
                }

                servicesDataGridView.Rows.Add(
                    name is null ? "" : name.ToString(),
                    namespac is null ? "" : namespac.ToString(),
                    labels is null ? "" : labels.ToString(),
                    type is null ? "" : type.ToString(),
                    cluster is null ? "" : cluster.ToString(),
                    interna is null ? "" : interna.ToString(),
                    external is null ? " - " : external.ToString(),
                    created is null ? "" : created.ToString()
                    );

            }
        }

       

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text;
            if (String.IsNullOrWhiteSpace(serviceName))
            {
                MessageBox.Show("Please, enter a valid Service name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string deploymentName = cmbBoxServiceDeploymentName.Text;
            if (String.IsNullOrWhiteSpace(deploymentName))
            {
                MessageBox.Show("Please, enter a valid deployment name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string serviceNamespace = DeploymentsForm.getNamespace(deploymentName);
            if (String.IsNullOrWhiteSpace(serviceNamespace)){
                MessageBox.Show("Could not get the deployment namespace!", "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceProtocol = cmbBoxServiceProtocol.Text.ToUpper();
            if (String.IsNullOrWhiteSpace(serviceProtocol) || (serviceProtocol != "TCP" && serviceProtocol != "UDP"))
            {
                MessageBox.Show("Please, enter a valid service protocol", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string servicePort = txtServicePort.Text;
            if (!int.TryParse(servicePort, out int servicePortInt) || servicePortInt < 1 || servicePortInt > 65535)
            {
                MessageBox.Show("Please, enter a valid port", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceTargetPort = txtServicePort.Text;
            if (!int.TryParse(serviceTargetPort, out int serviceTargetPortInt) || serviceTargetPortInt < 1 || serviceTargetPortInt > 65535)
            {
                MessageBox.Show("Please, enter a valid port", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServiceSpecPort[] ports = new ServiceSpecPort[1];
            ports[0] = new ServiceSpecPort
            {
                protocol = serviceProtocol,
                port = servicePortInt,
                targetPort = serviceTargetPortInt,
            };

            Models.Service service = new Service
            {
                apiVersion = "v1",
                kind = "Service",
                metadata = new ServiceMetadata
                {
                    name = serviceName,
                },
                spec = new ServiceSpec
                {
                    selector = new ServiceSpecSelector 
                    {
                        app = deploymentName,
                    },
                    ports = ports,

                    type = "NodePort",
                },

            };

            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces/" + serviceNamespace + "/services";

                string requestJson = JsonConvert.SerializeObject(service);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = payload,
                };

                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not create the Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Service created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not create the Service!" + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //deploymentsTabControl.SelectedTab = deploymentsTab;
            //fillDeploymentsDataGridView();


        }


        private void cellclick_delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == servicesDataGridView.Columns["deleteColumn"].Index)
            {

                deleteService(servicesDataGridView[0, e.RowIndex].Value.ToString(), servicesDataGridView[1, e.RowIndex].Value.ToString());
                fillServicesDataGridView();
            }
        }

        private void deleteService(string serviceName, string serviceNamespace)
        {
            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces/" + serviceNamespace + "/services/" + serviceName;

                var request = new HttpRequestMessage(HttpMethod.Delete, url);
                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not Delete the service!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Service deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not Delete the service! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
