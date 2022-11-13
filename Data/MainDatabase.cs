using BlazorServer.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class MainDatabase : DbContext
    {
        public MainDatabase(DbContextOptions<MainDatabase> options) : base(options)
        {

        }

        public DbSet<ItemEntity> Items => Set<ItemEntity>();
        public DbSet<TestEntity> Tests => Set<TestEntity>();
    }
}
