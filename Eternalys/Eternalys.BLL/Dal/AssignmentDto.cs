namespace Eternalys.BLL.Dal
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AssignmentDto : Interfaces.IModel
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required! Please fill it in.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "This field is required! Please fill it in.")]
        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }
        public double Mark { get; set; }
        public int UserId { get; set; }
        public int Achievement { get; set; }
        public string Attachment { get; set; }
        public bool IsDone { get; set; }
        public bool IsCancel { get; set; }
    }
}
