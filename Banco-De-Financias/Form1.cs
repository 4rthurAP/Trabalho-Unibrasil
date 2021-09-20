
using Banco_De_Financas.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Banco_De_Financias
{
    
    public  partial class Form1 : Form
    {
        public List<Metas> listaObj = new List<Metas>();
        public List<ViewLinha> ViewLinhas = new();
        public Form1()
        {
            InitializeComponent();
            
            Valor.Minimum = -1000000000000;
            Valor.Maximum = 1000000000000;

            valorTotal.Minimum = -1000000000000;
            valorTotal.Maximum = 1000000000000;

            valorEntradas.Minimum = -1000000000000;
            valorEntradas.Maximum = 1000000000000;

            valorSaidas.Minimum = -10000000000000;
            valorSaidas.Maximum = 10000000000000;

            string jsonString = File.ReadAllText(arquivo);                  // Lê o arquivo e desserializa 
            var save = JsonConvert.DeserializeObject<Salva>(jsonString);    // o arquivo json e transforma em objeto

            foreach (var elemento in save.Metas)
            {
                listaObj.Add(elemento);
            }

            foreach (var itens in save.ViewLinhas)
            {
                ViewLinhas.Add(itens);
            }

            if (save.Entrada != 0 || save.Saida != 0 || save.ViewLinhas != null || save.Total != 0)
            {
                valorEntradas.Value = save.Entrada;

                valorSaidas.Value = save.Saida;

                foreach (var item in save.ViewLinhas)
                {
                    DataTable.Rows.Add(new string[] { item.Valor, item.Data, item.Descricao });
                }
                
                valorTotal.Value = save.Total;

                foreach (var elemento in save.Metas)
                {
                    checkedListBox1.Items.Add(elemento.Texto + " " + elemento.DataCheck);
                }
            }

            // O painel total fica verde quando é positivo e fica vermelho quando é negativo
            panel5.BackColor = valorTotal.Value > 0 ? Color.Green : Color.Red;
            label6.BackColor = valorTotal.Value > 0 ? Color.Green : Color.Red;
            if(valorTotal.Value == 0)
            {
                panel5.BackColor = Color.White;
                label6.BackColor = Color.White;
            }
            // DiFERENÇA ENTRE CODIGO ASSINCRONO E CODIGO SINCRONO
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DateTime data = Date.Value;
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

            ViewLinhas.Add(new ViewLinha( valor.ToString(), data.ToShortDateString(), textoDesricao ));

            string[] row = new string[] { valor.ToString(), data.ToShortDateString(),  textoDesricao};
            DataTable.Rows.Add(row);
            
            TextChange();
            Save();

            Valor.ResetText();
            descricao.ResetText();
        }

        private void saidas_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            valorSaidas.ResetText();
            valorEntradas.ResetText();
            valorTotal.ResetText();
            descricao.ResetText();
            Valor.ResetText();
            valorTotal.Value = 0;
            valorEntradas.Value = 0;
            valorSaidas.Value = 0;
            Save();
        }

        private void TextChange()
        {
            // O painel total fica verde quando é positivo e fica vermelho quando é negativo
            panel5.BackColor = valorTotal.Value >= 0 ? Color.Green : Color.Red;
            label6.BackColor = valorTotal.Value >= 0 ? Color.Green : Color.Red;
            label6.ForeColor = valorTotal.Value >= 0 ? Color.Black : Color.White;

            if (valorTotal.Value == 0)
            {
                panel5.BackColor = Color.White;
                label6.BackColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (MessageBox.Show("Deseja sair?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Save();
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

            DateTime DataCheck = monthCalendar1.SelectionStart;
 
            string texto = textBox1.Text;

            listaObj.Add(new Metas(texto, DataCheck.ToShortDateString(), CheckState.Unchecked));   

            checkedListBox1.Items.Add(texto + " " + DataCheck.ToShortDateString(), CheckState.Unchecked);
        }

        private void RemoveMeta_Click(object sender, EventArgs e)
        {
            listaObj.Clear();
            checkedListBox1.Items.Clear();
        }

        public void Salvar_Click(object sender, EventArgs e)
        {

            var save = new Salva()
            {
                Entrada = valorEntradas.Value,
                Saida = valorSaidas.Value,
                Total = valorTotal.Value,
                ViewLinhas = ViewLinhas,
                Metas = listaObj
            };

            string jsonString = JsonConvert.SerializeObject(save);// Serializa o objeto 
            File.WriteAllText(arquivo, jsonString);               // e transforma em json e salva

            MessageBox.Show("Voce Salvou!", "",MessageBoxButtons.OK);

        }

        // private readonly string arquivo = @"~\\ArquivoJSON.json";
        private readonly string arquivo = "D:\\GitHub\\Projeto_C#\\Projeto_Banco_de_Financias\\Trabalho-Unibrasil\\Banco-De-Financias\\Properties\\ArquivoJSON.json";

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void Save()
        {
            var save = new Salva()
            {
                Entrada = valorEntradas.Value,
                Saida = valorSaidas.Value,
                Total = valorTotal.Value,
                ViewLinhas = ViewLinhas,
                Metas = listaObj
            };

            string jsonString = JsonConvert.SerializeObject(save);
            File.WriteAllText(arquivo, jsonString);
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
