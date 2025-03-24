using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTips();
            }
            return View(model);
        }
    }
}
