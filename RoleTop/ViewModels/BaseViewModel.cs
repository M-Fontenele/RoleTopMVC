using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class BaseViewModel
    {
        public Cliente Cliente {get;set;}
        public string NomeView {get;set;}
        public string UsuarioNome {get;set;}
        public string UsuarioEmail {get;set;}

        public BaseViewModel()
        {
            this.Cliente = new Cliente();
        }
    }
}