namespace Vendas.Domain.ObjectValues
{
    public class SaleItem
    {
        public Guid SaleGuid { get; private set; }
        public Guid ProductGuid { get; private set; }
        public decimal Value { get; private set; }
        public decimal Dicount { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalValue
        {
            get
            {
                return Quantity * (Value - Dicount);
            }
        }        
    }
}
