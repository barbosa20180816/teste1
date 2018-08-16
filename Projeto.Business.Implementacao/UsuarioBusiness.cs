using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Interface;
using Projeto.Business.Interface;
using Projeto.Business.Implementation.Util;

namespace Projeto.Business.Implementation
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private IUsuarioRepository repository;

        public UsuarioBusiness(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public void AtualizarUsuario(Usuario u)
        {
            
            repository.Update(u);
        }

        public void CadastrarUsuario(Usuario u)
        {
            //verificar se o login já existe...
            if (! repository.HasLogin(u.Login))
            {
                //criptografar a senha...
                u.Senha = Criptografia.EncriptarSenhaParaMD5(u.Senha);

                repository.Insert(u);
            }
            else
            {
                throw new Exception("Login já existe!");
            }
        }

        public Usuario ObterUsuario(string login, string senha)
        {
            //buscar usuario por login e senha...
            Usuario u = repository.Find(login, Criptografia.EncriptarSenhaParaMD5(senha));

            if (u != null)//se usuario foi encontrado...
            {
                return u;//retornando o usuario...
            }
            else
            {
                throw new Exception("Usuário não encontrado!");
            }
        }
    }
}
