
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
            this.captureScreenButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captureWindowButton = new System.Windows.Forms.Button();
            this.screenSelector = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureScreenButton
            // 
            this.captureScreenButton.Location = new System.Drawing.Point(20, 8);
            this.captureScreenButton.Name = "captureScreenButton";
            this.captureScreenButton.Size = new System.Drawing.Size(108, 23);
            this.captureScreenButton.TabIndex = 0;
            this.captureScreenButton.Text = "Capture Screen";
            this.captureScreenButton.UseVisualStyleBackColor = true;
            this.captureScreenButton.Click += new System.EventHandler(this.captureScreenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(254, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(335, 8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.screenSelector);
            this.panel1.Controls.Add(this.captureWindowButton);
            this.panel1.Controls.Add(this.captureScreenButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 42);
            this.panel1.TabIndex = 3;
            // 
            // captureWindowButton
            // 
            this.captureWindowButton.Location = new System.Drawing.Point(134, 8);
            this.captureWindowButton.Name = "captureWindowButton";
            this.captureWindowButton.Size = new System.Drawing.Size(114, 23);
            this.captureWindowButton.TabIndex = 3;
            this.captureWindowButton.Text = "Capture Window";
            this.captureWindowButton.UseVisualStyleBackColor = true;
            this.captureWindowButton.Click += new System.EventHandler(this.captureWindowButton_Click);
            // 
            // screenSelector
            // 
            this.screenSelector.FormattingEnabled = true;
            this.screenSelector.Location = new System.Drawing.Point(416, 9);
            this.screenSelector.Name = "screenSelector";
            this.screenSelector.Size = new System.Drawing.Size(121, 23);
            this.screenSelector.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 211);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(580, 250);
            this.Name = "Form1";
            this.Text = "Screen Capture Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureScreenButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button captureWindowButton;
        private System.Windows.Forms.ComboBox screenSelector;
    }
}

