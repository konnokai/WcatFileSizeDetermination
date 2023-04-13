#pragma warning disable CS8604 // 可能有 Null 參考引數。
#pragma warning disable CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
#pragma warning disable CS8622 // 參數類型中參考型別是否可為 Null 的情況，與目標委派不相符 (可能的原因是屬性可為 Null)。
#pragma warning disable IDE0044 // 新增唯讀修飾元

using AssetStudio;
using NAudio.Wave;
using System.Diagnostics;
using Wcat_Index_Decide.Properties;
using Color = System.Drawing.Color;

namespace Wcat_Index_Decide
{
    public partial class MainForm : Form
    {
        public delegate void SendMessageHandler(string title, string text);
        public event SendMessageHandler SendMessage;

        public bool AutoExport { get; private set; }
        public string IndexSavePath { get; private set; }
        public string ExportSavePath { get; private set; }
        public string FileName { get; private set; }
        public int Interval { get; private set; }
        public int ServerIndex { get; private set; }

        private Stopwatch watch = new Stopwatch();
        private HttpClient httpClient = HttpClientFactory.Create();
        private bool isRunning = true, isDownloading = false;
        private long oldFileLength, newFileLength;
        private int step = 1;
        private string serverUrl = "";
        private string[] serverName = new string[]
        {
            "日版Android",
            "日版iOS",
            "台版Android",
            "台版iOS"
        };

        public MainForm(bool autoExport, string indexSavePath, string exportSavePath, string fileName, int interval, int serverIndex)
        {
            InitializeComponent();

            AutoExport = autoExport;
            IndexSavePath = indexSavePath;
            ExportSavePath = exportSavePath;
            FileName = fileName;
            Interval = interval;
            ServerIndex = serverIndex;

            switch (ServerIndex)
            {
                case 0:
                    serverUrl = Settings.Default.JPAndroidServer;
                    break;
                case 1:
                    serverUrl = Settings.Default.JPiOSServer;
                    break;
                case 2:
                    serverUrl = Settings.Default.TWAndroidServer;
                    break;
                case 3:
                    serverUrl = Settings.Default.TWiOSServer;
                    break;
            }
        }

        #region 委派
        int listViewItemIndex  = 0 ;
        private void AddListViewItem(ListViewItem LVI)
        {
            LVI.SubItems.Add($"{DateTime.Now:yyyy-MM-dd-HH-mm}");
            foreach (ListViewItem.ListViewSubItem item in LVI.SubItems)  
            {
                item.Tag = listViewItemIndex;
            }
            listViewItemIndex++;

            if (InvokeRequired)
                Invoke(AddListViewItem, LVI);

            ListView_Log.Items.Add(LVI);
        }

        private void SetButtonEnable(bool enable, Button btn)
        {
            if (InvokeRequired)
                Invoke(SetButtonEnable, enable, btn);

            btn.Enabled = enable;
        }

        private void SetLableText(string Text, Label lab)
        {
            if (InvokeRequired)
                Invoke(SetLableText, Text, lab);

            lab.Text = Text;
        }

        private void SetPictureBoxColor(Color color)
        {
            if (InvokeRequired)
                Invoke(SetPictureBoxColor, color);

            pictureBox1.BackColor = color;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer_Main.Interval = Interval * 60 * 1000;
            Timer_Main.Enabled = true;
            watch.Start();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ((MdiForm)MdiParent).AddMainForm(this);
            WriterLog("開始偵測");
            _ = MainFunction();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriterLog("關閉視窗");
            Timer_Main.Stop();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MdiForm)MdiParent).RemoveMainForm(this);
        }

        private void Btn_Status_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                WriterLog("開始偵測");

                isDownloading = true;
                step = 1;

                _ = MainFunction();
                Timer_Main.Start();
                watch.Restart();
                Btn_Status.Text = "停止";
                SetPictureBoxColor(Color.Red);
            }
            else
            {
                WriterLog("停止偵測");
                Timer_Main.Stop();
                watch.Stop();
                Btn_Status.Text = "開始";
                SetPictureBoxColor(Color.Green);
            }
        }

        private async void Timer_Main_Tick(object sender, EventArgs e)
        {
            if (!isDownloading)
            {
                await MainFunction();
            }
        }

        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            SetLableText($"已用時間: {watch.Elapsed:dd}天 {watch.Elapsed.ToString(@"hh\:mm\:ss")}", Lab_UsedTime);
        }

        private void ListView_Log_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (ListView_Log.Sorting == SortOrder.Ascending)
                ListView_Log.Sorting = SortOrder.Descending;
            else
                ListView_Log.Sorting = SortOrder.Ascending;

            ListView_Log.ListViewItemSorter = new ListViewItemComparerNum(e.Column, ListView_Log.Sorting == SortOrder.Ascending);
        }

        private async Task MainFunction()
        {
            isDownloading = true;
            SetLableText($"運行第{step}次", Lab_Step);

            bool isFileExist = true;
            string serverFileName = FileName + "?v=" + DateTime.Now.ToFileTime();
            string unity3dPath = $"{IndexSavePath}\\{ConvertServerIndexToServerName()}\\{Path.GetFileNameWithoutExtension(FileName)}-{DateTime.Now:HH-mm}{Path.GetExtension(FileName)}";

            SetLableText("狀態: 抓取中", Lab_Status);
            WriterLog(serverUrl + serverFileName);

            oldFileLength = newFileLength;
            if ((newFileLength = Utility.GetWebFileSize(serverUrl + serverFileName)) == -1)
            {
                SetLableText("狀態: 等待中", Lab_Status);
                WriterLog("網路錯誤，無法取得檔案大小");
                isFileExist = false;
            }

            if (isFileExist)
            {
                WriterLog($"{newFileLength}B");

                ListViewItem listViewItem = new ListViewItem($"{FileName} (No. {step})");
                listViewItem.SubItems.Add($"{newFileLength}B");

                if (step == 1)
                {
                    AddListViewItem(listViewItem);
                    await DownloadUnity3DFile(unity3dPath, serverFileName);
                }
                else if (oldFileLength != -1 && oldFileLength != newFileLength)
                {
                    string variety = "";

                    AddListViewItem(listViewItem);

                    if (oldFileLength < newFileLength) variety = "大";
                    else variety = "小";

                    listViewItem = new ListViewItem(Path.GetFileName(unity3dPath));
                    listViewItem.SubItems.Add("檔案變" + variety);
                    AddListViewItem(listViewItem);

                    WriterLog("偵測到檔案變" + variety);
                    SetLableText("狀態: 檔案變" + variety, Lab_Status);
                    SendMessage($"({serverName[ServerIndex]}){FileName}", $"偵測到檔案變{variety}");

#if RELEASE
                    ThreadPool.QueueUserWorkItem(delegate (object state)
                    {
                        using (DirectSoundOut DSO = new DirectSoundOut())
                        {
                            int num = 0;
                            while (num != 3)
                            {
                                num++;
                                DSO.Init(new WaveChannel32(new WaveFileReader(Resources.catora)));
                                DSO.Play();
                                Thread.Sleep(2000);
                            }
                        }
                    });
#endif
                    await DownloadUnity3DFile(unity3dPath, serverFileName);
                }

            }

            isDownloading = false;
            step++;
        }

        private async Task DownloadUnity3DFile(string unity3dPath, string serverFileName)
        {
            try
            {
                SetLableText("狀態: 下載中", Lab_Status);
                var bytes = await httpClient.GetByteArrayAsync($"{serverUrl}{serverFileName}?v={DateTime.Now.ToFileTime()}");

                if (!Directory.Exists(Path.GetDirectoryName(unity3dPath))) Directory.CreateDirectory(Path.GetDirectoryName(unity3dPath));
                if (!Directory.Exists(Path.GetDirectoryName(ExportSavePath))) Directory.CreateDirectory(Path.GetDirectoryName(ExportSavePath));

                File.WriteAllBytes(unity3dPath, bytes);

                if (AutoExport)
                   DecodeIndexFromTextAsset(unity3dPath, $"{ExportSavePath}\\{ConvertServerIndexToServerName()}\\{GetIndexName(Path.GetFileNameWithoutExtension(FileName))}-{DateTime.Now:MM-dd-HH-mm}.txt");

                SetLableText("狀態: 等待中", Lab_Status);
            }
            catch (Exception ex)
            {
                WriterLog($"下載失敗: {ex}");
                SendMessage($"({serverName}){FileName}", " 下載失敗");
            }
        }

        private void DecodeIndexFromTextAsset(string unity3dPath, string exportPath)
        {
            try
            {
                AssetsManager assetsManager = new AssetsManager();
                assetsManager.LoadFiles(unity3dPath);

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

                assetsManager.Clear();
            }
            catch (Exception ex)
            {
                WriterLog($"解包失敗: {ex}");
                SendMessage($"({serverName}){FileName}", " 解包失敗");
            }           
        }

        private string ConvertServerIndexToServerName()
        {
            switch (ServerIndex)
            {
                case 0:
                    return "JP_Android";
                case 1:
                    return "JP_iOS";
                case 2:
                    return "TW_Android";
                case 3:
                    return "TW_iOS";
                default:
                    return "";
            }
        }

        private string GetIndexName(string name)
        {
            if (name.StartsWith("_Version"))
                return name.Split(new char[] { '_' })[3];
            return Path.GetFileNameWithoutExtension(name);
        }

        private void WriterLog(string text)
        {
            try
            {
                string logPath = $"{IndexSavePath}\\{ConvertServerIndexToServerName()}\\{GetIndexName(FileName).ToUpper()}-{DateTime.Now:MM-dd}-LOG.txt";
                if (!Directory.Exists(Path.GetDirectoryName(logPath))) Directory.CreateDirectory(Path.GetDirectoryName(logPath));

                File.AppendAllText(logPath, $"{DateTime.Now:yyyy-MM-dd-HH-mm} | {serverName[ServerIndex]} | {FileName} | {text}\r\n");
            }
            catch (Exception) { }
        }
    }
}
