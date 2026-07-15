using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Models
{
    public class FaturaFornecedor
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorComIva { get; set; }
        public decimal ValorSemIva { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal? FaturaAutoLiquidacao { get; set; }
        public decimal Iva { get; set; }


    }



}
