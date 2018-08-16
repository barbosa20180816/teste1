using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Projeto.Presentation.Validators
{
    //REGRA 1 - HERDAR ValidationAttribute
    public class UploadImagemValidator : ValidationAttribute
    {
        //REGRA 2 - Sobrescrever o método IsValid
        public override bool IsValid(object value)
        {
            if (value is HttpPostedFileBase)
            {
                HttpPostedFileBase arquivo = value as HttpPostedFileBase;

                //obter extensão do arquivo...
                string extensao = Path.GetExtension(arquivo.FileName);

                return (extensao.Equals(".jpg") || extensao.Equals(".jpeg") || extensao.Equals(".png")) && arquivo.ContentLength <= 1 * Math.Pow(1024, 2); //1MB
            }
            return false;
        }
    }
}