namespace BrowseTool
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
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            this.SuspendLayout();
            // 
            // webView23
            // 
            this.webView23.AllowExternalDrop = true;
            this.webView23.CreationProperties = null;
            this.webView23.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView23.Location = new System.Drawing.Point(0, 0);
            this.webView23.Name = "webView23";
            this.webView23.Size = new System.Drawing.Size(790, 405);
            this.webView23.Source = new System.Uri("https://fajkvfejhbv", System.UriKind.Absolute);
            this.webView23.TabIndex = 0;
            this.webView23.ZoomFactor = 1D;
            this.webView23.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView23_CoreWebView2InitializationCompleted);
            this.webView23.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView23_NavigationCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(790, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webView23);
            this.Name = "Form1";
            this.Text = "BrowseTool";
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
        private System.Windows.Forms.Label label2;
    }
}

