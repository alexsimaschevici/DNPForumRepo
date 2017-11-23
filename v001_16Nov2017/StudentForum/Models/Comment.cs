namespace StudentForum.Models
{
    public class Comment
    {
        public long ID { get; set; }
        public string Content { get; set; }

        public virtual ApplicationUser Author { get; set; }

    }
}