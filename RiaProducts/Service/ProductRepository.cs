

using RiaProject.Data;
using RiaProject.Models;

namespace RiaProject.Service
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> _products;
        public ProductRepository()
        {
            _products = DataInitializer.ProductInit();
        }
        public ProductModel ProductCategoryId(ProductCategory category)
        {
            var categoryProducts = from product in _products
                                   where product.Category == category
                                   select product;
            //we are know categoryProducts  never refrence null
            return categoryProducts.FirstOrDefault();
        }
        public ProductModel ProductMostExpensive()
        {
            var products = from product in _products
                           orderby product.Price descending
                           select product;
            //we are know categoryProducts  never refrence null
            return products.FirstOrDefault();
        }
        public decimal ProductTotalPrice()
        {
            var products = (from product in _products
                            select product.Price).Sum();
            return products;

        }
        public IEnumerable<IGrouping<ProductCategory, ProductModel>> ProductGroupByCategory()
        {
            var groupProudct = from product in _products
                               group product by product.Category into productCategory
                               orderby productCategory.Key
                               select productCategory;
            return groupProudct;
        }
        public decimal ProductAveragePrice()
        {
            var products = (from product in _products
                            select product.Price).Average();
            return products;
        }
    }
}
