using System.Collections.Generic;
using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Agendar> Agendar {get;set;}
        public uint EventosAprovados {get;set;}
        public uint EventosReprovados {get;set;}
        public uint EventosPendentes {get;set;}
        public DashboardViewModel()
        {
            this.Agendar = new List<Agendar>();
        }
    }
}