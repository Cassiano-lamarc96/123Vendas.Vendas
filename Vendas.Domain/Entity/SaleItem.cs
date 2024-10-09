namespace Vendas.Domain.Entity
{
    public class SaleItem
    {
        public Guid Guid { get; private set; }
        public Guid SaleGuid { get; private set; }
        public Guid ProductGuid { get; private set; }
        public decimal Price { get; private set; }
        public decimal Discount { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalValue
        {
            get
            {
                return Quantity * (Price - (Price * Discount / 100));
            }
        }

        public SaleItem CreateSaleItem(Guid saleGuid, Guid productGuid, decimal price, decimal discount, int quantity)
        {
            if (saleGuid == Guid.Empty)
                throw new Exception("Something gets wrong try again!");

            if (productGuid == Guid.Empty)
                throw new Exception("Product is required");

            if (price < 0)
                throw new Exception("Value must be bigger than zero!");

            if (discount > 100)
                throw new Exception("Discount can not be higher than 100%");

            if (quantity <= 0)
                throw new Exception("Quantity is required");

            return new SaleItem
            {
                Guid = new Guid(),
                SaleGuid = saleGuid,
                ProductGuid = productGuid,
                Price = price,
                Discount = discount,
                Quantity = quantity
            };
        }
    }
}
