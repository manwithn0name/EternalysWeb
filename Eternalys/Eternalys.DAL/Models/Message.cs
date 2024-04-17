namespace Eternalys.DAL.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string TextMessage { get; set; }
        public int RecipientID { get; set; }
        public int SenderID { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Attachment { get; set; }
        public System.DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
