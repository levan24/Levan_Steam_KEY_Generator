using System;
using System.Threading;
using System.Windows.Forms;

namespace SteamGifKeyGenerator
{
    public partial class Main : Form
    {
        const String KEY_CHAR = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789";
        public Main()
        {
            InitializeComponent();
        }

        Random random = new Random();

        string GeneratePartKey()
        {

            String result = "";

            for (int i = 1; i <= 5; i++) result += KEY_CHAR[random.Next(0, KEY_CHAR.Length)];
            return result;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            KeyList.Clear();
        }

        private void Generate_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= KeyCounter.Value; i++)

                KeyList.Text += GeneratePartKey() + "-" + GeneratePartKey() + "-" + GeneratePartKey() + "\r\n";
            Thread.Sleep((int)KeyCounter.Value * 350);
                    MessageBox.Show("We Found the required (" + KeyCounter.Value + ") Keys. Enjoy!");

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)          //  The tray expands , when you click mouse twice.
        {
            SystemTrayIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Main_Resize(object sender, EventArgs e)                          // When you fold the program down it folds in tray and is seen icon and description.
        {
            if (WindowState == FormWindowState.Minimized)
            {
                SystemTrayIcon.Visible = true;
                this.Hide();
                SystemTrayIcon.BalloonTipText = "I'm Here! In a Tray "; // DateTime.Now.ToString("t") ; if you want to use time instead of text then use this.
                SystemTrayIcon.ShowBalloonTip(2000);    // In how many milliseconds will the notification be visible
            }
        }

        private void CloseMenu_MouseDown(object sender, MouseEventArgs e)
        {
            SystemTrayIcon.Dispose(); // We destroy the icon and then close the program.
            Application.Exit();
        }
    }
}
