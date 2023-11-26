using GroceryStore.View;
using GroceryStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Controllers
{
   internal class GroceryController
    {
        private GroceryDisplay display;
        private GroceryModel model;

        public GroceryController()
        {
            display = new GroceryDisplay();
            model = new GroceryModel(display.pricePerKilogramVegetables, display.pricePerKilogramFruits, display.kilogramsVegetables, display.kilogramsFruits);
            display.VegetablesTotal = model.CalculateVegetables();
            display.FruitTotal = model.CalculateFruits();
            display.Total = model.CalculateTotal();
            display.ShowPrices();
        }
    }
}
