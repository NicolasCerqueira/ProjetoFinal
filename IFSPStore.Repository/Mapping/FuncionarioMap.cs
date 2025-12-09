using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop!.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(100);
            builder.Property(prop => prop.Login)
                .IsRequired().
                HasMaxLength(100);
            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.DataRegistro)
                .HasDefaultValue(DateTime.Now);
            builder.Property(prop => prop.UltimoLogin)
                .HasMaxLength(100);
            builder.Property(prop => prop.Ativo);
        }
    }
}
