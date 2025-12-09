using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class LocacaoMap : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("Locacao"); 
            builder.HasKey(p => p.Id);

            builder.Property(prop => prop.DataLocacao)
                .IsRequired();

            builder.Property(prop => prop.ValorTotal) 
                .IsRequired();

            builder.HasOne(prop => prop.Funcionario); 
            builder.HasOne(prop => prop.Cliente);   

            builder.HasMany(prop => prop.CarrosAlugados) 
                .WithOne(prop => prop.Locacao_) 
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class CarrosAlugadosMap : IEntityTypeConfiguration<CarrosAlugados>
    {
        public void Configure(EntityTypeBuilder<CarrosAlugados> builder)
        {
            builder.ToTable("CarrosAlugados");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.ValorDiaria).IsRequired(); 
            builder.Property(prop => prop.ValorTotalLoc).IsRequired();

            builder.HasOne(prop => prop.Carro);
            builder.HasOne(prop => prop.Locacao_)
                .WithMany(prop => prop.CarrosAlugados)
                .HasForeignKey(prop => prop.LocacaoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}