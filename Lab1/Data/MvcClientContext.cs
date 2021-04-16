using Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class MvcClientContext: DbContext
    {
        public MvcClientContext(DbContextOptions<MvcClientContext> options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
    }
}
