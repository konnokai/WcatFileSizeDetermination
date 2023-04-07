using AssetStudio;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WcatFileSizeDetermination
{
    public partial class Form1 : Form
	{
		public event SendMessageHandler SendMessage;

		public bool AutoExport { get; private set; }

		public string IndexSavePath { get; private set; }

		public string ExportSavePath { get; private set; }

		public string FileName { get; private set; }

		public int Interval { get; private set; }

		public int Index { get; private set; }

		public Form1(bool autoExport, string indexSavePath, string exportSavePath, string fileName, int interval, int index)
		{
			InitializeComponent();
			ServerHost[0] = Static_Fidle.JPServer;
			ServerHost[1] = Static_Fidle.TWServer;
			AutoExport = autoExport;
			IndexSavePath = indexSavePath;
			ExportSavePath = exportSavePath;
			FileName = fileName;
			Interval = interval;
			Index = index;
		}

		private void AddListViewItem(ListViewItem LVI)
		{
			LVI.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd-HH-mm"));
			if (InvokeRequired)
			{
				Invoke(new Action(delegate()
				{
					list_Event.Items.Add(LVI);
				}));
				LVI = null;
				return;
			}
			list_Event.Items.Add(LVI);
			LVI = null;
		}

		private void SetButtonEnable(bool enable, Button btn)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(delegate()
				{
					btn.Enabled = enable;
				}));
				return;
			}
			btn.Enabled = enable;
		}

		private void SetLableText(string Text, Label lab)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(delegate()
				{
					if (lab == lab_status)
					{
						lab.Text = "狀態:" + Text;
						return;
					}
					lab.Text = Text;
				}));
				return;
			}
			if (lab == lab_status)
			{
				lab.Text = "狀態:" + Text;
				return;
			}
			lab.Text = Text;
		}

		private void SetPictureBoxColor(Color color)
		{
			if (InvokeRequired)
			{
				Graphics graphics = pictureBox1.CreateGraphics();
				Brush brush = new SolidBrush(color);
				graphics.FillEllipse(brush, 2, 2, 18, 18);
				return;
			}
			Graphics graphics2 = pictureBox1.CreateGraphics();
			Brush brush2 = new SolidBrush(color);
			graphics2.FillEllipse(brush2, 2, 2, 18, 18);
		}

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (!isDownloading)
			{
				new Thread(new ThreadStart(DownloadUnity3d)).Start();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			SetLableText(string.Concat(new string[]
			{
                "已用時間",
				watch.Elapsed.Hours.ToString("D2"),
				":",
				watch.Elapsed.Minutes.ToString("D2"),
				":",
				watch.Elapsed.Seconds.ToString("D2")
			}), lab_Time);
		}

		private string GetChineseToEnglish(int i)
		{
			switch (i)
			{
			case 0:
				return "JP";
			case 1:
				return "TW";
			default:
				return "";
			}
		}

		private void btn_Stop_Click(object sender, EventArgs e)
		{
			timer.Stop();
			EnableEvent(true);
			SetLableText("停止中", lab_status);
			SetPictureBoxColor(Color.Green);
			WriterLog("停止偵測");
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(IndexSavePath)) Directory.CreateDirectory(IndexSavePath);
            Step = 1;
			isDownloading = true;
#if DEBUG
#else
            isFristPlayVoice = true;
#endif
			SetPictureBoxColor(Color.Red);
			WriterLog("開始偵測");
			EnableEvent(false);
			new Thread(new ThreadStart(DownloadUnity3d)).Start();
			timer.Interval = Interval * 60 * 1000;
			timer.Start();
		}

		private void DownloadUnity3d()
		{
			SetLableText(string.Format("運行第{0}次", Step.ToString()), lab_Step);

            ListViewItem listViewItem;
            bool isFileExist = true;
			string serverFileName = FileName + "?t=" + DateTime.Now.ToFileTime();
			string path = string.Concat(new string[]
			{
				IndexSavePath,
				"\\",
				GetChineseToEnglish(Index),
				"-",
				GetIndexName(FileName).ToUpper(),
				"-",
				DateTime.Now.ToString("MM-dd"),
				"\\",
				Path.GetFileNameWithoutExtension(FileName),
				"-",
				DateTime.Now.ToString("HH-mm"),
				Path.GetExtension(FileName)
			});
            
            SetLableText("抓取中", lab_status);
            OldFileLength = NewFileLength;
            if ((NewFileLength = GetFileSize(ServerHost[Index] + serverFileName)) == -1)
            {
                listViewItem = new ListViewItem(string.Format("({0}){1}", ServerName[Index], FileName));
                listViewItem.SubItems.Add("網路錯誤，無法取得檔案大小");
                AddListViewItem(listViewItem);
                WriterLog("網路錯誤，無法取得檔案大小");
                isFileExist = false;
            }

			if (isFileExist)
			{
				WriterLog(NewFileLength.ToString() + "B");

                if (Step == 1)
                {
                    listViewItem = new ListViewItem(string.Format("({0}){1} (No. {2})", ServerName[Index], FileName, Step.ToString()));
                    listViewItem.SubItems.Add(NewFileLength + "B");
                    AddListViewItem(listViewItem);
                    DownloadUnity3DFile(path, serverFileName);
                }
                else if (OldFileLength != -1 && OldFileLength != NewFileLength)
				{
                    string variety = "";

                    listViewItem = new ListViewItem(string.Format("({0}){1} (No. {2})", ServerName[Index], FileName, Step.ToString()));
                    listViewItem.SubItems.Add(NewFileLength + "B");
                    AddListViewItem(listViewItem);
                    
                    if (OldFileLength < NewFileLength) variety = "大";
                    else variety = "小";

                    listViewItem = new ListViewItem("(" + ServerName[Index] + ")" + Path.GetFileName(path));
                    listViewItem.SubItems.Add("檔案變" + variety);
                    AddListViewItem(listViewItem);

                    WriterLog("偵測到檔案變" + variety);
                    SetLableText("檔案變" + variety, lab_status);
                    SendMessage(string.Format("({0}){1}", ServerName[Index], FileName), "偵測到檔案變" + variety);

#if DEBUG
#else
                    if (isFristPlayVoice)
                    {
                        isFristPlayVoice = false;
                        ThreadPool.QueueUserWorkItem(delegate (object state)
                        {
                            int num = 0;
                            while (num != 3)
                            {
                                num++;
                                DSO.Init(new WaveChannel32(new WaveFileReader(Properties.Resources.catora_talk_006)));
                                DSO.Play();
                                Thread.Sleep(2000);
                            }
                            DSO.Dispose();
                        });
                    }
#endif

                    DownloadUnity3DFile(path, serverFileName);
                }               
            }

			Step++;
			isDownloading = false;
			SetLableText("等待中", lab_status);
		}

		private void list_Event_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (list_Event.Sorting == SortOrder.Ascending)
                list_Event.Sorting = SortOrder.Descending;
            else
                list_Event.Sorting = SortOrder.Ascending;

            list_Event.ListViewItemSorter = new ListViewItemComparerNum(e.Column, list_Event.Sorting == SortOrder.Ascending);
		}

        private void EnableEvent(bool enable)
		{
			if (enable)
			{
				timer2.Stop();
				watch.Reset();
			}
			else
			{
				timer2.Start();
				watch.Start();
			}
			SetButtonEnable(enable, btn_Start);
			SetButtonEnable(!enable, btn_Stop);
		}

		private string GetIndexName(string Name)
		{
			if (Name.StartsWith("_Version"))
                return Name.Split(new char[] { '_' })[3];
            return Path.GetFileNameWithoutExtension(Name);
		}

		private void WriterLog(string Text)
		{
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(IndexSavePath + "\\" + Path.GetFileNameWithoutExtension(GetIndexName(FileName)) + "-LOG.txt", true))
                {
                    streamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + "  " + string.Format("({0}){1}", ServerName[Index], FileName) + "  " + Text);
                }
            }
            catch (Exception) { }
        }

        public long GetFileSize(string url)
        {
            long result = -1;

            try
            {
                WebRequest req = WebRequest.Create(url);
                req.Method = "HEAD";
                using (WebResponse resp = req.GetResponse())
                {
                    if (long.TryParse(resp.Headers.Get("Content-Length"), out long ContentLength))
                        result = ContentLength;
                }
            }
            catch (Exception) { }

            return result;
        }

        private void DownloadUnity3DFile(string path, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    SetLableText("下載中", lab_status);
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                    webClient.DownloadFile(ServerHost[Index] + fileName, path);

                    if (AutoExport)
                        DecodeIndexFromTextAsset(path, ExportSavePath + "\\" +
                            string.Format("({0}) {1}-{2}.txt",
                            GetChineseToEnglish(Index),
                            GetIndexName(Path.GetFileNameWithoutExtension(FileName)),
                            DateTime.Now.ToString("MM-dd-HH-mm")));
                }
                catch (WebException)
                {
                    WriterLog("下載失敗");
                    SendMessage(string.Format("({0}){1}", ServerName[Index], FileName), " 下載失敗");
                }
            }
        }        

        private void DecodeIndexFromTextAsset(string path, string exportPath)
		{
            AssetsManager assetsManager = new AssetsManager();
            assetsManager.LoadFiles(new string[] { path });
			try
            {
                foreach (var item in assetsManager.assetsFileList)
                {
                    foreach (var item2 in item.m_Objects)
                    {
                        ObjectReader objectReader = new ObjectReader(item.reader, item, item2);
                        if (objectReader.type == ClassIDType.TextAsset)
                        {
                            TextAsset m_TextAsset = new TextAsset(objectReader);

                            if (!Directory.Exists(Path.GetDirectoryName(exportPath))) Directory.CreateDirectory(Path.GetDirectoryName(exportPath));
                            File.WriteAllBytes(exportPath, m_TextAsset.m_Script);
                        }
                    }
                }
            }
			catch (Exception ex)
			{
				Debugger.Log(3, "DecodeIndexFromTextAsset", ex.ToString());
			}
		}

		private string[] ServerHost = new string[3];

		private string[] ServerName = new string[]
        {
            "日版",
            "台版",
			"韓版"
		};


		private Stopwatch watch = new Stopwatch();

		private int Step = 1;

#if DEBUG
#else
		private DirectSoundOut DSO = new DirectSoundOut();
		private bool isFristPlayVoice = true;
#endif

        private bool isDownloading;

		private long OldFileLength;

		private long NewFileLength;

		public delegate void SendMessageHandler(string title, string text);
	}
}
