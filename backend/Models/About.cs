using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class About
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Bio { get; set; }

        public string ProfilePictureUrl { get; set; }
        public SocialLinks SocialLinks { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
