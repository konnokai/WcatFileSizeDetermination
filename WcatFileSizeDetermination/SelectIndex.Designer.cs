namespace Wcat_Index_Decide
{
    partial class SelectIndex
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Accessory",
            "Action",
            "AdvancedJobItem",
            "Area",
            "Building",
            "Card",
            "Character",
            "CutScene",
            "Data",
            "Effect",
            "Event",
            "ExSoulBoard",
            "FieldTable",
            "InGame",
            "Item",
            "Lightmap",
            "List",
            "Location",
            "Logo",
            "MapChip",
            "NGUIAtlas",
            "OutGame",
            "Shop",
            "SoulBoard",
            "Sound",
            "Stage",
            "StagePlacementObject",
            "Stamp",
            "TexturesDL",
            "Town",
            "Weapon",
            "WeaponBullet",
            "World"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 567);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // SelectIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 567);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectIndex";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "選擇Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectIndex_FormClosing);
            this.Load += new System.EventHandler(this.SelectIndex_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
    }
}