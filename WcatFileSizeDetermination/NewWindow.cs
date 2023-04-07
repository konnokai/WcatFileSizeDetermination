using Wcat_Index_Decide.Properties;

namespace Wcat_Index_Decide
{
    public partial class NewWindow : Form
    {
        public bool AllIndexMode { get; set; } = false;

        private MdiForm mdiForm;
        private string[] serverName = new string[]
        {
            "日版Android",
            "日版iOS",
            "台版Android",
            "台版iOS"
        };

        public NewWindow(MdiForm mdiForm)
        {
            InitializeComponent();
            this.mdiForm = mdiForm;
        }

        private void NewWindow_Load(object sender, EventArgs e)
        {
            TBox_IndexPath.Text = Settings.Default.IndexSavePath;
            TBox_ExportPath.Text = Settings.Default.ExportSavePath;

            if (AllIndexMode)
            {
                TBox_FileName.Text = "將自動帶入所有的Index名稱";
                TBox_FileName.Enabled = false;
                Btn_SelectIndex.Enabled = false;
            }
            else
            {
                TBox_FileName.Clear();
                TBox_FileName.Enabled = true;
                Btn_SelectIndex.Enabled = true;
            }
        }

        private void Btn_IndexPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TBox_IndexPath.Text = folderBrowserDialog1.SelectedPath;
                Settings.Default.IndexSavePath = TBox_IndexPath.Text;
                Settings.Default.Save();
            }
        }

        private void Btn_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TBox_ExportPath.Text = folderBrowserDialog1.SelectedPath;
                Settings.Default.ExportSavePath = TBox_ExportPath.Text;
                Settings.Default.Save();
            }
        }
        private void Btn_SelectIndex_Click(object sender, EventArgs e)
        {
            new SelectIndex(RBox_JP_iOS.Checked || RBox_TW_iOS.Checked ? "i" : "a", false).ShowDialog();
            if (Utility.SeleteIndex != "")
            {
                TBox_FileName.Text = Utility.SeleteIndex;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numericUpDown_Time.Text))
            {
                MessageBox.Show("時間間隔不可空白");
                return;
            }

            if (string.IsNullOrEmpty(TBox_ExportPath.Text) || string.IsNullOrEmpty(TBox_IndexPath.Text))
            {
                MessageBox.Show("路徑不可空白");
                return;
            }

            if (string.IsNullOrEmpty(TBox_FileName.Text))
            {
                MessageBox.Show("檔案名稱不可空白");
                return;
            }

            if (int.TryParse(numericUpDown_Time.Text, out int time)) numericUpDown_Time.Text = Math.Min(Math.Max(time, 1), 120).ToString();
            else numericUpDown_Time.Text = "1";

            if (AllIndexMode)
            {
                new SelectIndex(RBox_JP_iOS.Checked || RBox_TW_iOS.Checked ? "i" : "a", true).ShowDialog();
                if (Utility.SeleteIndex != "")
                {
                    TBox_FileName.Text = Utility.SeleteIndex;
                }
            }

            int serverIndex = 0;
            if (RBox_JP_iOS.Checked)
                serverIndex = 1;
            else if (RBox_TW_Android.Checked)
                serverIndex = 2;
            else if (RBox_TW_iOS.Checked)
                serverIndex = 3;

            var list = TBox_FileName.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            list.Sort();

            foreach (var item in list)
            {
                if (!mdiForm.MdiChildren.Any((x) => x.Text == $"({serverName[serverIndex]}) {item}"))
                {
                    MainForm form = new MainForm(CBox_AutoExport.Checked, TBox_IndexPath.Text, TBox_ExportPath.Text, item, int.Parse(numericUpDown_Time.Text), serverIndex);
                    form.MdiParent = mdiForm;
                    form.Text = $"({serverName[serverIndex]}) {item}";
                    form.SendMessage += mdiForm.ChildForm_SendMessage;
                    form.Show();
                }
            }
           
            Close();
        }
    }
}
