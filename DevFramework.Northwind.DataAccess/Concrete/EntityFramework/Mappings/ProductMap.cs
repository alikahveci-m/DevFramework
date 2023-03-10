using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.ProductId).HasColumnName("ProductId");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}