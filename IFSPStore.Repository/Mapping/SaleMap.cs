using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(p => p.Id);
            builder.Property(prop => prop.SaleDate)
                .IsRequired();
            builder.Property(prop => prop.SaleTotal)
                .IsRequired();
            builder.HasOne(prop => prop.Salesman);
            builder.HasOne(prop => prop.Customer);
            builder.HasMany(prop => prop.SaleItens)
                .WithOne(prop => prop.Sale)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
        {
            public void Configure (EntityTypeBuilder<SaleItem> builder)
            {
                builder.ToTable("SaleItem");
                builder.HasKey(prop => prop.Id);
                builder.Property(prop => prop.Quantity)
                    .IsRequired();
                builder.Property(prop => prop.UnitPrice)
                    .IsRequired();
                builder.Property(prop => prop.TotalPrice)
                    .IsRequired(); 
                builder.HasOne(prop => prop.Product);
                builder.HasOne(prop => prop.Sale)
                    .WithMany(prop => prop.SaleItens)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
