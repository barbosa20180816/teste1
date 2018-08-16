using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Usuario
    {
        //atributos..
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimoAcesso { get; set; }

        public Usuario()
        {
            //vazio...
        }

        public Usuario(int idUsuario, string nome, string login, string senha, string foto, DateTime dataCadastro, DateTime dataUltimoAcesso)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Login = login;
            Senha = senha;
            Foto = foto;
            DataCadastro = dataCadastro;
            DataUltimoAcesso = dataUltimoAcesso;
        }

        public override string ToString()
        {
            return $"ID: {IdUsuario} | Nome: {Nome} | Login: {Login} | Data de Cadastro: {DataCadastro} .";
        }
    }
}
