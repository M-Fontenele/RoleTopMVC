using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class HomeController : AbstractController
    {
        AgendaRepository AgendaRepository = new AgendaRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {

            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            
            return View(new HomeViewModel(DateTime.Now){
                Cliente = c,
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Eventospublicos()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            var todosEventos =  AgendaRepository.ObterTodos();
            var agendaEvento = new List<Agendar>();
            foreach (var item in todosEventos)
            {
                if (item.PublicoePrivado)
                {
                    agendaEvento.Add(item);
                }
            }

            return View(new MeusEventosViewModel(){
                Cliente = c,
                Agendar = agendaEvento,
                NomeView = "MeusEventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}
