using System;
using System.Windows.Forms;
using WcatFileSizeDetermination.Properties;

namespace WcatFileSizeDetermination
{
    public partial class IndexSelect : Form
	{
		public IndexSelect()
		{
			InitializeComponent();
			object[] items2 = Resources.Index.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.RemoveEmptyEntries);
			listBox1.Items.AddRange(items2);
		}

		private void IndexSelect_FormClosing(object sender, FormClosingEventArgs e)
		{
			string text = "";
			if (listBox1.SelectedItems.Count >= 1)
			{
				string text2 = listBox1.SelectedItem.ToString();
				if (text2 != "Sound_SE" && text2 != "Sound_SE_v2" && text2 != "WeaponBullet_Prefabs")
				{
					text += string.Format("_Version_a_{0}_txt.unity3d", text2);
				}
				else
				{
					text = text2 + ".unity3d";
				}
				Setting.SeleteIndex = text;
			}
		}
    }
}
