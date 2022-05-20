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
    public partial class NodesForm : Form
    {
        public NodesForm()
        {
            InitializeComponent();

            refresh();
        }

        private void refresh()
        {
            nodesGridView.Rows.Clear();
            nodesGridView.Refresh();

            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/api/v1/nodes";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Nodes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray nodes = (JArray)responseJsonObject["items"];

            for (int i = 0; i < nodes.Count; i++)
            {
                var currentNode = nodes[i];

                var name = currentNode["metadata"]["name"];
                Console.WriteLine(name);

                string labels = null;
                foreach (var item in currentNode["metadata"]["labels"])
                {
                    labels = labels + item.ToString() + "\n";
                }
                if (labels != null)
                {
                    labels = labels.Replace("\"", string.Empty);
                }

                var ready = currentNode["status"]["conditions"][4]["status"];

                //var cpu = currentNamespace["conditions"][3]["status"];

                string created = null;
                var creationTimestamp = currentNode["metadata"]["creationTimestamp"];
                if (creationTimestamp != null)
                {
                    DateTime prevDate = Convert.ToDateTime(creationTimestamp).ToUniversalTime(); ;
                    DateTime today = DateTime.Now.ToUniversalTime();

                    var diffOfDate = (today - prevDate);
                    created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min. ago";
                }

                nodesGridView.Rows.Add(
                    name is null ? "" : name.ToString(),
                    labels is null ? "" : labels.ToString(),
                    ready is null ? "" : ready.ToString(),
                    created is null ? "" : created.ToString()
                    );

            }
        }
    }
}
