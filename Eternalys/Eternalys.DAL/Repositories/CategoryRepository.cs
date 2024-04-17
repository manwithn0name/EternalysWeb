﻿namespace Eternalys.DAL.Repositories
{    
    using Models;
    using System.Linq;
    using Eternalys.DAL.EF;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Eternalys.DAL.Interfaces;
    using System.Collections.Generic;

    public class CategoryRepository : IRepository<Category>
    {
        private DataContext db;

        public CategoryRepository(DataContext db)
        {
            this.db = db;
        }

        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            db.Categories.Remove(entity);
            db.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var found = await db.Categories.FindAsync(id);
            db.Categories.Remove(found);
            db.SaveChanges();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public IQueryable<Category> GetAll()
        {
            return db.Categories;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await db.Categories.ToListAsync();
        }

        public void Update(Category entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
