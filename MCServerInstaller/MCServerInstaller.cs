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
        private static string Seed;
        private static string WorldType;
        private static string paperJar = "paper.jar";

        private static string[] ProgressLogLang = new string[] { "Downloading paper.jar...", "Creating start.bat...", "Agreeing to EULA...", "Creating server.properties...", "Copying server-icon.png...", "Getting IP... ", "IP found! Your IP is ", "Done! You can now close the program. " };

        private static readonly Image[] oxyBG = new Image[] { Properties.Resources.pride, Properties.Resources.pant };

        private static Uri paperUri;

        Image ResizedServerIcon = Properties.Resources.server_icon;

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
            WorldTypeDropdown.SelectedIndex = 0;

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
            if(!SkipPaperDownload.Checked)
            {
                ProgressLog.AppendText(ProgressLogLang[0]);
            }
            DownloadPaper(MCVersion, rootDir, progressBar);
        }

        private void OnPaperFinishedDownload(object sender, EventArgs e)
        {
            ContinueDoingShit();
        }

        private void ContinueDoingShit()
        {
            MOTD = MOTDTextBox.Text;
            Seed = SeedBox.Text;
            WorldType = WorldTypeDropdown.Text;

            ProgressLog.AppendText("\r\n" + ProgressLogLang[1]);
            File.WriteAllText(Path.Combine(rootDir, "start.bat"), "@echo off\r\njava -Xmx1024M -Xms1024M -jar " + paperJar + " nogui\r\npause");

            ProgressLog.AppendText("\r\n" + ProgressLogLang[2]);
            File.WriteAllText(Path.Combine(rootDir, "eula.txt"), "eula=true");

            ProgressLog.AppendText("\r\n" + ProgressLogLang[3]);
            File.WriteAllText(Path.Combine(rootDir, "server.properties"), "motd=" + MOTD + "\r\nspawn-protection=0" + "\r\nlevel-seed=" + Seed + "\r\nlevel-type=" + WorldType);

            ProgressLog.AppendText("\r\n" + ProgressLogLang[4]);
            ResizedServerIcon.Save(Path.Combine(rootDir, "server-icon.png"), ImageFormat.Png);

            string SerOpsJson = DoOpsJsonShit();
            File.WriteAllText(Path.Combine(rootDir, "ops.json"), SerOpsJson);

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

        private string DoOpsJsonShit()
        {
            if (OpPlayerList_User.Text != "")
            {
                List<UuidPlayer> opsJson = new List<UuidPlayer>();
                opsJson = new List<UuidPlayer>();
                try
                {
                    string[] Usernames = OpPlayerList_User.Text.Split(',');

                    foreach (string Username in Usernames)
                    {
                        PlayerUuid PlayerUuidJson = GetPlayerUuid(Username);

                        UuidPlayer uuidPlayer = new UuidPlayer
                        {
                            name = PlayerUuidJson.Name,
                            uuid = TrimmedUuidToFull(PlayerUuidJson.Id),
                            level = 4,
                            bypassesPlayerLimit = false
                        };

                        opsJson.Add(uuidPlayer);
                    }
                    string SerOpsJson = JsonConvert.SerializeObject(opsJson, Formatting.Indented);
                    return SerOpsJson;
                }
                catch
                {
                    MessageBox.Show("Player not found nerd");
                    return "[]";
                }
            }
            else
            {
                return "[]";
            }
        }

        private void DownloadPaper(string VersionNumber, string path, ProgressBar progress)
        {
            if (!SkipPaperDownload.Checked)
            {
                paperUri = new Uri("https://papermc.io/api/v1/paper/" + VersionNumber + "/latest/download");
                WebClient web = new WebClient();
                web.DownloadProgressChanged += (s, e) =>
                {
                    progress.Value = e.ProgressPercentage;
                };

                web.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(OnPaperFinishedDownload);
                web.DownloadFileAsync(paperUri, Path.Combine(path, paperJar));
                web.Dispose();
            }
            else
            {
                ContinueDoingShit();
            }
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
            label4.Text = "tiny plant";
            label5.Text = "nekopara icon goes here";
            label6.Text = "burger type";
            label8.Text = "op playbers (seperate by commas with no spaces nerd)";
            ServerIconBrowseButton.Text = "use eye";
            CopyIPCheckbox.Text = "copy doxxy numbers";
            SkipPaperDownload.Text = "no papercuts";
            FuckWyoming.Visible = true;

            FolderPathSaveFile.FileName = "cum.in.this.directory";
            FolderPathSaveFile.Title = "the cum directory";

            ProgressLogLang = new string[] { "downloading biblbe.jart...", "making epic gamer totally not virus rat...", "forging documents...", "typing gamer words into gamer file...", "applying porn to server icon...", "getting the 3 wacky numbers on the back... ", "IP found! Your IP is being set to russian hackers, also this \r\n", "kill program fatass" }; ;
            paperJar = "biblbe.jar";
        }

        private void LoadPaperVersions()
        {
            string paperJson;

            try
            {
                WebClient webClient = new WebClient();
                paperJson = webClient.DownloadString("https://papermc.io/api/v1/paper");
                webClient.Dispose();

                PaperVersions deserPaperJson = JsonConvert.DeserializeObject<PaperVersions>(paperJson);
                PaperVersion.Items.Clear();
                foreach (string item in deserPaperJson.Versions)
                {
                    PaperVersion.Items.Add(item);
                }
                PaperVersion.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Connect to the internet nerd");
                Environment.Exit(2);
            }
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

        private PlayerUuid GetPlayerUuid(string PlayerName)
        {
            string FunnyUrl = "https://api.mojang.com/users/profiles/minecraft/";

            WebClient web = new WebClient();
            string PlayerUuidJson = web.DownloadString(FunnyUrl + PlayerName);
            web.Dispose();
            if(PlayerUuidJson == "")
            {
                throw new PlayerNotFoundException();
            }
            PlayerUuid deserPlayerUuid = JsonConvert.DeserializeObject<PlayerUuid>(PlayerUuidJson);

            return deserPlayerUuid;
        }

        private void FuckWyoming_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string TrimmedUuidToFull(string TrimmedUuid)
        {
            TrimmedUuid = TrimmedUuid.Insert(8,"-");
            TrimmedUuid = TrimmedUuid.Insert(13, "-");
            TrimmedUuid = TrimmedUuid.Insert(18, "-");
            TrimmedUuid = TrimmedUuid.Insert(23, "-");
            return TrimmedUuid;
        }
    }

    public class PaperVersions
    {
        public string Project { get; set; }
        public IList<string> Versions { get; set; }
    }

    public class PlayerUuid
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class UuidPlayer
    {
        public string uuid { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public bool bypassesPlayerLimit { get; set; }
    }

    public class OpsJson
    {
        public IList<UuidPlayer> UuidPlayer { get; set; }
    }

    [Serializable]
    public class PlayerNotFoundException : Exception
    {
        public PlayerNotFoundException() { }
        public PlayerNotFoundException(string message) : base(message) { }
        public PlayerNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected PlayerNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
