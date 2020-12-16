using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample
{
   public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public int UserID { get; set; }
        public string Body { get; set; }

    }
}
