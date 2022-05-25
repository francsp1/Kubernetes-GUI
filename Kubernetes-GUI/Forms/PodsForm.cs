using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kubernetes_GUI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes_GUI.Forms
{
    public partial class PodsForm : Form
    {
        public PodsForm()
        {
            InitializeComponent();

            podsTabControl.TabPages.Remove(editPodTab);

            podsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            podsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //podsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            fillPodsDataGridView();

            getNamespaces();

            cmbBoxPodNamespace.Text = "default";

        }

        private void fillPodsDataGridView()
        {
            podsDataGridView.Rows.Clear();
            podsDataGridView.Refresh();


            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/pods";

                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var request = new HttpRequestMessage(HttpMethod.Get, url);

                HttpResponseMessage response = client.SendAsync(request).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var responseJsonObject = JObject.Parse(responseString);
                JArray pods = (JArray)responseJsonObject["items"];

                for (int i = 0; i < pods.Count; i++)
                {
                    var currentPod = pods[i];

                    var name = currentPod["metadata"]["name"];
                    var nspace = currentPod["metadata"]["namespace"];

                    HashSet<string> imagesList = new HashSet<string>();
                    foreach (var item in currentPod["spec"]["containers"])
                    {
                        imagesList.Add(item["image"].ToString());
                    }

                    string images = null;
                    if (imagesList.Count > 0)
                    {
                        images = string.Join("\n", imagesList.ToArray());
                    }

                    string labels = null;
                    foreach (var item in currentPod["metadata"]["labels"])
                    {
                        labels = labels + item.ToString() + "\n";
                    }
                    if (labels != null)
                    {
                        labels = labels.Replace("\"", string.Empty);
                    }

                    var node = currentPod["spec"]["nodeName"];

                    var status = currentPod["status"]["phase"];

                    string created = null;
                    var creationTimestamp = currentPod["metadata"]["creationTimestamp"];
                    if (creationTimestamp != null)
                    {
                        DateTime prevDate = Convert.ToDateTime(creationTimestamp).ToUniversalTime(); ;
                        DateTime today = DateTime.Now.ToUniversalTime();

                        var diffOfDate = (today - prevDate);
                        created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min. ago";
                    }

                    podsDataGridView.Rows.Add(
                        name is null ? "" : name.ToString(),
                        nspace is null ? "" : nspace.ToString(),
                        images is null ? "" : images.ToString(),
                        labels is null ? "" : labels.ToString(),
                        node is null ? "" : node.ToString(),
                        status is null ? "" : status.ToString(),
                        "Restarts",
                        "CPU ",
                        "Memory",
                        created is null ? "" : created.ToString()
                        );
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not get the Pods! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if(name == null || name == "kube-system" || name == "kube-public" || name == "kube-node-lease")
                    {
                        continue;
                    }
                    
                    cmbBoxPodNamespace.Items.Add(name);

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not get the Namespaces! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region SecundaryEvents

        #endregion SecundaryEvents

        

        private void btnCreatePod_Click(object sender, EventArgs e)
        {
            string podName = txtPodName.Text;
            if (String.IsNullOrWhiteSpace(podName))
            {
                MessageBox.Show("Please, enter a valid Namespace Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string image = txtPodImage.Text;
            if (String.IsNullOrWhiteSpace(podName))
            {
                MessageBox.Show("Please, enter a valid Namespace Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string podNspace = cmbBoxPodNamespace.SelectedItem.ToString();

            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces/" + podNspace + "/pods";

                string requestJson = "{\"apiVersion\":\"v1\",\"kind\":\"Pod\",\"metadata\":{\"name\":\"" + podName + "\",\"labels\":{\"name\":\"" + podName + "\"}},\"spec\":{\"containers\":[{\"name\":\"" + podName + "\",\"image\":\"" + image + "\"}]}}";
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
                    MessageBox.Show(response.ReasonPhrase, "Could not create the Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Pod created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not create the Pod! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            podsTabControl.SelectedTab = podsTab;

            fillPodsDataGridView();

        }

        private void podsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == podsDataGridView.Columns["columnDeletePod"].Index)
            {
                deletePod(podsDataGridView[0, e.RowIndex].Value.ToString(), podsDataGridView[1, e.RowIndex].Value.ToString());
                fillPodsDataGridView();
            }
            /*
            if (e.ColumnIndex == namespacesDataGridView.Columns["collumnNamespaceEdit"].Index)
            {

            }
            */
        }

        void deletePod(string podName, string podNamespace)
        { 
            try
            {
                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/namespaces/" + podNamespace + "/pods/" + podName;

                var request = new HttpRequestMessage(HttpMethod.Delete, url);
                var client = GlobalSessionDetails._clientFactory.CreateClient();

                var response = client.SendAsync(request).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not Delete the pod!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Pod deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Could not Delete the pod! " + excp.InnerException.Message, excp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
