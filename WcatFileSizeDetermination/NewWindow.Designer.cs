namespace Wcat_Index_Decide
{
    partial class NewWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBox_IndexPath = new System.Windows.Forms.TextBox();
            this.Btn_IndexPath = new System.Windows.Forms.Button();
            this.Btn_SavePath = new System.Windows.Forms.Button();
            this.TBox_ExportPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox_FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.CBox_AutoExport = new System.Windows.Forms.CheckBox();
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_SelectIndex = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBox_TW_iOS = new System.Windows.Forms.RadioButton();
            this.RBox_TW_Android = new System.Windows.Forms.RadioButton();
            this.RBox_JP_iOS = new System.Windows.Forms.RadioButton();
            this.RBox_JP_Android = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index儲存位置";
            // 
            // TBox_IndexPath
            // 
            this.TBox_IndexPath.Enabled = false;
            this.TBox_IndexPath.Location = new System.Drawing.Point(12, 27);
            this.TBox_IndexPath.Name = "TBox_IndexPath";
            this.TBox_IndexPath.Size = new System.Drawing.Size(454, 23);
            this.TBox_IndexPath.TabIndex = 1;
            // 
            // Btn_IndexPath
            // 
            this.Btn_IndexPath.Location = new System.Drawing.Point(472, 27);
            this.Btn_IndexPath.Name = "Btn_IndexPath";
            this.Btn_IndexPath.Size = new System.Drawing.Size(26, 23);
            this.Btn_IndexPath.TabIndex = 2;
            this.Btn_IndexPath.Text = "...";
            this.Btn_IndexPath.UseVisualStyleBackColor = true;
            this.Btn_IndexPath.Click += new System.EventHandler(this.Btn_IndexPath_Click);
            // 
            // Btn_SavePath
            // 
            this.Btn_SavePath.Location = new System.Drawing.Point(472, 71);
            this.Btn_SavePath.Name = "Btn_SavePath";
            this.Btn_SavePath.Size = new System.Drawing.Size(26, 23);
            this.Btn_SavePath.TabIndex = 5;
            this.Btn_SavePath.Text = "...";
            this.Btn_SavePath.UseVisualStyleBackColor = true;
            this.Btn_SavePath.Click += new System.EventHandler(this.Btn_SavePath_Click);
            // 
            // TBox_ExportPath
            // 
            this.TBox_ExportPath.Enabled = false;
            this.TBox_ExportPath.Location = new System.Drawing.Point(12, 71);
            this.TBox_ExportPath.Name = "TBox_ExportPath";
            this.TBox_ExportPath.Size = new System.Drawing.Size(454, 23);
            this.TBox_ExportPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "解包儲存位置";
            // 
            // TBox_FileName
            // 
            this.TBox_FileName.Location = new System.Drawing.Point(12, 115);
            this.TBox_FileName.Name = "TBox_FileName";
            this.TBox_FileName.Size = new System.Drawing.Size(486, 23);
            this.TBox_FileName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "檔案名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "時間間隔(分)";
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Location = new System.Drawing.Point(93, 195);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown_Time.TabIndex = 9;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBox_AutoExport
            // 
            this.CBox_AutoExport.AutoSize = true;
            this.CBox_AutoExport.Checked = true;
            this.CBox_AutoExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBox_AutoExport.Location = new System.Drawing.Point(149, 196);
            this.CBox_AutoExport.Name = "CBox_AutoExport";
            this.CBox_AutoExport.Size = new System.Drawing.Size(74, 19);
            this.CBox_AutoExport.TabIndex = 10;
            this.CBox_AutoExport.Text = "自動解包";
            this.CBox_AutoExport.UseVisualStyleBackColor = true;
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.Location = new System.Drawing.Point(423, 193);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.Btn_Accept.TabIndex = 11;
            this.Btn_Accept.Text = "確定";
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(342, 193);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 12;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_SelectIndex
            // 
            this.Btn_SelectIndex.Location = new System.Drawing.Point(261, 193);
            this.Btn_SelectIndex.Name = "Btn_SelectIndex";
            this.Btn_SelectIndex.Size = new System.Drawing.Size(75, 23);
            this.Btn_SelectIndex.TabIndex = 13;
            this.Btn_SelectIndex.Text = "選擇Index";
            this.Btn_SelectIndex.UseVisualStyleBackColor = true;
            this.Btn_SelectIndex.Click += new System.EventHandler(this.Btn_SelectIndex_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBox_TW_iOS);
            this.groupBox1.Controls.Add(this.RBox_TW_Android);
            this.groupBox1.Controls.Add(this.RBox_JP_iOS);
            this.groupBox1.Controls.Add(this.RBox_JP_Android);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 43);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "伺服器";
            // 
            // RBox_TW_iOS
            // 
            this.RBox_TW_iOS.AutoSize = true;
            this.RBox_TW_iOS.Location = new System.Drawing.Point(283, 18);
            this.RBox_TW_iOS.Name = "RBox_TW_iOS";
            this.RBox_TW_iOS.Size = new System.Drawing.Size(69, 19);
            this.RBox_TW_iOS.TabIndex = 3;
            this.RBox_TW_iOS.Text = "日版iOS";
            this.RBox_TW_iOS.UseVisualStyleBackColor = true;
            // 
            // RBox_TW_Android
            // 
            this.RBox_TW_Android.AutoSize = true;
            this.RBox_TW_Android.Location = new System.Drawing.Point(182, 18);
            this.RBox_TW_Android.Name = "RBox_TW_Android";
            this.RBox_TW_Android.Size = new System.Drawing.Size(95, 19);
            this.RBox_TW_Android.TabIndex = 2;
            this.RBox_TW_Android.Text = "台版Android";
            this.RBox_TW_Android.UseVisualStyleBackColor = true;
            // 
            // RBox_JP_iOS
            // 
            this.RBox_JP_iOS.AutoSize = true;
            this.RBox_JP_iOS.Location = new System.Drawing.Point(107, 18);
            this.RBox_JP_iOS.Name = "RBox_JP_iOS";
            this.RBox_JP_iOS.Size = new System.Drawing.Size(69, 19);
            this.RBox_JP_iOS.TabIndex = 1;
            this.RBox_JP_iOS.Text = "日版iOS";
            this.RBox_JP_iOS.UseVisualStyleBackColor = true;
            // 
            // RBox_JP_Android
            // 
            this.RBox_JP_Android.AutoSize = true;
            this.RBox_JP_Android.Checked = true;
            this.RBox_JP_Android.Location = new System.Drawing.Point(6, 18);
            this.RBox_JP_Android.Name = "RBox_JP_Android";
            this.RBox_JP_Android.Size = new System.Drawing.Size(95, 19);
            this.RBox_JP_Android.TabIndex = 0;
            this.RBox_JP_Android.TabStop = true;
            this.RBox_JP_Android.Text = "日版Android";
            this.RBox_JP_Android.UseVisualStyleBackColor = true;
            // 
            // NewWindow
            // 
            this.AcceptButton = this.Btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(510, 225);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_SelectIndex);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Accept);
            this.Controls.Add(this.CBox_AutoExport);
            this.Controls.Add(this.numericUpDown_Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBox_FileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_SavePath);
            this.Controls.Add(this.TBox_ExportPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_IndexPath);
            this.Controls.Add(this.TBox_IndexPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新增檢測視窗";
            this.Load += new System.EventHandler(this.NewWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TBox_IndexPath;
        private Button Btn_IndexPath;
        private Button Btn_SavePath;
        private TextBox TBox_ExportPath;
        private Label label2;
        private TextBox TBox_FileName;
        private Label label3;
        private Label label4;
        private FolderBrowserDialog folderBrowserDialog1;
        private NumericUpDown numericUpDown_Time;
        private CheckBox CBox_AutoExport;
        private Button Btn_Accept;
        private Button Btn_Cancel;
        private Button Btn_SelectIndex;
        private GroupBox groupBox1;
        private RadioButton RBox_TW_iOS;
        private RadioButton RBox_TW_Android;
        private RadioButton RBox_JP_iOS;
        private RadioButton RBox_JP_Android;
    }
}