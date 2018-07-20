using System;
using System.Drawing;
using System.Windows.Forms;
using AudioPlayerProject;

namespace AudioPlayer
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
            sliderRed.Value = CustomColor.maincolor.R;
            sliderGreen.Value = CustomColor.maincolor.G;
            sliderBlue.Value = CustomColor.maincolor.B;
            colorChanger.BackColor = CustomColor.maincolor;
            label4.Text = Settings.Default.path;
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCloser_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void sliderRed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sliderGreen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sliderBlue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            CustomColor.SetMainColor(Color.FromArgb(sliderRed.Value, sliderGreen.Value, sliderBlue.Value));
            MainPageOfPlayer.UpdateButtonImage();
            (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["ButtonAdd"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.add);
            (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonDelete"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.delete);
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["ButtonPlay"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.Circled_Play_100px);
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["ButtonStop"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.stop1);
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["ButtonPause"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.pause1);
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["ButtonSkipLeft"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.SkipLeft);
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["ButtonSkipRight"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.SkipRight);
            (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["ButtonSettings"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.settings);
            (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonMainList"] as ns1.BunifuFlatButton).Iconimage = CustomColor.FillShape(Properties.Resources.list);
            (Application.OpenForms["MainPageOfPlayer"].Controls["menu"].Controls["buttonMainList"] as ns1.BunifuFlatButton).Text = "   Основной плейлист";
            (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["buttonDownload"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.Download);

            if ((Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["buttonMute"] as ns1.BunifuImageButton).Image == Properties.Resources.No_audio)
            {
                (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["buttonMute"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.No_audio);
            }
            else
            {
                (Application.OpenForms["MainPageOfPlayer"].Controls["bottomPanel"].Controls["buttonMute"] as ns1.BunifuImageButton).Image = CustomColor.FillShape(Properties.Resources.yes_audio);
            }
        }

        private void colorChanger_BackColor(object sender, EventArgs e)
        {
            colorChanger.BackColor = Color.FromArgb(sliderRed.Value, sliderGreen.Value, sliderBlue.Value);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            sliderRed.Value = CustomColor.defaultcolor.R;
            sliderGreen.Value = CustomColor.defaultcolor.G;
            sliderBlue.Value = CustomColor.defaultcolor.B;
            colorChanger.BackColor = CustomColor.defaultcolor;
            buttonApply_Click(this, new EventArgs());
        }

        private void buttonSaveDomain_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath != "" && folderBrowserDialog1.SelectedPath != null)
            {
                Settings.Default.path = folderBrowserDialog1.SelectedPath + "\\";
                Settings.Default.Save();
            }
        }

        private void buttonSaveFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }
    }
}
