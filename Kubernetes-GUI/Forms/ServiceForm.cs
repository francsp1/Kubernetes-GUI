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

            getNamespaces();
            cmbBoxServiceNamespace.Text = "default";
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
                foreach (var item in currentService["metadata"]["labels"])
                {
                    labels = labels + item.ToString() + currentService["component"] + currentService["provider"] + " \n ";
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

                    cmbBoxServiceNamespace.Items.Add(name);

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not get the Namespaces! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            string deploymentName = txtServiceDeploymentName.Text;
            if (String.IsNullOrWhiteSpace(deploymentName))
            {
                MessageBox.Show("Please, enter a valid deployment name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deploymentNamespace = cmbBoxServiceNamespace.SelectedItem.ToString();

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
                },

            };

            string requestJson = JsonConvert.SerializeObject(service);

        }


        private void cellclick_delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == servicesDataGridView.Columns["deleteColumn"].Index)
            {

                deleteKey(servicesDataGridView[0, e.RowIndex].Value.ToString());
                fillServicesDataGridView();
            }
        }

        private void deleteKey(string keyID)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/os-keypairs/" + keyID); 

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.DeleteAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not Delete the Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Key Pair deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            fillServicesDataGridView();
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
