using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentForum.Models;

namespace StudentForum.Models
{
    public class Thread
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public ICollection<string> FilePath { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }

    }
}