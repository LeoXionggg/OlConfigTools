using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlConfigTools
{
    public class OlPrfSetHelper
    {
        private static readonly string TMPPath;
        private static readonly string TemplPrf;

        static OlPrfSetHelper()
        {
            string curPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            TemplPrf = File.ReadAllText($"{curPath}\\Templ.prf");


            TMPPath = Environment.GetEnvironmentVariable("TEMP");
        }


        public string MakePrf(OlPrfSetInfo olPrfSetInfo)
        {
            string prfPathAndName = $"{TMPPath}\\{olPrfSetInfo.CompanyName}.prf";
            Console.WriteLine(prfPathAndName);
            string prfContent = TemplPrf.Replace("{{ProfileName}}", olPrfSetInfo.ProfileName);

            string accountList = "";
            for (int i = 0; i < olPrfSetInfo.Accounts.Count; i++)
            {
                accountList = $"{accountList}Account{i + 1}=I_Mail{Environment.NewLine}";
            }
            prfContent = prfContent.Replace("{{AccountList}}", accountList);

            prfContent = prfContent.Replace("{{PstName}}", olPrfSetInfo.PstName);
            prfContent = prfContent.Replace("{{PstPathFilename}}", olPrfSetInfo.PstPathFilename);

            StringBuilder accountSection = new StringBuilder();
            int k = 0;
            olPrfSetInfo.Accounts.ForEach(acc =>
            {
                k++;
                string accname = $"{olPrfSetInfo.AccountPrefix}@{acc.AccountSufix}";
                accountSection.Append($"[Account{k}]{Environment.NewLine}");
                accountSection.AppendLine("UniqueService=No");
                accountSection.AppendLine($"AccountName={accname}");
                accountSection.AppendLine($"POP3Server={acc.POP3Server}");
                accountSection.AppendLine($"SMTPServer={acc.SMTPServer}");
                accountSection.AppendLine($"POP3UserName={accname}");
                accountSection.AppendLine($"EmailAddress={accname}");
                accountSection.AppendLine("POP3UseSPA=0");
                accountSection.AppendLine($"DisplayName={olPrfSetInfo.DisplayName}");
                accountSection.AppendLine("ReplyEMailAddress=");
                accountSection.AppendLine("SMTPUseAuth=1");
                accountSection.AppendLine("SMTPAuthMethod=0");
                accountSection.AppendLine("ConnectionType=0");
                accountSection.AppendLine("LeaveOnServer=0x140003");
                accountSection.AppendLine("POP3UseSSL=0");
                accountSection.AppendLine("ConnectionOID=");
                accountSection.AppendLine("POP3Port=110");
                accountSection.AppendLine("ServerTimeOut=60");
                accountSection.AppendLine("SMTPPort=25");
                accountSection.AppendLine("SMTPSecureConnection=0");
                if (k == 1)
                {
                    accountSection.AppendLine("DefaultAccount=TRUE");
                }
                accountSection.AppendLine();

            });

            prfContent = prfContent.Replace("{{AccountSection}}", accountSection.ToString());

            File.WriteAllText(prfPathAndName, prfContent);

            return prfPathAndName;
        }


    }

}
