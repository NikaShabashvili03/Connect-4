
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConnectFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGame.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoadGame.Width, LoadGame.Height, 100, 100));
            Options.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Options.Width, Options.Height, 100, 100));
            creator.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, creator.Width, creator.Height, 20, 20));
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            GameScene gc = new GameScene();
            gc.Show();
            this.Hide();
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptionScreen op = new OptionScreen();
            op.Show();
            this.Hide();
        }

        private void MenuScreenClose(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void creator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://nikashabashvili-portfolio.vercel.app/",
                UseShellExecute = true
            });
        }
    }
}
