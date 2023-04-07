namespace WcatFileSizeDetermination
{
	public partial class ServerSetting : global::System.Windows.Forms.Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TW = new System.Windows.Forms.TextBox();
            this.txt_JP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "台版伺服器:";
            // 
            // txt_TW
            // 
            this.txt_TW.Location = new System.Drawing.Point(78, 6);
            this.txt_TW.Name = "txt_TW";
            this.txt_TW.Size = new System.Drawing.Size(409, 22);
            this.txt_TW.TabIndex = 1;
            this.txt_TW.Text = "http://img.wcproject.so-net.tw/assets/2018/a/";
            // 
            // txt_JP
            // 
            this.txt_JP.Location = new System.Drawing.Point(78, 34);
            this.txt_JP.Name = "txt_JP";
            this.txt_JP.Size = new System.Drawing.Size(409, 22);
            this.txt_JP.TabIndex = 3;
            this.txt_JP.Text = "https://i-cf.wcat.colopl.jp/assets/2020/a/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "日版伺服器:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(412, 62);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "確定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ServerSetting
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 89);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_JP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TW);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServerSetting";
            this.Text = "伺服器設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerSetting_FormClosing);
            this.Load += new System.EventHandler(this.ServerSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox txt_TW;

		private global::System.Windows.Forms.TextBox txt_JP;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Button btn_ok;
	}
}
