using System.ComponentModel.DataAnnotations;

namespace Lab6.Models.ViewModels
{
    public class PostEditModel
    {
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public String Title { get; set; }

        [Required]
        public String Text { get; set; }
    }
}
