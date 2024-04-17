namespace Eternalys.BLL.Interfaces
{
    public interface IEmailService
    {
        string SendMessage(Dal.Email.EmailData data, string ownerRecepient, string attachment);
    }
}
