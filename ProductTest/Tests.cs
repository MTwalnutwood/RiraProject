using RiaProject.Service;

namespace ProductTest
{
    public class Tests
    {
      IProductRepository _repository;
        [SetUp]
        public void Setup()
        {
            _repository= new ProductRepository();
        }

        [Test]
        public void ProductSumTest()
        {
            var total = _repository.ProductTotalPrice();

            Assert.AreEqual(780m, total);
        }
        [Test]
        public void ProductAverageTest()
        {
            var total = _repository.ProductAveragePrice();

            Assert.AreEqual(156m, total);
        }
        [Test]
        public void ProductMostExpensiveShouldBeProductNumber4()
        {
            var Product = _repository.ProductMostExpensive();

            Assert.AreEqual(Product.Id, 4);
        }
        [Test]
        public void ProductCategory1ShouldNotBeEmpty()
        {
            var Product = _repository.ProductCategoryId(ProductCategory.category1);

            Assert.AreEqual(Product.Category, ProductCategory.category1);
        }
        [Test]
        public void ProductCategoryGroupBy()
        {
            var Products = _repository.ProductGroupByCategory();

            Assert.That(Products,Is.Not.Null);
        }
    }
}