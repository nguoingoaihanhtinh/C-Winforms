using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class AddDownloadForm : Form
    {
        public string DownloadURL { get; private set; }
        public string DownloadDirectory { get; private set; }
        public AddDownloadForm()
        {
            InitializeComponent();
        }

        private void AddDownloadForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDownloadDirectory.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDownload_Click(object sender, EventArgs e)
        {
           // if (Uri.TryCreate(txtDownloadURL.Text, UriKind.Absolute, out var uri) && uri.Scheme == Uri.UriSchemeHttp)
            //{
                DownloadURL = txtDownloadURL.Text;
                DownloadDirectory = txtDownloadDirectory.Text;

                DialogResult = DialogResult.OK;
                Close();
           //}
            //else
           // {
            //    MessageBox.Show("Invalid URL. Please enter a valid HTTP URL.", "Error");
          // }
        }
    }
}
