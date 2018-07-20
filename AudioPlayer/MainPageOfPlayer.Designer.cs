namespace AudioPlayer
{
    partial class MainPageOfPlayer
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageOfPlayer));
            this.playlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormHider = new ns1.BunifuImageButton();
            this.FormCloser = new ns1.BunifuImageButton();
            this.dragControlForHeader = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.dragControlForLogo = new ns1.BunifuDragControl(this.components);
            this.menu = new System.Windows.Forms.Panel();
            this.buttonDelete = new ns1.BunifuImageButton();
            this.buttonSearchSoundCloud = new ns1.BunifuFlatButton();
            this.soundCloud = new System.Windows.Forms.Label();
            this.imageSoundCloud = new ns1.BunifuImageButton();
            this.buttonSearchVK = new ns1.BunifuFlatButton();
            this.buttonLogoutVk = new ns1.BunifuImageButton();
            this.buttonFavoritesVk = new ns1.BunifuFlatButton();
            this.buttonMainList = new ns1.BunifuFlatButton();
            this.buttonLoginVk = new ns1.BunifuFlatButton();
            this.ButtonAdd = new ns1.BunifuImageButton();
            this.vkCom = new System.Windows.Forms.Label();
            this.buttonVK = new ns1.BunifuImageButton();
            this.buttonMenuSlider = new ns1.BunifuImageButton();
            this.ButtonSettings = new ns1.BunifuImageButton();
            this.buttonListVk = new ns1.BunifuFlatButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttonDownload = new ns1.BunifuImageButton();
            this.buttonMute = new ns1.BunifuImageButton();
            this.volumeTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.streamTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.ButtonPause = new ns1.BunifuImageButton();
            this.ButtonSkipLeft = new ns1.BunifuImageButton();
            this.ButtonPlay = new ns1.BunifuImageButton();
            this.ButtonSkipRight = new ns1.BunifuImageButton();
            this.ButtonStop = new ns1.BunifuImageButton();
            this.menuSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.buttonSearchStartVK = new ns1.BunifuFlatButton();
            this.buttonSearchStartSoundCloud = new ns1.BunifuFlatButton();
            this.searchTextBox = new ns1.BunifuTextbox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormHider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSoundCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogoutVk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenuSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSettings)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSkipLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSkipRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStop)).BeginInit();
            this.SuspendLayout();
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuSlider.SetDecoration(this.playlist, BunifuAnimatorNS.DecorationType.None);
            this.playlist.Font = new System.Drawing.Font("Phenomena", 14.25F);
            this.playlist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 29;
            this.playlist.Location = new System.Drawing.Point(52, 47);
            this.playlist.Margin = new System.Windows.Forms.Padding(4);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(1088, 609);
            this.playlist.TabIndex = 4;
            this.playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.menuSlider.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Phenomena", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.menuSlider.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Phenomena", 12F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(697, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.FormHider);
            this.header.Controls.Add(this.FormCloser);
            this.menuSlider.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1153, 35);
            this.header.TabIndex = 7;
            // 
            // logo
            // 
            this.menuSlider.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::AudioPlayer.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(-6, 3);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 31);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.menuSlider.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 17;
            // 
            // FormHider
            // 
            this.FormHider.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.FormHider, BunifuAnimatorNS.DecorationType.None);
            this.FormHider.Image = global::AudioPlayer.Properties.Resources._Minus_Math__32px;
            this.FormHider.ImageActive = null;
            this.FormHider.Location = new System.Drawing.Point(1093, 9);
            this.FormHider.Margin = new System.Windows.Forms.Padding(4);
            this.FormHider.Name = "FormHider";
            this.FormHider.Size = new System.Drawing.Size(27, 25);
            this.FormHider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormHider.TabIndex = 9;
            this.FormHider.TabStop = false;
            this.FormHider.Zoom = 10;
            this.FormHider.Click += new System.EventHandler(this.FormHider_Click);
            // 
            // FormCloser
            // 
            this.FormCloser.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.FormCloser, BunifuAnimatorNS.DecorationType.None);
            this.FormCloser.Image = global::AudioPlayer.Properties.Resources.Delete_50px_9;
            this.FormCloser.ImageActive = null;
            this.FormCloser.Location = new System.Drawing.Point(1123, 9);
            this.FormCloser.Margin = new System.Windows.Forms.Padding(4);
            this.FormCloser.Name = "FormCloser";
            this.FormCloser.Size = new System.Drawing.Size(27, 25);
            this.FormCloser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormCloser.TabIndex = 8;
            this.FormCloser.TabStop = false;
            this.FormCloser.Zoom = 10;
            this.FormCloser.Click += new System.EventHandler(this.FormCloser_Click);
            // 
            // dragControlForHeader
            // 
            this.dragControlForHeader.Fixed = true;
            this.dragControlForHeader.Horizontal = true;
            this.dragControlForHeader.TargetControl = this.header;
            this.dragControlForHeader.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dragControlForLogo
            // 
            this.dragControlForLogo.Fixed = true;
            this.dragControlForLogo.Horizontal = true;
            this.dragControlForLogo.TargetControl = this.logo;
            this.dragControlForLogo.Vertical = true;
            // 
            // menu
            // 
            this.menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menu.Controls.Add(this.buttonDelete);
            this.menu.Controls.Add(this.buttonSearchSoundCloud);
            this.menu.Controls.Add(this.soundCloud);
            this.menu.Controls.Add(this.imageSoundCloud);
            this.menu.Controls.Add(this.buttonSearchVK);
            this.menu.Controls.Add(this.buttonLogoutVk);
            this.menu.Controls.Add(this.buttonFavoritesVk);
            this.menu.Controls.Add(this.buttonMainList);
            this.menu.Controls.Add(this.buttonLoginVk);
            this.menu.Controls.Add(this.ButtonAdd);
            this.menu.Controls.Add(this.vkCom);
            this.menu.Controls.Add(this.buttonVK);
            this.menu.Controls.Add(this.buttonMenuSlider);
            this.menu.Controls.Add(this.ButtonSettings);
            this.menu.Controls.Add(this.buttonListVk);
            this.menuSlider.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Location = new System.Drawing.Point(0, 34);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(44, 638);
            this.menu.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonDelete, BunifuAnimatorNS.DecorationType.None);
            this.buttonDelete.Image = global::AudioPlayer.Properties.Resources.delete;
            this.buttonDelete.ImageActive = null;
            this.buttonDelete.Location = new System.Drawing.Point(1, 545);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(40, 40);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Zoom = 7;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearchSoundCloud
            // 
            this.buttonSearchSoundCloud.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSearchSoundCloud.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundCloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchSoundCloud.BorderRadius = 0;
            this.buttonSearchSoundCloud.ButtonText = "   Поиск";
            this.buttonSearchSoundCloud.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuSlider.SetDecoration(this.buttonSearchSoundCloud, BunifuAnimatorNS.DecorationType.None);
            this.buttonSearchSoundCloud.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSearchSoundCloud.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundCloud.Iconimage = global::AudioPlayer.Properties.Resources.SearchSoundcloud;
            this.buttonSearchSoundCloud.Iconimage_right = null;
            this.buttonSearchSoundCloud.Iconimage_right_Selected = null;
            this.buttonSearchSoundCloud.Iconimage_Selected = null;
            this.buttonSearchSoundCloud.IconMarginLeft = 3;
            this.buttonSearchSoundCloud.IconMarginRight = 0;
            this.buttonSearchSoundCloud.IconRightVisible = false;
            this.buttonSearchSoundCloud.IconRightZoom = 0D;
            this.buttonSearchSoundCloud.IconVisible = true;
            this.buttonSearchSoundCloud.IconZoom = 62D;
            this.buttonSearchSoundCloud.IsTab = false;
            this.buttonSearchSoundCloud.Location = new System.Drawing.Point(0, 406);
            this.buttonSearchSoundCloud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchSoundCloud.Name = "buttonSearchSoundCloud";
            this.buttonSearchSoundCloud.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundCloud.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSearchSoundCloud.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchSoundCloud.selected = false;
            this.buttonSearchSoundCloud.Size = new System.Drawing.Size(302, 59);
            this.buttonSearchSoundCloud.TabIndex = 28;
            this.buttonSearchSoundCloud.Text = "   Поиск";
            this.buttonSearchSoundCloud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchSoundCloud.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchSoundCloud.TextFont = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchSoundCloud.Click += new System.EventHandler(this.buttonSearchSoundCloud_Click);
            // 
            // soundCloud
            // 
            this.soundCloud.AutoSize = true;
            this.menuSlider.SetDecoration(this.soundCloud, BunifuAnimatorNS.DecorationType.None);
            this.soundCloud.Font = new System.Drawing.Font("Phenomena", 16.25F);
            this.soundCloud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.soundCloud.Location = new System.Drawing.Point(46, 361);
            this.soundCloud.Name = "soundCloud";
            this.soundCloud.Size = new System.Drawing.Size(119, 34);
            this.soundCloud.TabIndex = 27;
            this.soundCloud.Text = "SoundCloud";
            // 
            // imageSoundCloud
            // 
            this.imageSoundCloud.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.imageSoundCloud, BunifuAnimatorNS.DecorationType.None);
            this.imageSoundCloud.Image = global::AudioPlayer.Properties.Resources.SoundCloud;
            this.imageSoundCloud.ImageActive = null;
            this.imageSoundCloud.Location = new System.Drawing.Point(4, 363);
            this.imageSoundCloud.Margin = new System.Windows.Forms.Padding(4);
            this.imageSoundCloud.Name = "imageSoundCloud";
            this.imageSoundCloud.Size = new System.Drawing.Size(35, 35);
            this.imageSoundCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSoundCloud.TabIndex = 26;
            this.imageSoundCloud.TabStop = false;
            this.imageSoundCloud.Zoom = 0;
            // 
            // buttonSearchVK
            // 
            this.buttonSearchVK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSearchVK.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchVK.BorderRadius = 0;
            this.buttonSearchVK.ButtonText = "   Поиск";
            this.buttonSearchVK.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuSlider.SetDecoration(this.buttonSearchVK, BunifuAnimatorNS.DecorationType.None);
            this.buttonSearchVK.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSearchVK.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSearchVK.Iconimage = global::AudioPlayer.Properties.Resources.Search;
            this.buttonSearchVK.Iconimage_right = null;
            this.buttonSearchVK.Iconimage_right_Selected = null;
            this.buttonSearchVK.Iconimage_Selected = null;
            this.buttonSearchVK.IconMarginLeft = 3;
            this.buttonSearchVK.IconMarginRight = 0;
            this.buttonSearchVK.IconRightVisible = false;
            this.buttonSearchVK.IconRightZoom = 0D;
            this.buttonSearchVK.IconVisible = true;
            this.buttonSearchVK.IconZoom = 62D;
            this.buttonSearchVK.IsTab = false;
            this.buttonSearchVK.Location = new System.Drawing.Point(0, 285);
            this.buttonSearchVK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchVK.Name = "buttonSearchVK";
            this.buttonSearchVK.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonSearchVK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSearchVK.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchVK.selected = false;
            this.buttonSearchVK.Size = new System.Drawing.Size(302, 59);
            this.buttonSearchVK.TabIndex = 25;
            this.buttonSearchVK.Text = "   Поиск";
            this.buttonSearchVK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchVK.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchVK.TextFont = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchVK.Visible = false;
            this.buttonSearchVK.Click += new System.EventHandler(this.buttonSearchVK_Click);
            // 
            // buttonLogoutVk
            // 
            this.buttonLogoutVk.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonLogoutVk, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogoutVk.ErrorImage = null;
            this.buttonLogoutVk.Image = global::AudioPlayer.Properties.Resources.logout;
            this.buttonLogoutVk.ImageActive = null;
            this.buttonLogoutVk.InitialImage = null;
            this.buttonLogoutVk.Location = new System.Drawing.Point(257, 134);
            this.buttonLogoutVk.Name = "buttonLogoutVk";
            this.buttonLogoutVk.Size = new System.Drawing.Size(35, 35);
            this.buttonLogoutVk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLogoutVk.TabIndex = 24;
            this.buttonLogoutVk.TabStop = false;
            this.buttonLogoutVk.Zoom = 10;
            this.buttonLogoutVk.Click += new System.EventHandler(this.buttonLogoutVk_Click);
            // 
            // buttonFavoritesVk
            // 
            this.buttonFavoritesVk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonFavoritesVk.BackColor = System.Drawing.Color.Transparent;
            this.buttonFavoritesVk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFavoritesVk.BorderRadius = 0;
            this.buttonFavoritesVk.ButtonText = "   Избранное";
            this.buttonFavoritesVk.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuSlider.SetDecoration(this.buttonFavoritesVk, BunifuAnimatorNS.DecorationType.None);
            this.buttonFavoritesVk.DisabledColor = System.Drawing.Color.Gray;
            this.buttonFavoritesVk.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonFavoritesVk.Iconimage = global::AudioPlayer.Properties.Resources.favorites21;
            this.buttonFavoritesVk.Iconimage_right = null;
            this.buttonFavoritesVk.Iconimage_right_Selected = null;
            this.buttonFavoritesVk.Iconimage_Selected = null;
            this.buttonFavoritesVk.IconMarginLeft = 3;
            this.buttonFavoritesVk.IconMarginRight = 0;
            this.buttonFavoritesVk.IconRightVisible = false;
            this.buttonFavoritesVk.IconRightZoom = 0D;
            this.buttonFavoritesVk.IconVisible = true;
            this.buttonFavoritesVk.IconZoom = 62D;
            this.buttonFavoritesVk.IsTab = false;
            this.buttonFavoritesVk.Location = new System.Drawing.Point(0, 229);
            this.buttonFavoritesVk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFavoritesVk.Name = "buttonFavoritesVk";
            this.buttonFavoritesVk.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonFavoritesVk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonFavoritesVk.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFavoritesVk.selected = false;
            this.buttonFavoritesVk.Size = new System.Drawing.Size(302, 59);
            this.buttonFavoritesVk.TabIndex = 23;
            this.buttonFavoritesVk.Text = "   Избранное";
            this.buttonFavoritesVk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavoritesVk.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonFavoritesVk.TextFont = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavoritesVk.Visible = false;
            this.buttonFavoritesVk.Click += new System.EventHandler(this.buttonFavoritesVk_Click);
            // 
            // buttonMainList
            // 
            this.buttonMainList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonMainList.BackColor = System.Drawing.Color.Transparent;
            this.buttonMainList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMainList.BorderRadius = 0;
            this.buttonMainList.ButtonText = "   Основной плейлист";
            this.buttonMainList.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuSlider.SetDecoration(this.buttonMainList, BunifuAnimatorNS.DecorationType.None);
            this.buttonMainList.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMainList.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMainList.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMainList.Iconimage")));
            this.buttonMainList.Iconimage_right = null;
            this.buttonMainList.Iconimage_right_Selected = null;
            this.buttonMainList.Iconimage_Selected = null;
            this.buttonMainList.IconMarginLeft = 3;
            this.buttonMainList.IconMarginRight = 0;
            this.buttonMainList.IconRightVisible = false;
            this.buttonMainList.IconRightZoom = 0D;
            this.buttonMainList.IconVisible = true;
            this.buttonMainList.IconZoom = 62D;
            this.buttonMainList.IsTab = false;
            this.buttonMainList.Location = new System.Drawing.Point(0, 52);
            this.buttonMainList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMainList.Name = "buttonMainList";
            this.buttonMainList.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonMainList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonMainList.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMainList.selected = false;
            this.buttonMainList.Size = new System.Drawing.Size(302, 59);
            this.buttonMainList.TabIndex = 22;
            this.buttonMainList.Text = "   Основной плейлист";
            this.buttonMainList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainList.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonMainList.TextFont = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainList.Click += new System.EventHandler(this.buttonMainList_Click);
            // 
            // buttonLoginVk
            // 
            this.buttonLoginVk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(153)))));
            this.buttonLoginVk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(153)))));
            this.buttonLoginVk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoginVk.BorderRadius = 0;
            this.buttonLoginVk.ButtonText = "Войти";
            this.buttonLoginVk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSlider.SetDecoration(this.buttonLoginVk, BunifuAnimatorNS.DecorationType.None);
            this.buttonLoginVk.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLoginVk.Font = new System.Drawing.Font("Phenomena", 12F);
            this.buttonLoginVk.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLoginVk.Iconimage = null;
            this.buttonLoginVk.Iconimage_right = null;
            this.buttonLoginVk.Iconimage_right_Selected = null;
            this.buttonLoginVk.Iconimage_Selected = null;
            this.buttonLoginVk.IconMarginLeft = 0;
            this.buttonLoginVk.IconMarginRight = 0;
            this.buttonLoginVk.IconRightVisible = true;
            this.buttonLoginVk.IconRightZoom = 0D;
            this.buttonLoginVk.IconVisible = true;
            this.buttonLoginVk.IconZoom = 90D;
            this.buttonLoginVk.IsTab = false;
            this.buttonLoginVk.Location = new System.Drawing.Point(52, 175);
            this.buttonLoginVk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLoginVk.Name = "buttonLoginVk";
            this.buttonLoginVk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(153)))));
            this.buttonLoginVk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonLoginVk.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLoginVk.selected = false;
            this.buttonLoginVk.Size = new System.Drawing.Size(184, 31);
            this.buttonLoginVk.TabIndex = 19;
            this.buttonLoginVk.Text = "Войти";
            this.buttonLoginVk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLoginVk.Textcolor = System.Drawing.Color.White;
            this.buttonLoginVk.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonLoginVk.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonAdd, BunifuAnimatorNS.DecorationType.None);
            this.ButtonAdd.Image = global::AudioPlayer.Properties.Resources.add;
            this.ButtonAdd.ImageActive = null;
            this.ButtonAdd.Location = new System.Drawing.Point(1, 497);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(40, 40);
            this.ButtonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.TabStop = false;
            this.ButtonAdd.Zoom = 7;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // vkCom
            // 
            this.menuSlider.SetDecoration(this.vkCom, BunifuAnimatorNS.DecorationType.None);
            this.vkCom.Font = new System.Drawing.Font("Phenomena", 16.25F);
            this.vkCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(153)))));
            this.vkCom.Location = new System.Drawing.Point(46, 133);
            this.vkCom.Name = "vkCom";
            this.vkCom.Size = new System.Drawing.Size(205, 34);
            this.vkCom.TabIndex = 18;
            this.vkCom.Text = "VK.COM";
            // 
            // buttonVK
            // 
            this.buttonVK.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonVK, BunifuAnimatorNS.DecorationType.None);
            this.buttonVK.Image = global::AudioPlayer.Properties.Resources.VK_com_100px;
            this.buttonVK.ImageActive = null;
            this.buttonVK.Location = new System.Drawing.Point(4, 134);
            this.buttonVK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVK.Name = "buttonVK";
            this.buttonVK.Size = new System.Drawing.Size(35, 35);
            this.buttonVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonVK.TabIndex = 17;
            this.buttonVK.TabStop = false;
            this.buttonVK.Zoom = 0;
            // 
            // buttonMenuSlider
            // 
            this.buttonMenuSlider.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMenuSlider.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuSlider.Image = global::AudioPlayer.Properties.Resources.Less_Than_RightBlackNew;
            this.buttonMenuSlider.ImageActive = null;
            this.buttonMenuSlider.Location = new System.Drawing.Point(16, 9);
            this.buttonMenuSlider.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenuSlider.Name = "buttonMenuSlider";
            this.buttonMenuSlider.Size = new System.Drawing.Size(20, 31);
            this.buttonMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMenuSlider.TabIndex = 10;
            this.buttonMenuSlider.TabStop = false;
            this.buttonMenuSlider.Zoom = 7;
            this.buttonMenuSlider.Click += new System.EventHandler(this.buttonMenuSlider_Click);
            this.buttonMenuSlider.MouseLeave += new System.EventHandler(this.buttonMenuSlider_MouseLeave);
            this.buttonMenuSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMenuSlider_MouseMove);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonSettings, BunifuAnimatorNS.DecorationType.None);
            this.ButtonSettings.Image = global::AudioPlayer.Properties.Resources.settings;
            this.ButtonSettings.ImageActive = null;
            this.ButtonSettings.Location = new System.Drawing.Point(1, 593);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(40, 40);
            this.ButtonSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonSettings.TabIndex = 16;
            this.ButtonSettings.TabStop = false;
            this.ButtonSettings.Zoom = 7;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonListVk
            // 
            this.buttonListVk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonListVk.BackColor = System.Drawing.Color.Transparent;
            this.buttonListVk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonListVk.BorderRadius = 0;
            this.buttonListVk.ButtonText = "   Плейлист в vk.com";
            this.buttonListVk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menuSlider.SetDecoration(this.buttonListVk, BunifuAnimatorNS.DecorationType.None);
            this.buttonListVk.DisabledColor = System.Drawing.Color.Gray;
            this.buttonListVk.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonListVk.Iconimage = global::AudioPlayer.Properties.Resources.list2;
            this.buttonListVk.Iconimage_right = null;
            this.buttonListVk.Iconimage_right_Selected = null;
            this.buttonListVk.Iconimage_Selected = null;
            this.buttonListVk.IconMarginLeft = 3;
            this.buttonListVk.IconMarginRight = 0;
            this.buttonListVk.IconRightVisible = false;
            this.buttonListVk.IconRightZoom = 0D;
            this.buttonListVk.IconVisible = true;
            this.buttonListVk.IconZoom = 62D;
            this.buttonListVk.IsTab = false;
            this.buttonListVk.Location = new System.Drawing.Point(0, 173);
            this.buttonListVk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListVk.Name = "buttonListVk";
            this.buttonListVk.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonListVk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonListVk.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buttonListVk.selected = false;
            this.buttonListVk.Size = new System.Drawing.Size(302, 59);
            this.buttonListVk.TabIndex = 21;
            this.buttonListVk.Text = "   Плейлист в vk.com";
            this.buttonListVk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListVk.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonListVk.TextFont = new System.Drawing.Font("Phenomena ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListVk.Visible = false;
            this.buttonListVk.Click += new System.EventHandler(this.buttonListVk_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bottomPanel.Controls.Add(this.buttonDownload);
            this.bottomPanel.Controls.Add(this.buttonMute);
            this.bottomPanel.Controls.Add(this.volumeTrackBar);
            this.bottomPanel.Controls.Add(this.streamTrackBar);
            this.bottomPanel.Controls.Add(this.ButtonPause);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.label2);
            this.bottomPanel.Controls.Add(this.ButtonSkipLeft);
            this.bottomPanel.Controls.Add(this.ButtonPlay);
            this.bottomPanel.Controls.Add(this.ButtonSkipRight);
            this.bottomPanel.Controls.Add(this.ButtonStop);
            this.menuSlider.SetDecoration(this.bottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.bottomPanel.Location = new System.Drawing.Point(0, 669);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1153, 70);
            this.bottomPanel.TabIndex = 19;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonDownload, BunifuAnimatorNS.DecorationType.None);
            this.buttonDownload.Image = global::AudioPlayer.Properties.Resources.Download;
            this.buttonDownload.ImageActive = null;
            this.buttonDownload.Location = new System.Drawing.Point(3, 22);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(35, 35);
            this.buttonDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDownload.TabIndex = 30;
            this.buttonDownload.TabStop = false;
            this.buttonDownload.Zoom = 7;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.buttonMute, BunifuAnimatorNS.DecorationType.None);
            this.buttonMute.Image = global::AudioPlayer.Properties.Resources.yes_audio;
            this.buttonMute.ImageActive = null;
            this.buttonMute.Location = new System.Drawing.Point(1105, 18);
            this.buttonMute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(35, 35);
            this.buttonMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMute.TabIndex = 20;
            this.buttonMute.TabStop = false;
            this.buttonMute.Zoom = 5;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuSlider.SetDecoration(this.volumeTrackBar, BunifuAnimatorNS.DecorationType.None);
            this.volumeTrackBar.Location = new System.Drawing.Point(994, 25);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(93, 23);
            this.volumeTrackBar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.volumeTrackBar.TabIndex = 19;
            this.volumeTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volumeTrackBar.UseCustomBackColor = true;
            this.volumeTrackBar.Value = 100;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            this.volumeTrackBar.Click += new System.EventHandler(this.volumeTrackBar_Click);
            // 
            // streamTrackBar
            // 
            this.streamTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.streamTrackBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuSlider.SetDecoration(this.streamTrackBar, BunifuAnimatorNS.DecorationType.None);
            this.streamTrackBar.Location = new System.Drawing.Point(233, 25);
            this.streamTrackBar.Name = "streamTrackBar";
            this.streamTrackBar.Size = new System.Drawing.Size(459, 23);
            this.streamTrackBar.Style = MetroFramework.MetroColorStyle.Teal;
            this.streamTrackBar.TabIndex = 18;
            this.streamTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.streamTrackBar.UseCustomBackColor = true;
            this.streamTrackBar.Value = 0;
            this.streamTrackBar.ValueChanged += new System.EventHandler(this.streamTrackBar_ValueChanged);
            this.streamTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.streamTrackBar_Scroll);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonPause, BunifuAnimatorNS.DecorationType.None);
            this.ButtonPause.Image = global::AudioPlayer.Properties.Resources.pause1;
            this.ButtonPause.ImageActive = null;
            this.ButtonPause.Location = new System.Drawing.Point(903, 18);
            this.ButtonPause.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(35, 35);
            this.ButtonPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPause.TabIndex = 11;
            this.ButtonPause.TabStop = false;
            this.ButtonPause.Zoom = 5;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonSkipLeft
            // 
            this.ButtonSkipLeft.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonSkipLeft, BunifuAnimatorNS.DecorationType.None);
            this.ButtonSkipLeft.Image = global::AudioPlayer.Properties.Resources.SkipLeft;
            this.ButtonSkipLeft.ImageActive = null;
            this.ButtonSkipLeft.Location = new System.Drawing.Point(769, 22);
            this.ButtonSkipLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSkipLeft.Name = "ButtonSkipLeft";
            this.ButtonSkipLeft.Size = new System.Drawing.Size(27, 27);
            this.ButtonSkipLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSkipLeft.TabIndex = 14;
            this.ButtonSkipLeft.TabStop = false;
            this.ButtonSkipLeft.Zoom = 6;
            this.ButtonSkipLeft.Click += new System.EventHandler(this.ButtonSkipLeft_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonPlay, BunifuAnimatorNS.DecorationType.None);
            this.ButtonPlay.Image = global::AudioPlayer.Properties.Resources.Circled_Play_100px;
            this.ButtonPlay.ImageActive = null;
            this.ButtonPlay.Location = new System.Drawing.Point(845, 9);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(50, 50);
            this.ButtonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPlay.TabIndex = 10;
            this.ButtonPlay.TabStop = false;
            this.ButtonPlay.Zoom = 4;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonSkipRight
            // 
            this.ButtonSkipRight.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonSkipRight, BunifuAnimatorNS.DecorationType.None);
            this.ButtonSkipRight.Image = global::AudioPlayer.Properties.Resources.SkipRight;
            this.ButtonSkipRight.ImageActive = null;
            this.ButtonSkipRight.Location = new System.Drawing.Point(946, 22);
            this.ButtonSkipRight.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSkipRight.Name = "ButtonSkipRight";
            this.ButtonSkipRight.Size = new System.Drawing.Size(27, 27);
            this.ButtonSkipRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSkipRight.TabIndex = 13;
            this.ButtonSkipRight.TabStop = false;
            this.ButtonSkipRight.Zoom = 6;
            this.ButtonSkipRight.Click += new System.EventHandler(this.ButtonSkipRight_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.Transparent;
            this.menuSlider.SetDecoration(this.ButtonStop, BunifuAnimatorNS.DecorationType.None);
            this.ButtonStop.Image = global::AudioPlayer.Properties.Resources.stop1;
            this.ButtonStop.ImageActive = null;
            this.ButtonStop.Location = new System.Drawing.Point(804, 18);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(35, 35);
            this.ButtonStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonStop.TabIndex = 12;
            this.ButtonStop.TabStop = false;
            this.ButtonStop.Zoom = 5;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // menuSlider
            // 
            this.menuSlider.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.menuSlider.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuSlider.DefaultAnimation = animation1;
            // 
            // buttonSearchStartVK
            // 
            this.buttonSearchStartVK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonSearchStartVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonSearchStartVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchStartVK.BorderRadius = 0;
            this.buttonSearchStartVK.ButtonText = "Искать";
            this.buttonSearchStartVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSlider.SetDecoration(this.buttonSearchStartVK, BunifuAnimatorNS.DecorationType.None);
            this.buttonSearchStartVK.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonSearchStartVK.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSearchStartVK.Iconimage = null;
            this.buttonSearchStartVK.Iconimage_right = null;
            this.buttonSearchStartVK.Iconimage_right_Selected = null;
            this.buttonSearchStartVK.Iconimage_Selected = null;
            this.buttonSearchStartVK.IconMarginLeft = 0;
            this.buttonSearchStartVK.IconMarginRight = 0;
            this.buttonSearchStartVK.IconRightVisible = true;
            this.buttonSearchStartVK.IconRightZoom = 0D;
            this.buttonSearchStartVK.IconVisible = true;
            this.buttonSearchStartVK.IconZoom = 90D;
            this.buttonSearchStartVK.IsTab = false;
            this.buttonSearchStartVK.Location = new System.Drawing.Point(733, 42);
            this.buttonSearchStartVK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSearchStartVK.Name = "buttonSearchStartVK";
            this.buttonSearchStartVK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.buttonSearchStartVK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(133)))));
            this.buttonSearchStartVK.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSearchStartVK.selected = false;
            this.buttonSearchStartVK.Size = new System.Drawing.Size(155, 41);
            this.buttonSearchStartVK.TabIndex = 21;
            this.buttonSearchStartVK.Text = "Искать";
            this.buttonSearchStartVK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSearchStartVK.Textcolor = System.Drawing.Color.White;
            this.buttonSearchStartVK.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonSearchStartVK.Click += new System.EventHandler(this.buttonSearchStart_Click);
            // 
            // buttonSearchStartSoundCloud
            // 
            this.buttonSearchStartSoundCloud.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonSearchStartSoundCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonSearchStartSoundCloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchStartSoundCloud.BorderRadius = 0;
            this.buttonSearchStartSoundCloud.ButtonText = "Искать";
            this.buttonSearchStartSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSlider.SetDecoration(this.buttonSearchStartSoundCloud, BunifuAnimatorNS.DecorationType.None);
            this.buttonSearchStartSoundCloud.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonSearchStartSoundCloud.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSearchStartSoundCloud.Iconimage = null;
            this.buttonSearchStartSoundCloud.Iconimage_right = null;
            this.buttonSearchStartSoundCloud.Iconimage_right_Selected = null;
            this.buttonSearchStartSoundCloud.Iconimage_Selected = null;
            this.buttonSearchStartSoundCloud.IconMarginLeft = 0;
            this.buttonSearchStartSoundCloud.IconMarginRight = 0;
            this.buttonSearchStartSoundCloud.IconRightVisible = true;
            this.buttonSearchStartSoundCloud.IconRightZoom = 0D;
            this.buttonSearchStartSoundCloud.IconVisible = true;
            this.buttonSearchStartSoundCloud.IconZoom = 90D;
            this.buttonSearchStartSoundCloud.IsTab = false;
            this.buttonSearchStartSoundCloud.Location = new System.Drawing.Point(733, 42);
            this.buttonSearchStartSoundCloud.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSearchStartSoundCloud.Name = "buttonSearchStartSoundCloud";
            this.buttonSearchStartSoundCloud.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonSearchStartSoundCloud.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.buttonSearchStartSoundCloud.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSearchStartSoundCloud.selected = false;
            this.buttonSearchStartSoundCloud.Size = new System.Drawing.Size(155, 41);
            this.buttonSearchStartSoundCloud.TabIndex = 22;
            this.buttonSearchStartSoundCloud.Text = "Искать";
            this.buttonSearchStartSoundCloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSearchStartSoundCloud.Textcolor = System.Drawing.Color.White;
            this.buttonSearchStartSoundCloud.TextFont = new System.Drawing.Font("Phenomena", 13F);
            this.buttonSearchStartSoundCloud.Visible = false;
            this.buttonSearchStartSoundCloud.Click += new System.EventHandler(this.buttonSearchStartSoundCloud_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSlider.SetDecoration(this.searchTextBox, BunifuAnimatorNS.DecorationType.None);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(143)))));
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Location = new System.Drawing.Point(412, 42);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(303, 41);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.text = "";
            // 
            // MainPageOfPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1153, 739);
            this.Controls.Add(this.buttonSearchStartSoundCloud);
            this.Controls.Add(this.buttonSearchStartVK);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.Controls.Add(this.playlist);
            this.menuSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPageOfPlayer";
            this.Text = "AudioPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPageOfPlayer_FormClosed);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormHider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloser)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSoundCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogoutVk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenuSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSettings)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSkipLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSkipRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel header;
        private ns1.BunifuDragControl dragControlForHeader;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuImageButton FormCloser;
        private ns1.BunifuImageButton FormHider;
        private ns1.BunifuImageButton ButtonPlay;
        private ns1.BunifuImageButton ButtonPause;
        private ns1.BunifuImageButton ButtonStop;
        private ns1.BunifuImageButton ButtonSkipRight;
        private ns1.BunifuImageButton ButtonSkipLeft;
        private ns1.BunifuImageButton ButtonAdd;
        private System.Windows.Forms.PictureBox logo;
        private ns1.BunifuDragControl dragControlForLogo;
        private ns1.BunifuImageButton ButtonSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private BunifuAnimatorNS.BunifuTransition menuSlider;
        private ns1.BunifuImageButton buttonMenuSlider;
        private ns1.BunifuImageButton buttonVK;
        public System.Windows.Forms.Label vkCom;
        private ns1.BunifuFlatButton buttonLoginVk;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuFlatButton buttonListVk;
        private ns1.BunifuFlatButton buttonMainList;
        private ns1.BunifuFlatButton buttonFavoritesVk;
        private ns1.BunifuImageButton buttonLogoutVk;
        private MetroFramework.Controls.MetroTrackBar streamTrackBar;
        private System.Windows.Forms.Panel bottomPanel;
        private MetroFramework.Controls.MetroTrackBar volumeTrackBar;
        private ns1.BunifuFlatButton buttonSearchVK;
        private ns1.BunifuTextbox searchTextBox;
        private ns1.BunifuFlatButton buttonSearchStartVK;
        private ns1.BunifuImageButton buttonMute;
        private ns1.BunifuImageButton imageSoundCloud;
        public System.Windows.Forms.Label soundCloud;
        private ns1.BunifuFlatButton buttonSearchSoundCloud;
        private ns1.BunifuFlatButton buttonSearchStartSoundCloud;
        private ns1.BunifuImageButton buttonDelete;
        private ns1.BunifuImageButton buttonDownload;
    }
}