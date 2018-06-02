using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class FormListaVenda : Form
    {
        public FormListaVenda()
        {
            InitializeComponent();
            CarregaCombos();
        }

        #region Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var formVenda = new FormVenda();
            formVenda.StartPosition = FormStartPosition.Manual;
            formVenda.ShowDialog(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new FiltroTelaVendas()
                {
                    CodigoCliente = cbCliente.SelectedValue == null ? 0 : int.Parse(cbCliente.SelectedValue.ToString()),
                    DataInicial = String.IsNullOrWhiteSpace(txtDataInicial.Text.Replace("_", "").Replace("/", "")) ? (DateTime?)null : DateTime.Parse(txtDataInicial.Text),
                    DataFinal = String.IsNullOrWhiteSpace(txtDataFinal.Text.Replace("_", "").Replace("/", "")) ? (DateTime?)null : DateTime.Parse(txtDataFinal.Text),
                    Status = cbStatus.SelectedValue == null ? 0 : int.Parse(cbStatus.SelectedValue.ToString())
                };

                var lvenda = CadastroVenda.BuscaVendasComFiltro(filtro).ToList();

                PreencheGrid(lvenda);

            }
            catch (Exception ex)
            {
                lblNotificacao.Text = ex.Message;
            }
        }

        private void FormListaVenda_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void gvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var codigo = int.Parse(senderGrid.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                if (e.ColumnIndex == 7) //Editar
                {
                    var formVenda = new FormVenda(codigo);
                    formVenda.StartPosition = FormStartPosition.Manual;
                    formVenda.ShowDialog(this);
                }
                else if (e.ColumnIndex == 8) //Apagar
                {
                    var message = MessageBox.Show(Properties.Resources.ConfirmarApagar, "", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        CadastroVenda.ApagaVenda(codigo);
                        MessageBox.Show(Properties.Resources.DadoApagadoSucesso);
                        Recarregar();
                    }
                }
            }
        }
        #endregion

        public void Recarregar()
        {
            try
            {
                var vendas = CadastroVenda.BuscaTodasVendas().ToList();
                PreencheGrid(vendas);
            }
            catch (Exception ex)
            {
                lblNotificacao.Text = ex.Message;
            }
        }

        private void PreencheGrid(List<Venda> vendas)
        {
            gvVendas.Rows.Clear();

            if (vendas.Count > 0)
            {
                int i = 0;
                foreach (var item in vendas)
                {
                    var ldataPagamento = item.DataPagamento.HasValue ? item.DataPagamento.Value.ToString("dd/MM/yyy") : string.Empty;
                    var lstatus = "Pendente";

                    if (item.DataVencimento < DateTime.Now && !item.DataPagamento.HasValue)
                        lstatus = "Vencido";
                    else if (item.DataPagamento.HasValue)
                        lstatus = "Pago";

                    gvVendas.Rows.Add(item.Cliente.Nome, item.DataVenda.ToString("dd/MM/yyy"), item.DataVencimento.ToString("dd/MM/yyy"), ldataPagamento, item.ValorTotal.ToString("C2"), item.Descricao, item.Codigo);

                    switch (lstatus)
                    {
                        case "Pendente":
                            gvVendas.Rows[i].DefaultCellStyle.ForeColor = Color.DarkOrange;
                            break;
                        case "Vencido":
                            gvVendas.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        case "Pago":
                            gvVendas.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                            break;
                    }

                    i++;

                }

                gvVendas.Sort(this.Nome, ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show(Properties.Resources.NenhumRegistroEncontrado);
            }
        }

        private void CarregaCombos()
        {
            PreencheCombo(cbCliente, BuscaClientes());
            PreencheCombo(cbStatus, BuscaStatus());
        }

        private void PreencheCombo(ComboBox lcombo, Dictionary<string, string> comboSource)
        {
            lcombo.DataSource = new BindingSource(comboSource, null);
            lcombo.DisplayMember = "Value";
            lcombo.ValueMember = "Key";
            lcombo.SelectedItem = null;
        }

        private Dictionary<string, string> BuscaStatus()
        {
            var status = new Dictionary<string, string>();

            status.Add("0", "");
            status.Add("2", "Pago");
            status.Add("1", "Pendente");
            status.Add("3", "Vencido");

            return status;
        }

        private Dictionary<string, string> BuscaClientes()
        {
            var comboSource = new Dictionary<string, string>();

            var clientes = CadastroCliente.BuscaTodosClientes().OrderBy(p => p.Nome);

            comboSource.Add("0", "");

            foreach (var item in clientes)
            {
                comboSource.Add(item.Codigo.ToString(), item.Nome);
            }
            return comboSource;
        }

    }
}
