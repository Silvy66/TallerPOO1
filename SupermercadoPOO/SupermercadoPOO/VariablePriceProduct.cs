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
            return $"{Id} {Description}" +
                $"\n\t Measurement......: {$"{Measurement}",15}" +
                $"\n\t Quantity.........: {$"{Quantity:N2}",15}" +
                $"\n\t Price.........:    {$"{Price:C2}",15}" +
                $"\n\t Tax.........:      {$"{Tax:P2}",15}" +
                $"\n\t Value............: {$"{ValueToPay():C2}",15}";
        }
    }
}
