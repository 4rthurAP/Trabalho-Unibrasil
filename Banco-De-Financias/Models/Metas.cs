using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_De_Financas.Models
{
    public class Metas
    {
        public Metas(string texto, string dataCheck, CheckState CheckState)
        {
            Texto = texto;
            DataCheck = dataCheck;
            Check = CheckState;
        }
        public decimal Id { get; set; }
        public string Texto { get; set; }
        public string DataCheck { get; set; }
        public CheckState Check { get; set; }

    }

}
