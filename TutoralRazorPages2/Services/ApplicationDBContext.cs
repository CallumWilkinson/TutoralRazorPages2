using Microsoft.EntityFrameworkCore;
using TutoralRazorPages2.Models;

namespace TutoralRazorPages2.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
