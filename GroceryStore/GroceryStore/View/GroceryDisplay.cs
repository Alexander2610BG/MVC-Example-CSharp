using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.View
{
    internal class GroceryDisplay
    {
        public double pricePerKilogramVegetables { get; set; }
        public double pricePerKilogramFruits { get; set; }
        public double kilogramsVegetables { get; set; }
        public double kilogramsFruits { get; set; }
        public double VegetablesTotal { get; set; }
        public double FruitTotal { get; set; }
        public double Total { get; set; }

        public GroceryDisplay()
        {
            pricePerKilogramVegetables = 0;
            pricePerKilogramFruits = 0;
            kilogramsVegetables = 0;
            kilogramsFruits = 0;
            VegetablesTotal = 0;
            FruitTotal = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Моля въведете цената за килограм на зеленчуци");
            pricePerKilogramVegetables = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете цената за килограм на плодовете");
            pricePerKilogramFruits = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете килограмите на зеленчуците");
            kilogramsVegetables = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете килограмите на плодовете");
            kilogramsFruits = double.Parse(Console.ReadLine());
        }

        public void ShowPrices()
        {
            Console.WriteLine(VegetablesTotal );
            Console.WriteLine(FruitTotal);
            Console.WriteLine(Total / 1.94 );
        }

    }
}
