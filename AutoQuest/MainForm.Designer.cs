namespace AutoQuest
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cefsharpArea = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.デバッグツール表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cefsharpArea
            // 
            this.cefsharpArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cefsharpArea.Location = new System.Drawing.Point(0, 24);
            this.cefsharpArea.Name = "cefsharpArea";
            this.cefsharpArea.Size = new System.Drawing.Size(456, 631);
            this.cefsharpArea.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.デバッグツール表示ToolStripMenuItem,
            this.テストToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // デバッグツール表示ToolStripMenuItem
            // 
            this.デバッグツール表示ToolStripMenuItem.Name = "デバッグツール表示ToolStripMenuItem";
            this.デバッグツール表示ToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.デバッグツール表示ToolStripMenuItem.Text = "デバッグツール表示";
            this.デバッグツール表示ToolStripMenuItem.Click += new System.EventHandler(this.デバッグツール表示ToolStripMenuItem_Click);
            // 
            // テストToolStripMenuItem
            // 
            this.テストToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertToolStripMenuItem});
            this.テストToolStripMenuItem.Name = "テストToolStripMenuItem";
            this.テストToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.テストToolStripMenuItem.Text = "テスト";
            // 
            // alertToolStripMenuItem
            // 
            this.alertToolStripMenuItem.Name = "alertToolStripMenuItem";
            this.alertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alertToolStripMenuItem.Text = "alert";
            this.alertToolStripMenuItem.Click += new System.EventHandler(this.alertToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 655);
            this.Controls.Add(this.cefsharpArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AutoQuest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cefsharpArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem デバッグツール表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertToolStripMenuItem;
    }
}

