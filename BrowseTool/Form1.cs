using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowseTool
{
    public partial class Form1 : Form
    {
        bool terminateonopen;
        public string urltogo;
        string exception;
        public Form1(string url, bool termiate, string urlexecption)
        {

            urltogo = url;
            exception = urlexecption;
            terminateonopen = termiate;

            InitializeComponent();


            //webBrowser1.AllowNavigation = true;
            //webBrowser1.ScriptErrorsSuppressed = true;
            //webBrowser1.Navigate(url);

        }

        private void webView23_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (exception == "BT-Clear")
            {
                webView23.CoreWebView2.Profile.ClearBrowsingDataAsync();
                System.Windows.Forms.MessageBox.Show("Saved Data Cleared", "BrowseTool");
                Environment.Exit(0);
            }
            string currenturl = webView23.CoreWebView2.Source.ToString();
            label2.Text = currenturl;


            if (terminateonopen == true && currenturl.ToLower().Contains(exception.ToLower()))
            {
                Environment.Exit(0);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void webView23_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            webView23.Source =new System.Uri(urltogo, System.UriKind.Absolute);

        }
    }
}