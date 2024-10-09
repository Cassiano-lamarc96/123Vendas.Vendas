namespace Vendas.Domain.Aggregates;

public class Customer
{
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
}
