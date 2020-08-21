using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace OlConfigTools
{
    public partial class fmMain : Form
    {
        private string OutlookPath;
        private string OutlookName;
        private IList<OlPrfSetInfo> setInfos = new List<OlPrfSetInfo>();
        private string PstPathDrive = "D:\\";
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            setInfos = OlPrfSetInfo.GetSetInfos();

            bool g = GetOutlookPath.TryGetPath(out OutlookPath);
            if (!g)
            {
                MessageBox.Show("未检测到Outlook程序安装路径！");
                return;
            }
            else
            {

                OutlookName = OutlookPath.Substring(OutlookPath.LastIndexOf("\\") + 1);
                OutlookPath = OutlookPath.Substring(0, OutlookPath.LastIndexOf("\\"));

                lbOutlookPath.Text = OutlookPath;
            }

            var drvs = Environment.GetLogicalDrives();
            if (drvs.Length == 1)
            {
                PstPathDrive = drvs[0];
            }
            else
            {
                PstPathDrive = drvs[1];
            }


            string[] comnames = setInfos.Select(s => s.CompanyName).ToArray();

            for (int i = 0; i < comnames.Length; i++)
            {
                cbxCompany.Items.Add(comnames[i]);
            }
            if (comnames.Length > 0)
            {
                cbxCompany.Text = comnames[0];

                tbxAccountPrefix.Text = cbxCompany.Text + "1";
            }

        }

        private void lbOpenSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"\"{OutlookPath}\\MLCFG32.CPL\"");
        }

        private void lbOpenOutlook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"\"{OutlookPath}\\{OutlookName}\"");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            OlPrfSetInfo prfSetInfo = new OlPrfSetInfo
            {
                CompanyName = cbxCompany.Text,
                AccountPrefix = tbxAccountPrefix.Text,
                DisplayName = tbxDisplayName.Text,
                PstName = tbxPstName.Text,
                PstPathFilename = tbxPstPathFilename.Text,
                ProfileName = $"{cbxCompany.Text} Config From OlConfigTools.Prf",
                Accounts = new List<OlPrfAccount>()
            };

            for (int i = 0; i < clbAccounts.CheckedItems.Count; i++)
            {
                prfSetInfo.Accounts.Add((OlPrfAccount)clbAccounts.CheckedItems[i]);
            }

            try
            {
                string prf = new OlPrfSetHelper().MakePrf(prfSetInfo);
                Console.WriteLine($"\"{OutlookPath}\\{OutlookName}\" /importprf \"{prf}\"");

                Process p = new Process();
                p.StartInfo.FileName = $"\"{OutlookPath}\\{OutlookName}\"";
                p.StartInfo.Arguments = $"/importprf {prf}";
                p.StartInfo.WorkingDirectory = OutlookPath;// 这个节点非常重要，位置一定要写对，是bat的工作区，不然bat在C#下运行找不到prf文件
                p.StartInfo.UseShellExecute = false;//是否重定向标准输入 
                p.StartInfo.RedirectStandardInput = false;//是否重定向标准转出 
                p.StartInfo.RedirectStandardOutput = false;//是否重定向错误 
                p.StartInfo.RedirectStandardError = false;//执行时是不是显示窗口 
                p.StartInfo.CreateNoWindow = true;//启动 
                p.Start();
                p.WaitForExit();
                p.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了：" + ex.Message);
            }

        }

        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxAccountPrefix.Text = cbxCompany.Text + "1";

            clbAccounts.Items.Clear();
            setInfos.Where(s => s.CompanyName.Equals(cbxCompany.Text))
                .FirstOrDefault().Accounts
                .ForEach(b =>
                clbAccounts.Items.Add(b, true));

        }

        private void tbxAccountPrefix_TextChanged(object sender, EventArgs e)
        {
            string prefix = tbxAccountPrefix.Text;
            string pstname = $"{prefix}_{DateTime.Now:yyyyMM}";
            tbxDisplayName.Text = prefix + "-";
            tbxPstName.Text = pstname;
            tbxPstPathFilename.Text = $"{PstPathDrive}Email\\{pstname}.pst";
        }

        private void lbOutlookPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(OutlookPath);
        }

    }
}
