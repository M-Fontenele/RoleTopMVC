using System;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class AgendaController : AbstractController
    {
        PlanoEventoRepository planoEventoRepository = new PlanoEventoRepository();
        ClienteRepository ClienteRepository = new ClienteRepository();
        AgendaRepository agendaRepository = new AgendaRepository();
        public IActionResult Agendar()
        {
            AgendaViewModel a = new AgendaViewModel();
            a.PlanoEvento = planoEventoRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                a.UsuarioNome = nomeUsuarioLogado;
            }

            var clienteLogado = ClienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                a.Cliente = clienteLogado;
            }
            
            a.NomeView = "Agenda";
            a.UsuarioEmail = ObterUsuarioSession();
            a.UsuarioNome = ObterUsuarioNomeSession();
            return View(a);
        }

        public IActionResult AgendarEvento(IFormCollection form)
        {
            Agendar agenda = new Agendar();

            agenda.NomeDoEvento = form["nomeDoEvento"];
            agenda.TipoDeEvento = form["tipoDeEvento"];
            agenda.PublicoePrivado = bool.Parse(form["publicoprivado"]);

            var nomePlanoEvento = form["planoDeEvento"];
            PlanoEvento planoEvento = new PlanoEvento();
            planoEvento.Nome = form["planoDeEvento"];
            planoEvento.Preco = planoEventoRepository.ObterPrecoDe(nomePlanoEvento);

            agenda.PlanoEvento = planoEvento;

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.CPF = form["cpf"];
            cliente.Telefone = form["telefone"];

            agenda.Cliente = cliente;

            agenda.DataDoRegistro = DateTime.Now;

            agenda.DiaDoEvento = DateTime.Parse(form["date"]);

            agenda.DescricaoEvento = form["descricao"];

            agenda.PrecoTotal = planoEventoRepository.ObterPrecoDe(nomePlanoEvento);

            if(agendaRepository.Inserir(agenda))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Agenda",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}