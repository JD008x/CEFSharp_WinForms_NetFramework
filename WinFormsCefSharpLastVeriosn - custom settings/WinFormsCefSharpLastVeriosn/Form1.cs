using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WinFormsCefSharpLastVeriosn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Custom settings for cef browser.
            if (!Cef.IsInitialized)
            {
                CefSettings cefSettings = new CefSettings();
                cefSettings.BrowserSubprocessPath = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).Location) +
                    "\\CefSharp.BrowserSubprocess.exe";
                cefSettings.IgnoreCertificateErrors = true;
                cefSettings.LocalesDirPath = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).Location) +
                    "\\locales";
                cefSettings.ResourcesDirPath = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).Location);

                Cef.Initialize(cefSettings);
            }

            browser = new ChromiumWebBrowser(tbURL.Text);
            pnWebBrowser.Controls.Add(browser);
        }

        private void btNavigate_Click(object sender, EventArgs e)
        {
            browser.Load(this.tbURL.Text);
        }

        private void btDevTools_Click(object sender, EventArgs e)
        {
            browser.GetBrowser().ShowDevTools();
        }
    }
}
