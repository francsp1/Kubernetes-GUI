using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
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

namespace OpenStack_GUI.Forms
{
    public partial class ImagesForm : Form
    {
        public ImagesForm()
        {
            InitializeComponent();

            imagesTabControl.TabPages.Remove(editImageTab);

            fillImagesDataGridView();

            /*
            txtImageFile.Text = "C:\\Users\\franc\\Downloads\\cirros-0.4.0-x86_64-disk.img";
            txtImageName.Text = "Teste";
            txtImageDescription.Text = "T desc";
            */

        }

        private void fillImagesDataGridView()
        {
            imagesDataGridView.Rows.Clear();
            imagesDataGridView.Refresh();
            /*
            using (WebClient myWebClient = new WebClient())
            {
               
                try
                { 
                    var responseJsonObject = new JObject();

                    myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                    string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images";

                    do
                    { 
                        var responseString = myWebClient.DownloadString(url);

                        responseJsonObject = JObject.Parse(responseString);
                        JArray images = (JArray)responseJsonObject["images"];

                        for (int i = 0; i < images.Count; i++)
                        {
                            var currentImage = images[i];
                            imagesDataGridView.Rows.Add(imagesDataGridView.Rows.Count + 1, false, currentImage["id"].ToString(), currentImage["owner"].ToString(), currentImage["name"].ToString(), currentImage["status"].ToString(), currentImage["visibility"].ToString(), bool.Parse(currentImage["protected"].ToString()) ? "Yes" : "No", currentImage["disk_format"].ToString(), currentImage["container_format"].ToString(), (((float)long.Parse(currentImage["size"].ToString()) / 1048576)).ToString("0.00") + "MB", "Delete");
                        }
                        if(responseJsonObject["next"] != null)
                        {
                            url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image" + responseJsonObject["next"].ToString();
                        }

                    } while (responseJsonObject["next"] != null);  // get the images while there is a next filed in the response 
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */

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
                    imagesDataGridView.Rows.Add(
                        imagesDataGridView.Rows.Count + 1, 
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

        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            string filePath = txtImageFile.Text;

            if (!File.Exists(filePath) || filePath.Length <= 0) //check if the path of the file is valid
            {
                MessageBox.Show("File is not valid! Please check if this file exists or the field is not empty", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtImageName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Image Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = txtImageDescription.Text;
            if (description == null || description.Length > 255)
            {
                MessageBox.Show("Please, enter a valid description", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string diskFormat = cmbBoxImageDiskFormat.Text;
            string visibility = cmbImageBoxVisibility.Text;

            if(visibility == "public" && GlobalSessionDetails.Username != "admin")
            {
                MessageBox.Show("Only administratos can create public images!", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string minimumDisk = txtImageMinimumDisk.Text;
            if (String.IsNullOrWhiteSpace(minimumDisk) || !int.TryParse(minimumDisk, out int it))
            {
                MessageBox.Show("Please, enter a valid disk size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string minimumRam = txtImageMinimumRam.Text;
            if (String.IsNullOrWhiteSpace(minimumRam) || !int.TryParse(minimumRam, out int it2))
            {
                MessageBox.Show("Please, enter a valid disk RAM Size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool imageProtected = switchImageProtected.Checked;

            CreateImageModel image = new CreateImageModel()
            {
                Name = name,
                Desccription = description,
                DiskFormat = diskFormat.ToLower(),
                Visibility = visibility,
                MinimumDisk = int.Parse(minimumDisk),
                MinimumRam = int.Parse(minimumRam),
                Protected = imageProtected,
                ContainerFormat = "bare",
            };

            //Create image
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images";

            string requestJson = JsonConvert.SerializeObject(image); //<<-----------------------------------------
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
                MessageBox.Show(response.ReasonPhrase, "Could not create the Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get the image ID from the response 
            var jo = JObject.Parse(json);
            var imageId = jo["id"].ToString();
            
            //Upload image file

            url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId + "/file";

            var stream = File.OpenRead(filePath);
            var payload2 = new StreamContent(stream);

            request = new HttpRequestMessage(HttpMethod.Put, url)
            {
                Content = payload2,
            };


            client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //https://code-examples.net/en/q/a2f3ae
            var field = typeof(System.Net.Http.Headers.HttpRequestHeaders)
                .GetField("invalidHeaders", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                ?? typeof(System.Net.Http.Headers.HttpRequestHeaders)
                .GetField("s_invalidHeaders", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (field != null)
            {
                var invalidFields = (HashSet<string>)field.GetValue(null);
                invalidFields.Remove("Content-Type");
            }
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/octet-stream");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            response = client.SendAsync(request).Result;
            json = response.Content.ReadAsStringAsync().Result;

            stream.Close();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase + "(make sure the project limit has not been reached)", "Could not upload the image file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Image created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fillImagesDataGridView();
            imagesTabControl.SelectedTab = imagesTab;
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = file.FileName;
            }
        }

        private void imagesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == imagesDataGridView.Columns["columnDeleteImage"].Index)
            {
                deleteImage(imagesDataGridView[2, e.RowIndex].Value.ToString());
                fillImagesDataGridView();

            }
            if (e.ColumnIndex == imagesDataGridView.Columns["collumnEditImage"].Index)
            {
                editImage(e.RowIndex);
            }
        }

        private void deleteImage(string imageId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Image deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            try
            {
                var url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId + "\r\n";
                WebRequest request = WebRequest.Create(url);
                request.Headers.Add("x-auth-token", GlobalSessionDetails.UnscopedToken);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            var imageIdentifier = imageId;
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageIdentifier);

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                HttpResponseMessage result = client.DeleteAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not Delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Image deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

        }

        private void editImage(int rowIndex)
        {
            if (!imagesTabControl.TabPages.Contains(editImageTab))
            {
                imagesTabControl.TabPages.Add(editImageTab);
            }
            imagesTabControl.SelectedTab = editImageTab;

            var selectedRow = imagesDataGridView.Rows[rowIndex].Cells;

            txtEditImageName.Text = selectedRow[4].Value.ToString();
            txtEditImageDescription.Text = selectedRow[5].Value.ToString();

            try
            {
                cmbBoxEditImageVisibility.SelectedIndex = cmbBoxEditImageVisibility.Items.IndexOf(selectedRow[7].Value.ToString().ToLower());

            }
            catch (Exception excp)
            {
                MessageBox.Show("Something went wrong displaing the image Visibility", "Can not edit the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switchEditImageProtected.Checked = selectedRow[8].Value.ToString() == "Yes" ? true : false;
            try
            {
                cmbBoxEditImageDiskFormat.SelectedIndex = cmbBoxEditImageDiskFormat.Items.IndexOf(selectedRow[9].Value.ToString().ToUpper());
            }
            catch (Exception excp)
            {
                MessageBox.Show("Something went wrong displaing the image Disk format", "Can not edit the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtEditImageMinimumDisk.Text = selectedRow[10].Value.ToString();
            txtEditImageMinimumRam.Text = selectedRow[11].Value.ToString();
            editImageRow.Value = rowIndex;

        }


        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            var rowIndex = (int)editImageRow.Value;
            if(rowIndex < 0)
            {
                return;
            }

            string name = txtEditImageName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Image Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = txtEditImageDescription.Text;
            if (description == null || description.Length > 255)
            {
                MessageBox.Show("Please, enter a valid description", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string diskFormat = cmbBoxEditImageDiskFormat.Text.ToLower();
            string visibility = cmbBoxEditImageVisibility.Text.ToLower();

            if (visibility == "public" && GlobalSessionDetails.Username != "admin")
            {
                MessageBox.Show("Only administratos can change visibility to public!", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string minimumDisk = txtEditImageMinimumDisk.Text;
            if (String.IsNullOrWhiteSpace(minimumDisk) || !int.TryParse(minimumDisk, out int it))
            {
                MessageBox.Show("Please, enter a valid disk size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string minimumRam = txtEditImageMinimumRam.Text;
            if (String.IsNullOrWhiteSpace(minimumRam) || !int.TryParse(minimumRam, out int it2))
            {
                MessageBox.Show("Please, enter a valid disk RAM Size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool imageProtectedBool = switchEditImageProtected.Checked;
            string imageProtected = switchEditImageProtected.Checked ? "yes" : "no";

            UpdateImageModel updateImageModel = new UpdateImageModel();

            var parametersToUpdate = updateImageModel.updateImageField ;

            var imageRow = imagesDataGridView.Rows[rowIndex].Cells;


            if (name != (imageRow[4].Value.ToString()) ) //if the value in the image name textbox is diferent from the one stored int the collumn "Name" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/name",
                    value = name,
                });
            }

            if (description != (imageRow[5].Value.ToString())) //if the value in the image description textbox is diferent from the one stored int the Hiden collumn "description" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/description",
                    value = description,
                });
            }

            if (diskFormat != (imageRow[9].Value.ToString())) //if the value in the image disk format textbox is diferent from the one stored int the collumn "Disk format" of the images grid view
            {
                if (imageRow[6].Value.ToString() != "queued") //if the image status is not queued the user can not modify the disk format
                {
                    MessageBox.Show("Attribute disk_format can be only replaced for a queued image.\n", "Could not Update the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/disk_format",
                    value = diskFormat,
                });
            }

            if (visibility != (imageRow[7].Value.ToString())) //if the value in the image Visibility Combo box is diferent from the one stored int the collumn "Visibility" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/visibility",
                    value = visibility,
                });
            }

            if (minimumDisk != (imageRow[10].Value.ToString())) //if the value in the image Minimum disk TextBox is diferent from the one stored int the collumn "Visibility" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/min_disk",
                    value = int.Parse(minimumDisk),
                });
            }

            if (minimumRam != (imageRow[11].Value.ToString())) //if the value in the image Minimum disk TextBox is diferent from the one stored int the collumn "Visibility" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/min_ram",
                    value = int.Parse(minimumRam),
                });
            }

            if (imageProtected != (imageRow[8].Value.ToString().ToLower())) //if the value in the image Protected switch is diferent from the one stored int the collumn "Protected" of the images grid view
            {
                parametersToUpdate.Add(new UpdateImageField
                {
                    op = "replace",
                    path = "/protected",
                    value = imageProtectedBool,
                });
            }

            if (parametersToUpdate == null || !parametersToUpdate.Any()) //if the list of parameters to update is empty (the user did not changed any field then do nothing)
            {
                return;
            }

            updateImage(imageRow[2].Value.ToString(), parametersToUpdate);


            fillImagesDataGridView();

            btnCancelEditImage_Click(null, null);

            imagesTabControl.TabPages.Remove(editImageTab);

        }

        private void updateImage(string imageId, List<UpdateImageField> body)
        {
            var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId);

            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var httpVerb = new HttpMethod("PATCH");

            string requestJson = JsonConvert.SerializeObject(body);
            var payload = new StringContent(requestJson, Encoding.UTF8, "application/openstack-images-v2.1-json-patch");

            var httpRequestMessage = new HttpRequestMessage(httpVerb, endpoint)
            {
                Content = payload,
            };

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);
            client.DefaultRequestHeaders.ExpectContinue = false;


            HttpResponseMessage response = client.SendAsync(httpRequestMessage).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Update the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Image updated with success", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void btnCancelEditImage_Click(object sender, EventArgs e)
        {
            txtEditImageName.Text = "";
            txtEditImageDescription.Text = "";
            cmbBoxEditImageDiskFormat.SelectedIndex = 0;
            txtEditImageMinimumDisk.Text = "0";
            cmbBoxEditImageVisibility.SelectedIndex = 0;
            txtEditImageMinimumRam.Text = "0";
            switchEditImageProtected.Checked = false;
            editImageRow.Value = -1;

            imagesTabControl.TabPages.Remove(editImageTab);
        }

        #region SecundaryEvents
        private void txtMinimumDisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void txtMinimumRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }



        #endregion SecundaryEvents

    }
}
