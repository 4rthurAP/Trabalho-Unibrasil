
namespace Banco_De_Financias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTBresultado = new System.Windows.Forms.RichTextBox();
            this.NomeProj = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.valorTotal = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.valorSaidas = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.valorEntradas = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descricao = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.NumericUpDown();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Total = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotal)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorSaidas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorEntradas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBresultado
            // 
            this.RTBresultado.Location = new System.Drawing.Point(12, 265);
            this.RTBresultado.Name = "RTBresultado";
            this.RTBresultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBresultado.Size = new System.Drawing.Size(1178, 414);
            this.RTBresultado.TabIndex = 1;
            this.RTBresultado.Text = "";
            this.RTBresultado.TextChanged += new System.EventHandler(this.RTBresultado_TextChanged);
            // 
            // NomeProj
            // 
            this.NomeProj.AutoSize = true;
            this.NomeProj.Location = new System.Drawing.Point(515, 710);
            this.NomeProj.Name = "NomeProj";
            this.NomeProj.Size = new System.Drawing.Size(155, 15);
            this.NomeProj.TabIndex = 2;
            this.NomeProj.Text = "Projeto | Banco de Financias";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelar.Location = new System.Drawing.Point(736, 172);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(103, 31);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Confirmar.Location = new System.Drawing.Point(736, 209);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(103, 40);
            this.Confirmar.TabIndex = 4;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 137);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.valorTotal);
            this.panel5.Location = new System.Drawing.Point(862, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 90);
            this.panel5.TabIndex = 3;
            // 
            // valorTotal
            // 
            this.valorTotal.DecimalPlaces = 2;
            this.valorTotal.Enabled = false;
            this.valorTotal.InterceptArrowKeys = false;
            this.valorTotal.Location = new System.Drawing.Point(42, 51);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(100, 23);
            this.valorTotal.TabIndex = 5;
            this.valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.valorSaidas);
            this.panel4.Location = new System.Drawing.Point(470, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 91);
            this.panel4.TabIndex = 2;
            // 
            // valorSaidas
            // 
            this.valorSaidas.DecimalPlaces = 2;
            this.valorSaidas.Enabled = false;
            this.valorSaidas.InterceptArrowKeys = false;
            this.valorSaidas.Location = new System.Drawing.Point(51, 52);
            this.valorSaidas.Name = "valorSaidas";
            this.valorSaidas.Size = new System.Drawing.Size(100, 23);
            this.valorSaidas.TabIndex = 4;
            this.valorSaidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.valorEntradas);
            this.panel3.Location = new System.Drawing.Point(75, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 91);
            this.panel3.TabIndex = 1;
            // 
            // valorEntradas
            // 
            this.valorEntradas.DecimalPlaces = 2;
            this.valorEntradas.Enabled = false;
            this.valorEntradas.InterceptArrowKeys = false;
            this.valorEntradas.Location = new System.Drawing.Point(40, 52);
            this.valorEntradas.Name = "valorEntradas";
            this.valorEntradas.Size = new System.Drawing.Size(100, 23);
            this.valorEntradas.TabIndex = 3;
            this.valorEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.descricao);
            this.panel2.Controls.Add(this.Valor);
            this.panel2.Controls.Add(this.Data);
            this.panel2.Location = new System.Drawing.Point(35, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 77);
            this.panel2.TabIndex = 5;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(28, 31);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(194, 23);
            this.descricao.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.DecimalPlaces = 2;
            this.Valor.Location = new System.Drawing.Point(255, 31);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(120, 23);
            this.Valor.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(417, 31);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(200, 23);
            this.Data.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(816, 58);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 23);
            this.Total.TabIndex = 2;
            this.Total.Text = "TOTAL";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 759);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.NomeProj);
            this.Controls.Add(this.RTBresultado);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Banco de Financias";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valorTotal)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valorSaidas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valorEntradas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RTBresultado;
        private System.Windows.Forms.Label NomeProj;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.NumericUpDown Valor;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.NumericUpDown valorTotal;
        private System.Windows.Forms.NumericUpDown valorSaidas;
        private System.Windows.Forms.NumericUpDown valorEntradas;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

