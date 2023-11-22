using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UsandoViews.Models;

namespace UsandoViews.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.QtdDeUsuarios = Usuario.Listagem.Count();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar(int? id)
        {
            var usuario = new Usuario();
            if(id.HasValue && Usuario.Listagem.Any(u => u.Id == id))
            {
                usuario = Usuario.Listagem.Single(u => u.Id == id);
                return View(usuario);
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            Usuario.Salvar(usuario);
            return RedirectToAction("Usuarios");
        }

        public IActionResult Usuarios()
        {

            return View(Usuario.Listagem);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            var usuario = new Usuario();
            if(id.HasValue && Usuario.Listagem.Any(u => u.Id == id))
            {
                usuario = Usuario.Listagem.Single(u => u.Id == id);
                return View(usuario);
            }
            
            return View("Usuarios");
        }
        [HttpPost]
        public IActionResult Excluir(Usuario usuario)
        {
           TempData["Excluiu"] = Usuario.Excluir(usuario.Id); 
            return RedirectToAction("Usuarios");
        }
    }
}