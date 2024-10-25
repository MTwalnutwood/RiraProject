using RiaProject.Models;

namespace RiaProject.Service
{
    public interface IProductRepository
    {
        decimal ProductAveragePrice();
        ProductModel ProductCategoryId(ProductCategory category);
        IEnumerable<IGrouping<ProductCategory, ProductModel>> ProductGroupByCategory();
        ProductModel ProductMostExpensive();
        decimal ProductTotalPrice();
    }
}