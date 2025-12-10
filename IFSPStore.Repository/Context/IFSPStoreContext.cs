using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
   public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> op) : base(op)
        {
            Database.EnsureCreated();//cria o banco de dados
        }
        public MySqlContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=projetofinal;user=root;password=");
        }
        public DbSet<Cidade> Cidades { get; set; }//cada classe vira uma tabela
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Locacao> Alugueis { get; set; }
        public DbSet<CarrosAlugados> CarrosAlugados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Carro>(new CarroMap().Configure);
            modelBuilder.Entity<Locacao>(new LocacaoMap().Configure);
            modelBuilder.Entity<CarrosAlugados>(new CarrosAlugadosMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
        }

    }
}
