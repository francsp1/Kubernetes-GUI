using Kubernetes_GUI.Models;
using Newtonsoft.Json.Linq;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            getPods();
            getDep();
            getServ();
        }

        private void getPods()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/pods";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Pods", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray pods = (JArray)responseJsonObject["items"];

            int count = 0;
            count = pods.Count;

            CountPodmaterialLabel.Text = count.ToString();

            for (int i = 0; i < pods.Count; i++)
            {
                var currentPod = pods[i];

                var name = currentPod["metadata"]["name"];

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

                var node = currentPod["spec"]["nodeName"];

                var status = currentPod["status"]["phase"];

                dataGridView1.Rows.Add(
                    name is null ? "" : name.ToString(),
                    images is null ? "" : images.ToString(),
                    node is null ? "" : node.ToString(),
                    status is null ? "" : status.ToString());                    
            }
        }

        private void getServ()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/services";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Pods", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray services = (JArray)responseJsonObject["items"];

            int count = 0;
            count = services.Count;

            CountServicesmaterialLabel.Text = count.ToString();

            for (int i = 0; i < services.Count; i++)
            {
                var currentService = services[i];

                var name = currentService["metadata"]["name"];

                dataGridView2.Rows.Add(name is null ? "" : name.ToString());
            }
        }

        private void getDep()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/apis/apps/v1/deployments";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Pods", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray dep = (JArray)responseJsonObject["items"];

            int count = 0;
            count = dep.Count;

            CountDepmaterialLabel.Text = count.ToString();

            for (int i = 0; i < dep.Count; i++)
            {
                var currentDeployment = dep[i];

                var name = currentDeployment["metadata"]["name"];

                string images = null;
                foreach (var item in currentDeployment["spec"]["template"]["spec"]["containers"])
                {
                    images = images + item["image"].ToString() + "\n";

                }
                if (images != null)
                {
                    images = images.Replace("\"", string.Empty);

                }
                
                dataGridView3.Rows.Add(
                    name is null ? "" : name.ToString(),
                    images is null ? "" : images.ToString(),
                    "pods"
                );

                

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
