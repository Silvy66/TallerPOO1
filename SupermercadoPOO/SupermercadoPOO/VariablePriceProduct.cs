namespace SupermercadoPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal priceVariable = (Price / 1000) * (decimal)(Quantity);
            return (priceVariable * (decimal) Tax) +priceVariable;
        }

        public override string ToString()
        {
            return $"{Id}    {Description}" +
                $"\n\tMeasurement.....:{$"{Measurement}",5}" +
                $"\n\tQuantity........:{$"{Quantity:N2}",15}" +
                $"\n\tPrice...........:{$"{Price:C2}",15}" +
                $"\n\tTax.............:{$"{Tax:P2}",15}" +
                $"\n\tValue...........:{$"{ValueToPay():C5}",15}";
        }
    }
}
