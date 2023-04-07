namespace Wcat_Index_Decide
{
    partial class MdiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewWindow_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OneWindow_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllIndex_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMenu_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascade_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertical_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontal_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAll_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerSetting_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectWindow_TSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer_GC = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWindow_TSMItem,
            this.WindowsMenu_TSMItem,
            this.ServerSetting_TSMItem,
            this.SelectWindow_TSMItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewWindow_TSMItem
            // 
            this.NewWindow_TSMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneWindow_TSMItem,
            this.AllIndex_TSMItem});
            this.NewWindow_TSMItem.Name = "NewWindow_TSMItem";
            this.NewWindow_TSMItem.Size = new System.Drawing.Size(67, 20);
            this.NewWindow_TSMItem.Text = "開新視窗";
            // 
            // OneWindow_TSMItem
            // 
            this.OneWindow_TSMItem.Name = "OneWindow_TSMItem";
            this.OneWindow_TSMItem.Size = new System.Drawing.Size(201, 22);
            this.OneWindow_TSMItem.Text = "新增單一視窗";
            this.OneWindow_TSMItem.Click += new System.EventHandler(this.OneWindow_TSMItem_Click);
            // 
            // AllIndex_TSMItem
            // 
            this.AllIndex_TSMItem.Name = "AllIndex_TSMItem";
            this.AllIndex_TSMItem.Size = new System.Drawing.Size(201, 22);
            this.AllIndex_TSMItem.Text = "一次開啟全部Index檢測";
            this.AllIndex_TSMItem.Click += new System.EventHandler(this.AllIndex_TSMItem_Click);
            // 
            // WindowsMenu_TSMItem
            // 
            this.WindowsMenu_TSMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cascade_TSMItem,
            this.TileVertical_TSMItem,
            this.TileHorizontal_TSMItem,
            this.CloseAll_TSMItem});
            this.WindowsMenu_TSMItem.Name = "WindowsMenu_TSMItem";
            this.WindowsMenu_TSMItem.Size = new System.Drawing.Size(67, 20);
            this.WindowsMenu_TSMItem.Text = "視窗檢視";
            // 
            // Cascade_TSMItem
            // 
            this.Cascade_TSMItem.Name = "Cascade_TSMItem";
            this.Cascade_TSMItem.Size = new System.Drawing.Size(122, 22);
            this.Cascade_TSMItem.Text = "重疊顯示";
            this.Cascade_TSMItem.Click += new System.EventHandler(this.Cascade_TSMItem_Click);
            // 
            // TileVertical_TSMItem
            // 
            this.TileVertical_TSMItem.Name = "TileVertical_TSMItem";
            this.TileVertical_TSMItem.Size = new System.Drawing.Size(122, 22);
            this.TileVertical_TSMItem.Text = "垂直顯示";
            this.TileVertical_TSMItem.Click += new System.EventHandler(this.TileVertical_TSMItem_Click);
            // 
            // TileHorizontal_TSMItem
            // 
            this.TileHorizontal_TSMItem.Name = "TileHorizontal_TSMItem";
            this.TileHorizontal_TSMItem.Size = new System.Drawing.Size(122, 22);
            this.TileHorizontal_TSMItem.Text = "水平顯示";
            this.TileHorizontal_TSMItem.Click += new System.EventHandler(this.TileHorizontal_TSMItem_Click);
            // 
            // CloseAll_TSMItem
            // 
            this.CloseAll_TSMItem.Name = "CloseAll_TSMItem";
            this.CloseAll_TSMItem.Size = new System.Drawing.Size(122, 22);
            this.CloseAll_TSMItem.Text = "全部關閉";
            this.CloseAll_TSMItem.Click += new System.EventHandler(this.CloseAll_TSMItem_Click);
            // 
            // ServerSetting_TSMItem
            // 
            this.ServerSetting_TSMItem.Name = "ServerSetting_TSMItem";
            this.ServerSetting_TSMItem.Size = new System.Drawing.Size(79, 20);
            this.ServerSetting_TSMItem.Text = "伺服器網址";
            this.ServerSetting_TSMItem.Click += new System.EventHandler(this.ServerSetting_TSMItem_Click);
            // 
            // SelectWindow_TSMItem
            // 
            this.SelectWindow_TSMItem.Enabled = false;
            this.SelectWindow_TSMItem.Name = "SelectWindow_TSMItem";
            this.SelectWindow_TSMItem.Size = new System.Drawing.Size(67, 20);
            this.SelectWindow_TSMItem.Text = "選擇視窗";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "檔案判斷偵測";
            this.notifyIcon1.Visible = true;
            // 
            // Timer_GC
            // 
            this.Timer_GC.Interval = 300000;
            this.Timer_GC.Tick += new System.EventHandler(this.Timer_GC_Tick);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiForm";
            this.Text = "檔案判斷偵測";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem NewWindow_TSMItem;
        private ToolStripMenuItem WindowsMenu_TSMItem;
        private ToolStripMenuItem ServerSetting_TSMItem;
        private ToolStripMenuItem Cascade_TSMItem;
        private ToolStripMenuItem TileVertical_TSMItem;
        private ToolStripMenuItem TileHorizontal_TSMItem;
        private ToolStripMenuItem CloseAll_TSMItem;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem OneWindow_TSMItem;
        private ToolStripMenuItem AllIndex_TSMItem;
        private ToolStripMenuItem SelectWindow_TSMItem;
        private System.Windows.Forms.Timer Timer_GC;
    }
}