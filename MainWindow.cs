using System.Net;
using System.IO.Compression;
using System.ComponentModel;

namespace LethalCompanyLauncher
{
    public partial class MainWindow : Form
    {
        private string _lethalCompany = "\\Lethal Company\\";
        private string _directory = "C:\\Games\\";
        private static string _link = "https://www.dropbox.com/scl/fi/cnr0qmijyqrz2hcfyeb9k/Lethal-Company.zip?rlkey=trg9ja7s7zyy05wdj7y2brv4d&dl=1";
        private const string _fileName = "\\Lethal Company.zip";
        private bool _installed = false;

        public MainWindow()
        {
            InitializeComponent();
            ReadData();
        }

        private void MainButtonClick(object sender, EventArgs e)
        {
            StartDownload(_link, _fileName);
        }

        private void HelpButtonClick(object sender, EventArgs e)
        {
            HelpMenu.Visible = !HelpMenu.Visible;
        }

        private void BrowseFoldersClick(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                _directory = FolderBrowser.SelectedPath;
                LethalCompanyLocation.Text = FolderBrowser.SelectedPath;
            }
        }

        private void MainWindowClose(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void StartDownload(string link, string fileName)
        {
            ReadData();
            if (Directory.Exists(_directory) && !_installed)
            {
                using (WebClient webClient = new WebClient())
                {
                    Uri uri = new Uri(link);
                    webClient.DownloadProgressChanged += ProgressChanged;
                    webClient.DownloadFileCompleted += DownloadCompleted;
                    webClient.DownloadFileA­sync(uri, _directory + fileName);
                }
                HelpMenu.Enabled = false;
                MainButton.Enabled = false;
                SaveData();
            }
            else if (!Directory.Exists(_directory))
            {
                StatusText2.Text = "Set Lethal Company Directory";
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            StatusText2.Text = "Downloading";
            ProgressBar.Value = e.ProgressPercentage;
            _progressText.Text = ProgressBar.Value.ToString() + "%";
        }

        private void DownloadCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            InstallingLethalCompany();
            StatusText2.Text = "Installed";
            _progressText.Text = "100%";
            MainButton.Text = "Lethal Company Installed";
            ProgressBar.Value = 100;
            _installed = true;
            HelpMenu.Enabled = true;
        }

        private void InstallingLethalCompany()
        {
            if (Directory.Exists(_directory + _lethalCompany))
            {
                Directory.Delete(_directory + _lethalCompany, true);
                InstallingLethalCompany();
            }

            if (!File.Exists(_directory + _lethalCompany + "Lethal Company.exe"))
            {
                ZipFile.ExtractToDirectory(_directory + _fileName, _directory);
            }
            File.Delete(_directory + _fileName);
            _installed = true;
        }

        private void SaveData()
        {
            if (!File.Exists("laucherData.data"))
            { 
                File.Create("laucherData.data"); 
            }
            else
            {
                if (!string.IsNullOrEmpty(LethalCompanyLocation.Text))
                { _directory = LethalCompanyLocation.Text; }

                using (StreamWriter streamWriter = new StreamWriter("laucherData.data"))
                {
                    streamWriter.WriteLine(LethalCompanyLocation.Text);
                    streamWriter.WriteLine(_installed);
                }
            }
        }

        private void ReadData()
        {
            if (File.Exists("laucherData.data") && new FileInfo("laucherData.data").Length != 0)
            {
                using (StreamReader streamReader = new StreamReader("laucherData.data"))
                {
                    _directory = streamReader.ReadLine();
                    _installed = Convert.ToBoolean(streamReader.ReadLine());
                }
                LethalCompanyLocation.Text = _directory;

                if (_installed)
                {
                    StatusText2.Text = "Installed";
                    _progressText.Text = "100%";
                    MainButton.Text = "Lethal Company Installed";
                    MainButton.Enabled = false;
                    ProgressBar.Value = 100;
                }
            }
            else
            { 
                _directory = FolderBrowser.SelectedPath; 
            }
        }
    }
}
