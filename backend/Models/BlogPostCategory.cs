﻿namespace backend.Models
{
    public class BlogPostCategory
    {
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}