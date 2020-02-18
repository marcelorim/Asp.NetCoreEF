using AutoMapper;
using BrasilCenter.App.ViewModels;
using BrasilCenter.Business.Interfaces;
using BrasilCenter.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BrasilCenter.App.Controllers
{
    public class LivrosController : BaseController
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivrosController(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            //var teste = _mapper.Map<IEnumerable<LivroViewModel>>(await _livroRepository.ObterTodos());
            var teste = await _livroRepository.ObterTodos();
            return View();
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var livroViewModel = await _livroRepository.ObterPorId(id);
            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LivroViewModel livroViewModel)
        {
            if (!ModelState.IsValid) return View(livroViewModel);

            var livro = _mapper.Map<Livro>(livroViewModel);
            await _livroRepository.Adicionar(livro);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var livroViewModel = await _livroRepository.ObterPorId(id);
            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, LivroViewModel livroViewModel)
        {
            if (id != livroViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(livroViewModel);

            var livro = _mapper.Map<Livro>(livroViewModel);
            await _livroRepository.Adicionar(livro);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var livroViewModel = await _livroRepository.ObterPorId(id);
            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var livroViewModel = await _livroRepository.ObterPorId(id);
            if (livroViewModel == null) return NotFound();

            await _livroRepository.Remover(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
