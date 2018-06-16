using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class FormVenda : Form
    {
        public int CodigoVenda { get; set; }

        bool focus = false;
        string dataInvalida = string.Empty;

        public FormVenda(int codigo)
        {
            CodigoVenda = codigo;
            InitializeComponent();
            CarregarTela();
            var ldadosVenda = new CadastroVenda().BuscaVendaPorCodigo(codigo);
            txtDescricao.Text = ldadosVenda.Descricao;

            dtDataVenda.Text = ldadosVenda.DataVenda.ToString();
            dtDataVencimento.Text = ldadosVenda.DataVencimento.ToString();
            cbCliente.SelectedValue = ldadosVenda.Cliente.Codigo.ToString();
            txtValorTotal.Text = ldadosVenda.ValorTotal.ToString("C2");

            if (ldadosVenda.DataPagamento.HasValue)
                dtDataPagamento.Text = ldadosVenda.DataPagamento.Value.ToString();
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void FormVenda_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                if (cbCliente.SelectedValue == null)
                    Util.ValidacaoCampo.AlteraBordaControl(cbCliente, e);
                if (String.IsNullOrEmpty(txtDescricao.Text))
                    Util.ValidacaoCampo.AlteraBordaControl(txtDescricao, e);
                if (String.IsNullOrEmpty(txtValorTotal.Text))
                    Util.ValidacaoCampo.AlteraBordaControl(txtValorTotal, e);
            }
            else
            {
                txtDescricao.BorderStyle = BorderStyle.FixedSingle;
                txtValorTotal.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                if (String.IsNullOrWhiteSpace(dtDataVenda.Text.Replace("/", "").Replace("_", "")))
                    Util.ValidacaoCampo.AlteraBordaControl(dtDataVenda, e);

                if (String.IsNullOrWhiteSpace(dtDataVencimento.Text.Replace("/", "").Replace("_", "")))
                    Util.ValidacaoCampo.AlteraBordaControl(dtDataVencimento, e);

                if (lblNotificacao.Text.Contains(Properties.Resources.DataInvalida))
                {
                    if (dataInvalida.Contains("venda"))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataVenda, e);

                    if (dataInvalida.Contains("vencimento"))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataVencimento, e);

                    if (dataInvalida.Contains("pagamento"))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataPagamento, e);
                }
                else
                {
                    if (lblNotificacao.Text.Contains(Properties.Resources.DataVendaMaiorPermitido))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataVenda, e);
                    else if (lblNotificacao.Text.Contains(Properties.Resources.DataPagamentoInvalida))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataPagamento, e);
                    else if (lblNotificacao.Text.Contains(Properties.Resources.DataVencimentoInvalida))
                        Util.ValidacaoCampo.AlteraBordaControl(dtDataVencimento, e);
                }

            }
            else
            {
                dtDataVenda.BorderStyle = BorderStyle.FixedSingle;
                dtDataVencimento.BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
        }

        #region MascaraValor
        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public static void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = String.IsNullOrWhiteSpace(txt.Text) ? txt.Text : double.Parse(txt.Text).ToString("C2");
        }

        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        #endregion
        #endregion

        public FormVenda()
        {
            InitializeComponent();
            CarregarTela();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Salvar();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Cancelar()
        {
            var message = MessageBox.Show(Properties.Resources.ConfirmarCancelar, "", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
                Application.OpenForms[2].Close();
            else
                this.DialogResult = DialogResult.None;
        }

        private void Salvar()
        {
            if (ValidaCamposPreenchidos())
            {
                try
                {
                    var message = DialogResult.Yes;

                    if (CodigoVenda > 0)
                        message = MessageBox.Show(Properties.Resources.ConfirmarEditar, "", MessageBoxButtons.YesNo);

                    if (message == DialogResult.Yes)
                    {
                        var venda = new Venda();
                        venda.Descricao = txtDescricao.Text;
                        venda.DataPagamento = String.IsNullOrWhiteSpace(dtDataPagamento.Text.Replace("_", "").Replace("/", "")) ? (DateTime?)null : DateTime.Parse(dtDataPagamento.Text);
                        venda.DataVencimento = DateTime.Parse(dtDataVencimento.Text);
                        venda.DataVenda = DateTime.Parse(dtDataVenda.Text);
                        venda.Cliente = new Cliente() { Codigo = int.Parse(cbCliente.SelectedValue.ToString()) };
                        venda.ValorTotal = double.Parse(txtValorTotal.Text.Replace("R$", "").Trim());
                        venda.Codigo = CodigoVenda;

                        if (CodigoVenda > 0)
                        {
                            new CadastroVenda().AtualizaVenda(venda);
                            FecharTela(Properties.Resources.DadosAlteradosSucesso);
                        }
                        else
                        {
                            new CadastroVenda().CadastraVenda(venda);
                            FecharTela(Properties.Resources.DadosInseridosSucesso);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblNotificacao.Text = ex.Message;
                }
            }
            else
            {
                focus = true;
                this.Refresh();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                var message = MessageBox.Show(Properties.Resources.ConfirmarCancelar, "", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    Close();
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CarregarTela()
        {
            PreencheComboBox();
            AplicarEventos(txtValorTotal);
        }

        private bool ValidaCamposPreenchidos()
        {
            var camposValidos = true;

            if (cbCliente.SelectedValue == null || String.IsNullOrEmpty(txtDescricao.Text) || String.IsNullOrEmpty(txtValorTotal.Text)
                || String.IsNullOrWhiteSpace(dtDataVenda.Text.Replace("/", "").Replace("_", "")) || String.IsNullOrWhiteSpace(dtDataVencimento.Text.Replace("/", "").Replace("_", "")))
                camposValidos = false;

            if (camposValidos)
                lblNotificacao.Text = string.Empty;
            else
                lblNotificacao.Text = Properties.Resources.CamposObrigatorios;

            return camposValidos && ValidaDatasPreenchidas();
        }

        private bool ValidaDatasPreenchidas()
        {
            DateTime ldataVenda, ldataPagamento, ldataVencimento;
            bool datasValidas = true, datasPreenchidasCorretamente = true;

            DateTime.TryParseExact(GerarData(dtDataVenda.Text), "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out ldataVenda);
            DateTime.TryParseExact(GerarData(dtDataPagamento.Text), "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out ldataPagamento);
            DateTime.TryParseExact(GerarData(dtDataVencimento.Text), "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out ldataVencimento);

            if (ldataVenda == DateTime.MinValue || ldataVencimento == DateTime.MinValue)
            {
                datasPreenchidasCorretamente = false;

                dataInvalida = ldataVenda == DateTime.MinValue ? "venda" : string.Empty;
                dataInvalida += ldataVencimento == DateTime.MinValue ? " vencimento" : string.Empty;
            }

            if (!String.IsNullOrWhiteSpace(GerarData(dtDataPagamento.Text)) && ldataPagamento == DateTime.MinValue)
            {
                datasPreenchidasCorretamente = false;
                dataInvalida += " pagamento";
            }

            if (datasPreenchidasCorretamente)
            {
                if(ldataVenda > DateTime.Now)
                {
                    datasValidas = false;
                    lblNotificacao.Text += Properties.Resources.DataVendaMaiorPermitido;
                }
                else if (ldataVenda > ldataVencimento)
                {
                    datasValidas = false;
                    lblNotificacao.Text += Properties.Resources.DataVencimentoInvalida;
                }
                else if (!String.IsNullOrWhiteSpace(GerarData(dtDataPagamento.Text)) && ldataVenda > ldataPagamento)
                {
                    datasValidas = false;
                    lblNotificacao.Text += Properties.Resources.DataPagamentoInvalida;
                }
            }
            else
            {
                lblNotificacao.Text += Properties.Resources.DataInvalida;
            }

            return datasValidas && datasPreenchidasCorretamente;
        }

        private string GerarData(string adata)
        {
            return String.IsNullOrWhiteSpace(adata.Replace("_", "").Replace("/", "")) ? string.Empty : adata;
        }

        private void PreencheComboBox()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            var clientes = new CadastroCliente().BuscaTodosClientes().OrderBy(p => p.Nome);

            foreach (var item in clientes)
            {
                comboSource.Add(item.Codigo.ToString(), item.Nome);
            }

            cbCliente.DataSource = new BindingSource(comboSource, null);
            cbCliente.DisplayMember = "Value";
            cbCliente.ValueMember = "Key";
            cbCliente.SelectedItem = null;
        }

        private void FecharTela(string mensagem)
        {
            var message = MessageBox.Show(mensagem, "", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                ((FormListaVenda)this.Owner.ActiveControl).Recarregar();
                this.Close();
            }
        }
    }
}
