namespace Eternalys.DAL.Repositories
{
    using Models;
    using System.Linq;
    using Eternalys.DAL.EF;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Eternalys.DAL.Interfaces;
    using System.Collections.Generic;

    public class AssigmentRepository : IRepository<Assigment>
    {
        private DataContext db;

        public AssigmentRepository(DataContext db)
        {
            this.db = db;
        }

        public void Create(Assigment entity)
        {
            db.Assigments.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Assigment entity)
        {
            db.Assigments.Remove(entity);
            db.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var found = await db.Assigments.FindAsync(id);
            db.Assigments.Remove(found);
            db.SaveChanges();
        }

        public Assigment Get(int id)
        {
            return db.Assigments.Find(id);
        }

        public IQueryable<Assigment> GetAll()
        {
            return db.Assigments;
        }

        public async Task<List<Assigment>> GetAllAsync()
        {
            return await db.Assigments.ToListAsync();
        }

        public void Update(Assigment entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
