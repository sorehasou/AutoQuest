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
            this.devMenu = new System.Windows.Forms.MenuStrip();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.デバッグツール表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cefsharpArea
            // 
            this.cefsharpArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cefsharpArea.Location = new System.Drawing.Point(0, 0);
            this.cefsharpArea.Name = "cefsharpArea";
            this.cefsharpArea.Size = new System.Drawing.Size(456, 655);
            this.cefsharpArea.TabIndex = 0;
            // 
            // devMenu
            // 
            this.devMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新ToolStripMenuItem,
            this.デバッグツール表示ToolStripMenuItem,
            this.テストToolStripMenuItem});
            this.devMenu.Location = new System.Drawing.Point(0, 0);
            this.devMenu.Name = "devMenu";
            this.devMenu.Size = new System.Drawing.Size(456, 24);
            this.devMenu.TabIndex = 1;
            this.devMenu.Text = "menuStrip1";
            this.devMenu.Visible = false;
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
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
            this.alertToolStripMenuItem,
            this.edaxToolStripMenuItem});
            this.テストToolStripMenuItem.Name = "テストToolStripMenuItem";
            this.テストToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.テストToolStripMenuItem.Text = "テスト";
            // 
            // alertToolStripMenuItem
            // 
            this.alertToolStripMenuItem.Name = "alertToolStripMenuItem";
            this.alertToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.alertToolStripMenuItem.Text = "alert";
            this.alertToolStripMenuItem.Click += new System.EventHandler(this.alertToolStripMenuItem_Click);
            // 
            // edaxToolStripMenuItem
            // 
            this.edaxToolStripMenuItem.Name = "edaxToolStripMenuItem";
            this.edaxToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.edaxToolStripMenuItem.Text = "edax";
            this.edaxToolStripMenuItem.Click += new System.EventHandler(this.edaxToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 655);
            this.Controls.Add(this.cefsharpArea);
            this.Controls.Add(this.devMenu);
            this.MainMenuStrip = this.devMenu;
            this.Name = "MainForm";
            this.Text = "AutoQuest";
            this.devMenu.ResumeLayout(false);
            this.devMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cefsharpArea;
        private System.Windows.Forms.MenuStrip devMenu;
        private System.Windows.Forms.ToolStripMenuItem デバッグツール表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edaxToolStripMenuItem;
    }
}

