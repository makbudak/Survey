using BlazorLearn.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearn.Models
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options) { }

        public DbSet<QuestionCategory> QuestionCategories { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
