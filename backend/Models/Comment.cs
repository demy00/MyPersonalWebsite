using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BlogPostId {  get; set; }
        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set; }
        public Guid AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public User Author { get; set; }
        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
