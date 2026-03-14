using ProductCatalog.Domain.Entities;
using Xunit;

namespace ProductCatalog.Tests;

public class ProductTests
{
    [Fact]
    public void Product_Should_Be_Created_Active_By_Default()
    {
        // Preparar
        var name = "Mouse Gamer";
        var category = "Acessórios";
        var price = 150.0m;

        // Agir
        var product = new Product(name, category, price);

        // Verificar
        Assert.True(product.IsActive);
        Assert.Equal(name, product.Name);
        Assert.Equal(category, product.Category);
        Assert.Equal(price, product.Price);
        Assert.Null(product.ImageUrl); // A imagem deve ser nula no início
    }

    [Fact]
    public void Deactivate_Should_Set_IsActive_To_False()
    {
        // Arrange
        var product = new Product("Teclado", "Acessórios", 200.0m);

        // Act
        product.Deactivate();

        // Assert
        Assert.False(product.IsActive);
    }
    
    [Fact]
    public void Update_Should_Change_Product_Properties()
    {
        // Arrange
        var product = new Product("Cadeira", "Móveis", 500.0m);
        var newName = "Cadeira Gamer";
        var newCategory = "Escritório";
        var newPrice = 850.0m;

        // Act
        product.Update(newName, newCategory, newPrice);

        // Assert
        Assert.Equal(newName, product.Name);
        Assert.Equal(newCategory, product.Category);
        Assert.Equal(newPrice, product.Price);
    }
}