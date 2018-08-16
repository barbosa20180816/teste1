using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;//mapeamento...
using Projeto.Entities;//entidades...
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Repository.Implementation.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        //construtor...
        public UsuarioMap()
        {
            //nome da tabela...
            ToTable("Usuario");

            //chave primaria...
            HasKey(u => new { u.IdUsuario });

            //mapear os outros campos da tabela...
            Property(u => u.IdUsuario).HasColumnName("IdUsuario").IsRequired();
            Property(u => u.Nome).HasColumnName("Nome").HasMaxLength(100).IsRequired();
            Property(u => u.Login).HasColumnName("Login").HasMaxLength(50).IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("ix_login") { IsUnique = true }));
            Property(u => u.Senha).HasColumnName("Senha").HasMaxLength(50).IsRequired();
            Property(u => u.Foto).HasColumnName("Foto").HasMaxLength(50).IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("ix_foto") { IsUnique = true }));
            Property(u => u.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(u => u.DataUltimoAcesso).HasColumnName("DataUltimoAcesso");
        }
    }
}
