using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Domain.Repositories;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(Guid id);
    Task<IEnumerable<Product>> GetAllAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}