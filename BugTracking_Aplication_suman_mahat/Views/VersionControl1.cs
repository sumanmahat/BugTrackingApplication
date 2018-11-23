using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class VersionControl1 : Form
    {
        private ChromiumWebBrowser browser;
        public VersionControl1()
        {
            InitializeComponent();
            newBrowser();
        }

        private void VersionControl1_Load(object sender, EventArgs e)
        {

        }
        public void newBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://github.com/sumanmahat/BugTrackingApplication.git");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
