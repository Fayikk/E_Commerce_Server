using MailKit.Net.Smtp;
using MimeKit;

namespace E_Commerce_API.MailService
{
    public class MailHelper : IMailHelper
    {
        //public MailHelper()
        //{
        //}

        public void SendEmailForOrder(string subject,string body ,string mail)
        {

            //var userDetail = _userSerivce.FindEmail(mail);

            try
            {

                var emailToSend = new MimeMessage();
                emailToSend.From.Add(MailboxAddress.Parse("MyMvcMailService@gmail.com"));

                emailToSend.To.Add(MailboxAddress.Parse(mail));

                emailToSend.Subject = subject;
                emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

                //send email
                using var emailClient = new SmtpClient();
                emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("veznedaroglufayik2@gmail.com", "wfqvpjvukemfkiam");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
