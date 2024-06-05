using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<BlogPostCategory> BlogPostsCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.BlogPosts)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<User>()
                .HasMany(b => b.Comments)
                .WithOne(c => c.Author)
                .HasForeignKey(c => c.AuthorId);

            modelBuilder.Entity<BlogPost>()
                .HasMany(b => b.Comments)
                .WithOne(b => b.BlogPost)
                .HasForeignKey(c => c.BlogPostId);

            modelBuilder.Entity<BlogPostCategory>()
                .HasKey(bc => new { bc.BlogPostId, bc.CategoryId });

            modelBuilder.Entity<BlogPostCategory>()
                .HasOne(bc => bc.BlogPost)
                .WithMany(b => b.BlogPostCategories)
                .HasForeignKey(bc => bc.BlogPostId);

            modelBuilder.Entity<BlogPostCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BlogPostCategories)
                .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.BlogPostId, pt.TagId });

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.BlogPost)
                .WithMany(b => b.PostTags)
                .HasForeignKey(pt => pt.BlogPostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);
        }
    }
}
