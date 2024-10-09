namespace Vendas.Domain.Entity;

public class Sale
{
    public Guid Guid { get; private set; }
    public int Number { get; private set; } 
    public DateTime SaleDate { get; private set; }
    public Guid CustomerGuid { get; private set; }
    public Guid CompanyBranchGuid {  get; private set; }
    public List<SaleItem>? SaleItems { get; private set; }
    public decimal TotalValue { 
        get
        {
            return SaleItems?.Sum(x => x.TotalValue) ?? 0;
        } 
    }
    public bool Canceled { get; private set; } = false;

    public Sale CreateSale(Guid customerGuid, Guid companyBranchGuid)
    {
        if (customerGuid == Guid.Empty)
            throw new Exception("Customer is required!");

        if (companyBranchGuid == Guid.Empty)
            throw new Exception("Company Branch is required!");

        Guid newSaleId = new Guid();
        return new Sale()
        {
            Guid = newSaleId,
            Number = new Random().Next(),
            SaleDate = DateTime.UtcNow,
            CompanyBranchGuid = companyBranchGuid,
            CustomerGuid = customerGuid
        };
    }

    public void AddItemToSale(List<SaleItem> saleItems)
    {
        SaleItems = saleItems;
    }
}
