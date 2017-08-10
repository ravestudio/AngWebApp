using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngWebApp.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string permalink { get; set; }
        public string author { get; set; }
        public DateTime datePublished { get; set; }
    }
}