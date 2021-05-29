
using System;

namespace ScreenCaptureTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screenSelector = new System.Windows.Forms.ComboBox();
            this.capturePanel = new System.Windows.Forms.Panel();
            this.imageCapture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.capturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.screenSelector);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 42);
            this.panel1.TabIndex = 3;
            // 
            // screenSelector
            // 
            this.screenSelector.FormattingEnabled = true;
            this.screenSelector.Location = new System.Drawing.Point(416, 9);
            this.screenSelector.Name = "screenSelector";
            this.screenSelector.Size = new System.Drawing.Size(121, 23);
            this.screenSelector.TabIndex = 4;
            // 
            // capturePanel
            // 
            this.capturePanel.AutoScroll = true;
            this.capturePanel.Controls.Add(this.imageCapture);
            this.capturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capturePanel.Location = new System.Drawing.Point(0, 24);
            this.capturePanel.Name = "capturePanel";
            this.capturePanel.Size = new System.Drawing.Size(564, 150);
            this.capturePanel.TabIndex = 4;
            // 
            // imageCapture
            // 
            this.imageCapture.Location = new System.Drawing.Point(0, 0);
            this.imageCapture.Name = "imageCapture";
            this.imageCapture.Size = new System.Drawing.Size(282, 141);
            this.imageCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageCapture.TabIndex = 0;
            this.imageCapture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.captureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureScreenToolStripMenuItem,
            this.captureWindowToolStripMenuItem,
            this.captureRegionToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // captureScreenToolStripMenuItem
            // 
            this.captureScreenToolStripMenuItem.Name = "captureScreenToolStripMenuItem";
            this.captureScreenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.captureScreenToolStripMenuItem.Text = "Capture Screen";
            this.captureScreenToolStripMenuItem.Click += new System.EventHandler(this.captureScreenToolStripMenuItem_Click);
            // 
            // captureWindowToolStripMenuItem
            // 
            this.captureWindowToolStripMenuItem.Name = "captureWindowToolStripMenuItem";
            this.captureWindowToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.captureWindowToolStripMenuItem.Text = "Capture Window";
            this.captureWindowToolStripMenuItem.Click += new System.EventHandler(this.captureWindowToolStripMenuItem_Click);
            // 
            // captureRegionToolStripMenuItem
            // 
            this.captureRegionToolStripMenuItem.Name = "captureRegionToolStripMenuItem";
            this.captureRegionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.captureRegionToolStripMenuItem.Text = "Capture Region";
            this.captureRegionToolStripMenuItem.Click += new System.EventHandler(this.captureRegionToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "gif";
            this.saveFileDialog.Filter = "Bitmap|*.bmp|Gif|*.gif|JPeg|*.jpeg|Png|*.png|Tiff|*.tif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 216);
            this.Controls.Add(this.capturePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(580, 255);
            this.Name = "Form1";
            this.Text = "Screen Capture Tool";
            this.panel1.ResumeLayout(false);
            this.capturePanel.ResumeLayout(false);
            this.capturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox screenSelector;
        private System.Windows.Forms.Panel capturePanel;
        private System.Windows.Forms.PictureBox imageCapture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureRegionToolStripMenuItem;
    }
}

