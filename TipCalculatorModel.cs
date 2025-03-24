using System;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        public decimal MealCost { get; set; }
        public decimal Tip15 { get; set; }
        public decimal Tip20 { get; set; }
        public decimal Tip25 { get; set; }

        public TipCalculatorModel()
        {
            MealCost = 0;
            Tip15 = 0;
            Tip20 = 0;
            Tip25 = 0;
        }

        public void CalculateTips()
        {
            if (MealCost > 0)  // Prevent calculation on empty input
            {
                Tip15 = MealCost * 0.15m;
                Tip20 = MealCost * 0.20m;
                Tip25 = MealCost * 0.25m;
            }
        }

    }
}
