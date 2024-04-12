using SHDocVw;

namespace mfc_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)axWebBrowser1).BeginInit();
            SuspendLayout();
            // 
            // axWebBrowser1
            // 
            axWebBrowser1.Enabled = true;
            axWebBrowser1.Location = new Point(0, 0);
            axWebBrowser1.OcxState = (AxHost.State)resources.GetObject("axWebBrowser1.OcxState");
            axWebBrowser1.Size = new Size(300, 150);
            axWebBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWebBrowser1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)axWebBrowser1).EndInit();
            ResumeLayout(false);

            axWebBrowser1.Show();
        }

        #endregion

        private AxSHDocVw.AxWebBrowser axWebBrowser1;
    }
}
