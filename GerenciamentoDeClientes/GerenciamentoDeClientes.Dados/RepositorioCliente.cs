using GerenciamentoDeClientes.Dados.Contratos;
using GerenciamentoDeClientes.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClientes.Dados
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private const string NomeArquivo = "clientes.txt";
        private const char Separador = '|';

        public RepositorioCliente()
        {
            File.AppendAllText(NomeArquivo, "");
        }

        public void Cria(Cliente cliente)
        {
            if (cliente.Codigo == 0)
                cliente.Codigo = BuscaProximoCodigo();

            var pacienteSerializado = string.Join(Separador.ToString(), cliente.Codigo, cliente.Nome,  cliente.Telefone, cliente.Email, cliente.DataNascimento, cliente.Sexo, cliente.CEP, cliente.Cidade, cliente.Rua,cliente.Bairro, cliente.Numero, cliente.UF, cliente.Observacoes);
            File.AppendAllText(NomeArquivo, pacienteSerializado + "\r\n");
        }

        private int BuscaProximoCodigo()
        {
            //var linhas = File.ReadAllLines(NomeArquivo);
            //if (linhas.Count() > 0)
            //{
            //    var valores = linhas.Last().Split(Separador);
            //    return int.Parse(valores[0]) + 1;
            //}
            //return 1;
            var pacientes = BuscaTodos();
            return pacientes.Any() ? pacientes.Max(p => p.Codigo) + 1 : 1;
        }

        public Cliente BuscaPorCodigo(int cod)
        {
            return BuscaTodos().FirstOrDefault(p => p.Codigo == cod);
        }

        public IEnumerable<Cliente> BuscaPorNome(string nome)
        {
            return BuscaTodos().Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }

        public IEnumerable<Cliente> BuscaTodos()
        {
            var linhas = File.ReadAllLines(NomeArquivo);
            foreach (var linha in linhas)
            {
                var valores = linha.Split(Separador);
                yield return new Cliente
                {
                    Codigo = int.Parse(valores[0]),
                    Nome = valores[1],
                    Telefone = valores[2],
                    Email = valores[3],
                    DataNascimento = String.IsNullOrEmpty(valores[4]) ? null : (DateTime?) Convert.ToDateTime(valores[4]),
                    Sexo = valores[5],
                    CEP = valores[6],
                    Cidade = valores[7],
                    Rua = valores[8],
                    Bairro = valores[9],
                    Numero = String.IsNullOrEmpty(valores[10]) ? 0 : int.Parse(valores[10]),
                    UF = valores[11],
                    Observacoes = valores[12]
                };
            }
        }

        public void ApagaCliente(int codigo)
        {
            var linhas = File.ReadAllLines(NomeArquivo);

            File.WriteAllLines(NomeArquivo, linhas.Where(l => l.Split(Separador)[0] != codigo.ToString()));
        }
    }
}
