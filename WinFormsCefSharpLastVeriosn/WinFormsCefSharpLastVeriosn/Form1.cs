using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;


namespace WinFormsCefSharpLastVeriosn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
