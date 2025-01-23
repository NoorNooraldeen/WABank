using WABank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace WABank.Data
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Entity
        public DbSet<Transaction> Transactions { get; set; }
    }
}
