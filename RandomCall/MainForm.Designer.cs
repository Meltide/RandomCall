namespace RandomCall
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已点名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.允许重复点名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.重置名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.LightGreen;
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.start_btn, "start_btn");
            this.start_btn.Name = "start_btn";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.重置名单ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看名单ToolStripMenuItem,
            this.已点名ToolStripMenuItem,
            this.导入名单ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            resources.ApplyResources(this.文件ToolStripMenuItem, "文件ToolStripMenuItem");
            // 
            // 查看名单ToolStripMenuItem
            // 
            this.查看名单ToolStripMenuItem.Name = "查看名单ToolStripMenuItem";
            resources.ApplyResources(this.查看名单ToolStripMenuItem, "查看名单ToolStripMenuItem");
            this.查看名单ToolStripMenuItem.Click += new System.EventHandler(this.查看名单ToolStripMenuItem_Click);
            // 
            // 已点名ToolStripMenuItem
            // 
            this.已点名ToolStripMenuItem.Name = "已点名ToolStripMenuItem";
            resources.ApplyResources(this.已点名ToolStripMenuItem, "已点名ToolStripMenuItem");
            this.已点名ToolStripMenuItem.Click += new System.EventHandler(this.已点名ToolStripMenuItem_Click);
            // 
            // 导入名单ToolStripMenuItem
            // 
            this.导入名单ToolStripMenuItem.Name = "导入名单ToolStripMenuItem";
            resources.ApplyResources(this.导入名单ToolStripMenuItem, "导入名单ToolStripMenuItem");
            this.导入名单ToolStripMenuItem.Click += new System.EventHandler(this.导入名单ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            resources.ApplyResources(this.退出ToolStripMenuItem1, "退出ToolStripMenuItem1");
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.允许重复点名ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            resources.ApplyResources(this.设置ToolStripMenuItem, "设置ToolStripMenuItem");
            // 
            // 允许重复点名ToolStripMenuItem
            // 
            this.允许重复点名ToolStripMenuItem.CheckOnClick = true;
            this.允许重复点名ToolStripMenuItem.Name = "允许重复点名ToolStripMenuItem";
            resources.ApplyResources(this.允许重复点名ToolStripMenuItem, "允许重复点名ToolStripMenuItem");
            this.允许重复点名ToolStripMenuItem.Click += new System.EventHandler(this.允许重复点名ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            resources.ApplyResources(this.关于ToolStripMenuItem1, "关于ToolStripMenuItem1");
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // 重置名单ToolStripMenuItem
            // 
            this.重置名单ToolStripMenuItem.Name = "重置名单ToolStripMenuItem";
            resources.ApplyResources(this.重置名单ToolStripMenuItem, "重置名单ToolStripMenuItem");
            this.重置名单ToolStripMenuItem.Click += new System.EventHandler(this.重置名单ToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Name = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已点名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 重置名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 允许重复点名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看名单ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

