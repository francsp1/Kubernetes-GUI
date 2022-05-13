using MaterialSkin.Controls;
using OpenStack_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

            materialSkinInitialize();

            /*
            txtDomain.Text = "192.168.100.140";
            txtPort.Text = "80";
            txtUsername.Text = "demo";
            //txtPassword.Text = "secret";
            txtPassword.Text = "password";
            */

            /*
            txtDomain.Text = "127.0.0.1";
            txtPort.Text = "8080";
            txtUsername.Text = "demo";
            txtPassword.Text = "secret";
            */

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean aux = false;

            string protocol = (string) cmbBoxProtocol.SelectedItem;
            if (String.IsNullOrWhiteSpace(protocol) || (protocol != "http" && protocol != "https") ) 
            {
                aux = true;
                MessageBox.Show("Please, enter a valid Procotol (http or https)", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Protocol = protocol;
            }

            string domain = (string)txtDomain.Text;
            if (String.IsNullOrWhiteSpace(domain))
            {
                aux = true;
                MessageBox.Show("Please, enter a domain/IP", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Domain = domain;
            }

            string port = (string)txtPort.Text;
            if (String.IsNullOrWhiteSpace(port) || !int.TryParse(port, out int it) || !float.TryParse(port, out float ft))
            {
                aux = true;
                MessageBox.Show("Please, enter a valid Port", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Port = port;
            }

            string username = (string)txtUsername.Text;
            if (String.IsNullOrWhiteSpace(username))
            {
                aux = true;
                MessageBox.Show("Please, enter a username", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Username = username;
            }

            string password = (string)txtPassword.Text;
            if (String.IsNullOrWhiteSpace(password))
            {
                aux = true;
                MessageBox.Show("Please, enter a password", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Password = password;
            }

            if(aux == true)
            {
                return;
            }

            if (GlobalSessionDetails.getUnscopedToken())
            {
                this.Hide();
                this.Controls.Clear();
                this.InitializeComponent();
                MainForm mainForm = new MainForm();
                this.Show();
            }

            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void materialSkinInitialize()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

    }
}
