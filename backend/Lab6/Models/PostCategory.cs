using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class PostCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
