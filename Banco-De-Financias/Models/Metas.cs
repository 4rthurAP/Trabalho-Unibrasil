using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_De_Financas.Models
{
    public class Metas
    {

        public Metas(string texto, DateTime dataCheck, int CheckState)
        {
            Texto = texto;
            DataCheck = dataCheck;
            Check = CheckState;
        }

        public string Texto { get; set; }
        public DateTime DataCheck { get; set; }
        public int Check { get; set; }

    }

}
