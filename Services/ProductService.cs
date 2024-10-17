using Task_1.Model;
using Task_1.Repositories;

namespace Task_1.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Product>> GetAllProducts() => _repository.GetAllProducts();

        public Task<Product> GetProductById(int id) => _repository.GetProductById(id);

        public Task AddProduct(Product product) => _repository.AddProduct(product);

        public Task UpdateProduct(Product product) => _repository.UpdateProduct(product);

        public Task DeleteProduct(int id) => _repository.DeleteProduct(id);
    }

}
