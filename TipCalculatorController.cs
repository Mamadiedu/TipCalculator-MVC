using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class TipCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new TipCalculatorModel()); // Ensure a model instance is passed
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            Console.WriteLine($"MealCost Received: {model.MealCost}"); // Debugging log
            if (ModelState.IsValid)
            {
                model.CalculateTips();
                Console.WriteLine($"Tip15: {model.Tip15}, Tip20: {model.Tip20}, Tip25: {model.Tip25}");
            }
            else
            {
                Console.WriteLine("ModelState is Invalid!");
            }
            return View(model);
        }

    }
}