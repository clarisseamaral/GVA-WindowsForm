using GerenciamentoDeClientes.Dominio;
using GerenciamentoDeClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClientes
{
    public partial class FormGrafico : Form
    {
        public FormGrafico()
        {
            InitializeComponent();
            IniciarGrafico();
        }

        private void FormGrafico_Load(object sender, EventArgs e)
        {

            
        }

        private void IniciarGrafico()
        {

            var filtro = new FiltroTelaVendas()
            {
                CodigoCliente = 4 //cbCliente.SelectedValue == null ? (int?)null : int.Parse(cbCliente.SelectedValue.ToString()),
            };

            var lvenda = CadastroVenda.BuscaVendasComFiltro(filtro).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Nome", typeof(String));
            dt.Columns.Add("DataPagamento", typeof(String));

            foreach (var valor in lvenda)
            {
                dt.Rows.Add(valor.Cliente, valor.DataVenda);
            }


            graficoCliente.Titles.Clear();
            graficoCliente.Titles.Add("Clientes");
            graficoCliente.DataSource = dt.DefaultView;
            graficoCliente.Series["Series1"].XValueMember = "Nome";
            graficoCliente.Series["Series1"].YValueMembers = "DataPagamento";
            graficoCliente.DataBind();
        }


    }
}
