using Vendas.Domain.ObjectValues;

namespace Vendas.Domain.Entity;

public class Sale
{
    public Guid Guid { get; private set; }
    public int Number { get; private set; } 
    public DateTime SaleDate { get; private set; }
    public Guid CustomerGuid { get; private set; }
    public Guid CompanyBranchGuid {  get; private set; }
    public List<SaleItem>? saleItems { get; private set; }
    public decimal TotalValue { 
        get
        {
            return saleItems?.Sum(x => x.TotalValue) ?? 0;
        } 
    }
    public bool Canceled { get; private set; } = false;    
}
