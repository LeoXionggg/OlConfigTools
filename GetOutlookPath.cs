using System;

namespace OlConfigTools
{
    public class GetOutlookPath
    {
        private enum Softwares
        {
            //The names are the same with the registry names.
            //You can add any software exists in the "regedit" path:
            //HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths

            EXCEL,      //Office Excel
            WINWORD,    //Office Word
            MSACCESS,   //Office Access
            POWERPNT,   //Office PowerPoint
            OUTLOOK,    //Office Outlook
            INFOPATH,   //Office InfoPath
            MSPUB,      //Office Publisher
            VISIO,      //Office Visio
            IEXPLORE,   //IE
            ITUNES      //Apple ITunes
                        //.........
        }

        //When you do not want to use string name, then use the Enum instead
        public static bool TryGetPath(out string path)
        {
            return TryGetSoftwarePath(Softwares.OUTLOOK.ToString(), out path);
        }

        private static bool TryGetSoftwarePath(string softName, out string path)
        {
            string strPathResult = string.Empty;
            string strKeyName = "";     //"(Default)" key, which contains the intalled path
            object objResult = null;

            Microsoft.Win32.RegistryValueKind regValueKind;
            Microsoft.Win32.RegistryKey regKey = null;
            Microsoft.Win32.RegistryKey regSubKey = null;

            try
            {
                //Read the key
                regKey = Microsoft.Win32.Registry.LocalMachine;
                regSubKey = regKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + softName.ToString() + ".exe", false);

                //Read the path
                objResult = regSubKey.GetValue(strKeyName);
                regValueKind = regSubKey.GetValueKind(strKeyName);

                //Set the path
                if (regValueKind == Microsoft.Win32.RegistryValueKind.String)
                {
                    strPathResult = objResult.ToString();
                }
            }
            catch (System.Security.SecurityException ex)
            {
                throw new System.Security.SecurityException("You have no right to read the registry!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Reading registry error!", ex);
            }
            finally
            {

                if (regKey != null)
                {
                    regKey.Close();
                }

                if (regSubKey != null)
                {
                    regSubKey.Close();
                }
            }

            if (strPathResult != string.Empty)
            {
                //Found
                path = strPathResult;
                return true;
            }
            else
            {
                //Not found
                path = null;
                return false;
            }
        }
    }
}
