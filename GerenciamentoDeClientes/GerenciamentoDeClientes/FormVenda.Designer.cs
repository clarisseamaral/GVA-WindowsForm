namespace GerenciamentoDeClientes
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.dtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.dtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.dtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.ForeColor = System.Drawing.Color.Red;
            this.lblNotificacao.Location = new System.Drawing.Point(56, 21);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(0, 13);
            this.lblNotificacao.TabIndex = 41;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(68, 91);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 26);
            this.lblDescricao.TabIndex = 39;
            this.lblDescricao.Text = "Descrição \r\ndo produto*:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(159, 88);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(471, 29);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(68, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.Text = "Cliente*:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(159, 52);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(186, 21);
            this.cbCliente.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(388, 59);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 13);
            this.lblValor.TabIndex = 45;
            this.lblValor.Text = "Valor*:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(444, 52);
            this.txtValorTotal.MaxLength = 8;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(186, 20);
            this.txtValorTotal.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(267, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "      Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.save;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Location = new System.Drawing.Point(372, 267);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 27);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "      Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(416, 29);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(104, 13);
            this.lblDataPagamento.TabIndex = 43;
            this.lblDataPagamento.Text = "Data do pagamento:";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(214, 29);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(110, 13);
            this.lblDataVencimento.TabIndex = 47;
            this.lblDataVencimento.Text = "Data do vencimento*:";
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.Location = new System.Drawing.Point(120, 26);
            this.dtDataVenda.Mask = "00/00/0000";
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(65, 20);
            this.dtDataVenda.TabIndex = 5;
            this.dtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // dtDataVencimento
            // 
            this.dtDataVencimento.Location = new System.Drawing.Point(330, 26);
            this.dtDataVencimento.Mask = "00/00/0000";
            this.dtDataVencimento.Name = "dtDataVencimento";
            this.dtDataVencimento.Size = new System.Drawing.Size(65, 20);
            this.dtDataVencimento.TabIndex = 6;
            this.dtDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // dtDataPagamento
            // 
            this.dtDataPagamento.Location = new System.Drawing.Point(526, 26);
            this.dtDataPagamento.Mask = "00/00/0000";
            this.dtDataPagamento.Name = "dtDataPagamento";
            this.dtDataPagamento.Size = new System.Drawing.Size(65, 20);
            this.dtDataPagamento.TabIndex = 7;
            this.dtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(29, 29);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(85, 13);
            this.lblDataVenda.TabIndex = 40;
            this.lblDataVenda.Text = "Data da venda*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataVenda);
            this.groupBox1.Controls.Add(this.dtDataPagamento);
            this.groupBox1.Controls.Add(this.dtDataVencimento);
            this.groupBox1.Controls.Add(this.dtDataVenda);
            this.groupBox1.Controls.Add(this.lblDataVencimento);
            this.groupBox1.Controls.Add(this.lblDataPagamento);
            this.groupBox1.Location = new System.Drawing.Point(39, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datas";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox_Paint);
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(549, 228);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(109, 13);
            this.lblCamposObrigatorios.TabIndex = 46;
            this.lblCamposObrigatorios.Text = "* Campos obrigatórios";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 322);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormVenda_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.MaskedTextBox dtDataVenda;
        private System.Windows.Forms.MaskedTextBox dtDataVencimento;
        private System.Windows.Forms.MaskedTextBox dtDataPagamento;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}