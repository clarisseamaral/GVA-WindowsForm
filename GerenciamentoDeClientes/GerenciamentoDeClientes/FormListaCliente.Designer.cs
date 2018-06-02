using System.Drawing;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    partial class FormListaCliente
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
            this.gvPessoas = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPessoas
            // 
            this.gvPessoas.AllowUserToAddRows = false;
            this.gvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Email,
            this.DataNascimento,
            this.Codigo,
            this.Visualizar,
            this.Editar,
            this.Apagar});
            this.gvPessoas.Location = new System.Drawing.Point(40, 94);
            this.gvPessoas.Name = "gvPessoas";
            this.gvPessoas.Size = new System.Drawing.Size(698, 210);
            this.gvPessoas.TabIndex = 3;
            this.gvPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPessoas_CellContentClick);
            this.gvPessoas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvPessoas_CellPainting);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Location = new System.Drawing.Point(615, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "     Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(70, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Cliente:";
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.ForeColor = System.Drawing.Color.Red;
            this.lblNotificacao.Location = new System.Drawing.Point(26, 9);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(0, 13);
            this.lblNotificacao.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.plus;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Location = new System.Drawing.Point(511, 43);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "     Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 223;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 110;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 160;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Width = 85;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Visualizar
            // 
            this.Visualizar.HeaderText = "";
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Width = 20;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar";
            this.Editar.Width = 20;
            // 
            // Apagar
            // 
            this.Apagar.HeaderText = "";
            this.Apagar.Name = "Apagar";
            this.Apagar.ToolTipText = "Apagar";
            this.Apagar.Width = 20;
            // 
            // FormListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 390);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gvPessoas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaCliente";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void gvPessoas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.view, new Rectangle(x, y, w, h));
                e.Handled = true;
            }else if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 7)
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

        private System.Windows.Forms.DataGridView gvPessoas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Button btnCadastrar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewButtonColumn Visualizar;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Apagar;
    }
}