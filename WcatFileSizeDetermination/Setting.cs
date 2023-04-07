using System;
using System.Windows.Forms;
using WcatFileSizeDetermination.Properties;

namespace WcatFileSizeDetermination
{
    public partial class Setting : Form
	{
		public static string SeleteIndex { private get; set; }

		public Setting(Main form)
		{
			InitializeComponent();
			main = form;
			txt_IndexPath.Text = Settings.Default.IndexSavePath;
			txt_ExportPath.Text = Settings.Default.ExportSavePath;
			txt_FileName.Clear();
		}

		private void btn_Path_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txt_IndexPath.Text = folderBrowserDialog1.SelectedPath;
				Settings.Default.IndexSavePath = txt_IndexPath.Text;
				Settings.Default.Save();
			}
		}

		private void btn_ExportPath_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txt_ExportPath.Text = folderBrowserDialog1.SelectedPath;
				Settings.Default.ExportSavePath = txt_ExportPath.Text;
				Settings.Default.Save();
			}
		}

		private void btn_SeleteIndex_Click(object sender, EventArgs e)
		{
			new IndexSelect().ShowDialog();
			if (Setting.SeleteIndex != "")
			{
				txt_FileName.Text = Setting.SeleteIndex;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cmb_Time.Text == "")
			{
				MessageBox.Show("時間間隔不可空白");
				return;
			}
			if (txt_IndexPath.Text == "" || txt_ExportPath.Text == "")
			{
				MessageBox.Show("路徑不可空白");
				return;
			}
			if (txt_FileName.Text == "")
			{
				MessageBox.Show("檔案名稱不可空白");
				return;
			}

            if (int.TryParse(cmb_Time.Text, out int time)) cmb_Time.Text = Math.Min(Math.Max(time, 1), 120).ToString();
            else cmb_Time.Text = "1";

            for (int i = 1; i >= 0; i--)
			{
                bool isShow = true;

                foreach (var item in main.MdiChildren)
                    if (item.Text == string.Format("({0}) {1}", ServerName[i], txt_FileName.Text))
                        isShow = false;

                if (isShow)
                {
                    Form1 form = new Form1(chb_AutoExport.Checked, txt_IndexPath.Text, txt_ExportPath.Text, txt_FileName.Text, int.Parse(cmb_Time.Text), i);
                    form.MdiParent = main;
                    form.Text = string.Format("({0}) {1}", ServerName[i], txt_FileName.Text);
                    form.SendMessage += main.ChildForm_SendMessage;
                    form.Show();
                }
			}
			Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Main main;

		private string[] ServerName = new string[]
        {
            "日版",
            "台版"
		};
    }
}
