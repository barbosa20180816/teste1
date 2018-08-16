using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Models;
using Projeto.Entities;
using Projeto.Business.Interface;
using System.Drawing;
using System.IO;

namespace Projeto.Presentation.Controllers
{
    public class UsuarioController : Controller
    {
        //atributo...
        private IUsuarioBusiness business;

        public UsuarioController(IUsuarioBusiness business)
        {
            this.business = business;
        }

        // GET: Usuario/Autenticar
        public ActionResult Autenticar()
        {
            return View();
        }

        // POST: Usuario/Autenticar
        [HttpPost]
        public ActionResult Autenticar(UsuarioAutenticarViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //buscar o usuario....
                    Usuario u = business.ObterUsuario(model.Login, model.Senha);

                    //TODO...
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }
            return View();
        }

        // GET: Usuario/CriarConta
        public ActionResult CriarConta()
        {
            return View();
        }

        // POST: Usuario/CriarConta
        [HttpPost]
        public ActionResult CriarConta(UsuarioCriarContaViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Usuario u = new Usuario();
                    u.Nome = model.Nome;
                    u.Login = model.Login;
                    u.Senha = model.Senha;
                    u.DataCadastro = DateTime.Now;
                    u.DataUltimoAcesso = new DateTime(2000, 1, 1);

                    Image fotoPadrao = Image.FromFile(Server.MapPath("~/Imagens/FotoPadrao.jpg"));
                    u.Foto = model.Login + Path.GetExtension(Server.MapPath("/Imagens/FotoPadrao.jpg"));

                    business.CadastrarUsuario(u);

                    //upload da imagem..
                    //model.Foto.SaveAs(Server.MapPath("/Imagens/") + u.Foto);
                    fotoPadrao.Save(Server.MapPath("/Imagens/") + u.Foto);

                    ModelState.Clear();
                    ViewBag.Mensagem = $"Usuário {u.Nome} - cadastrado com sucesso!";
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }
            return View();
        }

        // GET: Usuario/AreaSistema
        public ActionResult AreaSistema()
        {
            return View();
        }

        // GET: Usuario/AtualizarConta
        public ActionResult AtualizarConta()
        {
            return View();
        }
    }
}