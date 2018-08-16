using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//connectionstrings...
using System.Data.Entity;//entityframework...
using Projeto.Entities;
using Projeto.Repository.Implementation.Mappings;//classe de mapeamento...

namespace Projeto.Repository.Implementation.Context
{
    //HERDAR a classe DbContext
    public class Conexao : DbContext
    {
        //Construtor que envie para o DbContext o caminho da connectionstrings mapeada no WebConfig
        public Conexao()
            :base(ConfigurationManager.ConnectionStrings["PFinal"].ConnectionString)
        {

        }

        //Sobrescrever o método OnModelCreating()
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //classe de mapeamento...
            modelBuilder.Configurations.Add(new UsuarioMap());
        }

        //Disponibiliza o uso da sintaxe LAMBDA para cada entidade
        public DbSet<Usuario> Usuario { get; set; }
    }
}
