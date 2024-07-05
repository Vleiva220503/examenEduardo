using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VideoCallForm : Form
    {
        private string callUrl;

        public VideoCallForm(string url)
        {
            InitializeComponent();
            callUrl = url;
        }

        private void VideoCallForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Navigating to: {callUrl}"); 
           // webBrowser1.Navigate(callUrl);
           webBrowser1.Navigate(callUrl);
        }
    }
}
