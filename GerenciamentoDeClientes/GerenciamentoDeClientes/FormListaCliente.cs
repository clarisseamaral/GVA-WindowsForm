using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class FormListaCliente : Form
    {
        public FormListaCliente()
        {
            InitializeComponent();
        }


        #region Eventos

        private void FormListaCliente_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.StartPosition = FormStartPosition.Manual;
            formCliente.ShowDialog(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                gvPessoas.Rows.Clear();

                var clientes = new CadastroCliente().BuscaClientePorNome(txtNome.Text).ToList();

                if (clientes.Count > 0)
                    PreencheGrid(clientes);
                else
                    MessageBox.Show(Properties.Resources.NenhumRegistroEncontrado);
            }
            catch (Exception ex)
            {
                lblNotificacao.Text = ex.Message;
            }
        }

        private void gvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var codigo = int.Parse(senderGrid.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                if (e.ColumnIndex == 5 || e.ColumnIndex == 6 ) 
                {
                    FormCliente formCliente = new FormCliente(codigo, e.ColumnIndex == 6);
                    formCliente.StartPosition = FormStartPosition.Manual;
                    formCliente.ShowDialog(this);
                }
                else if (e.ColumnIndex == 7) //Ação de apagar
                {
                    var message = MessageBox.Show(Properties.Resources.ConfirmarApagar, "", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        var apagado = new CadastroCliente().ApagaCliente(codigo);
                        if (apagado)
                        {
                            MessageBox.Show(Properties.Resources.DadoApagadoSucesso);
                            Recarregar();
                        }
                        else
                            MessageBox.Show(Properties.Resources.ClienteComVenda);
                    }
                }
            }
        }
        #endregion

        private void PreencheGrid(List<Cliente> clientes)
        {
            gvPessoas.Rows.Clear();

            foreach (var item in clientes)
                gvPessoas.Rows.Add(item.Nome, item.Telefone, item.Email, item.DataNascimento.HasValue ? item.DataNascimento.Value.ToString("dd/MM/yyyy") : string.Empty, item.Codigo);

            gvPessoas.Sort(this.Nome, ListSortDirection.Ascending);
        }

        public void Recarregar()
        {
            try
            {
                var clientes = new CadastroCliente().BuscaTodosClientes().ToList();

                PreencheGrid(clientes);
            }
            catch (Exception ex)
            {
                lblNotificacao.Text = ex.Message;
            }
        }

    }
}
