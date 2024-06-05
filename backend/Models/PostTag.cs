namespace backend.Models
{
    public class PostTag
    {
        public Guid Id { get; set; }
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
