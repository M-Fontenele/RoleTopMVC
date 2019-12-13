using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Enums;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private AgendaRepository AgendaRepository = new AgendaRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }


        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("====================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("====================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch(cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                return RedirectToAction("MeusEventos","Cliente");
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                return RedirectToAction("Pendentes", "Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel());
            }
        }
        public IActionResult MeusEventos()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var agendaCliente = AgendaRepository.ObterTodosPorCliente(emailCliente);

            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new MeusEventosViewModel()
            {
                Cliente = c,
                Agendar = agendaCliente,
                NomeView = "MeusEventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult AlterarInformacoes(IFormCollection form)
        {
            ViewData["Action"] = "Alterar Informacoes";
            var clienteO = clienteRepository.ObterPor(ObterUsuarioSession());
            Cliente c = new Cliente();
            c.TipoUsuario = (uint) TiposUsuario.CLIENTE;
            c.Nome = form["nome"];
            c.Email =  form["email"];
            c.Senha = clienteO.Senha;
            c.Telefone = form["telefone"];
            c.DataNascimento = DateTime.Parse(form["dataNascimento"]);
            c.CPF = form["cpf"];
            if(clienteRepository.Atualizar(c,ObterUsuarioSession()))
            {
                HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
                HttpContext.Session.Remove(SESSION_CLIENTE_NOME);

                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, c.Email);
                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, c.Nome);

                var n = clienteRepository.ObterPor(ObterUsuarioSession());
                return View("Sucesso", new RespostaViewModel()
                {
                    Cliente = n,
                    NomeView = "InfoUsuario",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else{

                var n = clienteRepository.ObterPor(ObterUsuarioSession());

                return View("Erro", new RespostaViewModel()
                {
                    Cliente = n,
                    NomeView = "InfoUsuario",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult InfoUsuario()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "InfoUsuario",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult MudarInformacao()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "InfoUsuario",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }



        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }
    }
}