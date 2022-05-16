using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class Folder
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public String Name { get; set; }

        public Guid? FolderId { get; set; }
        public ICollection<Folder> Folders { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
