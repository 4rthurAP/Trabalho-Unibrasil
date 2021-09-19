
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NomeProj = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.valorSaidas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.valorTotal = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.valorEntradas = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Total = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddMeta = new System.Windows.Forms.Button();
            this.RemoveMeta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotal)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorEntradas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeProj
            // 
            this.NomeProj.AutoSize = true;
            this.NomeProj.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeProj.Location = new System.Drawing.Point(498, 706);
            this.NomeProj.Name = "NomeProj";
            this.NomeProj.Size = new System.Drawing.Size(277, 30);
            this.NomeProj.TabIndex = 2;
            this.NomeProj.Text = "Projeto | Banco de Finanças";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Maroon;
            this.cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelar.Location = new System.Drawing.Point(679, 165);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(153, 29);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "LIMPAR";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.Green;
            this.Confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirmar.Location = new System.Drawing.Point(679, 218);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(153, 27);
            this.Confirmar.TabIndex = 4;
            this.Confirmar.Text = "CONFIRMAR";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Salvar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 143);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.valorSaidas);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(321, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 80);
            this.panel4.TabIndex = 2;
            // 
            // valorSaidas
            // 
            this.valorSaidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorSaidas.DecimalPlaces = 2;
            this.valorSaidas.Enabled = false;
            this.valorSaidas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorSaidas.InterceptArrowKeys = false;
            this.valorSaidas.Location = new System.Drawing.Point(42, 43);
            this.valorSaidas.Name = "valorSaidas";
            this.valorSaidas.Size = new System.Drawing.Size(100, 34);
            this.valorSaidas.TabIndex = 4;
            this.valorSaidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(42, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saídas";
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Salvar.Location = new System.Drawing.Point(1105, 105);
            this.Salvar.Margin = new System.Windows.Forms.Padding(0);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(94, 34);
            this.Salvar.TabIndex = 10;
            this.Salvar.Text = "S A L V A R";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1165, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "Banco De Finanças";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.valorTotal);
            this.panel5.Location = new System.Drawing.Point(653, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 79);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(56, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // valorTotal
            // 
            this.valorTotal.DecimalPlaces = 2;
            this.valorTotal.Enabled = false;
            this.valorTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorTotal.InterceptArrowKeys = false;
            this.valorTotal.Location = new System.Drawing.Point(45, 43);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(100, 34);
            this.valorTotal.TabIndex = 5;
            this.valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.valorEntradas);
            this.panel3.Location = new System.Drawing.Point(18, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 80);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entradas";
            // 
            // valorEntradas
            // 
            this.valorEntradas.DecimalPlaces = 2;
            this.valorEntradas.Enabled = false;
            this.valorEntradas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorEntradas.InterceptArrowKeys = false;
            this.valorEntradas.Location = new System.Drawing.Point(46, 41);
            this.valorEntradas.Name = "valorEntradas";
            this.valorEntradas.Size = new System.Drawing.Size(100, 34);
            this.valorEntradas.TabIndex = 3;
            this.valorEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.descricao);
            this.panel2.Controls.Add(this.Valor);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 80);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(417, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(255, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
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
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(417, 31);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 23);
            this.Date.TabIndex = 0;
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
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(64, 357);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(64, 107);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(227, 238);
            this.checkedListBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 23);
            this.textBox1.TabIndex = 8;
            // 
            // AddMeta
            // 
            this.AddMeta.BackColor = System.Drawing.Color.Green;
            this.AddMeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddMeta.Location = new System.Drawing.Point(64, 72);
            this.AddMeta.Margin = new System.Windows.Forms.Padding(0);
            this.AddMeta.Name = "AddMeta";
            this.AddMeta.Size = new System.Drawing.Size(95, 29);
            this.AddMeta.TabIndex = 9;
            this.AddMeta.Text = "ADICIONAR";
            this.AddMeta.UseVisualStyleBackColor = false;
            this.AddMeta.Click += new System.EventHandler(this.AddMeta_Click);
            // 
            // RemoveMeta
            // 
            this.RemoveMeta.BackColor = System.Drawing.Color.Maroon;
            this.RemoveMeta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveMeta.Location = new System.Drawing.Point(197, 71);
            this.RemoveMeta.Name = "RemoveMeta";
            this.RemoveMeta.Size = new System.Drawing.Size(94, 30);
            this.RemoveMeta.TabIndex = 10;
            this.RemoveMeta.Text = "REMOVER";
            this.RemoveMeta.UseVisualStyleBackColor = false;
            this.RemoveMeta.Click += new System.EventHandler(this.RemoveMeta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(107, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Digite suas metas.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Controls.Add(this.monthCalendar1);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.checkedListBox1);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.RemoveMeta);
            this.panel7.Controls.Add(this.AddMeta);
            this.panel7.Location = new System.Drawing.Point(838, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(352, 535);
            this.panel7.TabIndex = 12;
            // 
            // DataTable
            // 
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Data,
            this.dataGridViewTextBoxColumn2});
            this.DataTable.Location = new System.Drawing.Point(15, 271);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowTemplate.Height = 25;
            this.DataTable.Size = new System.Drawing.Size(817, 408);
            this.DataTable.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 580;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1202, 759);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.NomeProj);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Financias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorEntradas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeProj;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.NumericUpDown Valor;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddMeta;
        private System.Windows.Forms.Button RemoveMeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Salvar;
        public System.Windows.Forms.NumericUpDown valorTotal;
        public System.Windows.Forms.NumericUpDown valorSaidas;
        public System.Windows.Forms.NumericUpDown valorEntradas;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

