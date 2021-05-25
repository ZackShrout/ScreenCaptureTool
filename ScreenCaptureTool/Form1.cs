using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCaptureTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GrabScreen()
        {
            Rectangle rect = Screen.PrimaryScreen.Bounds; // primary screen bounds... in case of multiple screens
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.CopyFromScreen(0, 0, 0, 0, rect.Size);
            this.BackgroundImage = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(5000);
            GrabScreen();
            this.Show();
            saveButton.Enabled = true;
        }
    }
}
