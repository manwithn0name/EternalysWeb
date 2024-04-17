namespace Eternalys.BLL.Interfaces
{
    using Eternalys.BLL.Dal;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IEternalysService
    {
        #region Assignment:
        void Insert(AssignmentDto model);
        void Update(AssignmentDto model);
        void Delete(AssignmentDto model);
        Task DeleteAssignmentAsync(int id);
        IEnumerable<AssignmentDto> ReadAssignments();
        Task<IEnumerable<AssignmentDto>> ReadAssignmentsAsync();
        #endregion

        #region Category:
        void Insert(CategoryDto model);
        void Update(CategoryDto model);
        void Delete(CategoryDto model);
        Task DeleteCategoryAsync(int id);
        IEnumerable<CategoryDto> ReadCategories();
        Task<IEnumerable<CategoryDto>> ReadCategoriesAsync();
        #endregion

        #region Subject:
        void Insert(SubjectDto model);
        void Update(SubjectDto model);
        void Delete(SubjectDto model);
        Task DeleteSubjectAsync(int id);
        IEnumerable<SubjectDto> ReadSubjects();
        Task<IEnumerable<SubjectDto>> ReadSubjectsAsync();
        #endregion
    }
}
