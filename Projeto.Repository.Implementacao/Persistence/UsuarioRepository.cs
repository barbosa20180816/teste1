using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.Repository.Implementation.Context;
using Projeto.Repository.Interface;

namespace Projeto.Repository.Implementation.Persistence
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Insert(Usuario u)
        {
            using (Conexao ctx = new Conexao())
            {
                ctx.Entry(u).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(Usuario u)
        {
            using (Conexao ctx = new Conexao())
            {
                ctx.Entry(u).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public Usuario Find(string login, string senha)
        {
            using (Conexao ctx = new Conexao())
            {
                //return ctx.Usuario.Where(u => u.Login.Contains(login));
                return ctx.Usuario.FirstOrDefault(u => u.Login.Equals(login));
            }
        }

        public bool HasLogin(string login)
        {
            using (Conexao ctx = new Conexao())
            {
                int count = ctx.Usuario.Count(u => u.Login.Equals(login));
                return count > 0;
            }
        }
    }
}
