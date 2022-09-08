using GameStore.Interfaces;
using GameStore.Models;

namespace GameStore.Repository
{
    public class ProductRepository : IProduct
    {
        private ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }



}
