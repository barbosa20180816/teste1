using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projeto.Business.Implementation.Util
{
    public class Criptografia
    {
        //método para encriptar a senha do usuário...
        public static string EncriptarSenhaParaMD5(string senha)
        {
            //modo de encriptação: MD5(criptografia baseada em HASH)
            MD5 md5 = new MD5CryptoServiceProvider();

            //converter a senha de string para bytes...
            byte[] senhaEmBytes = Encoding.UTF8.GetBytes(senha);

            //critografando...
            byte[] hash = md5.ComputeHash(senhaEmBytes);

            //retornando o hash...
            string resultado = string.Empty;

            foreach (byte b in hash)
            {
                resultado += b.ToString("X2");//X2 -> Hexadecimal
            }
            return resultado;
        }
    }
}
