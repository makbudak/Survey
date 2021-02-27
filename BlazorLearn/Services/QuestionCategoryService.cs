using BlazorLearn.Models;
using BlazorLearn.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BlazorLearn.Services
{
    public interface IQuestionCategoryService
    {
        List<QuestionCategory> Get();
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

        public List<QuestionCategory> Get()
        {
            var list = context.QuestionCategories.ToList();
            return list;
        }

        public void Add(QuestionCategory model)
        {
           context.QuestionCategories.Add(model);
           context.SaveChanges();
        }

        public void Edit(QuestionCategory model)
        {
            context.Update(model);
            context.SaveChanges();
        }
    }
}
