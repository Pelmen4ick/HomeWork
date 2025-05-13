using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_классов
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public double Weight { get; set; }

            public Product(string name, double weight)
            {
                Name = name;
                Weight = weight;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Продукт: {Name}, Вес: {Weight} г");
            }
        }

        class VitaminCProduct : Product
        {
            public double VitaminCPerGram { get; set; }

            public VitaminCProduct(string name, double weight, double vitaminCPerGram)
                : base(name, weight)
            {
                VitaminCPerGram = vitaminCPerGram;
            }

            public double CalculateTotalVitaminC()
            {
                return Weight * VitaminCPerGram;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Количество витамина С в 1 грамме: {VitaminCPerGram} мг, Общее количество витамина С: {CalculateTotalVitaminC()} мг");
            }
        }

       
            static void Main(string[] args)
            {
                Product product = new Product("Яблоко", 150);
                product.DisplayInfo();

                VitaminCProduct vitaminCProduct = new VitaminCProduct("Апельсин", 200, 0.5);
                vitaminCProduct.DisplayInfo();
                Console.ReadKey();
            }
        
    }
}
