using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class TweetContext: DbContext
    {
        public TweetContext(DbContextOptions<TweetContext> options)
               : base(options)
        {
        }
        public DbSet<Tweet> Tweets { get; set; } = null!;
    }
}
