using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class Invoice : IPay
    {
        private Product _products;

      

        public Product AddProduct(Product _products)
        {
            return _products;

        }
        
        public decimal ValueToPay()
        {

            return ++_products.Price;
        }

        public override string ToString()
        {
            return $"{_products} " +
                $"\n ============" +
                $"TOTAL:       {ValueToPay()}\n";
        }

    }
}
