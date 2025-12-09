using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int cnh { get; set; }
        public string? Endereco { get; set; }
        public string? Documento { get; set; }
        public string? Bairro { get; set; }
        public string? City { get; set; }
        public int IdCity { get; set; }

    }
}
