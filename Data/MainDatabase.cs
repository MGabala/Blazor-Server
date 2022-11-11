using BlazorServer.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class MainDatabase : DbContext
    {
        public MainDatabase(DbContextOptions<MainDatabase> options) : base(options)
        {

        }

        public DbSet<ItemEntity> Items { get; set; } = null!;
    }
}
