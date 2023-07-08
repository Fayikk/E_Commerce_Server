namespace E_Commerce_API.MailService
{
    public interface IMailHelper
    {
        public void SendEmailForOrder(string subject, string body,string mail);
    }
}
