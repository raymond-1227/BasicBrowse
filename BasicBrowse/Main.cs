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
using CefSharp.WinForms;
using EasyTabs;

namespace BasicBrowse
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		ChromiumWebBrowser browser;

		private void Main_Load(object sender, EventArgs e)
		{
			txtBar.Text = "https://www.google.com";
			browser = new ChromiumWebBrowser(txtBar.Text);
			browser.Dock = DockStyle.Fill;
			this.pContainer.Controls.Add(browser);
			browser.AddressChanged += Browser_AddressChanged;
		}

		private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
		{
			this.Invoke(new MethodInvoker(() =>
			{
				txtBar.Text = e.Address;
			}));
		}

		private void txtBar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtBar.Text.Trim().Length > 0)
			{
				if (txtBar.Text.Contains("."))
				{
					browser.Load(txtBar.Text);
				}
				else
				{
					browser.Load("https://www.google.com/search?client=chrome&q=" + txtBar.Text);
				}
			}
		}

		private void imgBtnReload_Click(object sender, EventArgs e)
		{
			browser.Reload();
		}

		private void imgBtnBack_Click(object sender, EventArgs e)
		{
			if (browser.CanGoBack)
				browser.Back();
		}

		private void imgBtnFoward_Click(object sender, EventArgs e)
		{
			if (browser.CanGoForward)
				browser.Forward();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Cef.Shutdown();
		}

		private void imgBtnAbout_Click(object sender, EventArgs e)
		{
			About aboutWindow = new About();
			aboutWindow.ShowDialog();
		}
	}
}
