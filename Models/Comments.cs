using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheJourneyAPI.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int ParentPost { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime datePosted { get; set; }

    }
}