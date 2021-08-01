using ListaLeitura.App.Models;
using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ListaLeitura.App.Controller
{
    public class LivrosController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IEnumerable<Livro> Livros { get; set; }
        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            ViewBag.NomeTela = "Livros Para Ler";
            return View("Lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            ViewBag.NomeTela = "Lendo";
            return View("Lista");
        }
        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            ViewBag.NomeTela = "Livros Lidos";
            return View("Lista");
        }
        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(x => x.Id == id);

            return livro.Detalhes();
        }
    }
}
