namespace ProductCatalog.Application.DTOs;
// o que usuario envia para criar ou atualizar um produto
public record ProductRequestDto(string Name, string Category, decimal Price);

// o que vai ser devolvido para ele 
public record ProductResponseDto(Guid Id, string Name, string Category, decimal Price, bool IsActive, string? ImageUrl);