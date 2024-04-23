using Microsoft.EntityFrameworkCore;

namespace TutoralRazorPages2.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }
    }
}
