using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEFOneToOne
{
    class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public BlogImage BlogImage { get; set; }
    }
}
