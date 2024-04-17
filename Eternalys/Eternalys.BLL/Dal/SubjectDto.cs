namespace Eternalys.BLL.Dal
{
    public class SubjectDto : Interfaces.IModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
