namespace Eternalys.BLL.Services
{
    using BLL.Interfaces;
    using System.Net.Mail;
    using System.Net.Mime;
    using Eternalys.BLL.Dal.Email;

    public class EmailService : IEmailService
    {
        private readonly string htmlBody;
        private AlternateView htmlView = null;

        public EmailService(string htmlBody = null)
        {
            this.htmlBody = htmlBody;
        }

        public string SendMessage(EmailData emailData, string attachFile = null, string ownerRecepient = null)
        {
            try
            {
                var recepient = ownerRecepient != null ? ownerRecepient : "andriygerbut@gmail.com";
                MailAddress from = new MailAddress(emailData.Email, emailData.Title);// emailData.UserName);
                MailAddress to = new MailAddress(recepient); // email to admin
                MailMessage m = new MailMessage(from, to);
                m.IsBodyHtml = true;
                m.Subject = emailData.Title;
                if (htmlBody != null)
                {
                    htmlView =
                    AlternateView.CreateAlternateViewFromString(htmlBody, System.Text.Encoding.UTF8, "text/html");
                    m.AlternateViews.Add(htmlView); // And a html attachment to make sure.
                    m.Body = htmlBody;
                }
                else m.Body = emailData.Body;
                if (attachFile != null)
                    m.Attachments.Add(Attach(attachFile));
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(qwerty_12345.Credentials.Email, qwerty_12345.Credentials.Password);
                smtp.EnableSsl = true;
                smtp.Send(m);
                return "Message Was Send Successfuly!";
            }
            catch (System.Exception ex)
            {
                return ex.Message;// + " | " + ex.StackTrace;
            }
        }

        private Attachment Attach(string file)
        {
            var attach = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add time stamp information for the file.
            ContentDisposition disposition = attach.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            // Add the file attachment to this email message.
            return attach;
        }
    }
}
