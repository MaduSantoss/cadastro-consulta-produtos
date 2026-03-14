namespace ProductCatalog.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Category { get; private set; }
    public decimal Price { get; private set; }
    public bool IsActive { get; private set; }
    public string? ImageUrl { get; private set; }

    public Product(string name, string category, decimal price, string? imageUrl = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Category = category;
        Price = price;
        IsActive = true; 
        ImageUrl = imageUrl;
    }
    
    public void Update(string name, string category, decimal price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

    public void Deactivate() => IsActive = false;
    public void Activate() => IsActive = true;
    public void SetImage(string imageUrl) => ImageUrl = imageUrl;
}