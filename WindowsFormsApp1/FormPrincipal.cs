using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        private DailyAPIClient dailyAPIClient;

        public FormPrincipal()
        {
            InitializeComponent();
            dailyAPIClient = new DailyAPIClient();
        }

        private void OpenVideoCall(string url)
        {
            var videoCallForm = new VideoCallForm(url);
            videoCallForm.Show();
        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            try
            {
                string roomName = dailyAPIClient.CreateRoom();
                if (!string.IsNullOrEmpty(roomName))
                {
                    string roomUrl = dailyAPIClient.GetRoomUrl(roomName);
                    txtCallUrl.Text = roomUrl;
                    btnCopyUrl.Enabled = true; 
                }
                else
                {
                    MessageBox.Show("Failed to create room. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create room: {ex.Message}");
            }
        }

        private void btnCopyUrl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCallUrl.Text))
            {
                Clipboard.SetText(txtCallUrl.Text);
                MessageBox.Show("URL copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No URL to copy.");
            }
        }

        private void btnGoToUrl_Click(object sender, EventArgs e)
        {
            string url = txtInputUrl.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        System.Diagnostics.Process.Start(url);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid URL");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open URL: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("please a valid url ");
            }
        }
    }
}
