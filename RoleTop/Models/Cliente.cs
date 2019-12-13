using System;
namespace RoleTop.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public string CPF {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Telefone {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string senha, string email, string cpf, DateTime dataNascimento, string telefone)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
        }
    }
}