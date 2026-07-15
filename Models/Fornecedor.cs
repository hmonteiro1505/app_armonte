using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<FaturaFornecedor> FaturasAssociadas { get; set; } = new List<FaturaFornecedor>();

        public int ProjetoId { get; set; }
        public ProjetoObraRelacaoCustos? Projeto { get; set; }
    }
}
