using System.Collections.Generic;
using System.IO;
using RoleTop.Models;
namespace RoleTop.Repositories
{
    public class PlanoEventoRepository
    {
        private const string PATH = "Database/PlanoEvento.csv";

        public double ObterPrecoDe(string nomePlanoEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomePlanoEvento))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<PlanoEvento> ObterTodos()
        {
            List<PlanoEvento> planoEventos = new List<PlanoEvento>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                PlanoEvento pe = new PlanoEvento();
                string[] dados = linha.Split(";");
                pe.Nome = dados[0];
                pe.Preco = double.Parse(dados[1]);
                planoEventos.Add(pe);
            }
            return planoEventos;
        }
    }
}