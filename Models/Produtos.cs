using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Models
{
    //
    public class Produtos
    {

        public int Id { get; set; }
        public string Designacao { get; set; } = string.Empty;
        public DateTime Data {  get; set; }
        public Fornecedor Fornecedor { get; set; }
        public decimal ValorComIva { get; set;  }
        public decimal ValorSemIva { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Iva {  get; set; }
        public bool Existe { get; set; } = true;  // se o produto realmente existe, ou é para equilibrio de contas
        public bool PertenceAObra { get; set; } = true; // se o produto pertence realmente á obra 
        public bool Contabilidade { get; set; } = true;  // se o produto conta para a contabilidade


    }
}
