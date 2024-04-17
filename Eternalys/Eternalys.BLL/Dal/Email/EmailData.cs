namespace Eternalys.BLL.Dal.Email
{
    public class EmailData
    {
        public string Body { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Subject { get; set; }
        public System.DateTime SendingDate { get; set; } = System.DateTime.MinValue;
    }
}
