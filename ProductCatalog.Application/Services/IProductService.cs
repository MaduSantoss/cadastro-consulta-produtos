using ProductCatalog.Application.DTOs;

namespace ProductCatalog.Application.Services;

public interface IProductService
{
    Task<ProductResponseDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProductResponseDto>> GetAllAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive);
    Task<ProductResponseDto> CreateAsync(ProductRequestDto request, string? imageUrl);
    Task UpdateAsync(Guid id, ProductRequestDto request);
    Task DeleteAsync(Guid id);
    Task UpdateImageAsync(Guid id, string imageUrl);
}