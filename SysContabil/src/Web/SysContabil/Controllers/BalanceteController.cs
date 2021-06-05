﻿using Dominio.IRepositories;
using History.Lancamentos;
using Microsoft.AspNetCore.Mvc;
using SysContabil.Factories;
using SysContabil.Models;
using System.Threading.Tasks;

namespace SysContabil.Controllers
{
    public class BalanceteController : Controller
    {
        private readonly ConsultarLancamento _consultarLancamento;
        private readonly AlterarLancamento _alterarLancamento;
        private readonly ExcluirLancamento _excluirLancamento;
        public BalanceteController(ILancamentoRepository lancamentoRepository)
        {
            _consultarLancamento = new ConsultarLancamento(lancamentoRepository);
            _alterarLancamento = new AlterarLancamento(lancamentoRepository);
            _excluirLancamento = new ExcluirLancamento(lancamentoRepository);
        }
        public async Task<IActionResult> Index()
        {
            var listaLancamentos = await _consultarLancamento.ListarTodosLancamentos();
            var listaLancamentosViewModel = LancamentoFactory.MapearListaLancamentoViewModel(listaLancamentos);
            return View(listaLancamentosViewModel);
        }
        public async Task<IActionResult> Alterar(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if (lancamento == null)
            {
                return RedirectToAction("Index");
            }
            var lancamentoViewModel = LancamentoFactory.MapearLancamentoViewModel(lancamento);
            return View(lancamentoViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, LancamentoViewModel lancamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(lancamentoViewModel);
            }
            var lancamento = LancamentoFactory.MapearLancamento(lancamentoViewModel);
            await _alterarLancamento.Executar(id, lancamento);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detalhar(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if (lancamento == null)
            {
                return RedirectToAction("Index");
            }
            var lancamentoViewModel = LancamentoFactory.MapearLancamentoViewModel(lancamento);
            return View(lancamentoViewModel);
        }
        public async Task<IActionResult> Excluir(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if (lancamento == null)
            {
                return RedirectToAction("Index");
            }
            await _excluirLancamento.Executar(lancamento);
            return RedirectToAction("Index");
        }
    }
}

