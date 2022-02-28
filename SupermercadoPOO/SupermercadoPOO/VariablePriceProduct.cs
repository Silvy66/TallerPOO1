namespace SupermercadoPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price* (decimal)(Quantity*Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n Measurement......:{Measurement}" +
                $"\n Quantity......: {Quantity}" +
                $"\n Value.......:{ValueToPay():C2}";
        }
    }
}
