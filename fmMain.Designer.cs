namespace OlConfigTools
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnRun = new System.Windows.Forms.Button();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDisplayName = new System.Windows.Forms.TextBox();
            this.tbxAccountPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPstPathFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbAccounts = new System.Windows.Forms.CheckedListBox();
            this.lbOpenOutlook = new System.Windows.Forms.LinkLabel();
            this.lbOpenSet = new System.Windows.Forms.LinkLabel();
            this.lbOutlookPath = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(370, 272);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(93, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "执行导入配置";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbxCompany
            // 
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(59, 64);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(71, 20);
            this.cbxCompany.TabIndex = 1;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选项：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "邮箱显示名：";
            // 
            // tbxDisplayName
            // 
            this.tbxDisplayName.Location = new System.Drawing.Point(95, 111);
            this.tbxDisplayName.Name = "tbxDisplayName";
            this.tbxDisplayName.Size = new System.Drawing.Size(100, 21);
            this.tbxDisplayName.TabIndex = 4;
            // 
            // tbxAccountPrefix
            // 
            this.tbxAccountPrefix.Location = new System.Drawing.Point(220, 63);
            this.tbxAccountPrefix.Name = "tbxAccountPrefix";
            this.tbxAccountPrefix.Size = new System.Drawing.Size(91, 21);
            this.tbxAccountPrefix.TabIndex = 4;
            this.tbxAccountPrefix.TextChanged += new System.EventHandler(this.tbxAccountPrefix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "邮箱前缀：";
            // 
            // tbxPstName
            // 
            this.tbxPstName.Location = new System.Drawing.Point(95, 161);
            this.tbxPstName.Name = "tbxPstName";
            this.tbxPstName.Size = new System.Drawing.Size(216, 21);
            this.tbxPstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "PST显示名：";
            // 
            // tbxPstPathFilename
            // 
            this.tbxPstPathFilename.Location = new System.Drawing.Point(89, 218);
            this.tbxPstPathFilename.Name = "tbxPstPathFilename";
            this.tbxPstPathFilename.Size = new System.Drawing.Size(352, 21);
            this.tbxPstPathFilename.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "PST文件：";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.clbAccounts);
            this.panel1.Controls.Add(this.lbOpenOutlook);
            this.panel1.Controls.Add(this.lbOpenSet);
            this.panel1.Controls.Add(this.lbOutlookPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxAccountPrefix);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.tbxPstPathFilename);
            this.panel1.Controls.Add(this.cbxCompany);
            this.panel1.Controls.Add(this.tbxPstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxDisplayName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 325);
            this.panel1.TabIndex = 5;
            // 
            // clbAccounts
            // 
            this.clbAccounts.CheckOnClick = true;
            this.clbAccounts.Location = new System.Drawing.Point(339, 63);
            this.clbAccounts.Name = "clbAccounts";
            this.clbAccounts.Size = new System.Drawing.Size(142, 116);
            this.clbAccounts.TabIndex = 6;
            // 
            // lbOpenOutlook
            // 
            this.lbOpenOutlook.AutoSize = true;
            this.lbOpenOutlook.Location = new System.Drawing.Point(247, 277);
            this.lbOpenOutlook.Name = "lbOpenOutlook";
            this.lbOpenOutlook.Size = new System.Drawing.Size(47, 12);
            this.lbOpenOutlook.TabIndex = 5;
            this.lbOpenOutlook.TabStop = true;
            this.lbOpenOutlook.Text = "Outlook";
            this.lbOpenOutlook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbOpenOutlook_LinkClicked);
            // 
            // lbOpenSet
            // 
            this.lbOpenSet.AutoSize = true;
            this.lbOpenSet.Location = new System.Drawing.Point(23, 277);
            this.lbOpenSet.Name = "lbOpenSet";
            this.lbOpenSet.Size = new System.Drawing.Size(113, 12);
            this.lbOpenSet.TabIndex = 5;
            this.lbOpenSet.TabStop = true;
            this.lbOpenSet.Text = "控制面板邮件配置项";
            this.lbOpenSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbOpenSet_LinkClicked);
            // 
            // lbOutlookPath
            // 
            this.lbOutlookPath.AutoSize = true;
            this.lbOutlookPath.Location = new System.Drawing.Point(23, 13);
            this.lbOutlookPath.Name = "lbOutlookPath";
            this.lbOutlookPath.Size = new System.Drawing.Size(71, 12);
            this.lbOutlookPath.TabIndex = 5;
            this.lbOutlookPath.TabStop = true;
            this.lbOutlookPath.Text = "OutlookPath";
            this.lbOutlookPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbOutlookPath_LinkClicked);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 325);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 364);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook邮箱帐号快捷配置工具 - OlConfigTools";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDisplayName;
        private System.Windows.Forms.TextBox tbxAccountPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPstPathFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbOpenSet;
        private System.Windows.Forms.LinkLabel lbOutlookPath;
        private System.Windows.Forms.LinkLabel lbOpenOutlook;
        private System.Windows.Forms.CheckedListBox clbAccounts;
    }
}

