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
                MessageBox.Show(response.ReasonPhrase, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DateTime prevDate = Convert.ToDateTime(creationTimestamp);
                    DateTime today = DateTime.Today;

                    var diffOfDate = today - prevDate;
                    created = diffOfDate.Days + " days " + diffOfDate.Hours + " hours and " + diffOfDate.Minutes + " min.";
                }

            }

            MessageBox.Show("Images obtained with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private void namespacesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == namespacesDataGridView.Columns["collumnNamespaceEdit"].Index)
            {
            }

            if (e.ColumnIndex == namespacesDataGridView.Columns["collumnNamespaceDelete"].Index)
            {

                fillNamespacesDataGrdiView();
            }
        }

        private void deleteVolume(string volumeID)
        {
            
            fillNamespacesDataGrdiView();
        }

    }
}
