using System;
using System.IO;
using RoleTop.Models;

namespace RoleTop.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public bool Atualizar(Cliente c, string email)
        {
            var clienteTotais = File.ReadAllLines(PATH);
            var clienteCSV = PrepararRegistroCSV(c);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < clienteTotais.Length ; i++)
            {
                var emailConvertido = ExtrairValorDoCampo("email", clienteTotais[i]);
                if(email.Equals(emailConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            if(resultado)
            {
                clienteTotais[linhaPedido] = clienteCSV;
                File.WriteAllLines(PATH,clienteTotais);
            }
            return resultado;
        }
        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Nome = ExtrairValorDoCampo("nome",item);
                    c.Email = ExtrairValorDoCampo("email",item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento",item));
                    c.Senha = ExtrairValorDoCampo("senha",item);
                    c.Telefone = ExtrairValorDoCampo("telefone",item);
                    c.CPF = ExtrairValorDoCampo("cpf",item);
                    return c;

                }
            }
                return null;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};senha={cliente.Senha};email={cliente.Email};cpf={cliente.CPF};data_nascimento={cliente.DataNascimento};telefone={cliente.Telefone}";
        }
    }
}