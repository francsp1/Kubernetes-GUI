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

namespace Kubernetes_GUI.Forms
{
    public partial class DeploymentsForm : Form
    {
        public DeploymentsForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

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

                    var teste = currentDeployment["spec"]["template"];

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
                        "images",
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

        
    }
}
