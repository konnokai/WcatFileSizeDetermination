namespace WcatFileSizeDetermination
{
	public partial class Setting : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.btn_IndexPath = new System.Windows.Forms.Button();
            this.txt_IndexPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Time = new System.Windows.Forms.ComboBox();
            this.btn_SeleteIndex = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_ExportPath = new System.Windows.Forms.Button();
            this.txt_ExportPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chb_AutoExport = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_IndexPath
            // 
            this.btn_IndexPath.Location = new System.Drawing.Point(472, 23);
            this.btn_IndexPath.Name = "btn_IndexPath";
            this.btn_IndexPath.Size = new System.Drawing.Size(26, 23);
            this.btn_IndexPath.TabIndex = 10;
            this.btn_IndexPath.Text = "...";
            this.btn_IndexPath.UseVisualStyleBackColor = true;
            this.btn_IndexPath.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // txt_IndexPath
            // 
            this.txt_IndexPath.Location = new System.Drawing.Point(14, 24);
            this.txt_IndexPath.Name = "txt_IndexPath";
            this.txt_IndexPath.ReadOnly = true;
            this.txt_IndexPath.Size = new System.Drawing.Size(454, 22);
            this.txt_IndexPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Index儲存位置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "檔案名稱";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(15, 102);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(484, 22);
            this.txt_FileName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "時間間隔(分)";
            // 
            // cmb_Time
            // 
            this.cmb_Time.FormattingEnabled = true;
            this.cmb_Time.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "30",
            "60",
            "120"});
            this.cmb_Time.Location = new System.Drawing.Point(91, 131);
            this.cmb_Time.MaxDropDownItems = 6;
            this.cmb_Time.MaxLength = 3;
            this.cmb_Time.Name = "cmb_Time";
            this.cmb_Time.Size = new System.Drawing.Size(42, 20);
            this.cmb_Time.TabIndex = 15;
            this.cmb_Time.Text = "1";
            // 
            // btn_SeleteIndex
            // 
            this.btn_SeleteIndex.Location = new System.Drawing.Point(262, 130);
            this.btn_SeleteIndex.Name = "btn_SeleteIndex";
            this.btn_SeleteIndex.Size = new System.Drawing.Size(75, 23);
            this.btn_SeleteIndex.TabIndex = 17;
            this.btn_SeleteIndex.Text = "選擇Index";
            this.btn_SeleteIndex.UseVisualStyleBackColor = true;
            this.btn_SeleteIndex.Click += new System.EventHandler(this.btn_SeleteIndex_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(343, 130);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.Text = "取消";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn_ExportPath
            // 
            this.btn_ExportPath.Location = new System.Drawing.Point(473, 63);
            this.btn_ExportPath.Name = "btn_ExportPath";
            this.btn_ExportPath.Size = new System.Drawing.Size(26, 23);
            this.btn_ExportPath.TabIndex = 21;
            this.btn_ExportPath.Text = "...";
            this.btn_ExportPath.UseVisualStyleBackColor = true;
            this.btn_ExportPath.Click += new System.EventHandler(this.btn_ExportPath_Click);
            // 
            // txt_ExportPath
            // 
            this.txt_ExportPath.Location = new System.Drawing.Point(15, 64);
            this.txt_ExportPath.Name = "txt_ExportPath";
            this.txt_ExportPath.ReadOnly = true;
            this.txt_ExportPath.Size = new System.Drawing.Size(454, 22);
            this.txt_ExportPath.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "解包儲存位置";
            // 
            // chb_AutoExport
            // 
            this.chb_AutoExport.AutoSize = true;
            this.chb_AutoExport.Checked = true;
            this.chb_AutoExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_AutoExport.Location = new System.Drawing.Point(140, 134);
            this.chb_AutoExport.Name = "chb_AutoExport";
            this.chb_AutoExport.Size = new System.Drawing.Size(72, 16);
            this.chb_AutoExport.TabIndex = 22;
            this.chb_AutoExport.Text = "自動解包";
            this.chb_AutoExport.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 160);
            this.Controls.Add(this.chb_AutoExport);
            this.Controls.Add(this.btn_ExportPath);
            this.Controls.Add(this.txt_ExportPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SeleteIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Time);
            this.Controls.Add(this.btn_IndexPath);
            this.Controls.Add(this.txt_IndexPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新增視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.Button btn_IndexPath;

		private global::System.Windows.Forms.TextBox txt_IndexPath;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox txt_FileName;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.ComboBox cmb_Time;

		private global::System.Windows.Forms.Button btn_SeleteIndex;

		private global::System.Windows.Forms.Button btn_Close;

		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		private global::System.Windows.Forms.Button btn_ExportPath;

		private global::System.Windows.Forms.TextBox txt_ExportPath;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.CheckBox chb_AutoExport;
	}
}
