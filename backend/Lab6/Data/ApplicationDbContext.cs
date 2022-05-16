using Lab6.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6.Data
{
    public class ApplicationDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PostCategory> PostCategories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostComment> PostComments { get; set; }

        public DbSet<PostAttachment> PostAttachments { get; set; }

        public DbSet<ForumCategory> ForumCategorys { get; set; }

        public DbSet<Forum> Forums { get; set; }

        public DbSet<ForumTopic> ForumTopics { get; set; }

        public DbSet<ForumMessage> ForumMessages { get; set; }

        public DbSet<ForumMessageAttachment> ForumMessageAttachments { get; set; }

        public DbSet<Folder> Folders { get; set; }

        public DbSet<Lab6.Models.File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Post>().HasOne(x => x.Creator).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<PostComment>().HasOne(x => x.Creator).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<ForumTopic>().HasOne(x => x.ApplicationUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<ForumMessage>().HasOne(x => x.ApplicationUser).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
