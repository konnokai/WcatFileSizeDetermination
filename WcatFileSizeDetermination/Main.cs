using System;
using System.Windows.Forms;
using WcatFileSizeDetermination.Properties;

namespace WcatFileSizeDetermination
{
    public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			setting = new Setting(this);
			serverSetting = new ServerSetting();
			Static_Fidle.TWServer = Settings.Default.TWServer;
			Static_Fidle.JPServer = Settings.Default.JPServer;
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			setting.ShowDialog();
		}

		private void ServerHostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			serverSetting.ShowDialog();
		}

		public void ChildForm_SendMessage(string title, string text)
		{
			notifyIcon1.ShowBalloonTip(1000, title, text, ToolTipIcon.None);
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form[] mdiChildren = base.MdiChildren;
			for (int i = 0; i < mdiChildren.Length; i++)
			{
				mdiChildren[i].Close();
			}
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form[] mdiChildren = base.MdiChildren;
			for (int i = 0; i < mdiChildren.Length; i++)
			{
				mdiChildren[i].Close();
			}
		}

		private Setting setting;

		private ServerSetting serverSetting;
    }
}
