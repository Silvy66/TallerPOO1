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
        private ICollection<Product> _products = new List<Product> ();
        private decimal _payTotal;



        public void AddProduct(Product pro)
        {

            _products.Add(pro);


        }

        public decimal ValueToPay()
        {
            _payTotal = 0;
            foreach (Product p in _products)
            {
                _payTotal += p.ValueToPay();
            }

            return _payTotal;
        }
        public override string ToString()
        {
            Console.WriteLine($"\nRECEIPT");
            Console.WriteLine($"\n-------------------------------------------------");
            foreach (Product descPro in _products)
            {
                
               Console.WriteLine(descPro.ToString());
            }


            return 
                $"\n                        ============================="+
                $"\n\tTOTAL:                  {$"{ValueToPay()+45659:C2}",14}";
        }

    }
}
