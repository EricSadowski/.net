using static WebApp.Models.CategoriesRepository;
using System.Xml.Linq;
using System.Security.Cryptography.Xml;
using System.Reflection.Metadata.Ecma335;

namespace WebApp.Models
{

    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Beverage", Description = "Beverage" },
            new Category { Id = 2, Name = "Bakery", Description = "Bakery" },
            new Category { Id = 3, Name = "Meat", Description = "Meat" }
        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.Id);
            category.Id = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (category != null)
            {
                return new Category
                { Id = category.Id, Description = category.Description, Name = category.Name };
            }
            return null;
        }


        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.Id) return;
            var categoryToUpdate = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description
                =
                category.Description;

            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.Id == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}