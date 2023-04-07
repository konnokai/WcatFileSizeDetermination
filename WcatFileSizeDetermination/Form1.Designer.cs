namespace WcatFileSizeDetermination
{
	public partial class Form1 : global::System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lab_Step = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.list_Event = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lab_Time = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(423, 4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "開始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(343, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "暫停";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lab_Step
            // 
            this.lab_Step.AutoSize = true;
            this.lab_Step.Location = new System.Drawing.Point(83, 9);
            this.lab_Step.Name = "lab_Step";
            this.lab_Step.Size = new System.Drawing.Size(59, 12);
            this.lab_Step.TabIndex = 9;
            this.lab_Step.Text = "運行第0次";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // list_Event
            // 
            this.list_Event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.list_Event.GridLines = true;
            this.list_Event.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_Event.LabelWrap = false;
            this.list_Event.Location = new System.Drawing.Point(13, 33);
            this.list_Event.MultiSelect = false;
            this.list_Event.Name = "list_Event";
            this.list_Event.Size = new System.Drawing.Size(486, 323);
            this.list_Event.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_Event.TabIndex = 12;
            this.list_Event.UseCompatibleStateImageBehavior = false;
            this.list_Event.View = System.Windows.Forms.View.Details;
            this.list_Event.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_Event_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名稱(事件)";
            this.columnHeader1.Width = 275;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大小";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "時間";
            this.columnHeader4.Width = 100;
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Location = new System.Drawing.Point(148, 9);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(101, 12);
            this.lab_Time.TabIndex = 14;
            this.lab_Time.Text = "已用時間: 00:00:00";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(11, 9);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(68, 12);
            this.lab_status.TabIndex = 16;
            this.lab_status.Text = "狀態:暫停中";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(317, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.lab_Time);
            this.Controls.Add(this.list_Event);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lab_Step);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "檔案 ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		private global::System.Windows.Forms.Timer timer;

		private global::System.Windows.Forms.Button btn_Start;

		private global::System.Windows.Forms.Button btn_Stop;

		private global::System.Windows.Forms.Label lab_Step;

		private global::System.Windows.Forms.Timer timer2;

		private global::System.Windows.Forms.ListView list_Event;

		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		private global::System.Windows.Forms.Label lab_Time;

		private global::System.Windows.Forms.Label lab_status;

		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
