using System.ComponentModel.DataAnnotations;

namespace BlazorLearn.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
