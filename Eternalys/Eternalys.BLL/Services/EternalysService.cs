namespace Eternalys.BLL.Services
{
    using Helpers;
    using System.Linq;
    using Eternalys.DAL.UOW;
    using Eternalys.BLL.Dal;
    using System.Threading.Tasks;
    using Eternalys.BLL.Interfaces;
    using System.Collections.Generic;

    public class EternalysService : IEternalysService
    {
        private readonly UnitOfWork service;

        public EternalysService(string connString)
        {
            service = new UnitOfWork(connString);
        }

        #region Assignment:
        public void Insert(AssignmentDto model)
        {
            var category = FillObjects.Assigment(model);
            service.Assigments.Create(category);
        }

        public void Update(AssignmentDto model)
        {
            var convert = FillObjects.Assigment(model);
            service.Assigments.Update(convert);
        }

        public void Delete(AssignmentDto model)
        {
            var category = FillObjects.Assigment(model);
            service.Assigments.Delete(category);
        }

        public async Task DeleteAssignmentAsync(int id)
        {
            await service.Assigments.DeleteAsync(id);
        }

        public IEnumerable<AssignmentDto> ReadAssignments()
        {
            var lst = service.Assigments.GetAll();
            return FillObjects.AssigmentList(lst.ToList());
        }

        public async Task<IEnumerable<AssignmentDto>> ReadAssignmentsAsync()
        {
            var lst = await service.Assigments.GetAllAsync();
            return FillObjects.AssigmentList(lst);
        }
        #endregion

        #region Category:
        public void Insert(CategoryDto model)
        {
            var category = FillObjects.Category(model);
            service.Categories.Create(category);
        }

        public void Update(CategoryDto model)
        {
            var convert = FillObjects.Category(model);
            service.Categories.Update(convert);
        }

        public void Delete(CategoryDto model)
        {
            var category = FillObjects.Category(model);
            service.Categories.Delete(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await service.Categories.DeleteAsync(id);
        }

        public IEnumerable<CategoryDto> ReadCategories()
        {
            var lst = service.Categories.GetAll();
            return FillObjects.CategoriesList(lst.ToList());
        }


        public async Task<IEnumerable<CategoryDto>> ReadCategoriesAsync()
        {
            var lst = await service.Categories.GetAllAsync();
            return FillObjects.CategoriesList(lst);
        }
        #endregion

        #region Subject:
        public void Insert(SubjectDto model)
        {
            var subject = FillObjects.Subject(model);
            service.Subjects.Create(subject);
        }

        public void Update(SubjectDto model)
        {
            var convert = FillObjects.Subject(model);
            service.Subjects.Update(convert);
        }

        public void Delete(SubjectDto model)
        {
            var subject = FillObjects.Subject(model);
            service.Subjects.Delete(subject);
        }

        public async Task  DeleteSubjectAsync(int id)
        {
            await service.Subjects.DeleteAsync(id);
        }

        public IEnumerable<SubjectDto> ReadSubjects()
        {
            var lst = service.Subjects.GetAll();
            return FillObjects.SubjectList(lst.ToList());
        }

        public async Task<IEnumerable<SubjectDto>> ReadSubjectsAsync()
        {
            var lst = await service.Subjects.GetAllAsync();
            return FillObjects.SubjectList(lst);
        } 
        #endregion
    }
}
