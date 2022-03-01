using System.Collections;

namespace SupermercadoPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private decimal _payComposed=0;
        private string _productName="";
        private float _discountComposed;
       

        public override decimal ValueToPay()
        {
            foreach (Product p in Products)
            {
              
                _discountComposed = (float)p.ValueToPay() * Discount;
                _payComposed += p.ValueToPay()- (decimal)_discountComposed;
            }
           
            return _payComposed;
        }
        public override string ToString()
        {
            
            foreach (Product product in Products)
            {
                _productName += product.Description + ",";

            }
            return $"{Id}    {Description}" +
                $"\n\tProducts........: {$"{_productName}",10}" +
                $"\n\tDiscount........: {$"{Discount:P2}",14}" +
                $"\n\tValue...........: {$"{ValueToPay():C2}",14}" +
                $"\nRECEIPT" +
                $"\n-----------------------------------------------------------------";
           

        }
    }
}
