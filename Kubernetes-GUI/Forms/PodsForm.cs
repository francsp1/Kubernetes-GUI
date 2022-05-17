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

            fillImagesDataGridView();

            /*
            txtImageFile.Text = "C:\\Users\\franc\\Downloads\\cirros-0.4.0-x86_64-disk.img";
            txtImageName.Text = "Teste";
            txtImageDescription.Text = "T desc";
            */

        }

        private void fillImagesDataGridView()
        {
            podsDataGridView.Rows.Clear();
            podsDataGridView.Refresh();
           

            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images";

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
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                responseJsonObject = JObject.Parse(responseString);
                JArray images = (JArray)responseJsonObject["images"];

                for (int i = 0; i < images.Count; i++)
                {
                    var currentImage = images[i];
                    var imageSize = currentImage["size"].ToString();
                    podsDataGridView.Rows.Add(
                        podsDataGridView.Rows.Count + 1, 
                        false, 
                        currentImage["id"].ToString(), 
                        currentImage["owner"].ToString(), 
                        currentImage["name"].ToString(), 
                        currentImage["description"] is null ? "" : currentImage["description"].ToString(), 
                        currentImage["status"].ToString(), 
                        currentImage["visibility"].ToString(), bool.Parse(currentImage["protected"].ToString()) ? "Yes" : "No", 
                        currentImage["disk_format"].ToString(), 
                        currentImage["min_disk"].ToString(), 
                        currentImage["min_ram"].ToString(), 
                        currentImage["container_format"].ToString(), 
                        (((float)long.Parse( string.IsNullOrWhiteSpace(imageSize)  ? "0" : imageSize) / 1048576)).ToString("0.00") + "MB"
                        );
                }
                var teste = responseJsonObject["next"];

                if (responseJsonObject["next"] != null)
                {
                    url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image" + responseJsonObject["next"].ToString();
                }

            } while (responseJsonObject["next"] != null);  // get the images while there is a next filed in the response 

        }

        
        #region SecundaryEvents

        #endregion SecundaryEvents

    }
}
