namespace Eternalys.DAL.Repositories
{
    using Models;
    using System.Linq;
    using Eternalys.DAL.EF;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Eternalys.DAL.Interfaces;
    using System.Collections.Generic;

    public class SubjectRepository : IRepository<Subject>
    {
        private DataContext db;

        public SubjectRepository(DataContext db)
        {
            this.db = db;
        }

        public void Create(Subject entity)
        {
            db.Subjects.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Subject entity)
        {
            db.Subjects.Remove(entity);
            db.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var found = await db.Subjects.FindAsync(id);
            db.Subjects.Remove(found);
            db.SaveChanges();
        }

        public Subject Get(int id)
        {
            return db.Subjects.Find(id);
        }

        public IQueryable<Subject> GetAll()
        {
            return db.Subjects;
        }

        public async Task<List<Subject>> GetAllAsync()
        {
            return await db.Subjects.ToListAsync();
        }

        public void Update(Subject entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
