using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;

namespace Projeto.Repository.Interface
{
    public interface IUsuarioRepository
    {
        void Insert(Usuario u);
        void Update(Usuario u);
        Usuario Find(string login, string senha);
        bool HasLogin(string login);
    }
}
