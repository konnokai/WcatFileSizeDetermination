using Wcat_Index_Decide.Properties;
using System.Linq.Expressions;

namespace Wcat_Index_Decide
{
    public partial class MdiForm : Form
    {
        private NewWindow newWindow;
        private ServerSetting serverSetting;
        private List<MainForm> mainForms = new List<MainForm>();
        private bool canCreateNewWindow = true;

        public MdiForm()
        {
            InitializeComponent();
            newWindow = new NewWindow(this);
            serverSetting = new ServerSetting();
            Utility.TWServer = Settings.Default.JPAndroidServer;
            Utility.JPServer = Settings.Default.JPiOSServer;
        }

        public void ChildForm_SendMessage(string title, string text)
        {
            notifyIcon1.ShowBalloonTip(1000, title, text, ToolTipIcon.None);
        }

        public void AddMainForm(MainForm mainForm)
        {
            var toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = mainForm.Text;
            toolStripMenuItem.Name = mainForm.Text.Replace(" ", "_") + "_TSMItem";
            toolStripMenuItem.Click += (sender, e) => { mainForm.Focus(); };
            SelectWindow_TSMItem.DropDownItems.Add(toolStripMenuItem);

            if (SelectWindow_TSMItem.DropDownItems.Count >= 24)
                canCreateNewWindow = false;

            if (SelectWindow_TSMItem.HasDropDownItems)
            {
                SelectWindow_TSMItem.Enabled = true;
                Timer_GC.Start();
            }
        }

        public void RemoveMainForm(MainForm mainForm)
        {
            var toolStripMenuItem = SelectWindow_TSMItem.DropDownItems.Find(mainForm.Text.Replace(" ", "_") + "_TSMItem", false).FirstOrDefault();
            if (toolStripMenuItem == null)
                return;

            SelectWindow_TSMItem.DropDownItems.Remove(toolStripMenuItem);

            if (SelectWindow_TSMItem.DropDownItems.Count < 24)
                canCreateNewWindow = true;

            if (!SelectWindow_TSMItem.HasDropDownItems)
            {
                SelectWindow_TSMItem.Enabled = false;
                Timer_GC.Stop();
                GC.Collect();
            }
        }

        private void OneWindow_TSMItem_Click(object sender, EventArgs e)
        {
            if (!canCreateNewWindow)
            {
                MessageBox.Show(this, "不可建立新視窗，請將視窗關閉至低於24個後再新增", "錯誤", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }

            newWindow.AllIndexMode = false;
            newWindow.ShowDialog();
        }

        private void AllIndex_TSMItem_Click(object sender, EventArgs e)
        {
            if (!canCreateNewWindow)
            {
                MessageBox.Show(this, "不可建立新視窗，請將視窗關閉至低於24個後再新增", "錯誤", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }

            newWindow.AllIndexMode = true;
            newWindow.ShowDialog();
        }

        private void ServerSetting_TSMItem_Click(object sender, EventArgs e)
        {
            serverSetting.ShowDialog();
        }

        private void Cascade_TSMItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVertical_TSMItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontal_TSMItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAll_TSMItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)   
            {
                item.Close();
            }
        }
        private void Timer_GC_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}