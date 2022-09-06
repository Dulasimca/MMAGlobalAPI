using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MMAGlobal.CommonUtilities
{
    public class MailSendings
    {
        public void SendMail(EmailParameter emailParameter)
        {
            try
            {
                MailAddress to = new MailAddress(emailParameter.ToEmailID);
                MailAddress from = new MailAddress(emailParameter.FromEmailID);
                MailMessage mail = new MailMessage(from, to);
                if (emailParameter != null)
                {
                    mail.CC.Add(new MailAddress(emailParameter.CCMailid));
                }
                mail.Subject = emailParameter.Subject;
                mail.Body = emailParameter.BodyMessage;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = emailParameter.Host;
                smtp.Port = emailParameter.Port;
                smtp.Credentials = new NetworkCredential(emailParameter.FromEmailID, emailParameter.FromPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                ErrorLog.WriteError(ex.Message);
            }
           
        }
    }
    public class EmailParameter
    {
        public string FromEmailID { get; set; }
        public string FromPassword { get; set; }
        public string ToEmailID { get; set; }
        public string CCMailid { get; set; }
        public string Subject { get; set; }
        public string BodyMessage { get; set; }
        public int Port { get; set; }        
        public string Host { get; set; }
    }
}
