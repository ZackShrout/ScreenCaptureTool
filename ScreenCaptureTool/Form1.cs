using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCaptureTool
{
    public partial class Form1 : Form
    {
        public int DWMWA_EXTENDED_FRAME_BOUNDS = 9;
        
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect);
        [DllImport("dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, 
                                                        ref Rectangle pvAttribute, int cbAttribute);
        
        public Form1()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                screenSelector.Items.Add(Screen.AllScreens[i].DeviceName);
            }
            screenSelector.Text = Screen.PrimaryScreen.DeviceName;
        }

        private void GrabScreen()
        {
            // Index into selected screen
            Rectangle rect = Screen.AllScreens[screenSelector.SelectedIndex].Bounds;
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height);
            Graphics image = Graphics.FromImage(bitmap);
            image.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            this.BackgroundImage = bitmap;
        }

        private void GrabWindow()
        {
            Rectangle rect = new Rectangle();
            IntPtr hWindow = GetForegroundWindow();
            int windowHeight;
            int windowWidth;
            Bitmap bitmap;
            Graphics image;
            if (hWindow != null)
            {
                // Check to see if Windows version is XP or below
                if (Environment.OSVersion.Version.Major < 6)
                {
                    GetWindowRect(hWindow, ref rect);
                }
                else
                {
                    // check to see if their is a window shadow, and if so, remove it
                    if (DwmGetWindowAttribute(hWindow, DWMWA_EXTENDED_FRAME_BOUNDS, ref rect, Marshal.SizeOf(typeof(Rectangle))) != 0)
                    {
                        GetWindowRect(hWindow, ref rect);
                    }
                }
                //GetWindowRect(hWindow, ref rect);
                windowWidth = rect.Width - rect.Left;
                windowHeight = rect.Height - rect.Top;
                bitmap = new Bitmap(windowWidth, windowHeight);
                image = Graphics.FromImage(bitmap);
                image.CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(windowWidth, windowHeight));
                this.BackgroundImage = bitmap;
            }
        }

        private void captureScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(5000);
            GrabScreen();
            this.Show();
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.BackgroundImage == null)
            {
                MessageBox.Show("No image to save!");
            }
            else
            {
                this.BackgroundImage.Save("testbitmap.bmp");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            saveButton.Enabled = false;
        }

        private void captureWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(5000);
            GrabWindow();
            this.Show();
            saveButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
