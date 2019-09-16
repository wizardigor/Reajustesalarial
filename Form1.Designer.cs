namespace Reajustesalarial
{
    partial class fmReajusteSalalrial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbCalouro = new System.Windows.Forms.RadioButton();
            this.rbVeterano = new System.Windows.Forms.RadioButton();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.pnlDescricao = new System.Windows.Forms.Panel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.gbCategoria.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.pnlDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Minimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(119, 10);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(108, 20);
            this.txtSalarioMinimo.TabIndex = 0;
            this.txtSalarioMinimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSalarioMinimo_KeyDown);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbCalouro);
            this.gbCategoria.Controls.Add(this.rbVeterano);
            this.gbCategoria.Location = new System.Drawing.Point(16, 75);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(211, 51);
            this.gbCategoria.TabIndex = 3;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // rbCalouro
            // 
            this.rbCalouro.AutoSize = true;
            this.rbCalouro.Checked = true;
            this.rbCalouro.Location = new System.Drawing.Point(22, 19);
            this.rbCalouro.Name = "rbCalouro";
            this.rbCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbCalouro.TabIndex = 2;
            this.rbCalouro.TabStop = true;
            this.rbCalouro.Text = "Calouro";
            this.rbCalouro.UseVisualStyleBackColor = true;
            this.rbCalouro.CheckedChanged += new System.EventHandler(this.RbCalouro_CheckedChanged);
            // 
            // rbVeterano
            // 
            this.rbVeterano.AutoSize = true;
            this.rbVeterano.Location = new System.Drawing.Point(123, 18);
            this.rbVeterano.Name = "rbVeterano";
            this.rbVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbVeterano.TabIndex = 3;
            this.rbVeterano.TabStop = true;
            this.rbVeterano.Text = "Veterano";
            this.rbVeterano.UseVisualStyleBackColor = true;
            this.rbVeterano.CheckedChanged += new System.EventHandler(this.RbCalouro_CheckedChanged);
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(119, 35);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(108, 20);
            this.txtHorasTrabalhadas.TabIndex = 1;
            this.txtHorasTrabalhadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSalarioMinimo_KeyDown);
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.rbNoturno);
            this.gbTurno.Controls.Add(this.rbMatutino);
            this.gbTurno.Controls.Add(this.rbVespertino);
            this.gbTurno.Location = new System.Drawing.Point(243, 10);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(112, 116);
            this.gbTurno.TabIndex = 4;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Turno:";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(22, 83);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbNoturno.TabIndex = 6;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            this.rbNoturno.CheckedChanged += new System.EventHandler(this.RbMatutino_CheckedChanged);
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Checked = true;
            this.rbMatutino.Location = new System.Drawing.Point(22, 19);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbMatutino.TabIndex = 4;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            this.rbMatutino.CheckedChanged += new System.EventHandler(this.RbMatutino_CheckedChanged);
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(22, 51);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbVespertino.TabIndex = 5;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            this.rbVespertino.CheckedChanged += new System.EventHandler(this.RbMatutino_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(16, 239);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(257, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TabStop = false;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(280, 239);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // pnlDescricao
            // 
            this.pnlDescricao.BackColor = System.Drawing.Color.White;
            this.pnlDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDescricao.Controls.Add(this.lbValor);
            this.pnlDescricao.Controls.Add(this.lbDescricao);
            this.pnlDescricao.Location = new System.Drawing.Point(16, 132);
            this.pnlDescricao.Name = "pnlDescricao";
            this.pnlDescricao.Size = new System.Drawing.Size(339, 101);
            this.pnlDescricao.TabIndex = 10;
            this.pnlDescricao.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDescricao_Paint);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(5, 7);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(0, 13);
            this.lbDescricao.TabIndex = 11;
            // 
            // lbValor
            // 
            this.lbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValor.AutoSize = true;
            this.lbValor.BackColor = System.Drawing.Color.White;
            this.lbValor.Location = new System.Drawing.Point(262, 7);
            this.lbValor.Name = "lbValor";
            this.lbValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbValor.Size = new System.Drawing.Size(0, 13);
            this.lbValor.TabIndex = 12;
            this.lbValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fmReajusteSalalrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 272);
            this.Controls.Add(this.pnlDescricao);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.gbTurno);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmReajusteSalalrial";
            this.Text = "Reajuste Salárial";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.pnlDescricao.ResumeLayout(false);
            this.pnlDescricao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbVeterano;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.RadioButton rbCalouro;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Panel pnlDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbValor;
    }
}

