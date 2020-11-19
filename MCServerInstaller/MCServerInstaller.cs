using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MCServerInstaller
{
    public partial class MCServerInstaller : Form
    {
        private static string rootDir;
        private static string MCVersion;
        private static string MOTD;
        private static string paperJar = "paper.jar";

        private static string[] ProgressLogLang = new string[] { "Downloading paper.jar...", "Creating start.bat...", "Agreeing to EULA...", "Creating server.properties...", "Copying server-icon.png...", "Getting IP... ", "IP found! Your IP is ", "Done! You can now close the program. " };

        private static readonly Image[] oxyBG = new Image[] { Properties.Resources.pride, Properties.Resources.pant };

        private static Uri paperUri;

        Image ResizedServerIcon = Properties.Resources.server_icon;
        private string paperJson;

        public MCServerInstaller()
        {
            InitializeComponent();
        }

        private void FolderPathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderPathSaveFile.ShowDialog();
            FolderPathTextBox.Text = Path.GetDirectoryName(FolderPathSaveFile.FileName);
        }

        private void MCServerInstaller_Load(object sender, EventArgs e)
        {
            LoadPaperVersions();

            string burgerFile = Path.Combine(Application.StartupPath, "mmm burger.burger");
            if (File.Exists(burgerFile))
            {
                string burgerFileContents = File.ReadAllText(burgerFile);
                if (burgerFileContents == String.Concat(Enumerable.Repeat("m", 10000)))
                {
                    OxyMode();
                }
            }
        }

        private void FolderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            CreateButton.Enabled = true;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            rootDir = FolderPathTextBox.Text;
            MCVersion = PaperVersion.Text;

            TabControl.Enabled = false;
            CreateButton.Enabled = false;
            bool rootDirEmpty = IsDirectoryEmpty(rootDir);
            if (!rootDirEmpty)
            {
                DialogResult dialogueResult = MessageBox.Show("Directory is not empty! Are you sure you want to install paper there? (Pressing no will close the application)", "Directory not empty!", MessageBoxButtons.YesNo);
                if (dialogueResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            ProgressLog.AppendText(ProgressLogLang[0]);
            DownloadPaper(MCVersion, rootDir, progressBar);
        }

        private void ContinueDoingShit(object sender, EventArgs e)
        {
            MOTD = MOTDTextBox.Text;

            ProgressLog.AppendText("\r\n" + ProgressLogLang[1]);
            File.WriteAllText(Path.Combine(rootDir, "start.bat"), "@echo off\r\njava -Xmx1024M -Xms1024M -jar " + paperJar + " nogui\r\npause");

            ProgressLog.AppendText("\r\n" + ProgressLogLang[2]);
            File.WriteAllText(Path.Combine(rootDir, "eula.txt"), "eula=true");

            ProgressLog.AppendText("\r\n" + ProgressLogLang[3]);
            File.WriteAllText(Path.Combine(rootDir, "server.properties"), "motd=" + MOTD + "\r\nspawn-protection=0");

            ProgressLog.AppendText("\r\n" + ProgressLogLang[4]);
            ResizedServerIcon.Save(Path.Combine(rootDir, "server-icon.png"), ImageFormat.Png);

            if (CopyIPCheckbox.Checked)
            {
                ProgressLog.AppendText("\r\n" + ProgressLogLang[5]);
                WebClient web = new WebClient();
                web.DownloadStringCompleted += (s, ev) =>
                {
                    string IP = ev.Result;

                    Clipboard.SetText(IP);

                    ProgressLog.AppendText(ProgressLogLang[6] + IP);
                };
                web.DownloadStringAsync(new Uri("https://api.ipify.org"));
                web.Dispose();
            }

            MessageBox.Show(ProgressLogLang[7]);
        }

        private void DownloadPaper(string VersionNumber, string path, ProgressBar progress)
        {
            paperUri = new Uri("https://papermc.io/api/v1/paper/" + VersionNumber + "/latest/download");
            WebClient web = new WebClient();
            web.DownloadProgressChanged += (s, e) =>
            {
                progress.Value = e.ProgressPercentage;
            };

            web.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(ContinueDoingShit);
            web.DownloadFileAsync(paperUri, Path.Combine(path, paperJar));
            web.Dispose();
        }

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private void oxyMode_Click(object sender, EventArgs e)
        {
            OxyMode();
        }
        private void OxyMode()
        {
            // change bg
            Random randomNumberYes = new Random();
            int randomIntYes = randomNumberYes.Next(oxyBG.Length);
            this.BackgroundImage = oxyBG[randomIntYes];

            Extra.Text = "ex t ra setting s";
            tabPage1.Text = "base configgy";
            CreateButton.Text = "do the thing";
            this.Text = "roblox serber maker 9000";

            label1.Text = "storag place (cock craft servers)";
            FolderPathBrowseButton.Text = "use eyes nerd";
            label2.Text = "penis wisth";
            label3.Text = "BOTD (burger of the day)";
            CopyIPCheckbox.Text = "copy doxxy numbers";

            FolderPathSaveFile.FileName = "cum.in.this.directory";
            FolderPathSaveFile.Title = "the cum directory";

            ProgressLogLang = new string[] { "downloading biblbe.jart...", "making epic gamer totally not virus rat...", "forging documents...", "typing gamer words into gamer file...", "applying porn to server icon...", "getting the 3 wacky numbers on the back... ", "IP found! Your IP is being set to russian hackers, also this \r\n", "kill program fatass" }; ;
            paperJar = "biblbe.jar";
        }

        private void LoadPaperVersions()
        {
            WebClient webClient = new WebClient();
            try
            {
                paperJson = webClient.DownloadString("https://papermc.io/api/v1/paper");
                webClient.Dispose();
            }
            catch
            {
                MessageBox.Show("Connect to the internet nerd");
                Environment.Exit(2);
            }
            PaperVersions deserPaperJson = JsonConvert.DeserializeObject<PaperVersions>(paperJson);
            PaperVersion.Items.Clear();
            foreach (string item in deserPaperJson.Versions)
            {
                PaperVersion.Items.Add(item);
            }
            PaperVersion.SelectedIndex = 0;
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
                return destImage;
            }
        }

        private void ServerIconBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            ServerIconTextBox.Text = OpenFileDialog.FileName;
            try
            {
                ResizedServerIcon = ResizeImage(Image.FromFile(ServerIconTextBox.Text), 64, 64);
                ServerIconPreview.Image = ResizedServerIcon;
            }
            catch
            {
                MessageBox.Show("Not an Image file. Nice. ");
            }
        }
    }

    public class PaperVersions
    {
        public string Project { get; set; }
        public IList<string> Versions { get; set; }
    }
}