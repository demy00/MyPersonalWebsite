using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Projects
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string DemoUrl { get; set; }
        public List<string> Technologies { get; set; }
        public string ShowcaseUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
