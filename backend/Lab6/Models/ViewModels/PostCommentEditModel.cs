using System.ComponentModel.DataAnnotations;

namespace Lab6.Models.ViewModels
{
    public class PostCommentEditModel
    {
        [Required]
        public String Text { get; set; }
    }
}
