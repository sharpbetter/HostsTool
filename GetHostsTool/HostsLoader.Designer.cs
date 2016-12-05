namespace HostsGetTool
{
    partial class HostsLoader
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labLocalVersion = new System.Windows.Forms.Label();
            this.labServerVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCodingCheck = new System.Windows.Forms.Label();
            this.labGithubCheck = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载HostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImageDownloadLink = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于HOSTS下载器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(32, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 38);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "更新HOSTS";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnRegain
            // 
            this.btnRegain.Location = new System.Drawing.Point(277, 257);
            this.btnRegain.Name = "btnRegain";
            this.btnRegain.Size = new System.Drawing.Size(200, 38);
            this.btnRegain.TabIndex = 1;
            this.btnRegain.Text = "恢复初始HOSTS";
            this.btnRegain.UseVisualStyleBackColor = true;
            this.btnRegain.Click += new System.EventHandler(this.btnRegain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "本地 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器 :";
            // 
            // labLocalVersion
            // 
            this.labLocalVersion.AutoSize = true;
            this.labLocalVersion.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labLocalVersion.Location = new System.Drawing.Point(88, 31);
            this.labLocalVersion.Name = "labLocalVersion";
            this.labLocalVersion.Size = new System.Drawing.Size(85, 20);
            this.labLocalVersion.TabIndex = 4;
            this.labLocalVersion.Text = "0000-00-00";
            // 
            // labServerVersion
            // 
            this.labServerVersion.AutoSize = true;
            this.labServerVersion.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labServerVersion.Location = new System.Drawing.Point(88, 60);
            this.labServerVersion.Name = "labServerVersion";
            this.labServerVersion.Size = new System.Drawing.Size(85, 20);
            this.labServerVersion.TabIndex = 5;
            this.labServerVersion.Text = "0000-00-00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GitHub :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(23, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coding :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labCodingCheck);
            this.groupBox1.Controls.Add(this.labGithubCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(277, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "镜像连接状态";
            // 
            // labCodingCheck
            // 
            this.labCodingCheck.AutoSize = true;
            this.labCodingCheck.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labCodingCheck.Location = new System.Drawing.Point(94, 60);
            this.labCodingCheck.Name = "labCodingCheck";
            this.labCodingCheck.Size = new System.Drawing.Size(60, 20);
            this.labCodingCheck.TabIndex = 9;
            this.labCodingCheck.Text = "连接中...";
            // 
            // labGithubCheck
            // 
            this.labGithubCheck.AutoSize = true;
            this.labGithubCheck.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labGithubCheck.Location = new System.Drawing.Point(94, 26);
            this.labGithubCheck.Name = "labGithubCheck";
            this.labGithubCheck.Size = new System.Drawing.Size(60, 20);
            this.labGithubCheck.TabIndex = 8;
            this.labGithubCheck.Text = "连接中...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labServerVersion);
            this.groupBox2.Controls.Add(this.labLocalVersion);
            this.groupBox2.Location = new System.Drawing.Point(32, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HOSTS版本";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GetHostsTool.Properties.Resources._3_e827b458;
            this.pictureBox1.Location = new System.Drawing.Point(13, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 81);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.Location = new System.Drawing.Point(4, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Version : 1.1.0 beta";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(509, 28);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载HostsToolStripMenuItem,
            this.tsmImageDownloadLink,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 下载HostsToolStripMenuItem
            // 
            this.下载HostsToolStripMenuItem.Name = "下载HostsToolStripMenuItem";
            this.下载HostsToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.下载HostsToolStripMenuItem.Text = "下载HOSTS";
            this.下载HostsToolStripMenuItem.Click += new System.EventHandler(this.HostsToolStripMenuItemDownLoader_Click);
            // 
            // tsmImageDownloadLink
            // 
            this.tsmImageDownloadLink.Name = "tsmImageDownloadLink";
            this.tsmImageDownloadLink.Size = new System.Drawing.Size(162, 24);
            this.tsmImageDownloadLink.Text = "输入镜像网址";
            this.tsmImageDownloadLink.Click += new System.EventHandler(this.tsmImageDownloadLink_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.TsmClose_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于HOSTS下载器ToolStripMenuItem,
            this.tsmUpdate});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于HOSTS下载器ToolStripMenuItem
            // 
            this.关于HOSTS下载器ToolStripMenuItem.Name = "关于HOSTS下载器ToolStripMenuItem";
            this.关于HOSTS下载器ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.关于HOSTS下载器ToolStripMenuItem.Text = "关于";
            this.关于HOSTS下载器ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuAbout_Click);
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(134, 24);
            this.tsmUpdate.Text = "检查更新";
            this.tsmUpdate.Click += new System.EventHandler(this.tsmUpdate_Click);
            // 
            // HostsLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegain);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "HostsLoader";
            this.Text = "Hosts下载器";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labLocalVersion;
        private System.Windows.Forms.Label labServerVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labCodingCheck;
        private System.Windows.Forms.Label labGithubCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载HostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmImageDownloadLink;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于HOSTS下载器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.FolderBrowserDialog fileDialog;
    }
}

