using Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class MvcContext: DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Client> Client { get; set; }

    }
}
