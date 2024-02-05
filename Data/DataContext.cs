using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheJourneyAPI.Models;

namespace TheJourneyAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Posts> posts {get; set;}
        public DbSet<Comments> comments {get; set;}
    }
}