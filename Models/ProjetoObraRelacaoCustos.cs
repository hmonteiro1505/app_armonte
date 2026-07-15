using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace armonte_aplicacao.Models
{
    public class ProjetoObraRelacaoCustos
    {
        public int Id { get; set; }
        public string Designacao { get; set; } = string.Empty;
        public string AnoRegularizacao {  get; set; } = string.Empty;
        public DateTime InicioObra { get; set; }
        public List<Cliente > Clientes { get; set;} = new List<Cliente>();
        public List<Obras> Obras { get; set; } = new List<Obras>();
        public List<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();




    }
}
