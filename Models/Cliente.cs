using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<FaturaCliente> FaturasAutos { get; set; }

    }
}
