using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class Invoice : IPay
    {
        public ICollection<Product> pro = new List<Product> ();
        private decimal _payTotal;
        


        public void AddProduct(Product _products)
        {
            foreach(Product item in pro)
            {
                pro.Add(_products);
            }

        }
        
        public decimal ValueToPay()
        {
            _payTotal = 0;
            foreach(Product item in pro)
            {
                _payTotal = item.ValueToPay();
            }

            return _payTotal;
        }

        public override string ToString()
        {
            Product compo = new ComposedProduct();
            Product fixe = new FixedPriceProduct();
            return 
                $"\n\t{compo.ValueToPay()} " +
                $"\n\t {fixe.ValueToPay()}" +
                $"TOTAL:       {ValueToPay()}\n";
        }

    }
}
