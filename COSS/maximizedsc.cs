using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSS
{
    public partial class maximizedsc : Form
    {
        public maximizedsc()
        {
            InitializeComponent();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void maximizedsc_KeyPress(object sender, KeyPressEventArgs e)
        {
 /*           if (e.KeyChar == (char)Keys.ShiftKey)
            { 
            webView21.GoForward();
            }
            if (e.KeyChar == (char)Keys.ControlKey)
            {
                webView21.GoBack();
            }
            if (e.KeyChar == (char)Keys.BrowserBack)
            {
                webView21.GoBack();
            }
            if (e.KeyChar == (char)Keys.BrowserForward)
            {
                webView21.GoForward();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
               this.Close();
            }
 */
        }

        private void maximizedsc_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            webView21.CoreWebView2.Navigate(label1.Text);

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;

            timer2.Enabled = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible=false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webView21_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
