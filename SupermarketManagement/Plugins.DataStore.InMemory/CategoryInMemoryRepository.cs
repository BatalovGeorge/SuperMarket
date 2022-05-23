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
                new Category{CategoryId = 1, Name = "Печи", Description = "Печи" },
                new Category{CategoryId = 2, Name = "Дымоходы", Description = "Дымоходы" },
                new Category{CategoryId = 3, Name = "Электрокамины", Description = "Электрокамины" },
            };
        }

        public void AddCategory(Category category)
        {
            if(categories.Any(x=>x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;

            categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}