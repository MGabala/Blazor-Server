using BlazorServer.Models;

namespace BlazorServer.MockData
{
    public class MockDataService
    {
        private static List<ItemModel>? _items = default!;

        public static List<ItemModel> Items
        {
            get
            {
                _items ??= InitializeMockItems();
                return _items;
            }
        }

        private static List<ItemModel> InitializeMockItems()
        {
            var item1 = new ItemModel
            {
                Id = 1,
                Name = "Item 1",
                Description = "Example desc"
            };
            var item2 = new ItemModel
            {
                Id = 1,
                Name = String.Empty,
                Description = "Example desc"
            };
            return new List<ItemModel>() { item1, item2 };
        }
    }
}
