using Wcat_Index_Decide.Properties;

namespace Wcat_Index_Decide
{
    public partial class ServerSetting : Form
    {
        public ServerSetting()
        {
            InitializeComponent();
        }

        private void ServerSetting_Load(object sender, EventArgs e)
        {
            TBox_JP_Android.Text = Settings.Default.JPAndroidServer;
            TBox_JP_iOS.Text = Settings.Default.JPiOSServer;
            TBox_TW_Android.Text = Settings.Default.TWAndroidServer;
            TBox_TW_iOS.Text = Settings.Default.TWiOSServer;
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            Settings.Default.JPAndroidServer = TBox_JP_Android.Text;
            if (!Settings.Default.JPAndroidServer.EndsWith("/")) Settings.Default.JPAndroidServer += "/";

            Settings.Default.JPiOSServer = TBox_JP_iOS.Text;
            if (!Settings.Default.JPiOSServer.EndsWith("/")) Settings.Default.JPiOSServer += "/";

            Settings.Default.TWAndroidServer = TBox_TW_Android.Text;
            if (!Settings.Default.TWAndroidServer.EndsWith("/")) Settings.Default.TWAndroidServer += "/";

            Settings.Default.TWiOSServer = TBox_TW_iOS.Text;
            if (!Settings.Default.TWiOSServer.EndsWith("/")) Settings.Default.TWiOSServer += "/";

            Settings.Default.Save();
            Close();
        }
    }
}
