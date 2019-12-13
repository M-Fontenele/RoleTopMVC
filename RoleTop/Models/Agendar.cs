using System;
using RoleTop.Enums;

namespace RoleTop.Models
{
    public class Agendar
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeDoEvento {get;set;}
        public string TipoDeEvento {get;set;}
        public PlanoEvento PlanoEvento {get;set;}
        public DateTime DiaDoEvento {get;set;}
        public DateTime DataDoRegistro {get;set;}
        public double PrecoTotal {get;set;}
        public string Complemento {get;set;}
        public string DescricaoEvento {get;set;}
        public uint Status {get;set;}
        public bool PublicoePrivado {get;set;}

        public bool Pagamento {get;set;}

        public Agendar()
        {
            this.Cliente = new Cliente();
            this.PlanoEvento = new PlanoEvento();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }

    }
}