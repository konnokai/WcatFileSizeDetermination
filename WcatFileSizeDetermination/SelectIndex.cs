#pragma warning disable CS8600 // 正在將 Null 常值或可能的 Null 值轉換為不可為 Null 的型別。

namespace Wcat_Index_Decide
{
    public partial class SelectIndex : Form
    {
        bool isAllIndex = false;
        string version = "a";

        public SelectIndex(string version = "a", bool isAllIndex = false)
        {
            InitializeComponent();
            this.version = version;
            this.isAllIndex = isAllIndex;
        }

        private void SelectIndex_Load(object sender, EventArgs e)
        {
            if (isAllIndex)
            {
                List<string> result = new();

                foreach (string index in listBox1.Items)
                {
                    result.Add($"_Version_{version}_{index}_txt.unity3d");
                }

                Utility.SeleteIndex = string.Join(',', result);
                Close();
            }
        }

        private void SelectIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.SelectedItems.Count >= 1)
            {
                string selectIndex = listBox1.SelectedItem.ToString();
                Utility.SeleteIndex = $"_Version_{version}_{selectIndex}_txt.unity3d";
            }
        }
    }
}