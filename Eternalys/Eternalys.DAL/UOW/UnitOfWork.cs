namespace Eternalys.DAL.UOW
{
    using Eternalys.DAL.EF;
    using Eternalys.DAL.Models;
    using Eternalys.DAL.Interfaces;
    using Eternalys.DAL.Repositories;

    public class UnitOfWork : IUnitOfWork    
    {
        private readonly DataContext Db;
        private AssigmentRepository assignmentRepo;
        private CategoryRepository categoryRepo;
        private SubjectRepository subjectRepo;

        public UnitOfWork(string connection)
        {
            Db = new DataContext(connection);
        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepo == null)
                    categoryRepo = new CategoryRepository(Db);
                return categoryRepo;
            }
        }


        public IRepository<Assigment> Assigments
        {
            get
            {
                if (assignmentRepo == null)
                    assignmentRepo = new AssigmentRepository(Db);
                return assignmentRepo;
            }
        }

        public IRepository<Subject> Subjects
        {
            get
            {
                if (subjectRepo == null)
                    subjectRepo = new SubjectRepository(Db);
                return subjectRepo;
            }
        }

        #region Dispose:
        bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    Db.Dispose();

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
        #endregion
    }
}
