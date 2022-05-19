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

            fillPodsDataGridView();

        }

        private void fillPodsDataGridView()
        {
            podsDataGridView.Rows.Clear();
            podsDataGridView.Refresh();
           
            
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
                if(imagesList.Count > 0)
                {
                    images = string.Join("\n", imagesList.ToArray());
                }

                string labels = null;
                foreach (var item in currentPod["metadata"]["labels"])
                {
                    labels = labels + item.ToString() + "\n";
                }
                if(labels != null)
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
                    name   is null    ? "" : name.ToString(),
                    nspace is null    ? "" : nspace.ToString(),
                    images is null    ? "" : images.ToString(),
                    labels is null    ? "" : labels.ToString(),
                    node   is null    ? "" : node.ToString(),
                    status is null    ? "" : status.ToString(),
                    "Restarts",
                    "CPU ",
                    "Memory",
                    created is null   ? "" : created.ToString()
                    );
            }
            
        }

        
        #region SecundaryEvents

        #endregion SecundaryEvents

    }
}
