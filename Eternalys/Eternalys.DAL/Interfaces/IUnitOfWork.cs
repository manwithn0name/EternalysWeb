namespace Eternalys.DAL.Interfaces
{
    using Models;

    internal interface IUnitOfWork : System.IDisposable
    {
        IRepository<Category> Categories { get; }
        IRepository<Assigment> Assigments { get; }
        IRepository<Subject> Subjects { get; }
    }
}