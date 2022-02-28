﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private decimal _payComposed;
        private string  _productName;
        public override decimal ValueToPay()
        {
            foreach (Product P in Products)
            {
                _payComposed +=( P.ValueToPay() *(decimal) Discount) - P.ValueToPay();

            }
            return _payComposed;
        }
        public override string ToString()
        {
            foreach (Product product in Products)
            {
                _productName += product.Description + ","; 
            }
            return $"{Id} {Description}" +
                $"\n\t Products......:    {$"{_productName}",15}" +
                $"\n\t Discount.........: {$"{Discount:P2}",15}" +
                $"\n\t Price.........:    {$"{Price:C2}",15}" +
                $"\n\t Value............: {$"{ValueToPay():C2}",15}" +
                $"\n\t                  =============================" +
                $"\n\t TOTAl:.........:   {$"{_payComposed:C2}",15}";
                
        }
    }
}
