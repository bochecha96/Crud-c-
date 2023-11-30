using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoLocadora.Models;
using ProjetoLocadora.Repository;

namespace ProjetoLocadora.Controllers
{
    public class FilmeController : Controller
    {

        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public IActionResult Index()
        {
            List<FilmeModel> filmes = _filmeRepository.ListarFilmes();
            return View(filmes);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            var filme = _filmeRepository.BuscarId(id);
            return View(filme);
        }

        [HttpPost]
        public IActionResult Criar(FilmeModel filme)
        {
            _filmeRepository.Adicionar(filme);
            return RedirectToAction("Index");
        }
        
        public IActionResult Atualizar(FilmeModel filme)
        {
            _filmeRepository.Atualizar(filme);
            return RedirectToAction("Index");
        }
    }
}