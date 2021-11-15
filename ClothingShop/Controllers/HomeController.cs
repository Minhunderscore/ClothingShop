using ClothingShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ClothingShop.BusinessLogic.Repositories.Interfaces;

namespace ClothingShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShopRepository _shopRepository;

        public HomeController(ILogger<HomeController> logger, IShopRepository shopRepository)
        {
            _logger = logger;
            _shopRepository = shopRepository;
        }

        public IActionResult Index()
        {
            _shopRepository.Testing();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}