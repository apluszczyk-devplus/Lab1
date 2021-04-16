using Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class MvcBookContext: DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
