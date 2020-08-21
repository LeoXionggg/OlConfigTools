using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OlConfigTools
{
    public class OlPrfSetInfo
    {
        
        private static IList<OlPrfSetInfo> setInfos = new List<OlPrfSetInfo>();
        static OlPrfSetInfo()
        {
            try
            {
                XDocument doc = XDocument.Load("Settings.xml");
                setInfos =
                    doc.Descendants("Company")
                       .Select(
                           x => {
                               OlPrfSetInfo v=   new OlPrfSetInfo
                               {
                                   CompanyName = x.Attribute("Name").Value 
                               };
                               v.Accounts = x.Descendants("Account").Select(y => new OlPrfAccount
                               {
                                   AccountSufix = y.Attribute("AccountSufix").Value,
                                   POP3Server = y.Attribute("POP3Server").Value,
                                   SMTPServer = y.Attribute("SMTPServer").Value,
                                   DefaultAccount = y.Attribute("DefaultAccount").Value
                               }).ToList();
                               return v;
                           })
                       .ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("出错了，" + ex.Message);
            }
        }

        public static IList<OlPrfSetInfo> GetSetInfos()
        {
            return setInfos;
        }

        public string CompanyName { get; set; }

        public string AccountPrefix { get; set; }

        public string DisplayName { get; set; }
        public string PstName { get; set; }

        public string PstPathFilename { get; set; }

        public string ProfileName { get; set; }

        public List<OlPrfAccount> Accounts { get; set; }

    }

    public class OlPrfAccount
    {
        public string AccountSufix { get; set; }
        public string POP3Server { get; set; }
        public string SMTPServer { get; set; } 
        public string DefaultAccount { get; set; }

        public override string ToString()
        {
            return AccountSufix;
        }
    }

}
