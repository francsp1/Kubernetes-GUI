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
    public partial class NamespacesForm : Form
    {
        public NamespacesForm()
        {
            InitializeComponent();

            namespacesTabControl.TabPages.Remove(editNamespacesTab);

            fillNamespacesDataGrdiView();
        }

        private void fillNamespacesDataGrdiView()
        {
            namespacesDataGridView.Rows.Clear();
            namespacesDataGridView.Refresh();

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
                var name = currentNamespace["metadata"]["name"];

                string labels = null;
                foreach (var item in currentNamespace["metadata"]["labels"])
                {
                    labels = labels + item.ToString() + "\n";
                }
                if (labels != null)
                {
                    labels = labels.Replace("\"", string.Empty);
                }

                var phase = currentNamespace["status"]["phase"];

                string created = null;
                var creationTimestamp = currentNamespace["metadata"]["creationTimestamp"];
                if(creationTimestamp != null)
                {
                    DateTime prevDate = Convert.ToDateTime(creationTimestamp).ToUniversalTime(); ;
                    DateTime today = DateTime.Now.ToUniversalTime();

                    var diffOfDate = (today - prevDate);
                    created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min. ago";
                }

                namespacesDataGridView.Rows.Add(
                    name is null    ? "" : name.ToString(),
                    labels is null  ? "" : labels.ToString(),
                    phase is null   ? "" : phase.ToString(),
                    created is null ? "" : created.ToString()
                    );

            }

        }

        private void btnCreateNamespace_Click(object sender, EventArgs e)
        {
            string name = txtNamespaceName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Namespace Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces";

            string requestJson = "{\"apiVersion\":\"v1\",\"kind\":\"Namespace\",\"metadata\":{\"name\":\"" + name + "\",\"labels\":{\"name\":\"" + name + "\"}}}";
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
                MessageBox.Show(response.ReasonPhrase, "Could not create the Namespace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Namespace created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fillNamespacesDataGrdiView();
            namespacesTabControl.SelectedTab = namespacesTab;
        }



        private void namespacesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == namespacesDataGridView.Columns["collumnNamespaceDelete"].Index)
            {
                deleteNamespace(namespacesDataGridView[0, e.RowIndex].Value.ToString());
                fillNamespacesDataGrdiView();
            }
            if (e.ColumnIndex == namespacesDataGridView.Columns["collumnNamespaceEdit"].Index)
            {

            }
        }

        private void deleteNamespace(string namespaceName)
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces/" + namespaceName;

            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Delete the namespace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Namespace deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
