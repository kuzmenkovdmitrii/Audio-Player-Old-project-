using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AudioPlayerProject;

namespace AudioPlayer
{
    public partial class VkLogIn : Form
    {
        int idProgramm = 2890984; //2685278;

        public VkLogIn()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Visible = false;
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=" + idProgramm + "&display=popup&redirect_uri=https://oauth.vk.com/blank.html&scope=audio,offline,&response_type=token&v=5.64");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.text == "Email / Номер телефона")
                textBoxLogin.text = string.Empty;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.text == "Пароль")
                textBoxPassword.text = string.Empty;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("email").SetAttribute("value", textBoxLogin.text);
                webBrowser1.Document.GetElementById("pass").SetAttribute("value", textBoxPassword.text);
                webBrowser1.Document.GetElementById("install_allow").InvokeMember("click");

                if (bunifuCheckbox1.Checked)
                {
                    VkAuthLog.SetSave(true);
                }

                Thread.Sleep(2000);
                if (!VkAuthLog.GetAuth())
                {
                    webBrowser1.Visible = true;
                }

            }
            catch (NullReferenceException)
            {
                if (webBrowser1.Url.ToString().Contains("oauth.vk.com/error?err=2"))
                {
                    buttonLogout_Click(this, new EventArgs());
                }
                webBrowser1.Visible = false;
            }
            catch
            {
                ErrorForm erForm = new ErrorForm("Ошибка авторизации, попробуйте позже");
                buttonLogout_Click(this, new EventArgs());
            }

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser1.Navigate("m.vk.com");
            Thread.Sleep(500);
            webBrowser1.Navigate("https://login.vk.com/?act=logout_mobile&hash=4640faef262489f22b&_origin=https%3A%2F%2Fm.vk.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = webBrowser1.Url.ToString();
            if (url.IndexOf("#") > -1)
            {
                string l = url.Split('#')[1];
                if (l[0] == 'a')
                {
                    VkAuthLog.SetToken(l.Split('&')[0].Split('=')[1]);
                    VkAuthLog.SetId(l.Split('=')[3].Split('&')[0]);
                    VkAuthLog.SetAuth(true);
                    string firstname = ApiRequest.GetRequest("https://api.vk.com/method/account.getProfileInfo?owner_id=" + VkAuthLog.GetId() + "&need_user=0&access_token=" + VkAuthLog.GetToken(), "first_name");
                    string lastname = ApiRequest.GetRequest("https://api.vk.com/method/account.getProfileInfo?owner_id=" + VkAuthLog.GetId() + "&need_user=0&access_token=" + VkAuthLog.GetToken(), "last_name");
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["soundCloud"] as Label).Location = new Point(46, 361);
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["imageSoundCloud"] as ns1.BunifuImageButton).Location = new Point(4, 363);
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonSearchSoundCloud"] as ns1.BunifuFlatButton).Location = new Point(0, 406);
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonLoginVk"] as ns1.BunifuFlatButton).Visible = false;
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonListVk"] as ns1.BunifuFlatButton).Visible = true;
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonFavoritesVk"] as ns1.BunifuFlatButton).Visible = true;
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonSearchVK"] as ns1.BunifuFlatButton).Visible = true;
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["vkCom"] as Label).Text = firstname + " " + lastname;
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["vkCom"] as Label).Font = new Font("Phenomena", 12.25F);
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["vkCom"] as Label).Location = new Point(46, 140);
                    (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonLogoutVk"] as ns1.BunifuImageButton).Visible = true;
                    VkAudioClass.MyTracklist = ApiRequest.GetTracklistVK("https://api.vk.com/method/audio.get?owner_id=" + VkAuthLog.GetId() + "&need_user=0&access_token=" + VkAuthLog.GetToken());
                    this.Close();
                }
            }
        }
    }
}
