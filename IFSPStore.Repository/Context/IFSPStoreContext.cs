using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using static IFSPStore.Repository.Mapping.SaleMap;

namespace IFSPStore.Repository.Context
{
   public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext>? op = null) : base(op)
        {
            Database.EnsureCreated();//cria o banco de dados
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=IFSPStore;user=root;password=");
        }
        public DbSet<Cidade> Cities { get; set; }//cada classe vira uma tabela
        public DbSet<Funcionario> Users { get; set; }
        public DbSet<Categoria> Categories { get; set; }
        public DbSet<Carro> Products { get; set; }
        public DbSet<Cliente> Customers { get; set; }
        public DbSet<Locacao> Sales { get; set; }
        public DbSet<SaleItem> SalesItens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Carro>(new CarroMap().Configure);
            modelBuilder.Entity<Locacao>(new SaleMap().Configure);
            modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
        }

    }
}
