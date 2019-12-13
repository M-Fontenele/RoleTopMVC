using System;
using System.Collections.Generic;
using RoleTop.Models;
using RoleTop.Repositories;

namespace RoleTop.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        AgendaRepository AgendaRepository = new AgendaRepository();
        public List<Agendar> ListaMes {get;set;}
        public List<DateTime> Datas {get;set;}


        public HomeViewModel ()
        {
            this.ListaMes = new List<Agendar>();
        }
        public HomeViewModel (DateTime mes)
        {
            this.ListaMes = AgendaRepository.ObterPorData(mes);
            for(var i = 1 ; i < 31 ; i++)
            {
                
            }
        }
    }
}