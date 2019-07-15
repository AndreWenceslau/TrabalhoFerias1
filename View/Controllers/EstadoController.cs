using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class EstadoController : Controller
    {
        private EstadoRepository repository;

        public EstadoController()
        {
            repository = new EstadoRepository();

        }
        // GET: Estado
        public ActionResult Index()
        {
            List<Estado> estados = repository.ObterTodos();
            ViewBag.Estados = estados;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nomeEstado, string sigla)
        {
            Estado estado = new Estado();
            estado.NomeEstado = nomeEstado;
            estado.NomeEstado = sigla;
            repository.Inserir(estado);
            return RedirectToAction("Index");
        }
    }
}