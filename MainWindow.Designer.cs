namespace LethalCompanyLauncher
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            MainButton = new Button();
            StatusText = new Label();
            StatusText2 = new Label();
            ProgressBar = new ProgressBar();
            _progressText = new Label();
            Logo = new PictureBox();
            HelpMenuButton = new PictureBox();
            HelpMenu = new Panel();
            HelpMenuText4 = new Label();
            HelpMenuText2 = new Label();
            HelpMenuText3 = new Label();
            LethalCompanyLocation = new TextBox();
            BrowseFolders = new Button();
            LethalCompanyLocationText = new Label();
            HelpMenuText = new Label();
            FolderBrowser = new FolderBrowserDialog();
            VersionText = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HelpMenuButton).BeginInit();
            HelpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainButton
            // 
            MainButton.BackColor = Color.Transparent;
            MainButton.ForeColor = SystemColors.Control;
            MainButton.Image = (Image)resources.GetObject("MainButton.Image");
            MainButton.Location = new Point(271, 181);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(250, 45);
            MainButton.TabIndex = 0;
            MainButton.Text = "Download Lethal Company";
            MainButton.UseVisualStyleBackColor = false;
            MainButton.Click += MainButtonClick;
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.BackColor = Color.Transparent;
            StatusText.ForeColor = SystemColors.Control;
            StatusText.Location = new Point(271, 236);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(42, 15);
            StatusText.TabIndex = 1;
            StatusText.Text = "Status:";
            // 
            // StatusText2
            // 
            StatusText2.AutoSize = true;
            StatusText2.BackColor = Color.Transparent;
            StatusText2.ForeColor = SystemColors.Control;
            StatusText2.Location = new Point(308, 236);
            StatusText2.Name = "StatusText2";
            StatusText2.Size = new Size(58, 15);
            StatusText2.TabIndex = 2;
            StatusText2.Text = "Unknown";
            // 
            // ProgressBar
            // 
            ProgressBar.ForeColor = SystemColors.Desktop;
            ProgressBar.Location = new Point(271, 254);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(250, 21);
            ProgressBar.TabIndex = 3;
            // 
            // _progressText
            // 
            _progressText.AutoSize = true;
            _progressText.BackColor = Color.Transparent;
            _progressText.ForeColor = SystemColors.Control;
            _progressText.Location = new Point(498, 236);
            _progressText.Name = "_progressText";
            _progressText.Size = new Size(23, 15);
            _progressText.TabIndex = 4;
            _progressText.Text = "0%";
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(257, 64);
            Logo.MaximumSize = new Size(380, 111);
            Logo.Name = "Logo";
            Logo.Size = new Size(278, 111);
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // HelpMenuButton
            // 
            HelpMenuButton.BackColor = Color.Transparent;
            HelpMenuButton.Image = (Image)resources.GetObject("HelpMenuButton.Image");
            HelpMenuButton.Location = new Point(759, 410);
            HelpMenuButton.Name = "HelpMenuButton";
            HelpMenuButton.Size = new Size(30, 31);
            HelpMenuButton.TabIndex = 6;
            HelpMenuButton.TabStop = false;
            HelpMenuButton.Click += HelpButtonClick;
            // 
            // HelpMenu
            // 
            HelpMenu.BackColor = Color.Transparent;
            HelpMenu.BackgroundImageLayout = ImageLayout.None;
            HelpMenu.BorderStyle = BorderStyle.FixedSingle;
            HelpMenu.Controls.Add(HelpMenuText4);
            HelpMenu.Controls.Add(HelpMenuText2);
            HelpMenu.Controls.Add(HelpMenuText3);
            HelpMenu.Controls.Add(LethalCompanyLocation);
            HelpMenu.Controls.Add(BrowseFolders);
            HelpMenu.Controls.Add(LethalCompanyLocationText);
            HelpMenu.Controls.Add(HelpMenuText);
            HelpMenu.ForeColor = SystemColors.Control;
            HelpMenu.Location = new Point(257, 53);
            HelpMenu.MaximumSize = new Size(335, 271);
            HelpMenu.Name = "HelpMenu";
            HelpMenu.Size = new Size(278, 271);
            HelpMenu.TabIndex = 6;
            HelpMenu.Visible = false;
            // 
            // HelpMenuText4
            // 
            HelpMenuText4.AutoSize = true;
            HelpMenuText4.Location = new Point(31, 49);
            HelpMenuText4.Name = "HelpMenuText4";
            HelpMenuText4.Size = new Size(213, 15);
            HelpMenuText4.TabIndex = 13;
            HelpMenuText4.Text = "Unzip the application before opening it";
            // 
            // HelpMenuText2
            // 
            HelpMenuText2.AutoSize = true;
            HelpMenuText2.Location = new Point(94, 19);
            HelpMenuText2.Name = "HelpMenuText2";
            HelpMenuText2.Size = new Size(69, 15);
            HelpMenuText2.TabIndex = 12;
            HelpMenuText2.Text = "Comments:";
            // 
            // HelpMenuText3
            // 
            HelpMenuText3.AutoSize = true;
            HelpMenuText3.Location = new Point(50, 34);
            HelpMenuText3.Name = "HelpMenuText3";
            HelpMenuText3.Size = new Size(167, 15);
            HelpMenuText3.TabIndex = 11;
            HelpMenuText3.Text = "Run app with admin privileges";
            // 
            // LethalCompanyLocation
            // 
            LethalCompanyLocation.Location = new Point(13, 97);
            LethalCompanyLocation.Name = "LethalCompanyLocation";
            LethalCompanyLocation.Size = new Size(221, 23);
            LethalCompanyLocation.TabIndex = 8;
            // 
            // BrowseFolders
            // 
            BrowseFolders.BackColor = SystemColors.Control;
            BrowseFolders.ForeColor = SystemColors.Desktop;
            BrowseFolders.Location = new Point(240, 96);
            BrowseFolders.Name = "BrowseFolders";
            BrowseFolders.Size = new Size(25, 24);
            BrowseFolders.TabIndex = 10;
            BrowseFolders.Text = "...";
            BrowseFolders.UseVisualStyleBackColor = false;
            BrowseFolders.Click += BrowseFoldersClick;
            // 
            // LethalCompanyLocationText
            // 
            LethalCompanyLocationText.AutoSize = true;
            LethalCompanyLocationText.ForeColor = Color.Transparent;
            LethalCompanyLocationText.Location = new Point(69, 79);
            LethalCompanyLocationText.Name = "LethalCompanyLocationText";
            LethalCompanyLocationText.Size = new Size(148, 15);
            LethalCompanyLocationText.TabIndex = 9;
            LethalCompanyLocationText.Text = "Lethal Company Directory:";
            // 
            // HelpMenuText
            // 
            HelpMenuText.AutoSize = true;
            HelpMenuText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            HelpMenuText.Location = new Point(94, -1);
            HelpMenuText.Name = "HelpMenuText";
            HelpMenuText.Size = new Size(82, 20);
            HelpMenuText.TabIndex = 4;
            HelpMenuText.Text = "Help Menu";
            // 
            // VersionText
            // 
            VersionText.AutoSize = true;
            VersionText.BackColor = Color.Transparent;
            VersionText.ForeColor = SystemColors.Control;
            VersionText.Location = new Point(12, 426);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(29, 15);
            VersionText.TabIndex = 9;
            VersionText.Text = "V1.4";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(VersionText);
            Controls.Add(HelpMenu);
            Controls.Add(HelpMenuButton);
            Controls.Add(Logo);
            Controls.Add(_progressText);
            Controls.Add(ProgressBar);
            Controls.Add(StatusText2);
            Controls.Add(StatusText);
            Controls.Add(MainButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            Name = "MainWindow";
            Text = "LC Launcher";
            FormClosing += MainWindowClose;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)HelpMenuButton).EndInit();
            HelpMenu.ResumeLayout(false);
            HelpMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainButton;
        private Label StatusText;
        private Label StatusText2;
        private ProgressBar ProgressBar;
        private Label _progressText;
        private PictureBox Logo;
        private PictureBox HelpMenuButton;
        private FolderBrowserDialog FolderBrowser;
        private Panel HelpMenu;
        private Label VersionText;
        private Label HelpMenuText;
        private Label HelpMenuText4;
        private Label HelpMenuText2;
        private Label HelpMenuText3;
        private Label LethalCompanyLocationText;
        private Button BrowseFolders;
        private TextBox LethalCompanyLocation;
    }
}
