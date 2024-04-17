namespace Eternalys.DAL.EF
{
    using Eternalys.DAL.Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext(string connect) : base(connect)
        {
        }

        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Assigment> Assigments { get; set; }
        //public virtual DbSet<Subject> Subjects { get; set; }
    }
}
