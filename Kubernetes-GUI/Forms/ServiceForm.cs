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

            refresh();
        }

        private void refresh()
        {
            servicesGridView1.Rows.Clear();
            servicesGridView1.Refresh();

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
                Console.WriteLine(namespac);

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

                servicesGridView1.Rows.Add(
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

        private void CreateKeyButton_Click(object sender, EventArgs e)
        {
            string name = txtkeyName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Key Pair Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string type = typeComboBox.Text;
            
            KeyPair key = new KeyPair()
            {
                keypair = new

                CreateKeysModel()
                {
                    Name = name,
                    Type = type
                }
            };

            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/os-keypairs");

                string requestJson = JsonConvert.SerializeObject(key);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.PostAsync(endpoint, payload).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                MessageBox.Show("Key Pair created sucessesfully", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                materialTabControl1.SelectedTab = tabPageServices;

                refresh();
            }
        }

        private void cellclick_delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == servicesGridView1.Columns["deleteColumn"].Index)
            {

                deleteKey(servicesGridView1[0, e.RowIndex].Value.ToString());
                refresh();
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
            refresh();
        }
    }
}
