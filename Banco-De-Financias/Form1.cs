using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_De_Financias
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

            Valor.Minimum = -1000000000000;
            Valor.Maximum = 1000000000;
            
            valorTotal.Minimum = -1000000000000;
            valorTotal.Maximum = 1000000000000;

            valorEntradas.Minimum = -1000000000000;
            valorEntradas.Maximum = 1000000000000;

            valorSaidas.Minimum = -1000000000000;
            valorSaidas.Maximum = 1000000000000;


            DateTime DataAtual = DateTime.Now;
            string textoDesricao = descricao.Text;
            float valor = (float)Valor.Value;

            if (Valor.Value > 0)
            {
                valorEntradas.Value += (decimal)valor;
            }else
            {
                valorSaidas.Value += (decimal)valor;
            }

            valorTotal.Value += (decimal)valor;
            
            RTBresultado.AppendText
                (
                $"{textoDesricao}   " + $"{valor} Reais" + $"\t {DataAtual}" + "\n" +
                "\n" +
                $"|-----------------------------------------------------------------------------------------------------------------------------------------------------| \n "
                );
        }

        private void saidas_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            RTBresultado.ResetText();
            valorSaidas.ResetText();
            valorEntradas.ResetText();
            valorTotal.ResetText();

        }

        private void RTBresultado_TextChanged(object sender, EventArgs e)
        {
            // o painel total fica verde quando é positivo e fica vermelho quando é negativo
            panel5.BackColor = valorTotal.Value >= 0 ? Color.Green : Color.Red;
        }
 
    }
}
