using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Models
{
    public class Obras
    {
        public int Id { get; set; }
        public int ProjetoId { get; set; }
        public ProjetoObraRelacaoCustos? Projeto { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ObrasTipo Tipo { get; set; }
        public List<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public List<Produtos> Constituintes { get; set; } = new List<Produtos>();
        public string Morada { get; set;  }
        public string MoradaContabilistica { get; set; }
    }


   public enum ObrasTipo
    {
        UM,
        DOIS,
        TRES
    }
}
