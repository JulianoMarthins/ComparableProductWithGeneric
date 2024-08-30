using GenericsRestritivo.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsRestritivo {
    internal class Program {
        static void Main (string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number the product: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                Console.Write("\nEnter the name this product: ");
                string name = Console.ReadLine();
                Console.Write("Enter the price this product: ");
                double price = double.Parse(Console.ReadLine());

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("\nMax: " + max);
            
        }
    }
}
