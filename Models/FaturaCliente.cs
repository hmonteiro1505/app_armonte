using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Text;

namespace armonte_aplicacao.Models
{
    public class FaturaCliente
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public FaturaTipo Tipo { get; set; }
        public decimal Auto {  get; set;}
        public decimal ValorComIva { get; set; }
        public decimal ValorSemIva { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Iva { get; set; }

    }

    public enum FaturaTipo
    {
        FATURA,
        AUTO
    }
}
