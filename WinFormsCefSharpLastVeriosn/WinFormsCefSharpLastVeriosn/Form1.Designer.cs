using CefSharp.WinForms;

namespace WinFormsCefSharpLastVeriosn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNavigate = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.btDevTools = new System.Windows.Forms.Button();
            this.pnWebBrowser = new System.Windows.Forms.Panel();
            browser = new ChromiumWebBrowser("https://www.google.com/");
            this.SuspendLayout();
            // 
            // btNavigate
            // 
            this.btNavigate.Location = new System.Drawing.Point(64, 38);
            this.btNavigate.Name = "btNavigate";
            this.btNavigate.Size = new System.Drawing.Size(310, 23);
            this.btNavigate.TabIndex = 0;
            this.btNavigate.Text = "Navigate";
            this.btNavigate.UseVisualStyleBackColor = true;
            this.btNavigate.Click += new System.EventHandler(this.btNavigate_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(64, 12);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(693, 20);
            this.tbURL.TabIndex = 1;
            this.tbURL.Text = "https://www.google.com/";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(18, 15);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(32, 13);
            this.lbURL.TabIndex = 2;
            this.lbURL.Text = "URL:";
            // 
            // btDevTools
            // 
            this.btDevTools.Location = new System.Drawing.Point(447, 38);
            this.btDevTools.Name = "btDevTools";
            this.btDevTools.Size = new System.Drawing.Size(310, 23);
            this.btDevTools.TabIndex = 3;
            this.btDevTools.Text = "Developer tools";
            this.btDevTools.UseVisualStyleBackColor = true;
            this.btDevTools.Click += new System.EventHandler(this.btDevTools_Click);
            // 
            // pnWebBrowser
            // 
            this.pnWebBrowser.Location = new System.Drawing.Point(21, 78);
            this.pnWebBrowser.Name = "pnWebBrowser";
            this.pnWebBrowser.Size = new System.Drawing.Size(736, 474);
            this.pnWebBrowser.TabIndex = 4;
            this.pnWebBrowser.Controls.Add(browser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 564);
            this.Controls.Add(this.pnWebBrowser);
            this.Controls.Add(this.btDevTools);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btNavigate);
            this.Name = "Form1";
            this.Text = "CefSharp Demo - version 90.6.70";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNavigate;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Button btDevTools;
        private System.Windows.Forms.Panel pnWebBrowser;
        private ChromiumWebBrowser browser;
    }
}

