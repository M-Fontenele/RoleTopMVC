using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.IO;
using RoleTop.Models;
using System;

namespace RoleTop.Repositories
{
    public class AgendaRepository : RepositoryBase
    {
        private const string PATH = "Database/Agendar.csv";

        public AgendaRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Agendar agendar)
        {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            agendar.Id = (ulong)++quantidadePedidos;
            var linha = new string[] {PrepararAgendaCSV(agendar)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Agendar> ObterTodosPorCliente(string emailCliente)
        {
            var agendar = ObterTodos();
            List<Agendar> agendarCliente = new List<Agendar>();
            foreach (var agenda in agendar)
            {
                if(agenda.Cliente.Email.Equals(emailCliente))
                {
                    agendarCliente.Add(agenda);
                }
            }
            return agendarCliente;
        }

        public List<Agendar> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendar> agendar = new List<Agendar>();
            foreach (var linha in linhas)
            {
                Agendar agenda = new Agendar();

                agenda.Id = ulong.Parse(ExtrairValorDoCampo("id",linha));
                agenda.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                agenda.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                agenda.Cliente.Email = ExtrairValorDoCampo("cliente_email",linha);
                agenda.Cliente.CPF = ExtrairValorDoCampo("cliente_cpf",linha);
                agenda.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone",linha);
                agenda.NomeDoEvento = ExtrairValorDoCampo("nome_Evento",linha);
                agenda.TipoDeEvento = ExtrairValorDoCampo("tipos_Eventos",linha);
                agenda.Complemento = ExtrairValorDoCampo("outro_Tipo_De_Evento",linha);
                agenda.PlanoEvento.Nome = ExtrairValorDoCampo("planoDeEvento",linha);
                agenda.DiaDoEvento = DateTime.Parse(ExtrairValorDoCampo("dataEvento",linha));
                agenda.DataDoRegistro = DateTime.Parse(ExtrairValorDoCampo("diaDoRegistro",linha));
                agenda.DescricaoEvento = ExtrairValorDoCampo("descricao",linha);
                agenda.PrecoTotal = double.Parse(ExtrairValorDoCampo("precoTotal",linha));
                agenda.PublicoePrivado = bool.Parse(ExtrairValorDoCampo("privadopublico", linha));

                agendar.Add(agenda);
            }
            return agendar;
        }

        public Agendar ObterPor(ulong id)
        {
            var agendasTotais = ObterTodos();
            foreach (var agenda in agendasTotais)
            {
                if(id.Equals(agenda.Id))
                {
                    return agenda;
                }
            }
            return null;
        }
        public List<Agendar> ObterPorData(DateTime dataMes)
        {
            var mes = dataMes.Month;
            var todosEventos = ObterTodos();
            List<Agendar> eventosDesseMes = new List<Agendar>();
            foreach (var item in todosEventos)
            {
                var mesEvento =item.DiaDoEvento.Month;
                if(mesEvento == mes)
                {
                    eventosDesseMes.Add(item);
                }
            }
            return eventosDesseMes;
        }

        public bool Atualizar (Agendar agendar)
        {
            var agendasTotais = File.ReadAllLines(PATH);
            var agendaCSV = PrepararAgendaCSV(agendar);
            var linhaPedido = -1;
            var resultado = false;
            for (int i = 0; i < agendasTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", agendasTotais[i]));
                if(agendar.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                agendasTotais[linhaPedido] = agendaCSV;
                File.WriteAllLines(PATH,agendasTotais);
            }
            return resultado;
        }

        private string PrepararAgendaCSV(Agendar agendar)
        {
            Cliente c = agendar.Cliente;
            PlanoEvento pe = agendar.PlanoEvento;

            return $"id={agendar.Id};status_pedido={agendar.Status};privadopublico={agendar.PublicoePrivado};cliente_nome={c.Nome};cliente_email={c.Email};cliente_cpf={c.CPF};cliente_telefone={c.Telefone};nome_Evento={agendar.NomeDoEvento};tipos_Eventos={agendar.TipoDeEvento};outro_Tipo_De_Evento={agendar.Complemento};planoDeEvento={agendar.PlanoEvento.Nome};dataEvento={agendar.DiaDoEvento};diaDoRegistro={agendar.DataDoRegistro};descricao={agendar.DescricaoEvento};precoTotal={agendar.PrecoTotal}";
        }
    }
}