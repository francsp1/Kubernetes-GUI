using Newtonsoft.Json;
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
    public partial class KeyPairForm : Form
    {
        public KeyPairForm()
        {
            InitializeComponent();

            refresh();
        }

        private void refresh()
        {
            keysGridView1.Rows.Clear();
            keysGridView1.Refresh();

            getKeiPairs();
        }

        private void getKeiPairs()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/os-keypairs";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Key Pairs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray keyPairs = (JArray)responseJsonObject["keypairs"];

            foreach (JToken keyPair in keyPairs)
            {
                var name = keyPair["keypair"]["name"].ToString();
                var fingerprint = keyPair["keypair"]["fingerprint"].ToString();

                keysGridView1.Rows.Add(name, fingerprint);
            }
        }

        private void CreateKeyButton_Click(object sender, EventArgs e)
        {
            string name = txtkeyName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Key Pair Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string type = typeComboBox.Text;
            
            KeyPair key = new KeyPair()
            {
                keypair = new

                CreateKeysModel()
                {
                    Name = name,
                    Type = type
                }
            };

            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/os-keypairs");

                string requestJson = JsonConvert.SerializeObject(key);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.PostAsync(endpoint, payload).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                MessageBox.Show("Key Pair created sucessesfully", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                materialTabControl1.SelectedTab = tabPageKeyPair;

                refresh();
            }
        }

        private void cellclick_delete(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == keysGridView1.Columns["deleteColumn"].Index)
            {

                deleteKey(keysGridView1[0, e.RowIndex].Value.ToString());
                refresh();
            }
        }

        private void deleteKey(string keyID)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/os-keypairs/" + keyID); 

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.DeleteAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not Delete the Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Key Pair deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refresh();
        }
    }
}
