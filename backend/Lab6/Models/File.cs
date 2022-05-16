using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class File
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public String Name { get; set; }
        public String Extension { get; set; }
        public Int64 Size { get; set; }

        public Folder Folder { get; set; }
        public Guid FolderId { get; set; }
    }
}
