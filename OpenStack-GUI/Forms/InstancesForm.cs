using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
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

namespace OpenStack_GUI.Forms
{
    public partial class InstancesForm : Form
    {
        public InstancesForm()
        {
            InitializeComponent();

            //instancesGridView.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //instancesGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            refresh();
        }

        private void refresh()
        {
            instancesGridView.Rows.Clear();
            instancesGridView.Refresh();


            try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/servers/detail";

                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);

                JArray instances = (JArray)myObject["servers"];

                instancesGridView.Rows.Clear();
                instancesGridView.Refresh();

                for (int i = 0; i < instances.Count; i++)
                {

                    var currentInstance = instances[i];

                    var task = currentInstance["OS-EXT-STS:task_state"].ToString();

                    var powerState = currentInstance["OS-EXT-STS:power_state"].ToString();

                    switch (powerState)
                    {
                        case "0":
                            powerState = "No statte";
                            break;
                        case "1":
                            powerState = "Running";
                            break;
                        case "3":
                            powerState = "Paused";

                            break;
                        case "4":
                            powerState = "Shutdown";
                            break;
                        case "6":
                            powerState = "Crashed";
                            break;
                        case "7":
                            powerState = "Suspended";
                            break;
                    }

                    DateTime date = DateTime.Now;
                    var lauched = Convert.ToDateTime(
                        String.IsNullOrWhiteSpace(currentInstance["OS-SRV-USG:launched_at"].ToString()) ? date.ToString() : currentInstance["OS-SRV-USG:launched_at"].ToString()
                        );

                    var age = Convert.ToInt32((date - lauched).Days);

                    var weeks = (age % 365) / 7;
                    var days = (age % 365) % 7;
                    var final = (weeks + " Weeks," + days + " Days");

                    string flavorName = getFlavorName(currentInstance["flavor"]["id"].ToString());

                    string imageName = "";
                    if (currentInstance["image"].ToString() != "")
                    {
                        imageName = getImageName(currentInstance["image"]["id"].ToString());
                    }

                    string ips = "";
                    JObject addressesObject = JObject.Parse(currentInstance["addresses"].ToString());
                    foreach (var network in addressesObject)
                    {
                        var networkName = network.Key;
                        ips = ips + "Network: " + networkName + "\n";
                        foreach (var address in network.Value)
                        {

                            var version = address["version"].ToString();
                            var addr = address["addr"].ToString();

                            ips = ips + addr + "\n";
                        }
                    }


                    instancesGridView.Rows.Add(
                        currentInstance["id"].ToString(),
                        currentInstance["name"].ToString(),
                        String.IsNullOrWhiteSpace(imageName)                                                 ? "None"    : imageName,
                        String.IsNullOrWhiteSpace(ips)                                                       ? "None"   : ips,
                        String.IsNullOrWhiteSpace(flavorName)                                                ? "Error"  : flavorName,
                        String.IsNullOrWhiteSpace(currentInstance["key_name"].ToString())                    ? "None"   : currentInstance["key_name"].ToString(),
                        String.IsNullOrWhiteSpace(currentInstance["OS-EXT-STS:vm_state"].ToString())         ? ""       : currentInstance["OS-EXT-STS:vm_state"].ToString(),
                        String.IsNullOrWhiteSpace(currentInstance["OS-EXT-AZ:availability_zone"].ToString()) ? ""       : currentInstance["OS-EXT-AZ:availability_zone"].ToString(),
                        String.IsNullOrWhiteSpace(task)                                                      ? "None"   : task,
                        powerState.ToString(),
                        final.ToString() //<--- 
                    );
                
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Instances", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getImageName(string imageId)
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/images/" + imageId;

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            JObject responseJsonObject = JObject.Parse(json);
            return responseJsonObject["image"]["name"].ToString();
        }

        private string getFlavorName(string flavorId)
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/flavors/" + flavorId;

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            JObject responseJsonObject = JObject.Parse(json);
            return responseJsonObject["flavor"]["name"].ToString() ;
        }

        private void instancesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == instancesGridView.Columns["deleteColumn"].Index)
            {
                deleteInstance(instancesGridView[0, e.RowIndex].Value.ToString());
                refresh();

            }
        }

        private void deleteInstance(string serverId)
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/servers/" + serverId;

            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;


            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Delete the instance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Instance deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
