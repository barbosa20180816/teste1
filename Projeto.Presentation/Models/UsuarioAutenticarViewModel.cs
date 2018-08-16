using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//validações...

namespace Projeto.Presentation.Models
{
    public class UsuarioAutenticarViewModel
    {
        [Required(ErrorMessage ="Por Favor, informe seu login!")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Por Favor, informe sua senha!")]
        public string Senha { get; set; }
    }
}