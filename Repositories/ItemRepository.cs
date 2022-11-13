using BlazorServer.Data;
using BlazorServer.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private IDbContextFactory<MainDatabase> _context;
        public ItemRepository(IDbContextFactory<MainDatabase> context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ItemEntity>> GetAllItems()
        {
            //implementing DbContextFactory
            using var factory = _context.CreateDbContext();
            return await factory.Items.OrderBy(x => x.Id).ToListAsync();
            
        }
    }
}
