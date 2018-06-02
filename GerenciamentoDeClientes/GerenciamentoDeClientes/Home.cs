using System;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fechaTelaAberta()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private bool VerificaTelaAberta()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Close();
                    return true;
                }
            }
            return false;
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCliente();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirVenda();
        }

        private void gráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fechaTelaAberta();
            var formGrafico = new FormGrafico();
            formGrafico.MdiParent = this;
            formGrafico.Show();
        }

        private void AbrirVenda()
        {
            fechaTelaAberta();
            var formVenda = new FormListaVenda();
            formVenda.MdiParent = this;
            formVenda.Show();
        }

        private void AbrirCliente()
        {
            fechaTelaAberta();
            var formCliente = new FormListaCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show(Properties.Resources.ConfirmarSair, "", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
                Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape || keyData == Keys.F4)
                if (Sair(keyData))
                    return true;
                else if (keyData == Keys.F2)
                    AbrirCliente();
                else if (keyData == Keys.F3)
                    AbrirVenda();

            return base.ProcessDialogKey(keyData);
        }

        private bool Sair(Keys keyData)
        {
            var message = MessageBox.Show(Properties.Resources.ConfirmarSair, "", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                Close();
                return true;
            }
            this.DialogResult = DialogResult.None;

            return false;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VerificaTelaAberta())
            {
                e.Cancel = true;
            }
            else
            {
                var message = MessageBox.Show(Properties.Resources.ConfirmarSair, "", MessageBoxButtons.YesNo);
                if (message != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

    }
}
