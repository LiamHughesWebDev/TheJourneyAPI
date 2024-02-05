using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheJourneyAPI.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime datePosted { get; set; }
    }
}