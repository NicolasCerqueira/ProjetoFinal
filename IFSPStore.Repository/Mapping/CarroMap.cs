using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Diaria)
                .IsRequired();
            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Modelo)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Ano)
                .IsRequired();
            builder.Property(prop => prop.Cor)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.DataAquisicao)
                .IsRequired();
            builder.Property(prop => prop.Disponivel)
                .IsRequired();
            builder.Property(prop => prop.Status)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasOne(prop => prop.Categoria)
                .WithMany()
                .HasForeignKey(prop => prop.CategoriaId)
                .HasConstraintName("nome_chave_estrangeira"); // relacionamento
        }
    }
}
