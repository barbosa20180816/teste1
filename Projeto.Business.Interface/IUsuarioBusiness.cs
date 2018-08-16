using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;

namespace Projeto.Business.Interface
{
    public interface IUsuarioBusiness
    {
        void CadastrarUsuario(Usuario u);
        void AtualizarUsuario(Usuario u);
        Usuario ObterUsuario(string login, string senha);
    }
}
