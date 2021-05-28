using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ScreenCaptureTool
{
    public partial class GrabRegionForm : Form
    {
        public Rectangle rectangle;
        public Form1 mainForm;

        public const int WM_NCLBUTTONDOWN = 0xA3;
        public const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int message, int wParam, int lParam);

        public GrabRegionForm(Form1 aForm)
        {
            InitializeComponent();
            mainForm = aForm;
        }

        // cause clicking and dragging on the window to move it as though caption bar had been clicked
        private void GrabRegionForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);
            this.Hide();
            mainForm.CaptureRect(rectangle);
            Close();
        }
    }
}
