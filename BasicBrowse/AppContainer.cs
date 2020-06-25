using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using Microsoft.WindowsAPICodePack.Shell;

namespace BasicBrowse
{
	public partial class AppContainer : TitleBarTabs
	{
		public AppContainer()
		{
			InitializeComponent();
			AeroPeekEnabled = true;
			TabRenderer = new ChromeTabRenderer(this);
			Icon = Properties.Resources.website_64px;
		}

		public override TitleBarTab CreateTab()
		{
			return new TitleBarTab(this)
			{
				Content = new Main { Text = "BasicBrowse" }
			};
		}
	}
}
