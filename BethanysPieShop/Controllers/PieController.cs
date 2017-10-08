using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel()
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese cakes"
            };

            return View(piesListViewModel);
        }
    }
}
