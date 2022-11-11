using BlazorServer.Entities;

namespace BlazorServer.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemEntity>> GetAllItems();
    }
}
