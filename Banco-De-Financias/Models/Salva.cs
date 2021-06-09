using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Banco_De_Financas.Models
{
    public class Salva
    {
        public decimal Entrada { get; set; }
        public decimal Saida { get; set; }
        public decimal Total { get; set; }
        public string RTB { get; set; }
        public List<Metas> Metas { get; set; }


    }
}
