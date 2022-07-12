using Microsoft.EntityFrameworkCore;
using WebApplication22_1.Models;

namespace WebApplication22_1.Data
{
    public class NewsContext:DbContext
    {
        public DbSet<News> News { get; set; }
        public NewsContext(DbContextOptions<NewsContext>options):base(options)
        {
        }
    }
}
