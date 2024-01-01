
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class Form1 : Form
    {
        private List<DownloadItem> downloadItems = new List<DownloadItem>();
         private Dictionary<string, WebClient> activeDownloads = new Dictionary<string, WebClient>();
        //private Dictionary<string, TaskCompletionSource<bool>> downloadCompletionSources = new Dictionary<string, TaskCompletionSource<bool>>();



        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }
        private void InitializeListView()
        {
            listViewDownloads.View = View.Details;
            listViewDownloads.Columns.Add("File Name", 200);
            listViewDownloads.Columns.Add("Size", 100);
            listViewDownloads.Columns.Add("Progress", 100);
            listViewDownloads.Columns.Add("Speed", 100);
            listViewDownloads.Columns.Add("Status", 100);
            listViewDownloads.Columns.Add("URL", 300);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDownload_Click(object sender, EventArgs e)
        {
            using (var addDownloadForm = new AddDownloadForm())
            {
                if (addDownloadForm.ShowDialog() == DialogResult.OK)
                {
                    var downloadItem = new DownloadItem(addDownloadForm.DownloadURL, addDownloadForm.DownloadDirectory);
                    downloadItems.Add(downloadItem);
                    AddDownloadToListView(downloadItem);
                    Task.Run(() => DownloadFile(downloadItem));
                }
            }
        }
        private void AddDownloadToListView(DownloadItem downloadItem)
        {
            var listViewItem = new ListViewItem(new[]
            {
                downloadItem.FileName,
                downloadItem.Size,
                downloadItem.Progress,
                downloadItem.Speed,
                downloadItem.Status,
                downloadItem.URL
            });

            listViewDownloads.Items.Add(listViewItem);
        }

        private async void DownloadFile(DownloadItem downloadItem)
        {
            
            var client = new WebClient();

            client.DownloadProgressChanged += (s, e) =>
            {
                downloadItem.Progress = $"{e.ProgressPercentage}%";
                downloadItem.Speed = $"{e.BytesReceived / 1024} KB/s";
                UpdateListView(downloadItem);
            };

            client.DownloadFileCompleted += (s, e) =>
            {
                if (e.Cancelled)
                {
                    downloadItem.Status = "Cancelled";
                }
                else if (e.Error != null)
                {
                    downloadItem.Status = "Error";
                }
                else
                {
                    downloadItem.Status = "Completed";
                }

                UpdateListView(downloadItem);
                client.Dispose();
            };

            activeDownloads[downloadItem.FileName] = client;

            try
            {
                client.DownloadFileAsync(new Uri(downloadItem.URL), downloadItem.FileName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Download error: {ex.Message}");
                downloadItem.Status = "Error";
                UpdateListView(downloadItem);
                client.Dispose();
            }
            
            /*
            try
            {
                using (var client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    client.DownloadProgressChanged += (s, e) =>
                    {
                        downloadItem.Progress = $"{e.ProgressPercentage}%";
                        downloadItem.Speed = $"{e.BytesReceived / 1024} KB/s";
                        UpdateListView(downloadItem);
                    };

                    client.DownloadFileCompleted += (s, e) =>
                    {
                        if (e.Cancelled)
                        {
                            downloadItem.Status = "Cancelled";
                        }
                        else if (e.Error != null)
                        {
                            downloadItem.Status = "Error";
                        }
                        else
                        {
                            downloadItem.Status = "Completed";
                        }

                        UpdateListView(downloadItem);
                    };

                    await client.DownloadFileTaskAsync(new Uri(downloadItem.URL), downloadItem.FileName);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Download error: {ex.Message}");
                downloadItem.Status = "Error";
                UpdateListView(downloadItem);
            }
            */

        }

        private void UpdateListView(DownloadItem downloadItem)
        {
            listViewDownloads.BeginInvoke((MethodInvoker)delegate
            {
                var listViewItem = listViewDownloads.FindItemWithText(downloadItem.FileName);
                if (listViewItem != null)
                {
                    listViewItem.SubItems[2].Text = downloadItem.Progress;
                    listViewItem.SubItems[3].Text = downloadItem.Speed;
                    listViewItem.SubItems[4].Text = downloadItem.Status;
                }
            });
        }
        private void btnStopDownload_Click(object sender, EventArgs e)
        {
            if (listViewDownloads.SelectedItems.Count > 0)
            {
                var selectedDownloadItem = downloadItems[listViewDownloads.SelectedItems[0].Index];
                if (activeDownloads.TryGetValue(selectedDownloadItem.FileName, out var client))
                {
                    // Stop the download for the selected file
                    client.CancelAsync();
                    MessageBox.Show($"Stopping download for {selectedDownloadItem.FileName}", "Stop Download");
                }
            }
        }

    }
    public class DownloadItem
    {
        public string FileName { get; }
        public string Size { get; }
        public string Progress { get; set; }
        public string Speed { get; set; }
        public string Status { get; set; }
        public string URL { get; }

        public DownloadItem(string url, string downloadDirectory)
        {
            URL = url;
            FileName = Path.Combine(downloadDirectory, Path.GetFileName(new Uri(url).LocalPath));
            Size = GetFileSize(url);
            Progress = "0%";
            Speed = "0 KB/s";
            Status = "Downloading";
        }

        private string GetFileSize(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    long contentLength;
                    if (long.TryParse(response.Headers.Get("Content-Length"), out contentLength))
                    {
                        return $"{contentLength / 1024} KB";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error getting file size: {ex.Message}");
            }

            return "Unknown";
        }
    }
}
