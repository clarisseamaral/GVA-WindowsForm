using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using System;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class FormCliente : Form
    {
        public int CodigoCliente { get; set; }

        public bool Editar { get; set; }

        bool focus = false;

        public FormCliente(int codigo, bool editar)
        {
            CodigoCliente = codigo;
            Editar = editar;
            InitializeComponent();

            var ldadosCliente = CadastroCliente.BuscaClientePorCodigo(codigo);
            PrencherCampos(ldadosCliente);

            if (!Editar)
                DesabilitarCampos();
        }

        public FormCliente()
        {
            InitializeComponent();
        }

        #region Eventos

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                if (String.IsNullOrWhiteSpace(txtNome.Text))
                    Util.ValidacaoCampo.AlteraBordaControl(txtNome, e);
                if (!rbFeminino.Checked && !rbMasculino.Checked)
                {
                    Util.ValidacaoCampo.AlteraBordaControl(rbFeminino, e);
                    Util.ValidacaoCampo.AlteraBordaControl(rbMasculino, e);
                }

                if (lblNotificacao.Text.Contains(Properties.Resources.DataInvalida))
                    Util.ValidacaoCampo.AlteraBordaControl(dtDataNascimento, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void OnlyLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
                e.Handled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void PrencherCampos(Cliente ldadosCliente)
        {
            txtNome.Text = ldadosCliente.Nome;
            txtTelefone.Text = ldadosCliente.Telefone;
            txtEmail.Text = ldadosCliente.Email;
            if (ldadosCliente.DataNascimento.HasValue)
                dtDataNascimento.Text = ldadosCliente.DataNascimento.Value.ToString();

            if (ldadosCliente.Sexo == "F")
                rbFeminino.Checked = true;
            else
                rbMasculino.Checked = true;

            //Endereco
            if (ldadosCliente.Numero > 0)
                txtNumero.Text = ldadosCliente.Numero.ToString();

            txtBairro.Text = ldadosCliente.Bairro;
            txtCEP.Text = ldadosCliente.CEP;
            txtCidade.Text = ldadosCliente.Cidade;
            txtUF.Text = ldadosCliente.UF;
            txtRua.Text = ldadosCliente.Rua;
            txtObservacoes.Text = ldadosCliente.Observacoes;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            dtDataNascimento.Enabled = false;
            rbFeminino.Enabled = false;
            rbMasculino.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtRua.Enabled = false;
            txtObservacoes.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnVoltar.Visible = true;
        }

        private bool ValidaCamposPreenchidos()
        {
            var camposValidos = true;

            if (String.IsNullOrWhiteSpace(txtNome.Text) || (!rbFeminino.Checked && !rbMasculino.Checked))
                camposValidos = false;

            if (camposValidos)
                lblNotificacao.Text = string.Empty;
            else
                lblNotificacao.Text = Properties.Resources.CamposObrigatorios;

            return camposValidos;
        }

        private void FecharTela(string mensagem)
        {
            var message = MessageBox.Show(mensagem, "", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                ((FormListaCliente)this.Owner.ActiveControl).Recarregar();
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((CodigoCliente == 0 || CodigoCliente > 0 && Editar) && keyData == (Keys.Control | Keys.S))
            {
                Salvar();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Salvar()
        {
            lblNotificacao.Text = string.Empty;

            if (ValidaCamposPreenchidos())
            {
                try
                {
                    var message = DialogResult.Yes;

                    if (CodigoCliente > 0)
                        message = MessageBox.Show(Properties.Resources.ConfirmarEditar, "", MessageBoxButtons.YesNo);

                    if (message == DialogResult.Yes)
                    {
                        var cliente = new Cliente();
                        cliente.Nome = txtNome.Text;
                        cliente.Telefone = String.IsNullOrWhiteSpace(txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "")) ? string.Empty : txtTelefone.Text;
                        cliente.Email = txtEmail.Text;
                        cliente.DataNascimento = String.IsNullOrWhiteSpace(dtDataNascimento.Text.Replace("/", "").Replace("_", "")) ? (DateTime?)null : DateTime.Parse(dtDataNascimento.Text);
                        cliente.Codigo = CodigoCliente;
                        cliente.Bairro = txtBairro.Text;
                        cliente.CEP = txtCEP.Text;
                        cliente.Cidade = txtCidade.Text;
                        cliente.UF = txtUF.Text;
                        cliente.Numero = String.IsNullOrWhiteSpace(txtNumero.Text) ? 0 : int.Parse(txtNumero.Text);
                        cliente.Sexo = rbFeminino.Checked ? "F" : "M";
                        cliente.Rua = txtRua.Text;
                        cliente.Observacoes = txtObservacoes.Text;

                        if (CodigoCliente > 0)
                        {
                            CadastroCliente.AtualizaCliente(cliente);
                            FecharTela(Properties.Resources.DadosAlteradosSucesso);
                        }
                        else
                        {
                            CadastroCliente.CadastraCliente(cliente);

                            FecharTela(Properties.Resources.DadosInseridosSucesso);
                        }
                    }
                }
                catch (FormatException ex)
                {
                    if (ex.Message.Contains("DateTime"))
                    {
                        lblNotificacao.Text = Properties.Resources.DataInvalida;
                        focus = true;
                        this.Refresh();
                    }
                    else
                        lblNotificacao.Text = ex.Message;
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

        private void Cancelar()
        {
            var message = MessageBox.Show(Properties.Resources.ConfirmarCancelar, "", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
                Application.OpenForms[2].Close();
            else
                this.DialogResult = DialogResult.None;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (CodigoCliente > 0 && !Editar)
                {
                    Close();
                    return true;
                }
                else
                {
                    var message = MessageBox.Show(Properties.Resources.ConfirmarCancelar, "", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        Close();
                        return true;
                    }
                }
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}



