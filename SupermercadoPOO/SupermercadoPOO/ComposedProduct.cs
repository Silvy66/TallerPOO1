using System.Collections;

namespace SupermercadoPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private decimal _payComposed;
        private string _productName;
        private float _discountComposed;
        private decimal _payTotal;

        public override decimal ValueToPay()
        {

            foreach (Product product in Products)
            {
                _discountComposed = (float)product.ValueToPay()*Discount;
                _payComposed += ValueToPay() - (decimal)_discountComposed;
                _payTotal += product.ValueToPay();
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
                $"\n\t Value............: {$"{_payComposed:C2}",15}" +
                $"\n\t                  =============================" +
                $"\n\t TOTAl:.........:   {$"{_payComposed:C2}",15}";

        }
    }
}
