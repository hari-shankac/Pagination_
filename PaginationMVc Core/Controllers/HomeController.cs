using Microsoft.AspNetCore.Mvc;
using PaginationMVc_Core.Models;
using System.Diagnostics;

namespace PaginationMVc_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private AllEmployee emp = new AllEmployee();
        public async Task<IActionResult> Index(int filter = 1)
        {
            var result = await emp.GetAllEmployee(filter);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}