using System.Collections.Generic;
using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class AgendaViewModel : BaseViewModel
    {
        public List<PlanoEvento> PlanoEvento {get;set;}

        public string NomeUsuario {get;set;}

        public AgendaViewModel()
        {
            this.PlanoEvento = new List<PlanoEvento>();
            this.Cliente = new Cliente();
            this.NomeUsuario = "";
        }
    }
}