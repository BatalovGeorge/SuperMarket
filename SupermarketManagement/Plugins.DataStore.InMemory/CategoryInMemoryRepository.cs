using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category{CategoryId = 1, Name = "Напитки", Description = "Напитки" },
                new Category{CategoryId = 2, Name = "Мясо", Description = "Мясо" },
                new Category{CategoryId = 3, Name = "Хлеб", Description = "Хлеб" },
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}