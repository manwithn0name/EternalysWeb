namespace Eternalys.DAL.Models
{
    using System;

    public class Assigment
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
        public double Mark { get; set; }
        public int UserId { get; set; }
        public int Achievement { get; set; }
        public string Attachment { get; set; }
        public bool IsDone { get; set; }
        public bool IsCancel { get; set; }
    }
}
