using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
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

namespace OpenStack_GUI.Forms
{
    public partial class ContainersForm : Form
    {
        public ContainersForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

            fillContainersDataGridView();

        }

        private void fillContainersDataGridView()
        {
            containersGridView.Rows.Clear();
            containersGridView.Refresh(); ;

            getContainers();
        }

        private void getContainers()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container/v1/containers/";

            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            var responseJsonObject = new JObject();
            do
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                HttpResponseMessage response = client.SendAsync(request).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Containers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                responseJsonObject = JObject.Parse(responseString);
                JArray containers = (JArray)responseJsonObject["containers"];

                for (int i = 0; i < containers.Count; i++)
                {
                    var currentContainer = containers[i];

                    containersGridView.Rows.Add(
                            string.IsNullOrWhiteSpace(currentContainer["name"].ToString())         ? "-"    : currentContainer["name"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["uuid"].ToString())         ? "-"    : currentContainer["uuid"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["image"].ToString())        ? "-"    : currentContainer["image"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["status"].ToString())       ? "-"    : currentContainer["status"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["task_state"].ToString())   ? "-"    : currentContainer["task_state"].ToString()
                        );
                }
                var teste = responseJsonObject["next"].ToString();
                if (responseJsonObject["next"].ToString() != "")
                {
                    url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container" + responseJsonObject["next"].ToString();
                }

            } while (responseJsonObject["next"].ToString() != "");  // get the containers while there is a next filed in the response 

        }

        private void containersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == containersGridView.Columns["deleteCollumn"].Index)
            {
                deleteContainer(containersGridView[0, e.RowIndex].Value.ToString());
                fillContainersDataGridView();

            }
        }

        private void deleteContainer(string containerId)
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container/v1/containers/" + containerId;

            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;


            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Delete the container", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Container deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            string name = txtContainerName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Container Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imageName = txtContainerImage.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Image Name/ID", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container/v1/containers/";

            var requestJson = "{\"name\":\"" + name + "\",\"image\":\"" + imageName + "\"}";
            var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = payload,
            };

            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not create the Container", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Container Created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fillContainersDataGridView();
            containersTabControl.SelectedTab = containersTabPage;
        }
    }
}
