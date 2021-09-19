using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_De_Financas.Models
{
    public class ViewLinha
    {
        public ViewLinha(string valor, string data,string descricao)
        {
            Valor = valor;
            Data = data;
            Descricao = descricao;
        }
        public string Valor { get; set; }
        public string Data { get; set; } 
        public string Descricao { get; set; }
    }
}
