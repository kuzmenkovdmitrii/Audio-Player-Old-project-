using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AudioPlayer.Properties;
using AudioPlayerProject;

namespace AudioPlayer
{
    public partial class MainPageOfPlayer : Form
    {
        int memoryVolume;

        public MainPageOfPlayer()
        {
            InitializeComponent();

            if (!InternetChecker.ConnectionAvailable("https://www.google.by/"))
            {
                ErrorForm erForm = new ErrorForm("Отсутствует соединение с интернетом. Часть функционала программы недоступна. Попробуйте позже.");
                erForm.ShowDialog();
                buttonVK.Visible = false;
                vkCom.Visible = false;
                buttonLoginVk.Visible = false;
                imageSoundCloud.Visible = false;
                soundCloud.Visible = false;
                buttonSearchSoundCloud.Visible = false;
            }

            if (Settings.Default.red == 0 && Settings.Default.green == 0 && Settings.Default.blue == 0)
            {
                CustomColor.maincolor = CustomColor.defaultcolor;
            }
            else
            {
                CustomColor.maincolor = Color.FromArgb(Settings.Default.red, Settings.Default.green, Settings.Default.blue);
            }

            BassClass.InitBass(BassClass.HZ);
            openFileDialog1.Filter = TrackBase.GetInputFormats();
            ButtonAdd.Image = CustomColor.FillShape(Properties.Resources.add);
            buttonDelete.Image = CustomColor.FillShape(Properties.Resources.delete);
            ButtonPlay.Image = CustomColor.FillShape(Properties.Resources.Circled_Play_100px);
            ButtonStop.Image = CustomColor.FillShape(Properties.Resources.stop1);
            ButtonPause.Image = CustomColor.FillShape(Properties.Resources.pause1);
            ButtonSkipLeft.Image = CustomColor.FillShape(Properties.Resources.SkipLeft);
            ButtonSkipRight.Image = CustomColor.FillShape(Properties.Resources.SkipRight);
            ButtonSettings.Image = CustomColor.FillShape(Properties.Resources.settings);
            ButtonSettings.Image = CustomColor.FillShape(Properties.Resources.settings);
            buttonVK.Image = CustomColor.ColoredObject(Properties.Resources.VK_com_100px, Color.FromArgb(80, 114, 153));
            buttonLogoutVk.Image = CustomColor.ColoredObject(Properties.Resources.logout, Color.FromArgb(80, 114, 153));
            buttonMute.Image = CustomColor.FillShape(Properties.Resources.yes_audio);
            streamTrackBar.UseCustomBackColor = true;
            streamTrackBar.UseCustomForeColor = true;
            streamTrackBar.ForeColor = CustomColor.defaultcolor;

            playlist.Size = new Size(1088, 609);
            playlist.Location = new Point(52, 47);
            searchTextBox.Visible = false;
            buttonSearchStartVK.Visible = false;
            buttonDelete.Visible = true;
            buttonDownload.Visible = false;

            soundCloud.Location = new Point(46, 224);
            imageSoundCloud.Location = new Point(4, 226);
            buttonSearchSoundCloud.Location = new Point(0, 271);
            if (!VkAuthLog.GetAuth())
            {
                buttonLogoutVk.Visible = false;
            }

            vkCom.Font = new Font("Phenomena", 16.25F);
            vkCom.Location = new Point(46, 133);

            buttonDownload.Image = CustomColor.FillShape(Properties.Resources.Download);

            if (Settings.Default.path == "" || Settings.Default.path == null)
            {
                Settings.Default.path = TrackBase.AppPath;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                TrackBase.Files.Add(tmp[i]);
                TagClass TM = new TagClass(tmp[i]);
                if (TM.title != "")
                {
                    playlist.Items.Add(TM.artist + " - " + TM.title);
                }
                else
                {
                    playlist.Items.Add(TM.artist);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassClass.GetPosOfStream(BassClass.Stream)).ToString();
            streamTrackBar.Value = BassClass.GetPosOfStream(BassClass.Stream);

            if (BassClass.ToNextTrack())
            {
                playlist.SelectedIndex = TrackBase.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(BassClass.GetPosOfStream(BassClass.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassClass.GetTimeOfStream(BassClass.Stream)).ToString();
                streamTrackBar.Maximum = BassClass.GetTimeOfStream(BassClass.Stream);
                streamTrackBar.Value = BassClass.GetPosOfStream(BassClass.Stream);
            }

            if (BassClass.EndPlayList)
            {
                ButtonStop_Click(this, new EventArgs());
                playlist.SelectedIndex = TrackBase.CurrentTrackNumber = 0;
                BassClass.EndPlayList = false;
            }
        }

        private void FormHider_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormCloser_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            BassClass.Volume = 100;
            if (playlist.Items.Count != 0 && playlist.SelectedIndex != -1)
            {
                string current;
                TrackBase.CurrentTrackNumber = playlist.SelectedIndex;
                int index = playlist.SelectedIndex;
                if (VkAudioClass.ListOpened)
                {
                    current = VkAudioClass.MyTracklist[index].url;
                    BassClass.PlayURL(current, BassClass.Volume);
                }
                else if (SoundCloud.ListOpened)
                {
                    current = (SoundCloud.MyTracklist[index].stream_url + "?client_id=" + SoundCloud.clientID);
                    BassClass.PlayURL(current, BassClass.Volume);
                }
                else
                {
                    current = TrackBase.Files[index];
                    BassClass.Play(current, BassClass.Volume);
                }
                label1.Text = TimeSpan.FromSeconds(BassClass.GetPosOfStream(BassClass.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassClass.GetTimeOfStream(BassClass.Stream)).ToString();
                streamTrackBar.Maximum = BassClass.GetTimeOfStream(BassClass.Stream);
                streamTrackBar.Value = BassClass.GetPosOfStream(BassClass.Stream);
                timer1.Enabled = true;
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            BassClass.Stop();
            timer1.Enabled = false;
            streamTrackBar.Value = 0;
            label1.Text = "00:00:00";
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            TrackBase.CurrentTrackNumber = playlist.SelectedIndex;
            BassClass.Pause();
        }

        private void ButtonSkipLeft_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.SelectedIndex -= 1;
                ButtonPlay_Click(this, new EventArgs());
            }
            catch (ArgumentOutOfRangeException)
            {
                playlist.SelectedIndex = 0;
                ButtonPlay_Click(this, new EventArgs());
            }
        }

        private void ButtonSkipRight_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.SelectedIndex += 1;
                ButtonPlay_Click(this, new EventArgs());
            }
            catch (ArgumentOutOfRangeException)
            {
                if (playlist.SelectedIndex != -1)
                {
                    playlist.SelectedIndex = 0;
                    ButtonPlay_Click(this, new EventArgs());
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            buttonMainList_Click(this, new EventArgs());
            openFileDialog1.ShowDialog();
            streamTrackBar.Value = 0;
            label1.Text = "00:00:00";
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsform = new SettingsPage();
            settingsform.ShowDialog();
        }

        void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        public static void UpdateButtonImage()
        {

        }

        private void buttonMenuSlider_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (menu.Width <= 60)
                {
                    menu.Width = 300;
                }
                else
                {
                    menuSlider.HideSync(menu);
                    menu.Width = 44;
                    menuSlider.ShowSync(menu);
                }
            });
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenuSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (menu.Width <= 60)
            {
                buttonMenuSlider.Image = Properties.Resources.Less_Than_RightWhiteNew;
            }
            else
            {
                buttonMenuSlider.Image = Properties.Resources.Less_Than_LeftWhiteNew;
            }
        }

        private void buttonMenuSlider_MouseLeave(object sender, EventArgs e)
        {
            if (menu.Width <= 60)
            {
                buttonMenuSlider.Image = Properties.Resources.Less_Than_RightBlackNew;
            }
            else
            {
                buttonMenuSlider.Image = Properties.Resources.Less_Than_LeftBlackNew;
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            VkLogIn vkLogining = new VkLogIn();
            vkLogining.ShowDialog();
        }

        private void buttonLogoutVk_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser1 = new WebBrowser();
            webBrowser1.Navigate("m.vk.com");
            Thread.Sleep(1000);
            webBrowser1.Navigate("https://login.vk.com/?act=logout_mobile&hash=4640faef262489f22b&_origin=https%3A%2F%2Fm.vk.com");
            buttonListVk.Visible = false;
            buttonFavoritesVk.Visible = false;
            buttonLoginVk.Visible = true;
            buttonLogoutVk.Visible = false;
            buttonSearchVK.Visible = false;
            vkCom.Text = "VK.COM";
            vkCom.Font = new Font("Phenomena", 16.25F);
            vkCom.Location = new Point(46, 133);

            soundCloud.Location = new Point(46, 224);
            imageSoundCloud.Location = new Point(4, 226);
            buttonSearchSoundCloud.Location = new Point(0, 271);

            VkAuthLog.SetAuth(false);
            VkAuthLog.SetId("");
            VkAuthLog.SetToken("");
            VkAuthLog.SetSave(false);
        }

        private void streamTrackBar_ValueChanged(object sender, EventArgs e)
        {
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BassClass.SetVolumeToStream(BassClass.Stream, volumeTrackBar.Value);
        }

        private void buttonListVk_Click(object sender, EventArgs e)
        {
            buttonDownload.Visible = true;
            SoundCloud.ListOpened = true;
            buttonSearchStartSoundCloud.Visible = false;
            playlist.Size = new Size(1088, 609);
            playlist.Location = new Point(52, 47);
            searchTextBox.Visible = false;
            buttonSearchStartVK.Visible = false;
            buttonDelete.Visible = false;

            VkAudioClass.PlayListFiles = VkAudioClass.MyTracklist;
            VkAudioClass.ListOpened = true;
            playlist.Items.Clear();
            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < VkAudioClass.PlayListFiles.Count; i++)
                {
                    playlist.Items.Add(VkAudioClass.PlayListFiles[i].artist + " - " + VkAudioClass.PlayListFiles[i].title);
                }
            });
        }

        private void buttonMainList_Click(object sender, EventArgs e)
        {
            playlist.Size = new Size(1088, 609);
            playlist.Location = new Point(52, 47);
            searchTextBox.Visible = false;
            buttonSearchStartVK.Visible = false;
            buttonSearchStartSoundCloud.Visible = false;
            buttonDelete.Visible = true;
            buttonDownload.Visible = false;

            VkAudioClass.ListOpened = false;
            SoundCloud.ListOpened = false;
            playlist.Items.Clear();
            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < TrackBase.Files.Count; i++)
                {
                    TagClass TM = new TagClass(TrackBase.Files[i]);
                    if (TM.title != "")
                    {
                        playlist.Items.Add(TM.artist + " - " + TM.title);
                    }
                    else
                    {
                        playlist.Items.Add(TM.artist);
                    }
                }
            });
        }

        private void streamTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            BassClass.SetPosOfScroll(BassClass.Stream, streamTrackBar.Value);
        }

        private void buttonSearchVK_Click(object sender, EventArgs e)
        {
            SoundCloud.ListOpened = true;
            searchTextBox.ForeColor = Color.FromArgb(70, 104, 143);
            playlist.Size = new Size(1088, 551);
            playlist.Location = new Point(52, 97);
            searchTextBox.Visible = true;
            buttonSearchStartVK.Visible = true;
            buttonSearchStartSoundCloud.Visible = false;
            buttonDelete.Visible = false;
            buttonDownload.Visible = true;
        }

        private void buttonSearchStart_Click(object sender, EventArgs e)
        {
            VkAudioClass.ListOpened = true;
            playlist.Items.Clear();
            string search = searchTextBox.text;
            VkAudioClass.SearchFiles = ApiRequest.GetTracklistVK("https://api.vk.com/method/audio.search" + "?q=" + search + "&auto_complete=1&sort=2&count=50&offset=0&access_token=" + VkAuthLog.GetToken());
            VkAudioClass.PlayListFiles = VkAudioClass.SearchFiles;

            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < VkAudioClass.PlayListFiles.Count; i++)
                {
                    playlist.Items.Add(VkAudioClass.PlayListFiles[i].artist + " - " + VkAudioClass.PlayListFiles[i].title);
                }
            });
        }

        private void buttonFavoritesVk_Click(object sender, EventArgs e)
        {
            SoundCloud.ListOpened = true;
            playlist.Size = new Size(1088, 609);
            playlist.Location = new Point(52, 47);
            searchTextBox.Visible = false;
            buttonSearchStartVK.Visible = false;
            buttonSearchStartSoundCloud.Visible = false;
            buttonDelete.Visible = false;
            buttonDownload.Visible = true;

            if (VkAudioClass.FavoritesFiles!= null)
            {
                VkAudioClass.PlayListFiles = VkAudioClass.FavoritesFiles;
                playlist.Items.Clear();
                this.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < VkAudioClass.PlayListFiles.Count; i++)
                    {
                        playlist.Items.Add(VkAudioClass.PlayListFiles[i].artist + " - " + VkAudioClass.PlayListFiles[i].title);
                    }
                });
            }
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (!BassClass.MuteStatus)
            {
                BassClass.MuteStatus = true;
                buttonMute.Image = CustomColor.FillShape(Properties.Resources.No_audio);
                memoryVolume = volumeTrackBar.Value;
                volumeTrackBar.Value = 0;
            }
            else
            {
                BassClass.MuteStatus = false;
                buttonMute.Image = CustomColor.FillShape(Properties.Resources.yes_audio);
                volumeTrackBar.Value = memoryVolume;
            }
        }

        private void buttonSearchStartSoundCloud_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                playlist.Items.Clear();
                SoundCloud.SearchList = ApiRequest.GetTracklistSoundcloud("http://api.soundcloud.com/tracks.json?q=" + searchTextBox.text + "&offset=50&client_id=" + SoundCloud.clientID);
                SoundCloud.MyTracklist = SoundCloud.SearchList;
                for (int i = 0; i < SoundCloud.MyTracklist.Count; i++)
                {
                    SoundCloud.MyTracklist[i].CorectArtist();
                    SoundCloud.MyTracklist[i].CorectTitle();

                    if (SoundCloud.MyTracklist[i].artist != "" && SoundCloud.MyTracklist[i].artist != null && SoundCloud.MyTracklist[i].title != "" && SoundCloud.MyTracklist[i].title != null)
                    {
                        playlist.Items.Add(SoundCloud.MyTracklist[i].artist + " - " + SoundCloud.MyTracklist[i].title);
                    }
                    else
                    {
                        playlist.Items.Add(SoundCloud.MyTracklist[i].buferTitle);
                    }
                }
            });
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int bufer = playlist.SelectedIndex;
            if (playlist.SelectedIndex != -1)
            {
                TrackBase.Files.RemoveAt(playlist.SelectedIndex);
                if (BassClass.isStoped)
                {
                    ButtonStop_Click(this, new EventArgs());
                    label2.Text = "00:00:00";
                    playlist.Items.RemoveAt(playlist.SelectedIndex);
                }
                else if (BassClass.isPaused)
                {
                    playlist.Items.RemoveAt(playlist.SelectedIndex);
                }
                else if (!BassClass.isPaused && !BassClass.isStoped)
                {
                    playlist.Items.RemoveAt(playlist.SelectedIndex);
                    playlist.SelectedIndex = bufer - 1;
                    ButtonSkipRight_Click(this, new EventArgs());
                }
                if (playlist.Items.Count == 0)
                {
                    ButtonStop_Click(this, new EventArgs());
                }
            }
        }

        private void MainPageOfPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.red = CustomColor.maincolor.R;
            Settings.Default.green = CustomColor.maincolor.G;
            Settings.Default.blue = CustomColor.maincolor.B;
            Settings.Default.Save();
            if (!VkAuthLog.GetSave() && VkAuthLog.GetAuth())
            {
                buttonLogoutVk_Click(this, new EventArgs());
            }
            else
            {
                VkAuthLog.Save();
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (!UrlDownloader.DownloadStatus)
            {
                if (playlist.SelectedIndex != -1)
                {
                    string directory = Settings.Default.path;
                    string filename;
                    if (SoundCloud.MyTracklist[playlist.SelectedIndex].artist != "" && SoundCloud.MyTracklist[playlist.SelectedIndex].artist != null && SoundCloud.MyTracklist[playlist.SelectedIndex].title != "" && SoundCloud.MyTracklist[playlist.SelectedIndex].title != null)
                    {
                        filename = String.Format("{0} - {1}.mp3", SoundCloud.MyTracklist[playlist.SelectedIndex].artist, SoundCloud.MyTracklist[playlist.SelectedIndex].title);
                    }
                    else
                    {
                        filename = String.Format("{0}.mp3", SoundCloud.MyTracklist[playlist.SelectedIndex].buferTitle);
                    }
                    UrlDownloader.Downloader(SoundCloud.MyTracklist[playlist.SelectedIndex].stream_url + "?client_id=" + SoundCloud.clientID, directory, filename);
                    UrlDownloader.webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                }
            }
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            UrlDownloader.DownloadStatus = false;
            string filename;

            if (SoundCloud.MyTracklist[playlist.SelectedIndex].artist != "" && SoundCloud.MyTracklist[playlist.SelectedIndex].artist != null && SoundCloud.MyTracklist[playlist.SelectedIndex].title != "" && SoundCloud.MyTracklist[playlist.SelectedIndex].title != null)
            {
                filename = String.Format("{0} - {1}.mp3", SoundCloud.MyTracklist[playlist.SelectedIndex].artist, SoundCloud.MyTracklist[playlist.SelectedIndex].title);
            }
            else
            {
                filename = String.Format("{0}.mp3", SoundCloud.MyTracklist[playlist.SelectedIndex].buferTitle);
            }

            ErrorForm completeForm = new ErrorForm(String.Format("Файл ({0}) был успешно скачан", filename));
            completeForm.ShowDialog();
        }

        private void buttonSearchSoundCloud_Click(object sender, EventArgs e)
        {
            playlist.Items.Clear();
            buttonSearchStartVK.Visible = false;
            buttonDelete.Visible = false;
            buttonDownload.Visible = true;
            if (SoundCloud.SearchList != null)
            {
                SoundCloud.MyTracklist = SoundCloud.SearchList;
                this.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < SoundCloud.MyTracklist.Count; i++)
                    {
                        SoundCloud.MyTracklist[i].CorectArtist();
                        SoundCloud.MyTracklist[i].CorectTitle();

                        if (SoundCloud.MyTracklist[i].artist != "" && SoundCloud.MyTracklist[i].artist != null && SoundCloud.MyTracklist[i].title != "" && SoundCloud.MyTracklist[i].title != null)
                        {
                            playlist.Items.Add(SoundCloud.MyTracklist[i].artist + " - " + SoundCloud.MyTracklist[i].title);
                        }
                        else
                        {
                            playlist.Items.Add(SoundCloud.MyTracklist[i].buferTitle);
                        }
                    }
                });
            }
            VkAudioClass.ListOpened = false;
            SoundCloud.ListOpened = true;
            buttonDelete.Visible = false;
            playlist.Size = new Size(1088, 551);
            playlist.Location = new Point(52, 97);
            buttonSearchStartSoundCloud.Visible = true;
            searchTextBox.Visible = true;
            searchTextBox.ForeColor = Color.FromArgb(255, 85, 0);
        }

        private void volumeTrackBar_Click(object sender, EventArgs e)
        {
            BassClass.MuteStatus = false;
            buttonMute.Image = CustomColor.FillShape(Resources.yes_audio);
        }

        private void playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ButtonPlay_Click(this, new EventArgs());
        }
    }
}
