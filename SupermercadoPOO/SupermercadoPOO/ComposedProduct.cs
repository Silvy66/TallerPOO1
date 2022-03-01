using System.Collections;

namespace SupermercadoPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private decimal _payComposed=0;
        private string _productName=String.Empty;
        private float _discountComposed;
        private decimal _totalComposed;

        public override decimal ValueToPay()
        {
            Products = new List<Product>();
            foreach (Product p in Products)
              
            {
              
                _discountComposed = (float)p.ValueToPay() * Discount;
                _payComposed += p.ValueToPay()- (decimal)_discountComposed;
            }
           
            return _payComposed;
        }
        public override string ToString()
        {
            _totalComposed = 0;
            
            foreach (Product product in Products)
            {
                _productName += product.Description + ",";
                _totalComposed = product.ValueToPay();
                _discountComposed = (float)_totalComposed * Discount;
                _payComposed += _totalComposed - (decimal)_discountComposed;

            }
            return $"{Id}    {Description}" +
                $"\n\tProducts........: {$"{_productName}",10}" +
                $"\n\tDiscount........: {$"{Discount:P2}",14}" +
                $"\n\tValue...........: {$"{ValueToPay()+25268:C2}",14}";
           

        }
    }
}
