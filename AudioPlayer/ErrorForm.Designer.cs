namespace AudioPlayer
{
    partial class ErrorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.buttonOK = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 35);
            this.panel1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Activecolor = System.Drawing.Color.DarkGray;
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOK.BorderRadius = 0;
            this.buttonOK.ButtonText = "OK";
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.DisabledColor = System.Drawing.Color.Black;
            this.buttonOK.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonOK.Iconimage = null;
            this.buttonOK.Iconimage_right = null;
            this.buttonOK.Iconimage_right_Selected = null;
            this.buttonOK.Iconimage_Selected = null;
            this.buttonOK.IconMarginLeft = 0;
            this.buttonOK.IconMarginRight = 0;
            this.buttonOK.IconRightVisible = true;
            this.buttonOK.IconRightZoom = 0D;
            this.buttonOK.IconVisible = true;
            this.buttonOK.IconZoom = 90D;
            this.buttonOK.IsTab = false;
            this.buttonOK.Location = new System.Drawing.Point(139, 200);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Normalcolor = System.Drawing.Color.Silver;
            this.buttonOK.OnHovercolor = System.Drawing.Color.DarkGray;
            this.buttonOK.OnHoverTextColor = System.Drawing.Color.Black;
            this.buttonOK.selected = false;
            this.buttonOK.Size = new System.Drawing.Size(155, 41);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOK.Textcolor = System.Drawing.Color.Black;
            this.buttonOK.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Phenomena Light", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.MaximumSize = new System.Drawing.Size(405, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 156);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(429, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuFlatButton buttonOK;
        private System.Windows.Forms.Label label1;
    }
}