namespace AudioPlayer
{
    partial class VkLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VkLogIn));
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.FormCloser = new ns1.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new ns1.BunifuTextbox();
            this.buttonLogin = new ns1.BunifuFlatButton();
            this.textBoxLogin = new ns1.BunifuTextbox();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.FormCloser);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(353, 35);
            this.header.TabIndex = 12;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::AudioPlayer.Properties.Resources.Delete_50px_9;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(324, 5);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(27, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FormCloser
            // 
            this.FormCloser.BackColor = System.Drawing.Color.Transparent;
            this.FormCloser.Image = global::AudioPlayer.Properties.Resources.Delete_50px_9;
            this.FormCloser.ImageActive = null;
            this.FormCloser.Location = new System.Drawing.Point(1007, 12);
            this.FormCloser.Margin = new System.Windows.Forms.Padding(4);
            this.FormCloser.Name = "FormCloser";
            this.FormCloser.Size = new System.Drawing.Size(27, 25);
            this.FormCloser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormCloser.TabIndex = 8;
            this.FormCloser.TabStop = false;
            this.FormCloser.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phenomena", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phenomena", 19.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(80, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Войти в VK.COM";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxPassword.BackgroundImage")));
            this.textBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.textBoxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxPassword.Icon")));
            this.textBoxPassword.Location = new System.Drawing.Point(24, 175);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(307, 37);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.text = "Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.BorderRadius = 0;
            this.buttonLogin.ButtonText = "Войти";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogin.Iconimage = null;
            this.buttonLogin.Iconimage_right = null;
            this.buttonLogin.Iconimage_right_Selected = null;
            this.buttonLogin.Iconimage_Selected = null;
            this.buttonLogin.IconMarginLeft = 0;
            this.buttonLogin.IconMarginRight = 0;
            this.buttonLogin.IconRightVisible = true;
            this.buttonLogin.IconRightZoom = 0D;
            this.buttonLogin.IconVisible = true;
            this.buttonLogin.IconZoom = 90D;
            this.buttonLogin.IsTab = false;
            this.buttonLogin.Location = new System.Drawing.Point(24, 344);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(133)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogin.selected = false;
            this.buttonLogin.Size = new System.Drawing.Size(307, 44);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Textcolor = System.Drawing.Color.White;
            this.buttonLogin.TextFont = new System.Drawing.Font("Phenomena Light", 14F);
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxLogin.BackgroundImage")));
            this.textBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.textBoxLogin.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxLogin.Icon")));
            this.textBoxLogin.Location = new System.Drawing.Point(24, 110);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(307, 37);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TabStop = false;
            this.textBoxLogin.text = "Email / Номер телефона";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(24, 237);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phenomena Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(50, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "запомнить";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(353, 452);
            this.webBrowser1.TabIndex = 21;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // VkLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(353, 485);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VkLogIn";
            this.Text = "VkLogIn";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel header;
        private ns1.BunifuImageButton FormCloser;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuTextbox textBoxPassword;
        private ns1.BunifuFlatButton buttonLogin;
        private ns1.BunifuTextbox textBoxLogin;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}