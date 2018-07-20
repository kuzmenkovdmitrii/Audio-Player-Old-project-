using System;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string massege)
        {
            InitializeComponent();
            label1.Text = massege;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
