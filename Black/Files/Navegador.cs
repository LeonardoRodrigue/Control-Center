using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class Navegador : Form
	{
		public Navegador()
		{
			InitializeComponent();
			NovaGuia();
		}
	
		private void NovaGuia()
        {
            TabPage tab = new TabPage();
            tab.Text = "Nova Guia";

            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };

            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");

            txtUrl.Text = "https://www.google.com";

            browser.DocumentCompleted += Browser_DocumentCompleted;
        }
		
		private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
   		{
            WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                tabControl1.SelectedTab.Text = browser.DocumentTitle;
  		}
		
		void BntnovaguiaClick(object sender, EventArgs e)
		{
			NovaGuia();
		}
		void BntconfirmaClick(object sender, EventArgs e)
		{
			NovaGuia();
		}
		void BntretornaClick(object sender, EventArgs e)
		{
			WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                browser.Navigate(txtUrl.Text);
            }
		}
		void BntavancaClick(object sender, EventArgs e)
		{
			 WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                    browser.GoForward();
            }
		}
		void Button1Click(object sender, EventArgs e)
		{
			WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
    		if (browser != null)
    		{
        		browser.Refresh();  // Isso recarregará a página atual
    		}
		}
	}
}

// Leonardo Rodrigues Reis Lopes