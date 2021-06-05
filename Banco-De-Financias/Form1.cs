
using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Banco_De_Financias
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Valor.Minimum = -1000000000000;
            Valor.Maximum = 1000000000;

            valorTotal.Minimum = -1000000000000;
            valorTotal.Maximum = 1000000000000;

            valorEntradas.Minimum = -1000000000000;
            valorEntradas.Maximum = 1000000000000;

            valorSaidas.Minimum = -1000000000000;
            valorSaidas.Maximum = 1000000000000;

            string jsonString = File.ReadAllText(arquivo);
            Salvar save = JsonSerializer.Deserialize<Salvar>(jsonString);

            if (save.Entrada != 0 && save.Saida != 0 && save.RTB != null)
            {
                valorEntradas.Value = save.Entrada;

                valorSaidas.Value = save.Saida;

                checkedListBox1.Items.Add(save.Metas);

                RTBresultado.Text = save.RTB;

                valorTotal.Value = save.Total;
            }

            // DOFERENÇA ENTRE CODIGO ASSINCRONO E CODIGO SINCRONO

            // string arquivu = "D:\\GitHub\\Projeto_C#\\Projeto_Banco_de_Financias\\Trabalho-Unibrasil\\Banco-De-Financias\\Properties\\ArquivoJSON.json";
            // StreamReader sr = new StreamReader(arquivu);
            // JsonConversao jsonconv = new JsonConversao();
            // object saves = jsonconv.ConverteJSonParaObject<Salvaar>(jsonconv.ConverteObjectParaJSon(sr));
            // sr.Close();

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
    
            DateTime Data = DateTime.Now;
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
                    $"{textoDesricao}   " + $"{valor} Reais" + $"\t {Data}" + "\n" +
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
            
            valorTotal.Value = 0;
            valorEntradas.Value = 0;
            valorSaidas.Value = 0;

        }

        private void RTBresultado_TextChanged(object sender, EventArgs e)
        {
            // o painel total fica verde quando é positivo e fica vermelho quando é negativo
            panel5.BackColor = valorTotal.Value >= 0 ? Color.Green : Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* Determines whether the user wants to exit the application.
             * If not, adds another number to the list box. */
            while (true)
            {
                if (MessageBox.Show("Deseja sair?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                    break;
                }
                else
                {
                    break;
                }
            }
            
            // The user wants to exit the application. Close everything down.
            
        }

        private void AddMeta_Click(object sender, EventArgs e)
        {

            DateTime DataCheck = monthCalendar1.SelectionEnd;
            string texto =  textBox1.Text;
            
            checkedListBox1.Items.Add(texto +" "+ DataCheck,CheckState.Unchecked);
            
        }

        private void RemoveMeta_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        public void Salvar_Click(object sender, EventArgs e)
        {


            var save = new Salvar()
            {
                Entrada = valorEntradas.Value,
                Saida = valorSaidas.Value,
                Total = valorTotal.Value,
                RTB = RTBresultado.Text,
                Metas = checkedListBox1.Items
            };

            //JsonConversao jsonconv = new JsonConversao();
           // string arquivo = "D:\\GitHub\\Projeto_C#\\Projeto_Banco_de_Financias\\Trabalho-Unibrasil\\Banco-De-Financias\\Properties\\ArquivoJSON.json";

            string jsonString = JsonSerializer.Serialize(save);
            File.WriteAllText(arquivo, jsonString);

            MessageBox.Show("Voce Salvou", "",MessageBoxButtons.OK);
           // StreamWriter sw = new StreamWriter("D:\\GitHub\\Projeto_C#\\Projeto_Banco_de_Financias\\Trabalho-Unibrasil\\Banco-De-Financias\\Properties\\ArquivoJSON.json");
           // object saves = jsonconv.ConverteJSonParaObject<Salvaar>(jsonconv.ConverteObjectParaJSon(save));
           // sw.Close();

            //StreamReader sr = new StreamReader(arquivo);
            // arquivo = jsonconv.ConverteJSonParaObject<Salvaar>(save).ToString();
        }

        private readonly string arquivo = "D:\\GitHub\\Projeto_C#\\Projeto_Banco_de_Financias\\Trabalho-Unibrasil\\Banco-De-Financias\\Properties\\ArquivoJSON.json";

    }

    public class Salvar
    {
            public decimal Entrada { get; set; }
            public decimal Saida { get; set; }
            public decimal Total { get; set; }
            public string RTB { get; set; }
            public object Metas { get; set; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
