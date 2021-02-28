using Microsoft.EntityFrameworkCore;
using New_API.Models;

namespace New_API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}
    }
}