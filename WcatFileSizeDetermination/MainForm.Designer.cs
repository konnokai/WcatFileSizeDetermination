namespace Wcat_Index_Decide
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Lab_Status = new System.Windows.Forms.Label();
            this.Lab_Step = new System.Windows.Forms.Label();
            this.Lab_UsedTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Status = new System.Windows.Forms.Button();
            this.ListView_Log = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.Timer_Time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_Status
            // 
            this.Lab_Status.AutoSize = true;
            this.Lab_Status.Location = new System.Drawing.Point(12, 9);
            this.Lab_Status.Name = "Lab_Status";
            this.Lab_Status.Size = new System.Drawing.Size(73, 15);
            this.Lab_Status.TabIndex = 0;
            this.Lab_Status.Text = "狀態: 等待中";
            // 
            // Lab_Step
            // 
            this.Lab_Step.AutoSize = true;
            this.Lab_Step.Location = new System.Drawing.Point(235, 9);
            this.Lab_Step.Name = "Lab_Step";
            this.Lab_Step.Size = new System.Drawing.Size(68, 15);
            this.Lab_Step.TabIndex = 1;
            this.Lab_Step.Text = "運行第 0 次";
            // 
            // Lab_UsedTime
            // 
            this.Lab_UsedTime.AutoSize = true;
            this.Lab_UsedTime.Location = new System.Drawing.Point(91, 9);
            this.Lab_UsedTime.Name = "Lab_UsedTime";
            this.Lab_UsedTime.Size = new System.Drawing.Size(138, 15);
            this.Lab_UsedTime.TabIndex = 2;
            this.Lab_UsedTime.Text = "已用時間: 00天 00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(368, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Status
            // 
            this.Btn_Status.Location = new System.Drawing.Point(397, 5);
            this.Btn_Status.Name = "Btn_Status";
            this.Btn_Status.Size = new System.Drawing.Size(75, 23);
            this.Btn_Status.TabIndex = 4;
            this.Btn_Status.Text = "停止";
            this.Btn_Status.UseVisualStyleBackColor = true;
            this.Btn_Status.Click += new System.EventHandler(this.Btn_Status_Click);
            // 
            // ListView_Log
            // 
            this.ListView_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_Log.FullRowSelect = true;
            this.ListView_Log.GridLines = true;
            this.ListView_Log.Location = new System.Drawing.Point(12, 34);
            this.ListView_Log.MultiSelect = false;
            this.ListView_Log.Name = "ListView_Log";
            this.ListView_Log.ShowGroups = false;
            this.ListView_Log.Size = new System.Drawing.Size(460, 315);
            this.ListView_Log.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListView_Log.TabIndex = 5;
            this.ListView_Log.TabStop = false;
            this.ListView_Log.UseCompatibleStateImageBehavior = false;
            this.ListView_Log.View = System.Windows.Forms.View.Details;
            this.ListView_Log.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_Log_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名稱(事件)";
            this.columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大小";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "時間";
            this.columnHeader3.Width = 100;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Tick += new System.EventHandler(this.Timer_Main_Tick);
            // 
            // Timer_Time
            // 
            this.Timer_Time.Enabled = true;
            this.Timer_Time.Interval = 1000;
            this.Timer_Time.Tick += new System.EventHandler(this.Timer_Time_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ListView_Log);
            this.Controls.Add(this.Btn_Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lab_UsedTime);
            this.Controls.Add(this.Lab_Step);
            this.Controls.Add(this.Lab_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lab_Status;
        private Label Lab_Step;
        private Label Lab_UsedTime;
        private PictureBox pictureBox1;
        private Button Btn_Status;
        private ListView ListView_Log;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer Timer_Main;
        private System.Windows.Forms.Timer Timer_Time;
    }
}