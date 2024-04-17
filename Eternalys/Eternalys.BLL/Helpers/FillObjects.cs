namespace Eternalys.BLL.Helpers
{
    using Eternalys.BLL.Dal;
    using Eternalys.DAL.Models;
    using System.Collections.Generic;

    internal class FillObjects
    {
        #region Subjects fill:
        public static IEnumerable<SubjectDto> SubjectList(List<Subject> list)
        {
            var dto = new List<SubjectDto>();
            for (int i = 0; i < list.Count; i++)
            {
                dto.Add(new SubjectDto());
                dto[i].Id = list[i].Id;
                dto[i].CategoryId = list[i].CategoryId;
                dto[i].Name = list[i].Name;
            }
            return dto;
        }

        public static Subject Subject(SubjectDto dto)
        {
            if (dto != null)
                return new Subject
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    CategoryId = dto.CategoryId
                };
            else return null;
        }
        #endregion

        #region Categories fill:
        public static IEnumerable<CategoryDto> CategoriesList(List<Category> list)
        {
            var dto = new List<CategoryDto>();
            for (int i = 0; i < list.Count; i++)
            {
                dto.Add(new CategoryDto());
                dto[i].Id = list[i].Id;
                dto[i].Name = list[i].Name;
            }
            return dto;
        }

        public static Category Category(CategoryDto dto)
        {
            if (dto != null)
                return new Category
                {
                    Id = dto.Id,
                    Name = dto.Name
                };
            else return null;
        }
        #endregion

        #region Assignments fill:
        public static IEnumerable<AssignmentDto> AssigmentList(List<Assigment> list)
        {
            var dto = new List<AssignmentDto>();
            for (int i = 0; i < list.Count; i++)
            {
                dto.Add(new AssignmentDto());
                dto[i].Id = list[i].Id;
                dto[i].Achievement = list[i].Achievement;
                dto[i].Attachment = list[i].Attachment;
                dto[i].Title = list[i].Title;
                dto[i].DeadLine = list[i].DeadLine;
                dto[i].IsCancel = list[i].IsCancel;
                dto[i].IsDone = list[i].IsDone;
                dto[i].Mark = list[i].Mark;
                dto[i].StartDate = list[i].StartDate;
                dto[i].Task = list[i].Task;
                dto[i].UserId = list[i].UserId;
            }
            return dto;
        }

        public static Assigment Assigment(AssignmentDto dto)
        {
            if (dto != null)
                return new Assigment
                {
                    Id = dto.Id,
                    UserId = dto.UserId,
                    Task = dto.Task,
                    StartDate = dto.StartDate,
                    Mark= dto.Mark,
                    IsDone = dto.IsDone,
                    IsCancel = dto.IsCancel,
                    DeadLine = dto.DeadLine,
                    Title = dto.Title,
                    Attachment = dto.Attachment,    
                    Achievement = dto.Achievement
                };
            else return null;
        }
        #endregion
    }
}
