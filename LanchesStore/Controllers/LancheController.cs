using LanchesStore.Repositories.Interfaces;
using LanchesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesStore.Controllers
{
    public class LancheController : Controller
    {
        //Injeção de dependência
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "CAtegoria Atual";

            return View(lanchesListViewModel);
        }
    }
}
