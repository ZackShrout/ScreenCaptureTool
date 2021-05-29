using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        GrabRegionForm grabForm;
        
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
            grabForm = new GrabRegionForm(this);
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
            // top corner coordinates for additional monitors could be less or more than 0,0
            // so it is necessary to use rect.x, rect.y for upper left corner
            image.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            //this.BackgroundImage = bitmap;
            imageCapture.Image = bitmap;
        }

        public void CaptureRect(Rectangle rectangle)
        {
            int rectangleWidth = rectangle.Width - rectangle.Left;
            int rectangleHeight = rectangle.Height - rectangle.Top;
            Bitmap bitmap = new Bitmap(rectangleWidth, rectangleHeight);
            Graphics image = Graphics.FromImage(bitmap);
            image.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, new Size(rectangleWidth, rectangleHeight));
            imageCapture.Image = bitmap;
        }
        
        private void GrabRegion()
        {
            this.Hide();
            grabForm.ShowDialog(this);
            MakeTopMost();
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
                //this.BackgroundImage = bitmap;
                imageCapture.Image = bitmap;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename;
            ImageFormat imageFormat;
            saveFileDialog.FileName = "";
            if (this.imageCapture.Image == null)
            {
                MessageBox.Show("No image to save!");
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                imageFormat = GetImageFormat(filename);
                this.imageCapture.Image.Save(filename, imageFormat);
            }
        }

        private ImageFormat GetImageFormat(string filename)
        {
            String extention = Path.GetExtension(filename).ToLower();
            ImageFormat imageFormat = ImageFormat.Bmp;
            if (extention != "")
            {
                switch (extention)
                {
                    case ".gif":
                        imageFormat = ImageFormat.Gif;
                        break;
                    case ".jpeg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    case ".tif":
                        imageFormat = ImageFormat.Tiff;
                        break;
                }
            }
            return imageFormat;
        }

        // ensure form is shown and has focus (otherwise it may not 'yield' to
        // activity (keystrokes, mouse clicks) in other apps...
        private void MakeTopMost()
        {
            this.TopMost = true;
            this.Show();
            //SendKeys.Send("{LEFT}");
            this.TopMost = false;
        }

    private void clearButton_Click(object sender, EventArgs e)
        {
            this.imageCapture.Image = null;
        }

        private void captureRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrabRegion();
        }

        private void captureWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(5000);
            GrabWindow();
            this.Show();
        }

        private void captureScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(5000);
            GrabScreen();
            this.Show();
        }

    }
}
