using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    internal class GroceryModel
    {
        public double PricePerKilogramVegetables { get; set; }
        public double PricePerKilogramFruits { get; set; }
        public double KilogramsVegetables { get; set; }
        public double KilogramsFruits { get; set; }

        public GroceryModel(View.GroceryDisplay display, double pricePerKilogramVegetables, double pricePerKilogramFruits, double kilogramVegetables, double kilogramFruits)
        {
            this.PricePerKilogramVegetables = pricePerKilogramVegetables;
            this.PricePerKilogramFruits = pricePerKilogramFruits;
            this.KilogramsVegetables = kilogramVegetables;
            this.KilogramsFruits = kilogramFruits;
        }
        public GroceryModel(double pricePerKilogramVegetables, double pricePerKilogramFruits, double kilogramVegetables, double kilogramFruits)
        {
            this.PricePerKilogramVegetables = pricePerKilogramVegetables;
            this.PricePerKilogramFruits = pricePerKilogramFruits;
            this.KilogramsVegetables = kilogramVegetables;
            this.KilogramsFruits = kilogramFruits;
        }
        public double CalculateVegetables()
        {
           return (PricePerKilogramVegetables* KilogramsVegetables)/1.94;
           
        }
        public double CalculateFruits()
        {
            return (PricePerKilogramFruits * KilogramsFruits)/1.94;

        }
        public double CalculateTotal()
        {
            return (CalculateVegetables() + CalculateFruits())*1.94;
        }
    }
}
