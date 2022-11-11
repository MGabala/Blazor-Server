using BlazorServer.Data;
using BlazorServer.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private MainDatabase _context;
        public ItemRepository(MainDatabase context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ItemEntity>> GetAllItems()
        {
            return await _context.Items.OrderBy(x => x.Id).ToListAsync();
        }
    }
}
