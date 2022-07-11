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
        public DbSet<Users>? Users { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Article>? Article { get; set; }
        public DbSet<Comments>? Comments { get; set; }
    }
}