using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioRepository repository;

        public UsuarioController()
        {
            repository = new UsuarioRepository();
        }
        // GET: Usuario
        public ActionResult Index()
        {
            List<Usuario> ususarios = repository.ObterTodos();
            ViewBag.Usuarios = ususarios; //ViewBag.Usuarios não puxou POSSÍVEL PROBLEMA
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Store(string nome, string login, string senha)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Login = login;
            usuario.Senha = senha;
            repository.Inserir(usuario);
            return RedirectToAction("Index");
        }
    }
}