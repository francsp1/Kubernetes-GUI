
namespace OpenStack_GUI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.cmbBoxProtocol = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSlashSlash = new MaterialSkin.Controls.MaterialLabel();
            this.txtDomain = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCollon = new MaterialSkin.Controls.MaterialLabel();
            this.txtPort = new MaterialSkin.Controls.MaterialTextBox();
            this.lblProtocol = new MaterialSkin.Controls.MaterialLabel();
            this.lblDomain = new MaterialSkin.Controls.MaterialLabel();
            this.lblPort = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.Location = new System.Drawing.Point(36, 339);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(36, 433);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(39, 361);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(470, 50);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(39, 455);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(470, 50);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(39, 532);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(422, 532);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(64, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbBoxProtocol
            // 
            this.cmbBoxProtocol.AutoResize = false;
            this.cmbBoxProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxProtocol.Depth = 0;
            this.cmbBoxProtocol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxProtocol.DropDownHeight = 174;
            this.cmbBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProtocol.DropDownWidth = 121;
            this.cmbBoxProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxProtocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxProtocol.IntegralHeight = false;
            this.cmbBoxProtocol.ItemHeight = 43;
            this.cmbBoxProtocol.Items.AddRange(new object[] {
            "http",
            "https"});
            this.cmbBoxProtocol.Location = new System.Drawing.Point(39, 265);
            this.cmbBoxProtocol.MaxDropDownItems = 4;
            this.cmbBoxProtocol.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxProtocol.Name = "cmbBoxProtocol";
            this.cmbBoxProtocol.Size = new System.Drawing.Size(135, 49);
            this.cmbBoxProtocol.StartIndex = 0;
            this.cmbBoxProtocol.TabIndex = 0;
            // 
            // lblSlashSlash
            // 
            this.lblSlashSlash.AutoSize = true;
            this.lblSlashSlash.Depth = 0;
            this.lblSlashSlash.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSlashSlash.Location = new System.Drawing.Point(180, 282);
            this.lblSlashSlash.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSlashSlash.Name = "lblSlashSlash";
            this.lblSlashSlash.Size = new System.Drawing.Size(19, 19);
            this.lblSlashSlash.TabIndex = 7;
            this.lblSlashSlash.Text = "://";
            // 
            // txtDomain
            // 
            this.txtDomain.AnimateReadOnly = false;
            this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomain.Depth = 0;
            this.txtDomain.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDomain.LeadingIcon = null;
            this.txtDomain.Location = new System.Drawing.Point(205, 267);
            this.txtDomain.MaxLength = 50;
            this.txtDomain.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomain.Multiline = false;
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(209, 50);
            this.txtDomain.TabIndex = 8;
            this.txtDomain.Text = "";
            this.txtDomain.TrailingIcon = null;
            // 
            // lblCollon
            // 
            this.lblCollon.AutoSize = true;
            this.lblCollon.Depth = 0;
            this.lblCollon.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCollon.Location = new System.Drawing.Point(420, 282);
            this.lblCollon.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCollon.Name = "lblCollon";
            this.lblCollon.Size = new System.Drawing.Size(5, 19);
            this.lblCollon.TabIndex = 9;
            this.lblCollon.Text = ":";
            // 
            // txtPort
            // 
            this.txtPort.AnimateReadOnly = false;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Depth = 0;
            this.txtPort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPort.LeadingIcon = null;
            this.txtPort.Location = new System.Drawing.Point(431, 267);
            this.txtPort.MaxLength = 50;
            this.txtPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(78, 50);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "";
            this.txtPort.TrailingIcon = null;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Depth = 0;
            this.lblProtocol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProtocol.Location = new System.Drawing.Point(36, 243);
            this.lblProtocol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(60, 19);
            this.lblProtocol.TabIndex = 11;
            this.lblProtocol.Text = "Protocol";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Depth = 0;
            this.lblDomain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDomain.Location = new System.Drawing.Point(202, 243);
            this.lblDomain.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(78, 19);
            this.lblDomain.TabIndex = 12;
            this.lblDomain.Text = "Domain/IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Depth = 0;
            this.lblPort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPort.Location = new System.Drawing.Point(428, 243);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(30, 19);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "Port";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(118, 190);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(243, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Login to Your OpenStack Platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenStack_GUI.Properties.Resources.OpenStackLogo;
            this.pictureBox1.Location = new System.Drawing.Point(172, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblProtocol);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblCollon);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.lblSlashSlash);
            this.Controls.Add(this.cmbBoxProtocol);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 600);
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxProtocol;
        private MaterialSkin.Controls.MaterialLabel lblSlashSlash;
        private MaterialSkin.Controls.MaterialTextBox txtDomain;
        private MaterialSkin.Controls.MaterialLabel lblCollon;
        private MaterialSkin.Controls.MaterialTextBox txtPort;
        private MaterialSkin.Controls.MaterialLabel lblProtocol;
        private MaterialSkin.Controls.MaterialLabel lblDomain;
        private MaterialSkin.Controls.MaterialLabel lblPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}