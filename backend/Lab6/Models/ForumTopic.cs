using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class ForumTopic
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ForumId { get; set; }
        [Required]
        public String ApplicationUserId { get; set; }

        public DateTime Created { get; set; }
        [Required]
        public String Name { get; set; }

        public Forum Forum { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<ForumMessage> ForumMessages { get; set; }
    }
}
