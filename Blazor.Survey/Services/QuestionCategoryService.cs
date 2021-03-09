using BlazorLearn.Helper;
using BlazorLearn.Models;
using BlazorLearn.Models.Dto;
using BlazorLearn.Models.Entities;

namespace BlazorLearn.Services
{
    public interface IQuestionCategoryService
    {
        PagedResult<QuestionCategory> Get(int page, int pageSize = 5);
        void Add(QuestionCategory model);
        void Edit(QuestionCategory model);

    }

    public class QuestionCategoryService : IQuestionCategoryService
    {
        private readonly SurveyContext context;
        public QuestionCategoryService(SurveyContext context)
        {
            this.context = context;
        }

        public PagedResult<QuestionCategory> Get(int page, int pageSize = 5)
        {
            var list = context.QuestionCategories.GetPaged(page, pageSize);
            return list;
        }

        public void Add(QuestionCategory model)
        {
            context.Add(model);
            context.SaveChanges();
        }

        public void Edit(QuestionCategory model)
        {
            context.Update(model);
            context.SaveChanges();
        }
    }
}
