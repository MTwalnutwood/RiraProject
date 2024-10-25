
namespace RiaProject.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategory  Category { get; set; }
        public decimal Price { get; set; }

    }
}
public enum ProductCategory{
    category1,
    category2,
    category3,
    category4,
    category5,
    category6,
}