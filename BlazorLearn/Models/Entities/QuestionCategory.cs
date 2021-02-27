using System.ComponentModel.DataAnnotations;

namespace BlazorLearn.Models.Entities
{
    public class QuestionCategory : BaseEntity
    {
        [Required(ErrorMessage = "Soru kategorisi adı boş bırakılamaz.")]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
