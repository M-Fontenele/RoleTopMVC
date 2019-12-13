using Microsoft.AspNetCore.Mvc;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class AFaqController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Faq()
        {
            var c = clienteRepository.ObterPor(ObterUsuarioSession());
            return View(new BaseViewModel()
            {
                Cliente = c,
                NomeView = "AFaq",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}