using Microsoft.EntityFrameworkCore;
using Vendas.Data.EF.Mapping;
using Vendas.Domain.Entity;
using Vendas.Domain.ObjectValues;

namespace Vendas.Data.EF.Context;

public class Context : DbContext
{
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SalesItem { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SalesMapping());

    }
}
