using ProductCatalog.Application.DTOs;
using ProductCatalog.Domain.Entities;
using ProductCatalog.Domain.Repositories;

namespace ProductCatalog.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<ProductResponseDto?> GetByIdAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product == null) return null;

        return MapToResponseDto(product);
    }

    public async Task<IEnumerable<ProductResponseDto>> GetAllAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive)
    {
        var products = await _repository.GetAllAsync(category, minPrice, maxPrice, isActive);
        return products.Select(MapToResponseDto);
    }

    public async Task<ProductResponseDto> CreateAsync(ProductRequestDto request, string? imageUrl)
    {
        var product = new Product(request.Name, request.Category, request.Price, imageUrl);
        await _repository.AddAsync(product);
        
        return MapToResponseDto(product);
    }

    public async Task UpdateAsync(Guid id, ProductRequestDto request)
    {
        var product = await _repository.GetByIdAsync(id) ?? throw new Exception("Produto não encontrado.");
        
        product.Update(request.Name, request.Category, request.Price);
        await _repository.UpdateAsync(product);
    }

    public async Task DeleteAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id) ?? throw new Exception("Produto não encontrado.");
        await _repository.DeleteAsync(product);
    }

    public async Task UpdateImageAsync(Guid id, string imageUrl)
    {
        var product = await _repository.GetByIdAsync(id) ?? throw new Exception("Produto não encontrado.");
        product.SetImage(imageUrl);
        await _repository.UpdateAsync(product);
    }

    private static ProductResponseDto MapToResponseDto(Product product)
    {
        return new ProductResponseDto(
            product.Id, product.Name, product.Category, 
            product.Price, product.IsActive, product.ImageUrl);
    }
}