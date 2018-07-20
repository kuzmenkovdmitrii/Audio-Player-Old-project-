using ns1;

namespace AudioPlayer
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FormCloser = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.sliderRed = new ns1.BunifuTrackbar();
            this.sliderGreen = new ns1.BunifuTrackbar();
            this.sliderBlue = new ns1.BunifuTrackbar();
            this.buttonApplyColor = new ns1.BunifuFlatButton();
            this.colorChanger = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.buttonReset = new ns1.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveDomain = new ns1.BunifuFlatButton();
            this.buttonSaveFolder = new ns1.BunifuFlatButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.FormCloser);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(315, 35);
            this.header.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phenomena", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Settings";
            // 
            // FormCloser
            // 
            this.FormCloser.BackColor = System.Drawing.Color.Transparent;
            this.FormCloser.Image = global::AudioPlayer.Properties.Resources.Delete_50px_9;
            this.FormCloser.ImageActive = null;
            this.FormCloser.Location = new System.Drawing.Point(286, 4);
            this.FormCloser.Margin = new System.Windows.Forms.Padding(4);
            this.FormCloser.Name = "FormCloser";
            this.FormCloser.Size = new System.Drawing.Size(27, 25);
            this.FormCloser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormCloser.TabIndex = 8;
            this.FormCloser.TabStop = false;
            this.FormCloser.Zoom = 10;
            this.FormCloser.Click += new System.EventHandler(this.FormCloser_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phenomena", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Цвет элементов цправления : ";
            // 
            // sliderRed
            // 
            this.sliderRed.BackColor = System.Drawing.Color.Transparent;
            this.sliderRed.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sliderRed.BorderRadius = 0;
            this.sliderRed.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderRed.Location = new System.Drawing.Point(12, 84);
            this.sliderRed.Margin = new System.Windows.Forms.Padding(5);
            this.sliderRed.MaximumValue = 255;
            this.sliderRed.Name = "sliderRed";
            this.sliderRed.Size = new System.Drawing.Size(165, 35);
            this.sliderRed.SliderRadius = 0;
            this.sliderRed.TabIndex = 11;
            this.sliderRed.Value = 222;
            this.sliderRed.ValueChanged += new System.EventHandler(this.colorChanger_BackColor);
            // 
            // sliderGreen
            // 
            this.sliderGreen.BackColor = System.Drawing.Color.Transparent;
            this.sliderGreen.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sliderGreen.BorderRadius = 0;
            this.sliderGreen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.sliderGreen.Location = new System.Drawing.Point(12, 129);
            this.sliderGreen.Margin = new System.Windows.Forms.Padding(5);
            this.sliderGreen.MaximumValue = 255;
            this.sliderGreen.Name = "sliderGreen";
            this.sliderGreen.Size = new System.Drawing.Size(165, 35);
            this.sliderGreen.SliderRadius = 0;
            this.sliderGreen.TabIndex = 12;
            this.sliderGreen.Value = 140;
            this.sliderGreen.ValueChanged += new System.EventHandler(this.colorChanger_BackColor);
            // 
            // sliderBlue
            // 
            this.sliderBlue.BackColor = System.Drawing.Color.Transparent;
            this.sliderBlue.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sliderBlue.BorderRadius = 0;
            this.sliderBlue.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.sliderBlue.Location = new System.Drawing.Point(12, 174);
            this.sliderBlue.Margin = new System.Windows.Forms.Padding(5);
            this.sliderBlue.MaximumValue = 255;
            this.sliderBlue.Name = "sliderBlue";
            this.sliderBlue.Size = new System.Drawing.Size(165, 35);
            this.sliderBlue.SliderRadius = 0;
            this.sliderBlue.TabIndex = 13;
            this.sliderBlue.Value = 51;
            this.sliderBlue.ValueChanged += new System.EventHandler(this.colorChanger_BackColor);
            // 
            // buttonApplyColor
            // 
            this.buttonApplyColor.Activecolor = System.Drawing.Color.DarkGray;
            this.buttonApplyColor.BackColor = System.Drawing.Color.DarkGray;
            this.buttonApplyColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApplyColor.BorderRadius = 0;
            this.buttonApplyColor.ButtonText = "Принять";
            this.buttonApplyColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApplyColor.DisabledColor = System.Drawing.Color.Gray;
            this.buttonApplyColor.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonApplyColor.Iconimage = null;
            this.buttonApplyColor.Iconimage_right = null;
            this.buttonApplyColor.Iconimage_right_Selected = null;
            this.buttonApplyColor.Iconimage_Selected = null;
            this.buttonApplyColor.IconMarginLeft = 0;
            this.buttonApplyColor.IconMarginRight = 0;
            this.buttonApplyColor.IconRightVisible = true;
            this.buttonApplyColor.IconRightZoom = 0D;
            this.buttonApplyColor.IconVisible = true;
            this.buttonApplyColor.IconZoom = 90D;
            this.buttonApplyColor.IsTab = false;
            this.buttonApplyColor.Location = new System.Drawing.Point(195, 137);
            this.buttonApplyColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonApplyColor.Name = "buttonApplyColor";
            this.buttonApplyColor.Normalcolor = System.Drawing.Color.DarkGray;
            this.buttonApplyColor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonApplyColor.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonApplyColor.selected = false;
            this.buttonApplyColor.Size = new System.Drawing.Size(103, 36);
            this.buttonApplyColor.TabIndex = 15;
            this.buttonApplyColor.Text = "Принять";
            this.buttonApplyColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonApplyColor.Textcolor = System.Drawing.Color.White;
            this.buttonApplyColor.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonApplyColor.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // colorChanger
            // 
            this.colorChanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.colorChanger.Location = new System.Drawing.Point(195, 84);
            this.colorChanger.Margin = new System.Windows.Forms.Padding(4);
            this.colorChanger.Name = "colorChanger";
            this.colorChanger.Size = new System.Drawing.Size(103, 54);
            this.colorChanger.TabIndex = 14;
            this.colorChanger.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Activecolor = System.Drawing.Color.DarkGray;
            this.buttonReset.BackColor = System.Drawing.Color.DarkGray;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReset.BorderRadius = 0;
            this.buttonReset.ButtonText = "Сбросить";
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.DisabledColor = System.Drawing.Color.Gray;
            this.buttonReset.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonReset.Iconimage = null;
            this.buttonReset.Iconimage_right = null;
            this.buttonReset.Iconimage_right_Selected = null;
            this.buttonReset.Iconimage_Selected = null;
            this.buttonReset.IconMarginLeft = 0;
            this.buttonReset.IconMarginRight = 0;
            this.buttonReset.IconRightVisible = true;
            this.buttonReset.IconRightZoom = 0D;
            this.buttonReset.IconVisible = true;
            this.buttonReset.IconZoom = 90D;
            this.buttonReset.IsTab = false;
            this.buttonReset.Location = new System.Drawing.Point(195, 173);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Normalcolor = System.Drawing.Color.DarkGray;
            this.buttonReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonReset.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonReset.selected = false;
            this.buttonReset.Size = new System.Drawing.Size(103, 36);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonReset.Textcolor = System.Drawing.Color.White;
            this.buttonReset.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phenomena", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Путь сохранения файлов : ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(13, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 78);
            this.label4.TabIndex = 18;
            this.label4.Text = "C:\\Users\\kYzPC\\Downloads";
            // 
            // buttonSaveDomain
            // 
            this.buttonSaveDomain.Activecolor = System.Drawing.Color.DarkGray;
            this.buttonSaveDomain.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSaveDomain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveDomain.BorderRadius = 0;
            this.buttonSaveDomain.ButtonText = "Сохранить";
            this.buttonSaveDomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDomain.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSaveDomain.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSaveDomain.Iconimage = null;
            this.buttonSaveDomain.Iconimage_right = null;
            this.buttonSaveDomain.Iconimage_right_Selected = null;
            this.buttonSaveDomain.Iconimage_Selected = null;
            this.buttonSaveDomain.IconMarginLeft = 0;
            this.buttonSaveDomain.IconMarginRight = 0;
            this.buttonSaveDomain.IconRightVisible = true;
            this.buttonSaveDomain.IconRightZoom = 0D;
            this.buttonSaveDomain.IconVisible = true;
            this.buttonSaveDomain.IconZoom = 90D;
            this.buttonSaveDomain.IsTab = false;
            this.buttonSaveDomain.Location = new System.Drawing.Point(12, 424);
            this.buttonSaveDomain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSaveDomain.Name = "buttonSaveDomain";
            this.buttonSaveDomain.Normalcolor = System.Drawing.Color.DarkGray;
            this.buttonSaveDomain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonSaveDomain.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSaveDomain.selected = false;
            this.buttonSaveDomain.Size = new System.Drawing.Size(286, 36);
            this.buttonSaveDomain.TabIndex = 19;
            this.buttonSaveDomain.Text = "Сохранить";
            this.buttonSaveDomain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSaveDomain.Textcolor = System.Drawing.Color.White;
            this.buttonSaveDomain.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonSaveDomain.Click += new System.EventHandler(this.buttonSaveDomain_Click);
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.Activecolor = System.Drawing.Color.DarkGray;
            this.buttonSaveFolder.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSaveFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveFolder.BorderRadius = 0;
            this.buttonSaveFolder.ButtonText = "Обзор";
            this.buttonSaveFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFolder.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSaveFolder.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSaveFolder.Iconimage = null;
            this.buttonSaveFolder.Iconimage_right = null;
            this.buttonSaveFolder.Iconimage_right_Selected = null;
            this.buttonSaveFolder.Iconimage_Selected = null;
            this.buttonSaveFolder.IconMarginLeft = 0;
            this.buttonSaveFolder.IconMarginRight = 0;
            this.buttonSaveFolder.IconRightVisible = true;
            this.buttonSaveFolder.IconRightZoom = 0D;
            this.buttonSaveFolder.IconVisible = true;
            this.buttonSaveFolder.IconZoom = 90D;
            this.buttonSaveFolder.IsTab = false;
            this.buttonSaveFolder.Location = new System.Drawing.Point(12, 388);
            this.buttonSaveFolder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Normalcolor = System.Drawing.Color.DarkGray;
            this.buttonSaveFolder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonSaveFolder.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSaveFolder.selected = false;
            this.buttonSaveFolder.Size = new System.Drawing.Size(286, 36);
            this.buttonSaveFolder.TabIndex = 20;
            this.buttonSaveFolder.Text = "Обзор";
            this.buttonSaveFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSaveFolder.Textcolor = System.Drawing.Color.White;
            this.buttonSaveFolder.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonSaveFolder.Click += new System.EventHandler(this.buttonSaveFolder_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(313, 488);
            this.Controls.Add(this.buttonSaveFolder);
            this.Controls.Add(this.buttonSaveDomain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApplyColor);
            this.Controls.Add(this.colorChanger);
            this.Controls.Add(this.sliderBlue);
            this.Controls.Add(this.sliderGreen);
            this.Controls.Add(this.sliderRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsPage";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private ns1.BunifuImageButton FormCloser;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuTrackbar sliderRed;
        private ns1.BunifuTrackbar sliderGreen;
        private ns1.BunifuTrackbar sliderBlue;
        private ns1.BunifuFlatButton buttonApplyColor;
        private System.Windows.Forms.PictureBox colorChanger;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuFlatButton buttonReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuFlatButton buttonSaveDomain;
        private BunifuFlatButton buttonSaveFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}