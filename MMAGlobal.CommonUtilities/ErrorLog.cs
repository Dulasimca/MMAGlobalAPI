using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MMAGlobal.CommonUtilities
{
    public class ErrorLog
    {
        public static void WriteError(string sMessage, bool sendMail = false, EmailParameter emailParameter = null)
        {
            string fPath = string.Empty, sFileName = string.Empty;
            try
            {
                fPath = AppDomain.CurrentDomain.BaseDirectory + "//LogFiles";
                if (!Directory.Exists(fPath))
                {
                    Directory.CreateDirectory(fPath);
                }
                sFileName = DateTime.Now.ToString("ddMMyyyy");
                StreamWriter sw = new StreamWriter(fPath + "//" + sFileName + ".txt", true);
                sw.WriteLine(DateTime.Now + " : " + sMessage);
                sw.Flush();
                sw.Close();
                //send mail to corresponding godown.
                if (sendMail)
                {
                    MailSendings mailSendings = new MailSendings();
                    mailSendings.SendMail(emailParameter);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fPath = string.Empty; sFileName = string.Empty;
            }
        }
    }
}
