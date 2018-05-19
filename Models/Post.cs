using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBlog.Models
{
    public class Post
    {
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		public string Image { get; set; }

		public int BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}
