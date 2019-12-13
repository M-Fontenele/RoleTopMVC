using Microsoft.AspNetCore.Mvc;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class GaleriaController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Plantas()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "Plantas",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Salao()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "Salao",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        
        public IActionResult Casamento()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "Casamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Balada()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "Balada",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Formatura()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "Formatura",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult OutrosEventos()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "OutrosEventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}