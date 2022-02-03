using Microsoft.EntityFrameworkCore;
using tiwar_copy_Backend.Models;

namespace tiwar_copy_Backend.Data
{
    public class AppDBContent : DbContext
    {
        public DbSet<Account> Account { get; set; }

        public AppDBContent() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseMySql("server=localhost;user=root;password=;database=tiwar-copy_Backend", new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
