using IFSPStore.Domain.Base;
using System.Collections.Generic;

namespace IFSPStore.Domain.Entities
{
    public class Locacao : BaseEntity<int>
    {
        public Locacao()
        {
            CarrosAlugados = new List<CarrosAlugados>();
        }

        public Locacao(int id, DateTime dataLocacao, DateTime dataDevolucao, decimal valorTotal,
            int numDiarias, Funcionario funcionario, Cliente cliente)
            : base(id)
        {
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
            ValorTotal = valorTotal;
            NumDiarias = numDiarias;
            Funcionario = funcionario;
            Cliente = cliente;
            CarrosAlugados = new List<CarrosAlugados>();
        }

        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
        public int NumDiarias { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public List<CarrosAlugados> CarrosAlugados { get; set; }
    }
    public class CarrosAlugados : BaseEntity<int>
    {
        public CarrosAlugados() 
        {

        }
        public int LocacaoId { get; set; }
        public virtual Locacao? Locacao_ { get; set; }
        public int CarroId { get; set; }
        public virtual Carro? Carro { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorTotalLoc { get; set; }
        public decimal Quantidade { get; set; }
    }
}