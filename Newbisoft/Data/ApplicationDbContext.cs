using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newbisoft.Models;

namespace Newbisoft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Newbisoft.Models.Users>? Users { get; set; }
        public DbSet<Newbisoft.Models.Roles>? Roles { get; set; }
        public DbSet<Newbisoft.Models.Article>? Article { get; set; }
    }
}