using System;
using System.Windows.Forms;
using WcatFileSizeDetermination.Properties;

namespace WcatFileSizeDetermination
{
    public partial class ServerSetting : Form
	{
		public ServerSetting()
		{
			InitializeComponent();
		}

		private void ServerSetting_Load(object sender, EventArgs e)
		{
			txt_TW.Text = Static_Fidle.TWServer;
			txt_JP.Text = Static_Fidle.JPServer;
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ServerSetting_FormClosing(object sender, FormClosingEventArgs e)
		{
			Static_Fidle.TWServer = txt_TW.Text;
			Static_Fidle.JPServer = txt_JP.Text;
			Settings.Default.TWServer = Static_Fidle.TWServer;
			Settings.Default.JPServer = Static_Fidle.JPServer;
			Settings.Default.Save();
		}
	}
}
