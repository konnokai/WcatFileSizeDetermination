namespace Wcat_Index_Decide
{
    partial class ServerSetting
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
            this.TBox_JP_Android = new System.Windows.Forms.TextBox();
            this.TBox_JP_iOS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox_TW_Android = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBox_TW_iOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "日版Android";
            // 
            // TBox_JP_Android
            // 
            this.TBox_JP_Android.Location = new System.Drawing.Point(12, 27);
            this.TBox_JP_Android.Name = "TBox_JP_Android";
            this.TBox_JP_Android.Size = new System.Drawing.Size(501, 23);
            this.TBox_JP_Android.TabIndex = 1;
            this.TBox_JP_Android.Text = "https://i-cf.wcat.colopl.jp/assets/2020/a/";
            // 
            // TBox_JP_iOS
            // 
            this.TBox_JP_iOS.Location = new System.Drawing.Point(12, 71);
            this.TBox_JP_iOS.Name = "TBox_JP_iOS";
            this.TBox_JP_iOS.Size = new System.Drawing.Size(501, 23);
            this.TBox_JP_iOS.TabIndex = 3;
            this.TBox_JP_iOS.Text = "https://i-cf.wcat.colopl.jp/assets/2020/i/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "日版iOS";
            // 
            // TBox_TW_Android
            // 
            this.TBox_TW_Android.Location = new System.Drawing.Point(12, 115);
            this.TBox_TW_Android.Name = "TBox_TW_Android";
            this.TBox_TW_Android.Size = new System.Drawing.Size(501, 23);
            this.TBox_TW_Android.TabIndex = 5;
            this.TBox_TW_Android.Text = "http://img.wcproject.so-net.tw/assets/2020/a/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "台版Android";
            // 
            // TBox_TW_iOS
            // 
            this.TBox_TW_iOS.Location = new System.Drawing.Point(12, 159);
            this.TBox_TW_iOS.Name = "TBox_TW_iOS";
            this.TBox_TW_iOS.Size = new System.Drawing.Size(501, 23);
            this.TBox_TW_iOS.TabIndex = 7;
            this.TBox_TW_iOS.Text = "http://img.wcproject.so-net.tw/assets/2020/i/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "台版iOS";
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.Location = new System.Drawing.Point(438, 188);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.Btn_Accept.TabIndex = 8;
            this.Btn_Accept.Text = "確定";
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // ServerSetting
            // 
            this.AcceptButton = this.Btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 218);
            this.Controls.Add(this.Btn_Accept);
            this.Controls.Add(this.TBox_TW_iOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBox_TW_Android);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBox_JP_iOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox_JP_Android);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "伺服器設定";
            this.Load += new System.EventHandler(this.ServerSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TBox_JP_Android;
        private TextBox TBox_JP_iOS;
        private Label label2;
        private TextBox TBox_TW_Android;
        private Label label3;
        private TextBox TBox_TW_iOS;
        private Label label4;
        private Button Btn_Accept;
    }
}