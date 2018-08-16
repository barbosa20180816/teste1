using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Models
{
    public class UsuarioCriarContaViewModel
    {
        [Required(ErrorMessage ="Por Favor, informe o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por Favor, informe o login!")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Por Favor, informe a senha!")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage ="Senha não confere!")]
        [Required(ErrorMessage ="Por Favor, confirme a senha!")]
        public string ConfirmSenha { get; set; }

    }
}