namespace Vendas.Domain.Aggregates;

public class Product
{
    public Guid Guid { get; set; }
    public string Description { get; set; } = string.Empty;
}
