using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestritivo.Entities {
    internal class Product : IComparable{

        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string name, double price) {
            Name = name;
            Price = price;
        }


        public override string ToString () {
            string formatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Price.ToString("F2"));
            return $"{Name}: R$ {formatado}";
        }

        public int CompareTo (object obj) {
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing error: Argmument is not a Product");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
