using System.Drawing;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    partial class FormListaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaVenda));
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gvVendas = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.ForeColor = System.Drawing.Color.Red;
            this.lblNotificacao.Location = new System.Drawing.Point(29, 333);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(0, 13);
            this.lblNotificacao.TabIndex = 19;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Cliente:";
            // 
            // gvVendas
            // 
            this.gvVendas.AllowUserToAddRows = false;
            this.gvVendas.AllowUserToDeleteRows = false;
            this.gvVendas.AllowUserToOrderColumns = true;
            this.gvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Vencimento,
            this.Pagamento,
            this.Valor,
            this.Email,
            this.Status,
            this.Codigo,
            this.Editar,
            this.Apagar});
            this.gvVendas.Location = new System.Drawing.Point(43, 103);
            this.gvVendas.Name = "gvVendas";
            this.gvVendas.ReadOnly = true;
            this.gvVendas.Size = new System.Drawing.Size(710, 210);
            this.gvVendas.TabIndex = 17;
            this.gvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVendas_CellContentClick);
            this.gvVendas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvVendas_CellPainting);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.plus;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Location = new System.Drawing.Point(317, 74);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "     Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Location = new System.Drawing.Point(421, 74);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "     Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.DropDownWidth = 225;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(101, 39);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(186, 21);
            this.cbCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Período:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(374, 35);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 26;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(503, 35);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDataFinal.TabIndex = 27;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "à";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 225;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(101, 74);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(186, 21);
            this.cbStatus.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 154;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Data da venda";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 70;
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Data do vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 70;
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Data do pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            this.Pagamento.Width = 70;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 54;
            // 
            // Email
            // 
            this.Email.HeaderText = "Descrição do produto";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 130;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar";
            this.Editar.Width = 20;
            // 
            // Apagar
            // 
            this.Apagar.HeaderText = "";
            this.Apagar.Name = "Apagar";
            this.Apagar.ReadOnly = true;
            this.Apagar.ToolTipText = "Apagar";
            this.Apagar.Width = 20;
            // 
            // FormListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 390);
            this.ControlBox = false;
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gvVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaVenda";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void gvVendas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gvVendas;
        private System.Windows.Forms.ComboBox cbCliente;
        private Label label4;
        private MaskedTextBox txtDataInicial;
        private MaskedTextBox txtDataFinal;
        private Label label5;
        private ComboBox cbStatus;
        private Label lblStatus;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn Pagamento;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Apagar;
    }
}