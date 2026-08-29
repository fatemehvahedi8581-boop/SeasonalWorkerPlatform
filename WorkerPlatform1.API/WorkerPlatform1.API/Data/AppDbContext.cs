using Microsoft.EntityFrameworkCore;

namespace WorkerPlatform1.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // اینجا فردا مدل‌های User و JobAd را اضافه می‌کنیم
        // public DbSet<User> Users { get; set; }
        // public DbSet<JobAd> JobAds { get; set; }
    }
}