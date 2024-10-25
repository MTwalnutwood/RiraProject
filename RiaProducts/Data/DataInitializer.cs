
using RiaProject.Models;

namespace RiaProject.Data
{
    public class DataInitializer
    {
        public static List<ProductModel> ProductInit()
        {
            return new List<ProductModel>
            {
                new ProductModel { Id = 1, Name = "Product A", Price = 100M, Category = ProductCategory.category1 },
                new ProductModel { Id = 2, Name = "Product B", Price = 150M, Category = ProductCategory.category2 },
                new ProductModel { Id = 3, Name = "Product C", Price = 200M, Category = ProductCategory.category3 },
                new ProductModel { Id = 4, Name = "Product D", Price = 250M, Category = ProductCategory.category4 },
                new ProductModel { Id = 5, Name = "Product E", Price = 80M, Category = ProductCategory.category5 }

            };
        }
    }
}
